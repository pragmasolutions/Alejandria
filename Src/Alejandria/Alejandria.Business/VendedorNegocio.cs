using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.SqlServer;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Data.Helpers;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Entities.Dto;
using Alejandria.Business.Interfaces;
using Framework.Common.Extentensions;
using Framework.Common.Utility;
using AutoMapper.QueryableExtensions;

namespace Alejandria.Business
{
    public class VendedorNegocio : BusinessBase, IVendedoresNegocio
    {
        private IClock _clock;

        public VendedorNegocio(IAlejandriaUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public Vendedor ObtenerPorId(int vendedorId)
        {
            using (var uow = UowFactory.Create<IAlejandriaUow>())
            {
                return uow.Vendedores.Obtener(c => c.Id == vendedorId, c => c.Localidad, c => c.Provincia);    
            }
        }

        public List<VendedoresDto> Listado(string sortBy, string sortDirection, string nombre, string cuit, bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Nombre";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var cuitFormateado = cuit.PadLeft(11, '0');
            var denominacionFormateado = nombre.ToStringSearch();

            Expression<Func<Vendedor, bool>> where =
                x =>
                (string.IsNullOrEmpty(denominacionFormateado) || SqlFunctions.PatIndex(denominacionFormateado, x.Nombre) > 0) &&
                (string.IsNullOrEmpty(cuit) || SqlFunctions.PatIndex(cuitFormateado, x.Cuit) > 0) &&
                (!activo.HasValue || x.Activo == activo);

       
            var resultados = Uow.Vendedores.Listado(criteros,
                                                    where,
                                                    x => x.TiposDocumentosIdentidad,
                                                    x => x.Localidad
                                                  );

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<VendedoresDto>().ToList();
        }

        
    }
}
