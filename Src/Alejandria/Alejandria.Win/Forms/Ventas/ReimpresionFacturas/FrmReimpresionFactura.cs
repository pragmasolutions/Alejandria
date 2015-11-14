using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Entities.Enums;
using Alejandria.Win.Helpers;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;


namespace Alejandria.Win.Forms.Ventas.ReimpresionFacturas
{
    public partial class FrmReimpresionFacturas : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Venta _venta = new Venta();
        private string _lcn;

        public FrmReimpresionFacturas(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             IAlejandriaUow uow)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
           
        }

      #region Métodos

       
        private void CargarDatosFactura()
        {
            TxtCliente.Text = _venta.Cliente.Denominacion;
            TxtConcepto.Text = _venta.Concepto;
            TxtFecha.Text = String.Format("{0:dd MMMM yyyy}", _venta.FechaComprobante);
            TxtImporte.Text = _venta.ImporteNeto.ToString("N2");
        }

        private void Limpiar()
        {
            TxtCliente.Text = "";
            TxtConcepto.Text = "";
            TxtFecha.Text = "";
            TxtImporte.Text = "";
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var crearVenta = FormFactory.Create<FrmComprobantes>(_venta.Id);

            if (crearVenta.ShowDialog() == DialogResult.OK)
            {
               // _messageBoxDisplayService.ShowSuccess("Cuenta registrada con éxito");
                this.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
      {
          int numeroComprobante = int.TryParse(txtVentaNro.Text, out numeroComprobante) ? numeroComprobante : 0;
          _venta =
              Uow.Ventas.Listado(v => v.Cliente).OrderByDescending(v=>v.FechaAlta).FirstOrDefault(v => v.NumeroComprobante == numeroComprobante && v.EstadoVentaId==1);

          if (_venta != null)
          {
              CargarDatosFactura();
          }
          else
          {
              Limpiar();
              _messageBoxDisplayService.ShowSuccess("No se encontró factura con ese número");
          }
      }
    }
}
