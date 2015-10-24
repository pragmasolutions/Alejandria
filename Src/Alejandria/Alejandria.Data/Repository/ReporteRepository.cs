using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;

namespace Alejandria.Data.Repository
{
    public class ReporteRepository : EFBaseRepository, IReporteRepository
    {
        public ReporteRepository()
        {
        }

        public ReporteRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public IQueryable<ComprobantesByVentaId_Result> ComprobantesByVentaId(Guid ventaId)
        {
            return AlejandriaDbContext.ComprobantesByVentaId(ventaId).AsQueryable();
        }

        public IQueryable<ComprobantesDelDia1_Result> ComprobantesDelDia()
        {
            return AlejandriaDbContext.ComprobantesDelDia().AsQueryable();
        }
        
    }
}