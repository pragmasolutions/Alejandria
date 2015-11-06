using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Entities;

namespace Alejandria.Data.Interfaces
{
    public interface IReporteRepository
    {
        IQueryable<ComprobantesByVentaId_Result> ComprobantesByVentaId(Guid ventaId);
        IQueryable<ComprobantesDelDia1_Result> ComprobantesDelDia();
        IQueryable<ProximasCuotasByCobrador_Result> ProximasCuotasByCobrador(int cobradorId);
        
    }

}
