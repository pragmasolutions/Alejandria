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
    public partial class FrmVentas : FormBase
    {
        private readonly IClock _clock;
        private Venta _venta;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cliente _cliente;
        int ProvinciaId = 1;
        private int localidad = 0;
        private int cobrador = 0;
        private int nroComprobante = 0;
        private int cuenta = 0;

        public FrmVentas(IAlejandriaUow uow,IClock clock,IMessageBoxDisplayService messageBoxDisplayService,
            IFormFactory formFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
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
            Cuotas = 1;
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

            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == ProvinciaId).ToList();
            DdlLocalidad.DataSource = localidades;

        }

        private void DefinirCombos()
        {
            DdlLocalidad.DisplayMember = "Nombre";
            DdlLocalidad.ValueMember = "Id";

            DdlCobradores.DisplayMember = "Nombre";
            DdlCobradores.ValueMember = "Id";
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

            var deudaTotal = 0;// _clienteNegocio.DeudaTotal(_cliente.Id, this.Context.SucursalActual.Id);
            var deudaVencida = 0;// _clienteNegocio.DeudaVencida(_cliente.Id, this.Context.SucursalActual.Id);

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

       #endregion

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
            MontoCuota = Adeuda / Cuotas;
        }

        private void DdlCobradores_SelectedValueChanged(object sender, EventArgs e)
        {
            cobrador=  int.TryParse(DdlCobradores.SelectedValue.ToString(), out cobrador) ? cobrador : 0;
            DefinirLCN(cobrador,localidad,cuenta,nroComprobante);
        }

        private void DdlLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            localidad = int.TryParse(DdlLocalidad.SelectedValue.ToString(), out localidad) ? localidad : 0;
            DefinirLCN(cobrador, localidad, cuenta, nroComprobante);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AgregarVenta()

            //CuentaCorriente

            //Caja
        }

        private Venta AgregarVenta()
        {
            var venta = new Venta();

            venta.Id = Guid.NewGuid();

            venta.NumeroComprobante = nroComprobante;
            
            venta.LetraComprobante = "X";
            venta.LCN = DefinirLCN(cobrador,localidad,cuenta,nroComprobante);
            venta.ComprobanteId = 1; // FAC.VTA.CTA.CTE.
            venta.ClienteId = _cliente.Id;

            venta.PuntoVenta = 1;
            venta.FechaComprobante = _clock.Now;
            venta.FechaVencimiento = _clock.Now;
            venta.CondicionVentaId = CondicionVentaEnum.CuentaCorriente; //CUENTA CORRIENTE

            venta.Concepto = ventaData.TipoComprobanteSeleccionado.ToString();
            venta.ImporteNeto = ventaData.TotalPagar.GetValueOrDefault();
            venta.ImporteIva = ImporteIva;

            venta.ImporteSena = ventaData.Senas + ventaData.CreditosDevolucion;
            venta.FechaUltimoPago = _clock.Now;
            venta.TotalPagado = ventaData.TotalPagar;
            venta.EstadoVentaId = EstadoVentaEnum.Entregada;

            venta.FechaAlta = _clock.Now;
            venta.SucursalAltaId = ventaData.SucursalId;
            venta.OperadorAltaId = ventaData.OperadorId;

            Uow.Ventas.Agregar(venta);

            return venta;
        }
    }
}
