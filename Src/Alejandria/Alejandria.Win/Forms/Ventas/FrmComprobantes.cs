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
    public partial class FrmComprobantes : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Guid _ventaId;
        private readonly IReporteNegocio _reporteNegocio;

        public FrmComprobantes(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             IReporteNegocio reporteNegocio,
                             IAlejandriaUow uow, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _ventaId = id;
            _reporteNegocio = reporteNegocio;

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

            var venta = Uow.Ventas.Obtener(v => v.Id == _ventaId, v => v.CondicionesVenta);

            var LCN = venta.LCN;
            var fecha = venta.FechaComprobante.ToString();
            var cliente = Uow.Clientes.Obtener(c => c.Id == venta.ClienteId, c => c.Provincia, c => c.Localidad);
            var clienteNombre = "Cliente: " + cliente.Denominacion;
            var cuenta = cliente.Cuenta;
            var DNI = "Cuit/DNI: " + cliente.Cuit;
            var dom = cliente.Domicilio.TrimEnd(' ');
            var domicilio = "Domicilio: " + dom;
            var localidad = " Localidad: " + cliente.Localidad.Nombre.TrimEnd(' ');
            var concepto = venta.Concepto;

            this.Cursor = Cursors.WaitCursor;
            RvComprobantes.LocalReport.DataSources.Clear();
            RvComprobantes.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\Comprobantes.rdl";
            RvComprobantes.LocalReport.ReportPath = appPath + reportPath;

            var comprobantes = _reporteNegocio.ComprobantesByVentaId(_ventaId);
           RvComprobantes.LocalReport.DataSources.Add(new ReportDataSource("Comprobantes",comprobantes));

        }
    }
}
