using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Alejandria.Business.Interfaces;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Entities.Enums;
using Alejandria.Win.Enums;
using Alejandria.Win.Forms.Clientes;
using Alejandria.Win.Properties;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;
using Ninject.Activation;
using Telerik.WinControls;

namespace Alejandria.Win.Forms.Ventas
{
    public partial class FrmVentas : EditFormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cliente _cliente;
        int ProvinciaId = 3;
        private int localidad = 0;
        private int cobrador = 0;
        private int nroComprobante = 0;
        private int cuenta = 0;
        private Venta venta = new Venta();
        private Caja _caja;
        private readonly IClienteNegocio _clienteNegocio;

        public FrmVentas(IAlejandriaUow uow,IClock clock,IMessageBoxDisplayService messageBoxDisplayService,
            IFormFactory formFactory,IClienteNegocio clienteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
             _clienteNegocio = clienteNegocio;
            _messageBoxDisplayService = messageBoxDisplayService;
            InitializeComponent();
        }

        #region Eventos
        public event EventHandler<Venta> VentaAgregada;
        #endregion

        #region Properties
        public decimal? MontoVenta
        {
            get
            {
                decimal montoventa;
                return decimal.TryParse(TxtMontoVenta.Text, out montoventa) ? montoventa : (decimal?)0;
            }
            set
            {
                TxtMontoVenta.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public decimal? Anticipo
        {
            get
            {
                decimal anticipo;
                return decimal.TryParse(TxtAnticipo.Text, out anticipo) ? anticipo : (decimal?)0;
            }
            set
            {
                TxtAnticipo.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public decimal? Adeuda
        {
            get
            {
                decimal adeuda;
                return decimal.TryParse(TxtAdeuda.Text, out adeuda) ? adeuda : (decimal?)0;
            }
            set
            {
                TxtAdeuda.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public int Cuotas
        {
            get
            {
                int cuotas;
                return int.TryParse(TxtCuotas.Text, out cuotas) ? cuotas : 0;
            }
            set
            {
                TxtCuotas.Text =  value.ToString() ;
            }
        }

        public decimal? MontoCuota
        {
            get
            {
                decimal montoCuota;
                return decimal.TryParse(TxtMontoCuota.Text, out montoCuota) ? montoCuota : (decimal?)0;
            }
            set
            {
                TxtMontoCuota.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public string Concepto
        {
            get
            {
                return TxtConcepto.Text;
            }
            set
            {
                TxtConcepto.Text = value;
            }
        }
        #endregion

        #region Funciones

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.ucFiltrosClientes.BuscarFinished += UcFiltrosClienteOnBuscarFinished;
            DtpVencimiento.Value = DateTime.Now.AddMonths(1);
            DtpVencimientoHasta.Value = DateTime.Now.AddMonths(1);
            Cuotas = 1;
            Anticipo = 0;
            DefinirCombos();
            CargarCombos();
            nroComprobante = NumeroComprobante();
            DefinirLCN(cobrador, localidad, cuenta, nroComprobante);
        }

        private string DefinirLCN(int? cobrador, int? localidad, int? cuenta, int numeroComprobante)
        {
            var cob = (cobrador ?? 0).ToString().PadLeft(3, '0');
            var loc = (localidad ?? 0).ToString().PadLeft(4, '0');
            var cuen = (cuenta ?? 0).ToString().PadLeft(4, '0');
            var comprobante = numeroComprobante.ToString().PadLeft(4, '0');
            TxtLCN.Text = cob + '-' + loc + '-' + cuen + '-' + comprobante;
            return cob  + loc  + cuen +  comprobante;
        }

        public int NumeroComprobante()
        {
            var numeroFactura = 0;
            var numeroComprobante = Uow.Ventas.Listado().OrderByDescending(v => v.FechaAlta).FirstOrDefault();
            if (numeroComprobante == null)
                numeroFactura = 0;
            else
                numeroFactura = (numeroComprobante.NumeroComprobante);
            return numeroFactura + 1;
        }

        private void CargarCombos()
        {
            var cobradores = Uow.Cobradores.Listado().Where(c=>c.Activo).ToList();
            cobradores.Insert(0, new Cobrador { Id = 0, Nombre = "SELECCIONE ..." });
            DdlCobradores.DataSource = cobradores;

            var vendedores = Uow.Vendedores.Listado().ToList();
            vendedores.Insert(0, new Entities.Vendedor { Id = 0, Nombre = "SELECCIONE ..." });
            DdlVendedor.DataSource = vendedores;

            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == ProvinciaId).ToList();
            DdlLocalidad.DataSource = localidades;

        }

        private void DefinirCombos()
        {
            DdlLocalidad.DisplayMember = "Nombre";
            DdlLocalidad.ValueMember = "Id";

            DdlCobradores.DisplayMember = "Nombre";
            DdlCobradores.ValueMember = "Id";

            DdlVendedor.DisplayMember = "Nombre";
            DdlVendedor.ValueMember = "Id";
        }

        private void UcFiltrosClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    ActualizarCliente(clientes.Single());
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

        private void ActualizarCliente(Cliente cliente)
        {
            if (!cliente.Activo ?? true)
            {
                _messageBoxDisplayService.Show(this, string.Format(Resources.MensajeClienteInactivo, cliente.Denominacion, cliente.Cuit), Resources.LabelVentas);
                return;
            }

            _cliente = cliente;

            var deudaTotal =  _clienteNegocio.DeudaTotal(_cliente.Id, 1);
            var deudaVencida =  _clienteNegocio.DeudaVencida(_cliente.Id, 1);

            ucClienteDetalle.ActualizarCliente(_cliente, deudaTotal, deudaVencida);
            cuenta = _cliente.Cuenta?? 0;
            DefinirLCN(cobrador, localidad, cuenta, nroComprobante);
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

        private void AgregarVenta()
        {
           Uow.Ventas.Agregar(venta);
        }

        private void AgregarCuentaCorriente()
        {
            var cuotas = Cuotas;
            for (int i = 2; i <= cuotas +1; i++)
            {
                var clienteCuentaCorriente = new ClientesCuentasCorriente();
                clienteCuentaCorriente.Id = Guid.NewGuid();
                clienteCuentaCorriente.VentaId = venta.Id;
                clienteCuentaCorriente.ClienteId = _cliente.Id;
                clienteCuentaCorriente.Cuota = (byte)i;
                clienteCuentaCorriente.Fecha = _clock.Now;
                DateTime venc = DtpVencimiento.Value;
                clienteCuentaCorriente.FechaVencimiento = venc.AddMonths(i - 1);

                DateTime vencHasta = DtpVencimientoHasta.Value;
                clienteCuentaCorriente.FechaVencimientoHasta = vencHasta.AddMonths(i - 1);

                clienteCuentaCorriente.Importe = (float) MontoCuota;
                clienteCuentaCorriente.Pagado = 0;
                clienteCuentaCorriente.FechaGeneracion = _clock.Now;
                clienteCuentaCorriente.FechaAlta = _clock.Now;
                clienteCuentaCorriente.SucursalAltaId = 1;
                clienteCuentaCorriente.OperadorAltaId = Guid.Empty;

                Uow.ClientesCuentasCorrientes.Agregar(clienteCuentaCorriente);
               // Uow.Commit();
            }
        }

        private void AgregarClienteMovimiento()
        {
            var clientesMovimiento = new ClientesMovimiento();

            clientesMovimiento.IdCliente = _cliente.Id;
            clientesMovimiento.IdTipoComprobante = 1; // FAC.VTA.CTA.CTE.
            clientesMovimiento.IdComprobante = venta.Id;
            clientesMovimiento.Concepto = "FAC.VTA.CTA.CTE.";
            clientesMovimiento.Haber = Anticipo;
            clientesMovimiento.Debe = MontoVenta - Anticipo;
            clientesMovimiento.FechaGeneracion = _clock.Now;
            clientesMovimiento.FechaAlta = _clock.Now;
            clientesMovimiento.SucursalAltaId = 1;
            clientesMovimiento.OperadorAltaId = Guid.Empty;

            Uow.ClientesMovimientos.Agregar(clientesMovimiento);
           // Uow.Commit();
        }

        private void ModificarCaja()
        {
             _caja = Uow.Cajas.Listado().OrderByDescending(c=>c.FechaAlta).FirstOrDefault();
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
            _caja.Ingresos += (float?)venta.TotalPagado;
            if (_caja.Saldo == null)
                _caja.Saldo = 0;
            _caja.Saldo += (float?)venta.TotalPagado;
            _caja.FechaModificacion = _clock.Now;
            _caja.SucursalModificacionId = 1;
            _caja.OperadorModificacionId = Guid.Empty;

            if (estado == 0)
                Uow.Cajas.Agregar(_caja);
            else
                Uow.Cajas.Modificar(_caja);

            //Uow.Commit();
        }

        private void AgregarCajaMovimiento()
        {
            var cajaMovimiento = new CajasMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = _caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = 1; //FACTURA DE VENTA - CUENTA CORRIENTE
            cajaMovimiento.TipoComprobante = 1; //FAC.VTA.CTA.CTE.
            cajaMovimiento.ComprobanteId = venta.Id;
            //cajaMovimiento.Senia = ventaData.Senas + ventaData.CreditosDevolucion;
           // if (ventaData.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
                cajaMovimiento.Importe = Anticipo;
            //else
            //    cajaMovimiento.Importe = ventaData.TotalPagar;

            cajaMovimiento.ImpFac = MontoVenta;


            cajaMovimiento.PcAlta = Environment.MachineName;
            cajaMovimiento.SucursalAltaId = 1;
            cajaMovimiento.OperadorAltaId = Guid.Empty;
            cajaMovimiento.FechaAlta = _clock.Now;

            Uow.CajasMovimientos.Agregar(cajaMovimiento);
            //Uow.Commit();
        }

       #endregion

        #region Controles
        private void TxtMontoVenta_TextChanged(object sender, EventArgs e)
        {
            Adeuda = MontoVenta - (Anticipo ?? 0);
            MontoCuota = Adeuda/Cuotas;
        }

        private void TxtAnticipo_TextChanged(object sender, EventArgs e)
        {
            Adeuda = MontoVenta - (Anticipo ?? 0);
            MontoCuota = Adeuda / Cuotas;
        }

        private void TxtCuotas_TextChanged(object sender, EventArgs e)
        {
            if (Cuotas!=0)
                MontoCuota = Adeuda / Cuotas;
        }

        private void DdlCobradores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DdlCobradores.SelectedValue != null)
            {
                cobrador=  int.TryParse(DdlCobradores.SelectedValue.ToString(), out cobrador) ? cobrador : 0;
                DefinirLCN(cobrador,localidad,cuenta,nroComprobante);
            }
        }

        private void DdlLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            localidad = int.TryParse(DdlLocalidad.SelectedValue.ToString(), out localidad) ? localidad : 0;
            DefinirLCN(cobrador, localidad, cuenta, nroComprobante);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_cliente ==null)
            {
                _messageBoxDisplayService.ShowWarning("Debe seleccionar un cliente");
                return;
            }

            if (MontoVenta == 0)
            {
                _messageBoxDisplayService.ShowWarning("Debe ingresar un importe");
                return;
            }
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {

                AgregarVenta();

                AgregarCuentaCorriente();

                AgregarClienteMovimiento();

                ModificarCaja();

                AgregarCajaMovimiento();

                Uow.Commit();

                var crearVenta = FormFactory.Create<FrmComprobantes>(venta.Id);
             
                if (crearVenta.ShowDialog() == DialogResult.OK)
                {
                    _messageBoxDisplayService.ShowSuccess("Cuenta registrada con éxito");
                    this.Close();
                }
            }

        }
        protected override object ObtenerEntidad()
        {
            return ObtenerVentaDesdeForm();
        }

        private object ObtenerVentaDesdeForm()
        {
            venta.Id = Guid.NewGuid();

            venta.NumeroComprobante = nroComprobante;

            venta.LetraComprobante = "X";
            venta.LCN = DefinirLCN(cobrador, localidad, cuenta, nroComprobante);
            venta.ComprobanteId = 1; // FAC.VTA.CTA.CTE.
            if (_cliente != null)
                venta.ClienteId = _cliente.Id ;
            else
                venta.ClienteId = Guid.Empty;

            venta.PuntoVenta = 1;
            venta.FechaComprobante = _clock.Now;
            venta.FechaVencimiento = _clock.Now;
            venta.CondicionVentaId = CondicionVentaEnum.CuentaCorriente; //CUENTA CORRIENTE

            venta.Concepto = Concepto;
            venta.ImporteNeto = MontoVenta ?? 0;
            venta.ImporteIva = 0;

            venta.ImporteSena = 0;
            venta.FechaUltimoPago = _clock.Now;
            venta.TotalPagado = Anticipo;
            venta.EstadoVentaId = 1; //Entregada

            venta.CobradorId = cobrador;
            int vendedor;
            venta.VendedorId = int.TryParse(DdlVendedor.SelectedValue.ToString(), out vendedor) ? vendedor : 0;
            venta.CantidadCuota = Cuotas;

            venta.FechaAlta = _clock.Now;
            venta.SucursalAltaId = 1;
            venta.OperadorAltaId = Guid.Empty;

            return venta;
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(DdlCobradores, "CobradorId");
            this.ValidarControl(DdlVendedor, "VendedorId");
            this.ValidarControl(TxtMontoVenta, "ImporteNeto");
            //this.ValidarControl(txtCelular, "Celular");
            //this.ValidarControl(txtMail, "Mail");
            //this.ValidarControl(cbxCondicionVenta, "CondicionVentaId");
            //this.ValidarControl(cbxLocalidad, "LocalidadId");
            //this.ValidarControl(TxtNroCliente, "Cuenta");
        }


        
        #endregion
       
      

    }
}
