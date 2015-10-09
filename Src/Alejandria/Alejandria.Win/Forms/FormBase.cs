using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Framework.Common.Attributes;
using Framework.Ioc;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Win.Helpers;
using Alejandria.Win.Properties;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace Alejandria.Win.Forms
{
    public class FormBase : RadForm
    {
        private TelerikMetroTheme metroTheme;

        public FormBase()
        {
            InitializeControls();
            SetTheme();
            SetDefaultProperties();
          //  SetAppContext();
        }

        private void InitializeControls()
        {
            this.FormErrorProvider = new ErrorProvider(this);
            this.FormErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            //this.FormErrorProvider.Icon = Icon.FromHandle(Resources.ErrorIcon.GetHicon());
        }

        private void SetTheme()
        {
            this.ThemeName = "TelerikMetro";
            this.metroTheme = new TelerikMetroTheme();
        }

        private void SetDefaultProperties()
        {
            this.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = FormStartPosition.CenterParent;
            //this.Icon = Resources.LogoLaPaz;
        }

        //private void SetAppContext()
        //{
        //    if (Ioc.Container != null)
        //    {
        //        Context = Ioc.Container.Get<ILaPazContext>();
        //    }
        //}

        protected ErrorProvider FormErrorProvider { get; set; }

        protected IAlejandriaUow Uow { get; set; }

        protected IFormFactory FormFactory { get; set; }

        protected IUowFactory UowFactory { get; set; }

        protected IFormRegistry FormRegistry { get; set; }

        protected override void Dispose(bool disposing)
        {
            if (Uow != null && Uow is IDisposable)
            {
                if (IsLastForm && UseSharedContext)
                {
                    if (!Uow.IsDisposed)
                    {
                        ((IDisposable)Uow).Dispose();
                    }

                    Uow = null;
                }
                else
                {
                    if (!UseSharedContext)
                    {
                        if (!Uow.IsDisposed)
                        {
                            ((IDisposable)Uow).Dispose();    
                        }
                        
                        Uow = null;
                    }
                }
            }

            base.Dispose(disposing);
        }

        public bool IsLastForm
        {
            get
            {
                return FormRegistry != null && FormRegistry.GetForms(this.GetType()).Count() == 1;
            }
        }

        public bool UseSharedContext
        {
            get
            {
                return Attribute.IsDefined(this.GetType(), typeof(SharedContext));
            }
        }

        protected virtual void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridCommandCellElement cmdCell = e.CellElement as GridCommandCellElement;

            if (cmdCell != null)
            {
                cmdCell.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
            }
        }

        //protected ILaPazContext Context { get; private set; }

        //protected Operador ObtenerOperadorAdministrador()
        //{
        //    if (!EsOperadorAdmin)
        //    {
        //        return RequerirAdministrador();
        //    }
        //    return this.Context.OperadorActual;
        //}

        //protected bool EsOperadorAdmin
        //{
        //    get { return this.Context.IsInRole(RolesNames.Admin) || this.Context.IsInRole(RolesNames.SuperAdmin); }
        //}

        protected void CloseTab()
        {
            var page = this.Parent as RadPageViewPage;

            if (page != null)
            {
                var tabs = page.Parent as RadPageView;

                if (tabs != null)
                {
                    tabs.Pages.Remove(page);
                }
            }
        }

        protected virtual void RefrescarUow()
        {
            //Limpiar context.
            Uow.Dispose();
            Uow = UowFactory.Create<IAlejandriaUow>();
        }

        //private Operador RequerirAdministrador()
        //{
        //    using (var login = FormFactory.Create<FrmLogin>())
        //    {
        //        login.RolesAceptados = new List<string>() { RolesNames.Admin, RolesNames.SuperAdmin };
        //        login.CambiarIdentity = false;
        //        if (login.ShowDialog() == DialogResult.OK)
        //        {
        //            return login.UltimoOperadorIngresado;
        //        }
        //        else
        //        {
        //            //Cancelado.
        //            return null;
        //        }    
        //    }
        //}
    }
}
