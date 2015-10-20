using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandria.Business.Interfaces
{
    public interface IVentaNegocio:IDisposable
    {
        int NumeroComprobante();
    }
}
