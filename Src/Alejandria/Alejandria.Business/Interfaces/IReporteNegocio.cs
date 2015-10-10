using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Data.Helpers;
using Alejandria.Entities;
using Alejandria.Entities.Dto;

namespace Alejandria.Business.Interfaces
{
    public interface IReporteNegocio : IDisposable
    {

        List<ComprobantesByVentaId_Result> ComprobantesByVentaId(Guid ventaId);

    }
}
