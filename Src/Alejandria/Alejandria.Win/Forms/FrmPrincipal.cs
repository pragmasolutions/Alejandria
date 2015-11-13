using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Win.Enums;
using Alejandria.Win.Forms.Clientes;
using Alejandria.Win.Forms.Cobradores;
using Alejandria.Win.Forms.CuentaCorrientes;
using Alejandria.Win.Forms.Localidades;
using Alejandria.Win.Forms.Provincias;
using Alejandria.Win.Forms.Vendedores;
using Alejandria.Win.Forms.Ventas;
using Alejandria.Win.Forms.Ventas.AnulacionFacturas;
using Telerik.WinControls;

namespace Alejandria.Win.Forms
{
    public partial class FrmPrincipal : FormBase
    {

        public FrmPrincipal(IFormFactory formFactory, IAlejandriaUow uow)//, IUowFactory uowFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
           // UowFactory = uowFactory;
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmClienteListado>();
            frm.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmVentas>(default(int), ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void BtnCobradores_Click(object sender, EventArgs e)
        {
       
            var frm = FormFactory.Create<FrmCobradoresListado>();
            frm.ShowDialog();
        }

        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCuentaCorriente>(default(int), ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void BtnCuotasCobrador_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCuentasCorrientesCobrador>(default(int), ActionFormMode.Create);
            frm.ShowDialog();
        }

        private void BtnVendedores_Click(object sender, EventArgs e)
        {

            var frm = FormFactory.Create<FrmVendedoresListado>();
            frm.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            var crear = FormFactory.Create<FrmComprobantesdelDia>();
            crear.Show();
        }

        private void BtnProximos_Click(object sender, EventArgs e)
        {
            var crear = FormFactory.Create<FrmProximosVencimientosCobrador>();
            crear.Show();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            var crear = FormFactory.Create<FrmAnulacionFactura>();
            crear.Show();
        }

        private void BtnProvincia_Click(object sender, EventArgs e)
        {
            var crear = FormFactory.Create<FrmCrearEditarProvincia>(default(int), ActionFormMode.Create);
            crear.Show();
        }

        private void BtnLocalidad_Click(object sender, EventArgs e)
        {
            var crear = FormFactory.Create<FrmCrearEditarLocalidad>(default(int), ActionFormMode.Create);
            crear.Show();
        }

      
       }
}
