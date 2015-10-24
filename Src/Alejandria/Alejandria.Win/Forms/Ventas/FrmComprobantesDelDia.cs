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
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;
using Microsoft.Reporting.WinForms;

namespace Alejandria.Win.Forms.Ventas
{
    public partial class FrmComprobantesdelDia : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IReporteNegocio _reporteNegocio;

        public FrmComprobantesdelDia(IFormFactory formFactory,
                            IAlejandriaUow uow
                            )
        {
            FormFactory = formFactory;
            Uow = uow;
            InitializeComponent();
        }

        private void FrmComprobantes_Load(object sender, EventArgs e)
        {
            GenerarComprobantes();
            this.RvComprobantes.RefreshReport();
        }

        private void GenerarComprobantes()
        {
            this.Cursor = Cursors.WaitCursor;
            RvComprobantes.LocalReport.DataSources.Clear();
            RvComprobantes.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\ComprobantesDelDia.rdl";
            RvComprobantes.LocalReport.ReportPath = appPath + reportPath;

            var comprobantes = Uow.Reportes.ComprobantesDelDia();
           RvComprobantes.LocalReport.DataSources.Add(new ReportDataSource("Comprobantes",comprobantes));
           
            //var parametros = new List<ReportParameter>
            //                     {
            //                         new ReportParameter("ventaId", ""),
            //                     };

            //RvComprobantes.LocalReport.SetParameters(parametros);
            this.RvComprobantes.RefreshReport();
           this.Cursor = Cursors.Default;

        }

      }
}
