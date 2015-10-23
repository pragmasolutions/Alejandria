using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Business.Interfaces;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Win.Enums;
using Alejandria.Win.Forms.Clientes;
using Alejandria.Win.Properties;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls.UI;

namespace Alejandria.Win.Forms.CuentaCorrientes
{
    public partial class FrmCuentaCorriente : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IClienteNegocio _clienteNegocio;
        private Cliente _cliente;
        private ClientesCuentasCorriente _cuota;

        public FrmCuentaCorriente(IAlejandriaUow uow, IClock clock, IMessageBoxDisplayService messageBoxDisplayService,
            IFormFactory formFactory, IClienteNegocio clienteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clienteNegocio = clienteNegocio;
            InitializeComponent();
        }

        private void FrmCuentaCorriente_Load(object sender, EventArgs e)
        {
            this.ucFiltrosClientes.BuscarFinished += UcFiltrosClienteOnBuscarFinished;
            this.GridCuotas.Columns["FechaVencimiento"].DataType = typeof(DateTime);
            this.GridCuotas.Columns["FechaVencimiento"].FormatString = "{0: dd/M/yyyy}";

            this.GridCuotas.Columns["Fecha"].DataType = typeof(DateTime);
            this.GridCuotas.Columns["Fecha"].FormatString = "{0: dd/M/yyyy}";

            this.GridCuotas.Columns["Importe"].DataType = typeof(decimal);
            this.GridCuotas.Columns["Importe"].FormatString = "{0:N2}";

        }

