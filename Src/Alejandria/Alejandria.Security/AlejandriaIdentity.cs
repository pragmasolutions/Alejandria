using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Entities;

namespace Alejandria.Security
{
    public class AlejandriaIdentity : IIdentity
    {
        public AlejandriaIdentity(Operador operador,Sucursal sucursal)
        {
            Name = operador.Usuario;
            Email = string.Empty;
            //Roles = operador.Roles.Select(r => r.Description).ToArray();
            Sucursal = sucursal;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string[] Roles { get; private set; }
        public Operador Operador { get; private set; }
        public Sucursal Sucursal { get; private set; }

        #region IIdentity Members

        public string AuthenticationType
        {
            get { return "Alejandria authentication"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(Name); }
        }

        #endregion
    }

    public class AnonymousIdentity : AlejandriaIdentity
    {
        public AnonymousIdentity()
            : base(new Operador(),new Sucursal())
        { }
    }
}
