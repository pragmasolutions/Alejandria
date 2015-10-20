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

namespace Alejandria.Win.Forms.Cobradores
{
    public partial class FrmCrearEditarCobrador : EditFormBase
    {
        private readonly int _cobradorId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Cobrador _cobrador;

        public FrmCrearEditarCobrador(IAlejandriaUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _cobradorId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        #region Eventos
        public event EventHandler<Cobrador> CobradorAgregado;
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
                    this.Text = Resources.LabelCrearCobrador;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarCobrador;
                    break;
            }
        }

   private void FrmCrearEditarCobrador_Load(object sender, EventArgs e)
        {
            DefinirCombos();
            CargarCombos();
            CargarNroCobrador();
            CargarCobrador(_cobradorId);
        }

       private void CargarCobrador(int cobradorId)
        {
            if (cobradorId == default(int))
            {
                _cobrador = new Cobrador();
                return;
            }
            else
            {
                _cobrador = Uow.Cobradores.Obtener(c => c.Id == cobradorId);
            }

            this.ApellidoNombre = _cobrador.Nombre;
            this.Domicilio = _cobrador.Domicilio;
            this.Telefono = _cobrador.Telefono;
            this.Celular = _cobrador.Celular;
            this.Mail = _cobrador.Mail;
            this.ProvinciaId = _cobrador.ProvinciaId;
            this.LocalidadId = _cobrador.LocalidadId;
            this.TipoDocumentoId = _cobrador.TipoDocumentoId;
            this.Cuit = _cobrador.Cuit;
            this.Cuenta = _cobrador.Id;
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

        private void CargarNroCobrador()
        {
            var nroCobrador =Uow.Cobradores.Listado().OrderByDescending(c => c.Id).FirstOrDefault();
            if (nroCobrador == null)
                Cuenta = 1;
            else
                Cuenta = nroCobrador.Id + 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarCobrador();
        }

        private void CrearEditarCobrador()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var cobrador = ObtenerCobradorDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Cobradores.Agregar(cobrador);
                }
                else
                {
                    Uow.Cobradores.Modificar(cobrador);
                }

                Uow.Commit();

                if (_formMode == ActionFormMode.Create)
                {
                    OnCobradorAgregado(cobrador);
                }
            }
        }

        private void OnCobradorAgregado(Cobrador cliente)
        {
            if (CobradorAgregado != null)
            {
                CobradorAgregado(this, cliente);
            }
        }

        private Cobrador ObtenerCobradorDesdeForm()
        {
            _cobrador.Id = _cobradorId == default(int) ? 1 : _cobradorId;
            _cobrador.Nombre = ApellidoNombre;
            _cobrador.Domicilio = Domicilio;
            _cobrador.Telefono = Telefono;
            _cobrador.Celular = Celular;
            _cobrador.Mail = Mail;
            _cobrador.ProvinciaId = ProvinciaId;
            _cobrador.LocalidadId = LocalidadId;
            _cobrador.TipoDocumentoId = TipoDocumentoId;
            _cobrador.Cuit = Cuit.PadLeft(11, '0');
            _cobrador.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _cobrador.FechaAlta;
            _cobrador.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;
            _cobrador.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? 1
                                          : _cobrador.SucursalAltaId;

            _cobrador.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _cobrador.SucursalModificacionId;

            _cobrador.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? Guid.Empty
                                          : _cobrador.OperadorAltaId;

            _cobrador.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _cobrador.OperadorModificacionId;
            _cobrador.Activo = true;

            return _cobrador;
       }

        protected override object ObtenerEntidad()
        {
            return ObtenerCobradorDesdeForm();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(txtApellidoNombre, "Denominacion");
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