        #region Propiedades
        public float? TotalPagar
        {
            get
            {
                float totalpagar;
                return float.TryParse(TxtTotal.Text, out totalpagar) ? totalpagar : (float?)0;
            }
            set
            {
                TxtTotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }
        #endregion

        private void UcFiltrosClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    ActualizarCliente(clientes.Single());
                    ActualizarCuotas(_cliente.Id);
                }
                else
                {
                    //Mas de uno encontrado.
                    using (var seleccionarCliente = new FrmSeleccionarCliente(clientes))
                    {
                        seleccionarCliente.ClienteSelected += (o, cliente) =>
                        {
                            ActualizarCliente(cliente);
                            seleccionarCliente.Close();
                        };

                        seleccionarCliente.ShowDialog();
                    }
                }

            }
            else
            {
                CrearCliente();
            }
        }

        private void ActualizarCuotas(Guid _clienteId)
        {
            var cuotas =
                Uow.ClientesCuentasCorrientes.Listado().Where(
                    ccc => ccc.ClienteId == _clienteId && ccc.Importe > ccc.Pagado).OrderBy(
                        ccc => ccc.FechaVencimiento).ToList();
            GridCuotas.DataSource = cuotas;
        }

        private void ActualizarCliente(Cliente cliente)
        {
            if (!cliente.Activo ?? true)
            {
                _messageBoxDisplayService.Show(this, string.Format(Resources.MensajeClienteInactivo, cliente.Denominacion, cliente.Cuit), Resources.LabelVentas);
                return;
            }

            _cliente = cliente;

            var deudaTotal = _clienteNegocio.DeudaTotal(_cliente.Id, 1);
            var deudaVencida = _clienteNegocio.DeudaVencida(_cliente.Id, 1);

            ucClienteDetalle.ActualizarCliente(_cliente, deudaTotal, deudaVencida);
            //cuenta = _cliente.Cuenta ?? 0;
        }

        private void CrearCliente()
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                int i = 0;
                if (int.TryParse(ucFiltrosClientes.Cuit, out i))
                    formCrearCliente.SetearDni(ucFiltrosClientes.Cuit);


                formCrearCliente.ClienteAgregado += (sender, cliente) =>
                {
                    ActualizarCliente(cliente);
                    formCrearCliente.Close();
                };

                formCrearCliente.ShowDialog();
            }
        }

        private void GridCuotas_ValueChanged(object sender, EventArgs e)
        {
            if (this.GridCuotas.ActiveEditor is RadCheckBoxEditor)
            {
               if (GridCuotas.ActiveEditor.Value.ToString()=="On")
                {
                    var cuotas = GridCuotas.CurrentRow.DataBoundItem as ClientesCuentasCorriente;
                    if (cuotas != null)
                    {
                        TotalPagar +=  cuotas.Importe;
                        cuotas.Pagado = cuotas.Importe;
                    }

                }
                else if (GridCuotas.ActiveEditor.Value.ToString()=="Off")
                {
                    var cuotas = GridCuotas.CurrentRow.DataBoundItem as ClientesCuentasCorriente;
                    if (cuotas != null)
                    {
                        TotalPagar -= cuotas.Importe;
                        cuotas.Pagado = 0;
                    }
                    

                }
                
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TotalPagar!=0)
            {
                foreach (var cuotas in GridCuotas.Rows)
                {
                    _cuota = cuotas.DataBoundItem as ClientesCuentasCorriente;
                    if (_cuota.Pagado != 0)
                    {
                        AgregarClienteMovimiento(_cuota);
                        ModificarCaja(TotalPagar);
                        AgregarCajaMovimiento();
                        ModificarCuentaCorriente(_cuota);
                        ModificarVenta(_cuota.VentaId);

                        Uow.Commit();
                    }
                }
                _messageBoxDisplayService.ShowSuccess("Guardado exitosamente");
                ActualizarCuotas(_cliente.Id);
                this.Close();
            }
            
        }

        private void ModificarVenta(Guid ventaId)
        {
            var venta = Uow.Ventas.Obtener(v => v.Id == ventaId);
            venta.TotalPagado =  (venta.TotalPagado ?? 0) + (decimal?)_cuota.Pagado ;

            venta.FechaModificacion = _clock.Now;
            venta.SucursalModificacionId = 1;
            venta.OperadorModificacionId = Guid.Empty;
        }

        private void AgregarClienteMovimiento(ClientesCuentasCorriente cuota)
        {
            var clientesMovimiento = new ClientesMovimiento();

            clientesMovimiento.IdCliente = _cliente.Id;
            clientesMovimiento.IdTipoComprobante = 2; // PAGOCUOTA
            clientesMovimiento.IdComprobante = cuota.Id;
            clientesMovimiento.Concepto = "Pago.Cuota.CtaCte";
            clientesMovimiento.Haber = (decimal?)cuota.Pagado;
            //clientesMovimiento.Debe = MontoVenta - Anticipo;
            clientesMovimiento.FechaGeneracion = _clock.Now;
            clientesMovimiento.FechaAlta = _clock.Now;
            clientesMovimiento.SucursalAltaId = 1;
            clientesMovimiento.OperadorAltaId = Guid.Empty;

            Uow.ClientesMovimientos.Agregar(clientesMovimiento);
        }

        private void ModificarCaja(float? total)
        {
            var _caja = Uow.Cajas.Listado().OrderByDescending(c => c.FechaAlta).FirstOrDefault();
            var estado = 1; //Modificar Caja
            if (_caja == null)
            {
                _caja = new Caja();
                _caja.FechaAlta = _clock.Now;
                _caja.SucursalAltaId = 1;
                _caja.OperadorAltaId = Guid.Empty;
                _caja.Fecha = _clock.Now;
                _caja.SucursalId = 1;
                estado = 0; //AgregarCaja
            }


            if (_caja.Ingresos == null)
                _caja.Ingresos = 0;
            _caja.Ingresos += total;
            if (_caja.Saldo == null)
                _caja.Saldo = 0;
            _caja.Saldo += (float?)total;
            _caja.FechaModificacion = _clock.Now;
            _caja.SucursalModificacionId = 1;
            _caja.OperadorModificacionId = Guid.Empty;

            if (estado == 0)
                Uow.Cajas.Agregar(_caja);
            else
                Uow.Cajas.Modificar(_caja);

        }

        private void AgregarCajaMovimiento()
        {
            var _caja = Uow.Cajas.Listado().OrderByDescending(c => c.FechaAlta).FirstOrDefault();
            var cajaMovimiento = new CajasMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = _caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = 2; //PAGO CUOTA
            cajaMovimiento.TipoComprobante = 2; //PAGO CUOTA
            cajaMovimiento.ComprobanteId = _cuota.Id;
            cajaMovimiento.Importe = (decimal?) _cuota.Pagado;
            cajaMovimiento.ImpFac = (decimal?)_cuota.Pagado;
            cajaMovimiento.PcAlta = Environment.MachineName;
            cajaMovimiento.SucursalAltaId = 1;
            cajaMovimiento.OperadorAltaId = Guid.Empty;
            cajaMovimiento.FechaAlta = _clock.Now;

            Uow.CajasMovimientos.Agregar(cajaMovimiento);
        }

        private void ModificarCuentaCorriente(ClientesCuentasCorriente clienteCuentaCorriente)
        {
            clienteCuentaCorriente.FechaUltimoPago = _clock.Now;
            clienteCuentaCorriente.FechaModificacion = _clock.Now;
            clienteCuentaCorriente.SucursalModificacionId = 1;
            clienteCuentaCorriente.OperadorModificacionId = Guid.Empty;

            Uow.ClientesCuentasCorrientes.Modificar(clienteCuentaCorriente);
           
        }
      }
}
