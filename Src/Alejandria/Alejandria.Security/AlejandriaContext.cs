using System.Threading;
using Alejandria.Entities;
using Framework.Ioc;
using Alejandria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Alejandria.Security
{
    public class AlejandriaContext : IAlejandriaContext
    {
        public Operador OperadorActual
        {
            get { return AlejandriaIdentity.Operador; }
        }

        private AlejandriaIdentity AlejandriaIdentity
        {
            get
            {
                var alejandriaPrincipal = Thread.CurrentPrincipal as AlejandriaPrincipal;
                return alejandriaPrincipal != null ? alejandriaPrincipal.Identity as AlejandriaIdentity : null;
            }
        }

        private AlejandriaPrincipal AlejandriaPrincipal
        {
            get
            {
                return Thread.CurrentPrincipal as AlejandriaPrincipal;
            }
        }

        public Sucursal SucursalActual
        {
            get { return AlejandriaIdentity.Sucursal; }
        }

        public Caja CajaActual
        {
            get
            {
                return new Caja();
                //using (var cajaNegocio = Ioc.Container.Get<ICajaNegocio>())
                //{
                //    return cajaNegocio.UltimaCaja(this.OperadorActual.Id, this.SucursalActual.Id);
                //}
            }
        }

        public bool IsInRole(string role)
        {
            return AlejandriaPrincipal.IsInRole(role);
        }


        public bool EsOpedatorAdmin
        {
            get
            {
                return this.IsInRole(RolesNames.Admin) || this.IsInRole(RolesNames.SuperAdmin);
            }
        }
    }
}
