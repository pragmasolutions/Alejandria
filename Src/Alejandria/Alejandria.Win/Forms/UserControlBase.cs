using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Win;
using Alejandria.Win.Properties;
using Framework.Ioc;
using Alejandria.Data.Interfaces;
//using Alejandria.Seguridad;
using Alejandria.Win.Properties;
using Ninject;
using Ninject.Activation;
using Telerik.WinControls.UI;

namespace Alejandria.Win.Forms
{
    public class UserControlBase : UserControl
    {
        private Telerik.WinControls.Themes.TelerikMetroTheme metroTheme;

        public UserControlBase()
        {
            this.UserControlErrorProvider = new ErrorProvider(this);
            this.UserControlErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            //this.UserControlErrorProvider.Icon = Icon.FromHandle(Resources.ErrorIcon.GetHicon());

            this.metroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();

            //SetAppContext();
        }

        public ErrorProvider UserControlErrorProvider { get; set; }

        protected IAlejandriaUow Uow { get; set; }

        protected IFormFactory FormFactory { get; set; }

      // protected ILaPazContext Context { get; private set; }

        protected override void Dispose(bool disposing)
        {
            if (Uow != null && Uow is IDisposable)
            {
                ((IDisposable)Uow).Dispose();
                Uow = null;
            }
            base.Dispose(disposing);
        }

        protected void Grilla_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            GridCommandCellElement cmdCell = e.CellElement as GridCommandCellElement;

            if (cmdCell != null)
            {
                cmdCell.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
            }
        }

        //private void SetAppContext()
        //{
        //    if (Ioc.Container != null)
        //    {
        //        Context = Ioc.Container.Get<IAlejandriaContext>();
        //    }
        //}
    }
}
