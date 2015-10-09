using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Win.Forms.Clientes;
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
            frm.Show();
        }
    }
}
