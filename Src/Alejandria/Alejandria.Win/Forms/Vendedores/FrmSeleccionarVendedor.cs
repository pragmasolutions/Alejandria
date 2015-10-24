using Alejandria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandria.Win.Forms.Vendedores
{
    public partial class FrmSeleccionarVendedor : FormBase
    {
        private readonly IList<Vendedor> _vendedores; 

        public FrmSeleccionarVendedor(List<Vendedor> vendedores)
        {
            _vendedores = vendedores;
            InitializeComponent();
        }

        private void FrmSeleccionarVendedor_Load(object sender, EventArgs e)
        {
            this.GrillaSeleccionar.DataSource = _vendedores;
        }

        public event EventHandler<Vendedor> VendedorSelected;

       private void GrillaSeleccionar_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GrillaSeleccionar.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var vendedor = selectedRow.DataBoundItem as Vendedor;

            if (vendedor == null)
                return;

            OnVendedorSelected(vendedor);
        }
       private void OnVendedorSelected(Vendedor vendedor)
        {
            if (VendedorSelected != null)
            {
                VendedorSelected(this, vendedor);
            }
        }

        private void GrillaSeleccionar_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var selectedRow = GrillaSeleccionar.SelectedRows[0];

                var selectedVendedor = selectedRow.DataBoundItem as Vendedor;

                if (selectedVendedor != null)
                {
                    OnVendedorSelected(selectedVendedor);
                }

                e.Handled = true;
            }
        }

     

       
    }
}
