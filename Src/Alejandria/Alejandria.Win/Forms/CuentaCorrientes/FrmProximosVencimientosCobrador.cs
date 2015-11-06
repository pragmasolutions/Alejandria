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
using Alejandria.Win.Forms.Cobradores;
using Alejandria.Win.Properties;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;
using Microsoft.Reporting.WinForms;
using Telerik.WinControls.UI;

namespace Alejandria.Win.Forms.CuentaCorrientes
{
    public partial class FrmProximosVencimientosCobrador : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cobrador _cobrador;
        private readonly IClienteCuentaCorrienteNegocio _clientecuentacorrienteNegocio;
        private ClientesCuentasCorriente _cuota;

        public FrmProximosVencimientosCobrador(IAlejandriaUow uow, IClock clock, IMessageBoxDisplayService messageBoxDisplayService,
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
            this.RvProximas.RefreshReport();
        }

        #region Cobrador
        
        private void UcFiltrosCobradoresOnBuscarFinished(object sender, List<Cobrador> cobradores)
        {
            if (cobradores.Any())
            {
                if (cobradores.Count == 1)
                {
                    ActualizarCobrador(cobradores.Single());
                    Refresh();
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

        #endregion

        #region ClientesCuentasCorrientes

        private void Refresh()
        {
            this.Cursor = Cursors.WaitCursor;
            RvProximas.LocalReport.DataSources.Clear();
            RvProximas.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\ProximosVencimientos.rdl";
            RvProximas.LocalReport.ReportPath = appPath + reportPath;

            var cuotas = Uow.Reportes.ProximasCuotasByCobrador(_cobrador.Id);
            RvProximas.LocalReport.DataSources.Add(new ReportDataSource("cuotas", cuotas));

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("Cobrador", _cobrador.Nombre)
                                };

            RvProximas.LocalReport.SetParameters(parametros);

            this.RvProximas.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        #endregion

    }
}
