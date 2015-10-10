using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Win.Enums;
using Framework.Common.Utility;
using Telerik.WinControls;

namespace Alejandria.Win.Forms.Ventas
{
    public partial class FrmVentas : FormBase
    {
        private readonly IClock _clock;
        private Venta _venta;
        public FrmVentas(IAlejandriaUow uow,IClock clock)
        {
            Uow = uow;
            _clock = clock;

            InitializeComponent();
        }

        #region Eventos
        public event EventHandler<Venta> VentaAgregada;
        #endregion

        #region Properties
        #endregion
    }
}
