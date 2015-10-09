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

namespace Alejandria.Win.Forms.Clientes
{
    public partial class FrmGestionCliente : FormBase
    {
        public FrmGestionCliente(IFormFactory formfactory, IAlejandriaUow uow)
        {
            FormFactory = formfactory;
            Uow = uow;
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
