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

namespace Alejandria.Win.Forms.Cobradores
{
    public partial class FrmSeleccionarCobrador : FormBase
    {
        private readonly IList<Cobrador> _cobradores; 

        public FrmSeleccionarCobrador(List<Cobrador> cobradores)
        {
            _cobradores = cobradores;
            InitializeComponent();
        }

        private void FrmSeleccionarCobrador_Load(object sender, EventArgs e)
        {
            this.GrillaSeleccionar.DataSource = _cobradores;
        }

        public event EventHandler<Cobrador> CobradorSelected;

       private void GrillaSeleccionar_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GrillaSeleccionar.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var cobrador = selectedRow.DataBoundItem as Cobrador;

            if (cobrador == null)
                return;

            OnCobradorSelected(cobrador);
        }
        private void OnCobradorSelected(Cobrador cobrador)
        {
            if (CobradorSelected != null)
            {
                CobradorSelected(this, cobrador);
            }
        }

        private void GrillaSeleccionar_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var selectedRow = GrillaSeleccionar.SelectedRows[0];

                var selectedCobrador = selectedRow.DataBoundItem as Cobrador;

                if (selectedCobrador != null)
                {
                    OnCobradorSelected(selectedCobrador);
                }

                e.Handled = true;
            }
        }

     

       
    }
}
