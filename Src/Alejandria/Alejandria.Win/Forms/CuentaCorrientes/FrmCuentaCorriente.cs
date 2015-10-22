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

namespace Alejandria.Win.Forms.CuentaCorrientes
{
    public partial class FrmCuentaCorriente : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IClienteNegocio _clienteNegocio;
        private Cliente _cliente;

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
        }

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
                    ccc => ccc.ClienteId == _clienteId && ccc.Importe > ccc.Pagado).OrderByDescending(
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
    }
}
