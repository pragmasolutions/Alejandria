using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Data.Interfaces;
using Alejandria.Data;
using Alejandria.Data.Interfaces;
using Framework.Ioc;

namespace Alejandria.Business
{
    public class BusinessBase : IDisposable
    {
        protected IAlejandriaUow Uow { get; set; }

        protected IUowFactory UowFactory { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Uow != null)
                {
                    Uow.Dispose();
                    Uow = null;
                    Ioc.Container.Release(this);
                }
            }
        }

        #endregion
    }
}
