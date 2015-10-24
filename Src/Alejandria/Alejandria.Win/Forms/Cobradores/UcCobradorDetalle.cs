using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Entities;
using Alejandria.Win.Enums;
using Framework.Ioc;


namespace Alejandria.Win.Forms.Cobradores
{
    public partial class UcCobradorDetalle : UserControlBase
    {
        public event EventHandler<Cobrador> CobradorEdited;

        private Cobrador _cobrador;

        public UcCobradorDetalle()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }
            InitializeComponent();
        }

        #region Propiedades
        public string CobradorNombre
        {
            get { return TxtCobrador.Text; }
            set { TxtCobrador.Text = value; }
        }

        public string Domicilio
        {
            get { return TxtDomicilio.Text; }
            set { TxtDomicilio.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        public string Provincia
        {
            get { return TxtProvincia.Text; }
            set { TxtProvincia.Text = value; }
        }

        public string Localidad
        {
            get { return TxtLocalidad.Text; }
            set { TxtLocalidad.Text = value; }
        }

        #endregion

        public void ActualizarCobrador(Cobrador cobrador)
        {
            _cobrador = cobrador;

            this.CobradorNombre = cobrador.Nombre;
            this.Domicilio = cobrador.Domicilio;
            this.Cuit = cobrador.Cuit;
            this.Localidad = cobrador.Localidad != null ? cobrador.Localidad.Nombre : string.Empty;
            this.Provincia = cobrador.Provincia != null ? cobrador.Provincia.Nombre : string.Empty;

            LnkVerDetalleCobrador.Enabled = true;
            LnkEditarCobrador.Enabled = true;
        }

        private void LnkVerDetalleCliente_Click(object sender, EventArgs e)
        {
            if (_cobrador == null)
            {
                return;
            }

            DetalleCobrador(_cobrador);
        }

        private void DetalleCobrador(Cobrador cobrador)
        {
            using (var formDetalle = FormFactory.Create<FrmDetalleEliminarCobrador>(cobrador.Id, ActionFormMode.Detail))
            {
                formDetalle.ShowDialog(); 
            }
        }

        private void EditarCobrador(Cobrador cobrador)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCobrador>(cobrador.Id, ActionFormMode.Edit))
            {
                if (formCrear.ShowDialog() == DialogResult.OK)
                {
                    if (CobradorEdited != null)
                    {
                        CobradorEdited(this, cobrador);
                    }
                } 
            }
        }

        private void LnkEditarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_cobrador == null)
            {
                return;
            }

            EditarCobrador(_cobrador);
        }

       }
}
