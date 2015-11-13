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

namespace Alejandria.Win.Forms.Provincias
{
    public partial class FrmCrearEditarProvincia : FormBase
    {
        private readonly int _provinciaId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Provincia _provincia;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmCrearEditarProvincia(IAlejandriaUow uow, IClock clock, int id, ActionFormMode mode, IMessageBoxDisplayService messageBoxDisplayService)
        {
            Uow = uow;

            _provinciaId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nueva Provincia";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar Provincia";
                    break;
            }
        }

        private void CrearEditar()
        {
            if (TxtNombre.Text != "")
            {
                var provincia = ObtenerDesdeForm();
                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Provincias.Agregar(provincia);
                }
                else
                {
                    Uow.Provincias.Modificar(provincia);
                }

                Uow.Commit();
                _messageBoxDisplayService.ShowSuccess("Guardado exitosamente");
                this.Close();
            }
        }

        private Provincia ObtenerDesdeForm()
        {
            _provincia= new Provincia();
            _provincia.Id = (Uow.Provincias.Listado().OrderByDescending(p=>p.Id).FirstOrDefault().Id) +1 ;
            _provincia.Nombre = TxtNombre.Text;
            
            //Fechas.
            _provincia.FechaAlta =  _clock.Now ;
            _provincia.SucursalAltaId = 1;
            _provincia.OperadorAltaId = Guid.Empty;

            return _provincia;
        }

        private void BrnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditar();
        }
    }
}
