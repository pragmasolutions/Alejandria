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
using Alejandria.Win.Enums;
using Framework.Common.Utility;
using Framework.WinForm.Comun.Notification;

namespace Alejandria.Win.Forms.Localidades
{
    public partial class FrmCrearEditarLocalidad : FormBase
    {
        private readonly int _localidadId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Localidad _localidad;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmCrearEditarLocalidad(IAlejandriaUow uow, IClock clock, int id, ActionFormMode mode, IMessageBoxDisplayService messageBoxDisplayService)
        {
            Uow = uow;

            _localidadId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
            InicializarForm(mode);
        }

        private void FrmCrearEditarLocalidad_Load(object sender, EventArgs e)
        {
            DefinirCombos();
            CargarCombos();
        }

        private void DefinirCombos()
        {
            //Provincia
            cbxProvincia.DisplayMember = "Nombre";
            cbxProvincia.ValueMember = "Id";
        }

        private void CargarCombos()
        {
            var provincias = Uow.Provincias.Listado().OrderBy(p => p.Nombre).ToList();
            provincias.Insert(0, new Provincia() { Id = 0, Nombre = "SELECCIONE PROVINCIA" });
            cbxProvincia.DataSource = provincias;
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nueva Localidad";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar Localidad";
                    break;
            }
        }

        private void CrearEditar()
        {
            if (TxtNombre.Text == "")
            {
                _messageBoxDisplayService.ShowWarning("Debe completar el Nombre");
                return;
            }
        
           if ((int)cbxProvincia.SelectedValue == 0)
           {
               _messageBoxDisplayService.ShowWarning("Debe seleccionar una Provincia");
               return;
           }

                var localidad = ObtenerDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Localidades.Agregar(localidad);
                }
                else
                {
                    Uow.Localidades.Modificar(localidad);
                }

                Uow.Commit();
                _messageBoxDisplayService.ShowSuccess("Guardado exitosamente");
                this.Close();
          }

        private Localidad ObtenerDesdeForm()
        {
            _localidad= new Localidad();
            _localidad.Id = (Uow.Localidades.Listado().OrderByDescending(p=>p.Id).FirstOrDefault().Id) +1 ;
            _localidad.Nombre = TxtNombre.Text;
            _localidad.CP = TxtCP.Text;
            _localidad.ProvinciaId = (int) cbxProvincia.SelectedValue;
            //Fechas.
            _localidad.FechaAlta = _clock.Now;
            _localidad.SucursalAltaId = 1;
            _localidad.OperadorAltaId = Guid.Empty;

            _localidad.FechaModificacion = _clock.Now;
            _localidad.SucursalModificacionId = 1;
            _localidad.OperadorModificacionId = Guid.Empty;
            return _localidad;
        }

        private void BrnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }

       
    }
}
