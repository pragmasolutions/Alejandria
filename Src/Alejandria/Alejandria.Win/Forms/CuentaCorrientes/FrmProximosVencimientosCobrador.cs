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

        public FrmProximosVencimientosCobrador(IAlejandriaUow uow, IClock clock,
                                            IMessageBoxDisplayService messageBoxDisplayService,
                                            IFormFactory formFactory, IClienteCuentaCorrienteNegocio clientecuentacorrienteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clientecuentacorrienteNegocio = clientecuentacorrienteNegocio;


            InitializeComponent();
        }

        #region Inicializacion
        

        private void FrmCuentasCorrientesCobrador_Load(object sender, EventArgs e)
        {
            this.RvProximas.RefreshReport();
            DefinirCombos();
            CargarCombos();
        }

        private void CargarCombos()
        {
            var cobradores = Uow.Cobradores.Listado().Where(c => c.Activo).ToList();
            cobradores.Insert(0, new Cobrador { Id = 0, Nombre = "SELECCIONE ..." });
            DdlCobradores.DataSource = cobradores;
        }

        private void DefinirCombos()
        {
            DdlCobradores.DisplayMember = "Nombre";
            DdlCobradores.ValueMember = "Id";
        }

        #endregion

        #region Cobrador

        private void DdlCobradores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DdlCobradores.SelectedValue != null)
            {
                int cobrador = int.TryParse(DdlCobradores.SelectedValue.ToString(), out cobrador) ? cobrador : 0;
                _cobrador = Uow.Cobradores.Obtener(c => c.Id == cobrador, c=>c.Localidad, c=>c.Provincia);
                ActualizarCobrador(_cobrador);
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            if (_cobrador != null)
                Refresh();
        }

        private void ActualizarCobrador(Cobrador cobrador)
        {
            if (cobrador!=null)
            {
                if (!cobrador.Activo)
                {
                    _messageBoxDisplayService.Show(this, string.Format("Cobrador Inactivo", cobrador.Nombre, cobrador.Cuit), Resources.LabelVentas);
                    return;
                }

                _cobrador = cobrador;

                ucCobradorDetalle.ActualizarCobrador(_cobrador);
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
                                    new ReportParameter("Cobrador", _cobrador.Nombre),
                                    new ReportParameter("cobradorId", _cobrador.Id.ToString())
                                };

            RvProximas.LocalReport.SetParameters(parametros);

            this.RvProximas.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        #endregion

      

    }
}
