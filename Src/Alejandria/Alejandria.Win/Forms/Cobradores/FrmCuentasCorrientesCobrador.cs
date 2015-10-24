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
using Alejandria.Win.Properties;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;

namespace Alejandria.Win.Forms.Cobradores
{
    public partial class FrmCuentasCorrientesCobrador : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cobrador _cobrador;
        private readonly IClienteCuentaCorrienteNegocio _clientecuentacorrienteNegocio;

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
            //var cuotas2 =
            //    Uow.ClientesCuentasCorrientes.Listado(ccc => ccc.Venta.CobradorId == cobradorId && ccc.Importe > ccc.Pagado, ccc => ccc.Venta).OrderBy(
            //            ccc => ccc.FechaVencimiento).ToList();

            var cuotas = _clientecuentacorrienteNegocio.ListadoPorCobrador(cobradorId); 
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
    }
}
