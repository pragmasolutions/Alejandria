using Alejandria.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandria.Win.Forms.Clientes
{
    public partial class FrmBuscarCliente : FormBase
    {
        public FrmBuscarCliente(IAlejandriaUow uow)
        {
            Uow = uow;
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
