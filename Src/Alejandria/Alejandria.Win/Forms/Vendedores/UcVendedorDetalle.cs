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


namespace Alejandria.Win.Forms.Vendedores
{
    public partial class UcVendedorDetalle : UserControlBase
    {
        public event EventHandler<Vendedor> VendedoresEdited;

        private Vendedor _vendedor;

        public UcVendedorDetalle()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }
            InitializeComponent();
        }

        #region Propiedades
        public string VendedorNombre
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

        public void ActualizarVendedor(Vendedor vendedor)
        {
            _vendedor = vendedor;

            this.VendedorNombre = vendedor.Nombre;
            this.Domicilio = vendedor.Domicilio;
            this.Cuit = vendedor.Cuit;
            this.Localidad = vendedor.Localidad != null ? vendedor.Localidad.Nombre : string.Empty;
            this.Provincia = vendedor.Provincia != null ? vendedor.Provincia.Nombre : string.Empty;

            LnkVerDetalleCobrador.Enabled = true;
            LnkEditarCobrador.Enabled = true;
        }

        private void LnkVerDetalleCliente_Click(object sender, EventArgs e)
        {
            if (_vendedor == null)
            {
                return;
            }

            DetalleCobrador(_vendedor);
        }

        private void DetalleCobrador(Vendedor vendedor)
        {
            using (var formDetalle = FormFactory.Create<FrmDetalleEliminarVendedores>(vendedor.Id, ActionFormMode.Detail))
            {
                formDetalle.ShowDialog(); 
            }
        }

        private void EditarVendedor(Vendedor vendedor)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarVendedor>(vendedor.Id, ActionFormMode.Edit))
            {
                if (formCrear.ShowDialog() == DialogResult.OK)
                {
                    if (VendedoresEdited != null)
                    {
                        VendedoresEdited(this, vendedor);
                    }
                } 
            }
        }

        private void LnkEditarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_vendedor == null)
            {
                return;
            }

            EditarVendedor(_vendedor);
        }

       }
}
