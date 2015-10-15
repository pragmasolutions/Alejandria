using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
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

        public FrmVentas(IAlejandriaUow uow,IClock clock,IMessageBoxDisplayService messageBoxDisplayService, IFormFactory formFactory)
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

        #endregion

        #region Funciones

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.ucFiltrosClientes.BuscarFinished += UcFiltrosClienteOnBuscarFinished;
            DtpVencimiento.Value = DateTime.Now.AddMonths(1);
            Cuotas = 1;
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

       
    }
}
