﻿using System;
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
    public partial class FrmComprobantes : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        public Guid _ventaId;
        private readonly IReporteNegocio _reporteNegocio;

        public FrmComprobantes(IFormFactory formFactory,
                            IAlejandriaUow uow,
                            Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;

           // _clock = clock;
            //_messageBoxDisplayService = messageBoxDisplayService;
            _ventaId = id;
            InitializeComponent();
        }

        private void FrmComprobantes_Load(object sender, EventArgs e)
        {
            GenerarComprobantes();
            this.RvComprobantes.RefreshReport();
        }

        private void GenerarComprobantes()
        {
            if (_ventaId == Guid.Empty)
                return;


            this.Cursor = Cursors.WaitCursor;
            RvComprobantes.LocalReport.DataSources.Clear();
            RvComprobantes.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\Comprobantes.rdl";
            RvComprobantes.LocalReport.ReportPath = appPath + reportPath;

            var comprobantes = Uow.Reportes.ComprobantesByVentaId(_ventaId);
           RvComprobantes.LocalReport.DataSources.Add(new ReportDataSource("Comprobantes",comprobantes));
           
            var parametros = new List<ReportParameter>
                                 {
                                     new ReportParameter("ventaId", _ventaId.ToString()),
                                 };

            RvComprobantes.LocalReport.SetParameters(parametros);
            this.RvComprobantes.RefreshReport();
           this.Cursor = Cursors.Default;

        }

        private void FrmComprobantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult=DialogResult.OK;
        }

      }
}
