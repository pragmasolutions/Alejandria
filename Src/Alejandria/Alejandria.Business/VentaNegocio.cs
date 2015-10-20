using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Business.Interfaces;
using Alejandria.Data.Interfaces;
using Framework.Common.Utility;

namespace Alejandria.Business
{
    class VentaNegocio : BusinessBase, IVentaNegocio
    {
        private readonly IClock _clock;

        public VentaNegocio(IAlejandriaUow uow, IClock clock, IUowFactory factory)
        {
            Uow = uow;
            UowFactory = factory;
            _clock = clock;
        }

        public int NumeroComprobante()
        {
            var numeroFactura=0;
            var numeroComprobante =  Uow.Ventas.Listado().OrderByDescending(v=>v.FechaAlta).FirstOrDefault();
            if (numeroComprobante == null)
                numeroFactura=0;
            else
                numeroFactura = (numeroComprobante.NumeroComprobante);
            
           
            //if (numeroFactura > loteFactura.NroHasta)
            //{
            //    throw new ApplicationException("Ya se ha alcanzado el último número de factura dentro del lote");
            //}

            return numeroFactura + 1;
        }
    }
}
