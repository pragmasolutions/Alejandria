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


namespace Alejandria.Win.Forms.Vendedores
{
    public partial class FrmDetalleEliminarVendedores : FormBase
    {
        private readonly int _vendedorId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IVendedoresNegocio _vendedorNegocio;

        public FrmDetalleEliminarVendedores(IAlejandriaUow uow,
                                         IVendedoresNegocio vendedorNegocio,
                                         IMessageBoxDisplayService messageBoxDisplayService,
                                         int id, ActionFormMode mode, IFormFactory formFactory)
        {
            FormFactory = formFactory;
            Uow = uow;

            _messageBoxDisplayService = messageBoxDisplayService;
            _vendedorId = id;
            _vendedorNegocio = vendedorNegocio;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = "Detalle Vendedor";
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = "Eliminar Vendedor";
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
            CargarVendedor(_vendedorId);
        }

        private void CargarVendedor(int vendedorId)
        {
            Vendedor vendedor = Uow.Vendedores.Obtener(c => c.Id == vendedorId, c => c.Provincia,
                                                    c => c.Localidad,
                                                    c => c.TiposDocumentosIdentidad);

            this.ApellidoNombre = vendedor.Nombre;
            this.Domicilio = vendedor.Domicilio;
            this.Telefono = vendedor.Telefono;
            this.Celular = vendedor.Celular;
            this.Mail = vendedor.Mail;
            this.Provincia = vendedor.Provincia != null ? vendedor.Provincia.Nombre : string.Empty;
            this.Localidad = vendedor.Localidad != null ? vendedor.Localidad.Nombre : string.Empty;

            this.TipoDocumento = vendedor.TiposDocumentosIdentidad != null ? vendedor.TiposDocumentosIdentidad.Nombre : string.Empty;
            this.Cuit = vendedor.Cuit;
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
           
            var vendedor = Uow.Vendedores.Obtener(p => p.Id == _vendedorId);

            vendedor.Activo = false;

            Uow.Vendedores.Modificar(vendedor);

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
