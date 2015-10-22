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
using Alejandria.Win;
using Alejandria.Win.Enums;
using Alejandria.Win.Forms;
using Alejandria.Win.Properties;
using Framework.WinForm.Comun.Notification;


namespace Alejandria.Win.Forms.Cobradores
{
    public partial class FrmDetalleEliminarCobrador : FormBase
    {
        private readonly int _cobradorId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly ICobradoresNegocio _cobradorNegocio;

        public FrmDetalleEliminarCobrador(IAlejandriaUow uow,
                                         ICobradoresNegocio cobradorNegocio,
                                         IMessageBoxDisplayService messageBoxDisplayService,
                                         int id, ActionFormMode mode, IFormFactory formFactory)
        {
            FormFactory = formFactory;
            Uow = uow;

            _messageBoxDisplayService = messageBoxDisplayService;
            _cobradorId = id;
            _cobradorNegocio = cobradorNegocio;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = "Detalle Cliente";
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = "Eliminar Cliente";
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        #region Propiedades
        public Guid Id { get; set; }

        public string ApellidoNombre
        {
            get { return txtApellidoNombre.Text; }
            set { txtApellidoNombre.Text = value; }
        }

        public string Cuit
        {
            get { return txtDni.Text; }
            set { txtDni.Text = value; }
        }

        public string Domicilio
        {
            get { return txtDomicilio.Text; }
            set { txtDomicilio.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Celular
        {
            get { return txtCelular.Text; }
            set { txtCelular.Text = value; }
        }

        public string Mail
        {
            get { return txtMail.Text; }
            set { txtMail.Text = value; }
        }

        public bool? Llamar
        {
            get { return ckbLlamar.Checked; }
            set { ckbLlamar.Checked = value ?? false; }
        }

        public bool? MandarMail
        {
            get { return ckbMail.Checked; }
            set { ckbMail.Checked = value ?? false; }
        }

        public string Provincia
        {
            get { return txtProvincia.Text; }
            set { txtProvincia.Text = value; }
        }

        public string Localidad
        {
            get { return txtLocalidad.Text; }
            set { txtLocalidad.Text = value; }
        }

        public string TipoDocumento
        {
            get { return txtTipoDni.Text; }
            set { txtTipoDni.Text = value; }
        }

        public string Especialidad
        {
            get { return txtEspecialidad.Text; }
            set { txtEspecialidad.Text = value; }
        }

        public string Profesion
        {
            get { return txtProfesion.Text; }
            set { txtProfesion.Text = value; }
        }

        public string CondicionVentaId
        {
            get { return txtCondicion.Text; }
            set { txtCondicion.Text = value; }
        }

        public string EstadoCliente
        {
            get { return txtCondicion.Text; }
            set { txtCondicion.Text = value; }
        }
        #endregion

        private void FrmDetalleEliminarCliente_Load(object sender, EventArgs e)
        {
            CargarCobrador(_cobradorId);
        }

        private void CargarCobrador(int cobradorId)
        {
            Cobrador cobrador = Uow.Cobradores.Obtener(c => c.Id == cobradorId, c => c.Provincia,
                                                    c => c.Localidad,
                                                    c => c.TiposDocumentosIdentidad);

            this.ApellidoNombre = cobrador.Nombre;
            this.Domicilio = cobrador.Domicilio;
            this.Telefono = cobrador.Telefono;
            this.Celular = cobrador.Celular;
            this.Mail = cobrador.Mail;
            this.Provincia = cobrador.Provincia != null ? cobrador.Provincia.Nombre : string.Empty;
            this.Localidad = cobrador.Localidad != null ? cobrador.Localidad.Nombre : string.Empty;
            
            this.TipoDocumento = cobrador.TiposDocumentosIdentidad != null ? cobrador.TiposDocumentosIdentidad.Nombre : string.Empty;
            this.Cuit = cobrador.Cuit;
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var tieneDeuda = _cobradorNegocio.DeudaTotal(_cobradorId, null) > 0;

            if (tieneDeuda)
            {
                _messageBoxDisplayService.Show(Resources.ErrorMessageClienteConDeuda, Resources.LabelClientes);
                return;
            }

            var cobrador = Uow.Cobradores.Obtener(p => p.Id == _cobradorId);

            cobrador.Activo = false;

            Uow.Cobradores.Modificar(cobrador);

            Uow.Commit();
        }

        //private void btnSenas_Click(object sender, EventArgs e)
        //{
        //    using (var pantalla = FormFactory.Create<FrmCrearSenia>(_clienteId, ActionFormMode.Create))
        //    {
        //        pantalla.FormBorderStyle = FormBorderStyle.FixedSingle;
        //        pantalla.ShowDialog();
        //    }
        //}
    }
}
