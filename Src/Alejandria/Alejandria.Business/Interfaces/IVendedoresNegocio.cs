using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Entities;
using Alejandria.Entities.Dto;

namespace Alejandria.Business.Interfaces
{
    public interface IVendedoresNegocio : IDisposable
    {
        List<VendedoresDto> Listado(string sortBy, string sortDirection, string nombre, string cuit,bool? activo, int pageIndex, int pageSize, out int pageTotal);
        Vendedor ObtenerPorId(int vendedor);
    }
}
