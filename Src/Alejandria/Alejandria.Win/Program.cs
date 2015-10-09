using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Security;
using Alejandria.Win;
using Alejandria.Win.Forms;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using Ninject;
using log4net;

namespace Alejandria.Win
{
    static class Program
    {
        private static IMessageBoxDisplayService MessageBoxDisplayService;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if (!DEBUG)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
#endif

            AutoMapperConfig.Execute();
            MetadataTypesRegister.InstallForThisAssembly();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                IoCConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);

                //Config log4net
                log4net.Config.DOMConfigurator.Configure();

                MessageBoxDisplayService = Ioc.Container.Get<IMessageBoxDisplayService>();

                ////  Create a custom principal with an anonymous identity at startup
                var alejandriaPrincipal = new AlejandriaPrincipal();
                AppDomain.CurrentDomain.SetThreadPrincipal(alejandriaPrincipal);

            #if(MOCK_SECURITY)
                            MockUser();
            #else
                            //using (var login = kernel.Get<FrmLogin>())
                            //{
                            //    var result = login.ShowDialog();

                            //    if (result == DialogResult.Cancel)
                            //    {
                            //        Application.Exit();
                            //        return;
                            //    }
                            //}
            #endif
                var mainForm = kernel.Get<FrmPrincipal>();

                Application.Run(mainForm);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            //MessageBoxDisplayService.ShowError(mensaje);
            Application.Exit();
        }


        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            //MessageBoxDisplayService.ShowError(mensaje);
            Application.Exit();
        }
    }
}
