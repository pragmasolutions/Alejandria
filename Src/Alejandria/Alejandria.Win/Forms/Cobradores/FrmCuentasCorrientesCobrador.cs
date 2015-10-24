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
using Alejandria.Entities.Dto;
using Alejandria.Win.Enums;
using Alejandria.Win.Properties;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls.UI;

namespace Alejandria.Win.Forms.Cobradores
{
    public partial class FrmCuentasCorrientesCobrador : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cobrador _cobrador;
        private readonly IClienteCuentaCorrienteNegocio _clientecuentacorrienteNegocio;
        private ClientesCuentasCorriente _cuota;

        public FrmCuentasCorrientesCobrador(IAlejandriaUow uow, IClock clock, IMessageBoxDisplayService messageBoxDisplayService,
            IFormFactory formFactory, IClienteCuentaCorrienteNegocio clientecuentacorrienteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clientecuentacorrienteNegocio = clientecuentacorrienteNegocio;


            InitializeComponent();
        }

        private void FrmCuentasCorrientesCobrador_Load(object sender, EventArgs e)
        {
            this.ucFiltrosCobradores.BuscarFinished += UcFiltrosCobradoresOnBuscarFinished;
        }

        #region Properties
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


        private void UcFiltrosCobradoresOnBuscarFinished(object sender, List<Cobrador> cobradores)
        {
            if (cobradores.Any())
            {
                if (cobradores.Count == 1)
                {
                    ActualizarCobrador(cobradores.Single());
                    ActualizarCuotas(_cobrador.Id);
                }
                else
                {
                    //Mas de uno encontrado.
                    using (var seleccionarCobrador = new FrmSeleccionarCobrador(cobradores))
                    {
                        seleccionarCobrador.CobradorSelected += (o, cliente) =>
                        {
                            ActualizarCobrador(cliente);
                            seleccionarCobrador.Close();
                        };

                        seleccionarCobrador.ShowDialog();
                    }
                }

            }
            else
            {
                Crear();
            }
        }

        private void ActualizarCobrador(Cobrador cobrador)
        {
            if (!cobrador.Activo)
            {
                _messageBoxDisplayService.Show(this, string.Format("Cobrador Inactivo", cobrador.Nombre, cobrador.Cuit), Resources.LabelVentas);
                return;
            }

            _cobrador = cobrador;

            ucCobradorDetalle.ActualizarCobrador(_cobrador);
        }

        private void ActualizarCuotas(int cobradorId)
        {
            var cuotas =
                Uow.ClientesCuentasCorrientes.Listado(ccc => ccc.Venta, ccc => ccc.Cliente).Where(ccc => ccc.Venta.CobradorId == cobradorId &&
                                                                                    ccc.Importe>ccc.Pagado).OrderBy(
                        ccc => ccc.FechaVencimiento).ToList();



            //var cuotas = _clientecuentacorrienteNegocio.ListadoPorCobrador(cobradorId); 
            GridCuotas.DataSource = cuotas;

        }


        private void Crear()
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCobrador>(default(int), ActionFormMode.Create))
            {
                int i = 0;
                if (int.TryParse(ucFiltrosCobradores.Cuit, out i))
                    formCrear.SetearDni(ucFiltrosCobradores.Cuit);


                formCrear.CobradorAgregado += (sender, cobrador) =>
                {
                    ActualizarCobrador(cobrador);
                    formCrear.Close();
                };

                formCrear.ShowDialog();
            }
        }

        private void GridCuotas_ValueChanged(object sender, EventArgs e)
        {
            if (this.GridCuotas.ActiveEditor is RadCheckBoxEditor)
            {
                if (GridCuotas.ActiveEditor.Value.ToString() == "On")
                {
                    var cuotas = GridCuotas.CurrentRow.DataBoundItem as ClientesCuentasCorriente;
                    if (cuotas != null)
                    {
                        TotalPagar += cuotas.Importe;
                        cuotas.Pagado = cuotas.Importe;
                    }

                }
                else if (GridCuotas.ActiveEditor.Value.ToString() == "Off")
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
            GuardarPago();
        }

        private void GuardarPago()
        {
            if (TotalPagar != 0)
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
                ActualizarCuotas(_cobrador.Id);
                this.Close();
            }
        }

        private void ModificarVenta(Guid ventaId)
        {
            var venta = Uow.Ventas.Obtener(v => v.Id == ventaId);
            venta.TotalPagado = (venta.TotalPagado ?? 0) + (decimal?)_cuota.Pagado;

            venta.FechaModificacion = _clock.Now;
            venta.SucursalModificacionId = 1;
            venta.OperadorModificacionId = Guid.Empty;
        }

        private void AgregarClienteMovimiento(ClientesCuentasCorriente cuota)
        {
            var clientesMovimiento = new ClientesMovimiento();

            clientesMovimiento.IdCliente = cuota.Venta.ClienteId;
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
            cajaMovimiento.Importe = (decimal?)_cuota.Pagado;
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
