using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Entities.Enums;
using Alejandria.Win.Enums;
using Alejandria.Win.Forms;
using Alejandria.Win.Properties;
using Framework.Common.Utility;
using Ninject.Activation;

namespace Alejandria.Win.Forms.Vendedores
{
    public partial class FrmCrearEditarVendedor : EditFormBase
    {
        private readonly int _vendedorId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Vendedor _vendedor;

        public FrmCrearEditarVendedor(IAlejandriaUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _vendedorId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        #region Eventos
        public event EventHandler<Vendedor> VendedorAgregado;
        #endregion

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

        public int? Cuenta
        {
            get
            {
                int cuenta;
                return int.TryParse(TxtNroCliente.Text, out cuenta) ? cuenta : (int?)null;
            }
            set
            {
                TxtNroCliente.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
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
            get { return txtCelular.Text.Trim(); }
            set { txtCelular.Text = value; }
        }

        public string Mail
        {
            get { return txtMail.Text; }
            set { txtMail.Text = value; }
        }

       public int? ProvinciaId
        {
            get { return (int?)cbxProvincia.SelectedValue; }
            set { cbxProvincia.SelectedValue = value ?? 0; }
        }

        public int? LocalidadId
        {
            get { return (int?)cbxLocalidad.SelectedValue; }
            set { cbxLocalidad.SelectedValue = value ?? 0; }
        }

        public int? TipoDocumentoId
        {
            get { return (int?)cbxTipoDocumento.SelectedValue; }
            set { cbxTipoDocumento.SelectedValue = value ?? 0; }
        }

       #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearVendedor;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarVendedor;
                    break;
            }
        }

   private void FrmCrearEditarVendedor_Load(object sender, EventArgs e)
        {
            DefinirCombos();
            CargarCombos();
            CargarNroVendedor();
            CargarVendedor(_vendedorId);
        }

       private void CargarVendedor(int vendedorId)
        {
            if (vendedorId == default(int))
            {
                _vendedor = new Vendedor();
                return;
            }
            else
            {
                _vendedor = Uow.Vendedores.Obtener(c => c.Id == vendedorId);
            }

            this.ApellidoNombre = _vendedor.Nombre;
            this.Domicilio = _vendedor.Domicilio;
            this.Telefono = _vendedor.Telefono;
            this.Celular = _vendedor.Celular;
            this.Mail = _vendedor.Mail;
            this.ProvinciaId = _vendedor.ProvinciaId;
            this.LocalidadId = _vendedor.LocalidadId;
            this.TipoDocumentoId = _vendedor.TipoDocumentoId;
            this.Cuit = _vendedor.Cuit;
            this.Cuenta = _vendedor.Id;
        }

        private void DefinirCombos()
        {
            //Provincia
            cbxProvincia.DisplayMember = "Nombre";
            cbxProvincia.ValueMember = "Id";

           cbxTipoDocumento.DisplayMember = "Nombre";
            cbxTipoDocumento.ValueMember = "Id";

            cbxLocalidad.DisplayMember = "Nombre";
            cbxLocalidad.ValueMember = "Id";

        }

        private void CargarCombos()
        {

            var provincias = Uow.Provincias.Listado().OrderBy(p => p.Nombre).ToList();
            //provincias.Insert(0, new Provincia() { Id = 0, Nombre = "SELECCIONE PROVINCIA" });
            cbxProvincia.DataSource = provincias;
           
            var tiposDocumentos = Uow.TiposDocumentosIdentidades.Listado().ToList();
            //  tiposDocumentos.Insert(0, new TiposDocumentosIdentidad(){ Id = 0, Nombre = "SELECCIONE" });
            cbxTipoDocumento.DataSource = tiposDocumentos;
            cbxTipoDocumento.SelectedValue = 2;

            ProvinciaId = 3;
         }

        private void CargarLocalidad(int? provinciaId)
        {
            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == provinciaId).ToList();
            //localidades.Insert(0, new Localidad() { Id = 0, Nombre = "SELECCIONE LOCALIDAD" });

            cbxLocalidad.DataSource = localidades;
        }

        private void cbxProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarLocalidad((int?)cbxProvincia.SelectedValue);
        }

        private void CargarNroVendedor()
        {
            var nroVendedor =Uow.Vendedores.Listado().OrderByDescending(c => c.Id).FirstOrDefault();
            if (nroVendedor == null)
                Cuenta = 1;
            else
                Cuenta = nroVendedor.Id + 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarVendedor();
        }

        private void CrearEditarVendedor()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var vendedor = ObtenerVendedorDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Vendedores.Agregar(vendedor);
                }
                else
                {
                    Uow.Vendedores.Modificar(vendedor);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnVendedorAgregado(vendedor);
                }
            }
        }

        private void OnVendedorAgregado(Vendedor vendedor)
        {
            if (VendedorAgregado != null)
            {
                VendedorAgregado(this, vendedor);
            }
        }

        private Vendedor ObtenerVendedorDesdeForm()
        {
            _vendedor.Id = _vendedorId == default(int) ? 1 : _vendedorId;
            _vendedor.Nombre = ApellidoNombre;
            _vendedor.Domicilio = Domicilio;
            _vendedor.Telefono = Telefono;
            _vendedor.Celular = Celular;
            _vendedor.Mail = Mail;
            _vendedor.ProvinciaId = ProvinciaId;
            _vendedor.LocalidadId = LocalidadId;
            _vendedor.TipoDocumentoId = TipoDocumentoId;
            _vendedor.Cuit = Cuit.PadLeft(11, '0');
            _vendedor.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _vendedor.FechaAlta;
            _vendedor.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;
            _vendedor.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? 1
                                          : _vendedor.SucursalAltaId;

            _vendedor.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _vendedor.SucursalModificacionId;

            _vendedor.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? Guid.Empty
                                          : _vendedor.OperadorAltaId;

            _vendedor.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _vendedor.OperadorModificacionId;
            _vendedor.Activo = true;

            return _vendedor;
       }

        protected override object ObtenerEntidad()
        {
            return ObtenerVendedorDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(txtApellidoNombre, "Nombre");
            this.ValidarControl(txtDni, "Cuit");
            this.ValidarControl(txtDomicilio, "Domicilio");
            this.ValidarControl(txtCelular, "Celular");
            this.ValidarControl(txtMail, "Mail");
            this.ValidarControl(cbxLocalidad, "LocalidadId");
            this.ValidarControl(TxtNroCliente, "Cuenta");
         }

        public void SetearDni(string dni)
        {
            Cuit = dni;
        }


        #endregion

      }
}
