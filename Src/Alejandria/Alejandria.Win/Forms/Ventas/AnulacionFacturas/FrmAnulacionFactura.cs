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


namespace Alejandria.Win.Forms.Ventas.AnulacionFacturas
{
    public partial class FrmAnulacionFactura : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Venta _venta = new Venta();
        private string _lcn;

        public FrmAnulacionFactura(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             IAlejandriaUow uow)
                                //,IFormRegistry formRegistry)
        {
            FormFactory = formFactory;
            Uow = uow;
            //FormRegistry = formRegistry;

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
            if (_venta.EstadoVentaId == 2) //Anulada
            {
                _messageBoxDisplayService.ShowWarning("Factura ya anulada");
                return;
            }

            //var operador = this.ObtenerOperadorAdministrador();

            //if (operador == null)
            //{
            //    return;
            //}

            //if (!this.EsOperadorAdmin)
            //{
            //    //Guardamos el operador que autorizo la operacion.
            //    _venta.OperadorAutoriza = operador.Id;    
            //}

            //Anular la Venta
            _venta.EstadoVentaId = 2; //Anulada
            _venta.FechaModificacion = _clock.Now;
            _venta.OperadorModificacionId = Guid.Empty;
            _venta.SucursalModificacionId = 1;

            Uow.Ventas.Modificar(_venta);

          
            //Devovler caja
            Caja caja = Uow.Cajas.Listado().OrderByDescending(c => c.FechaAlta).FirstOrDefault();
            if (caja.Ingresos == null)
                caja.Ingresos = 0;
            caja.Ingresos -= (float?)_venta.TotalPagado;
            if (caja.Saldo == null)
                caja.Saldo = 0;
            caja.Saldo -= (float?)_venta.TotalPagado;
            caja.FechaModificacion = _clock.Now;
            caja.SucursalModificacionId = 1;
            caja.OperadorModificacionId = Guid.Empty;

            Uow.Cajas.Modificar(caja);

            //CajaMovimiento
            var cajaMovimientoAnterior = Uow.CajasMovimientos.Obtener(c => c.ComprobanteId == _venta.Id);

            CajasMovimiento cajaMovimiento = new CajasMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;

            if (_venta.CondicionVentaId == CondicionVentaEnum.CuentaCorriente)
                cajaMovimiento.TipoMovimientoCajaId = 3;
            else
                cajaMovimiento.TipoMovimientoCajaId = 3;

            cajaMovimiento.TipoComprobante = 3;
            cajaMovimiento.ComprobanteId = _venta.Id;
            cajaMovimiento.Senia = cajaMovimientoAnterior.Senia;
            cajaMovimiento.Importe = cajaMovimientoAnterior.Importe;
            cajaMovimiento.ImpFac = cajaMovimientoAnterior.ImpFac;
            cajaMovimiento.Recargo = cajaMovimientoAnterior.Recargo;
            cajaMovimiento.Efectivo = cajaMovimientoAnterior.Efectivo;
            cajaMovimiento.Tarjeta = cajaMovimientoAnterior.Tarjeta;
            cajaMovimiento.Cheque = cajaMovimientoAnterior.Cheque;
            cajaMovimiento.Deposito = cajaMovimientoAnterior.Deposito;

            cajaMovimiento.PcAlta = Environment.MachineName;
            cajaMovimiento.SucursalAltaId = _venta.SucursalAltaId;
            cajaMovimiento.OperadorAltaId = _venta.OperadorAltaId;
            cajaMovimiento.FechaAlta = _clock.Now;

            cajaMovimiento.SucursalModificacionId = 1;
            cajaMovimiento.OperadorModificacionId = Guid.Empty;
            cajaMovimiento.FechaModificacion = _clock.Now;

            Uow.CajasMovimientos.Agregar(cajaMovimiento);

            //MovimientoCliente
            ClientesMovimiento clientesMovimiento = new ClientesMovimiento();
            clientesMovimiento.IdCliente = _venta.ClienteId;
            clientesMovimiento.IdTipoComprobante = 3;
            clientesMovimiento.IdComprobante = _venta.Id;
            clientesMovimiento.Concepto = "Venta anulada";
            clientesMovimiento.Debe = _venta.TotalPagado;
            clientesMovimiento.FechaGeneracion = _clock.Now;
            clientesMovimiento.FechaAlta = _clock.Now;
            clientesMovimiento.SucursalAltaId = 1;
            clientesMovimiento.OperadorAltaId = Guid.Empty;

            Uow.ClientesMovimientos.Agregar(clientesMovimiento);

            //si la venta fue en CuentaCorriente, Anular las cuotas
            if (_venta.CondicionVentaId==CondicionVentaEnum.CuentaCorriente)
            {
                var cuotas = Uow.ClientesCuentasCorrientes.Listado().Where(cc => cc.VentaId == _venta.Id);
                foreach (ClientesCuentasCorriente cuota in cuotas)
                {
                    cuota.Pagado = cuota.Importe;
                    cuota.Observaciones = "Venta Anulada";
                    cuota.FechaModificacion = _clock.Now;
                    cuota.OperadorModificacionId = Guid.Empty;
                    cuota.SucursalModificacionId = 1;

                    Uow.ClientesCuentasCorrientes.Modificar(cuota);
                }
            }

          
            Uow.Commit();
            _messageBoxDisplayService.ShowSuccess("Factura anulada correctamente");

            this.Close();
            //OnAccionTerminada();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
      {
          int numeroComprobante = int.TryParse(txtVentaNro.Text, out numeroComprobante) ? numeroComprobante : 0;
          _venta =
              Uow.Ventas.Listado(v => v.Cliente).OrderByDescending(v => v.FechaAlta).FirstOrDefault(v => v.NumeroComprobante == numeroComprobante && v.EstadoVentaId == 1);

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

        private void FrmAnulacionFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
