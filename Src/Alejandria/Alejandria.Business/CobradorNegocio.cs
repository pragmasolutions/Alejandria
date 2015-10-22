using System;
using System.Collections.Generic;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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
    public class CobradorNegocio : BusinessBase, ICobradoresNegocio
    {
        private IClock _clock;

        public CobradorNegocio(IAlejandriaUow uow, IClock clock)//,IUowFactory uowFactory)
        {
            Uow = uow;
            //UowFactory = uowFactory;

            _clock = clock;
        }

        public Cobrador ObtenerPorId(int cobradorId)
        {
            using (var uow = UowFactory.Create<IAlejandriaUow>())
            {
                return uow.Cobradores.Obtener(c => c.Id == cobradorId, c => c.Localidad, c => c.Provincia);    
            }
        }

        public List<CobradoresDto> Listado(string sortBy, string sortDirection, string nombre, string cuit, bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Nombre";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var cuitFormateado = cuit.PadLeft(11, '0');
            var denominacionFormateado = nombre.ToStringSearch();

            //Expression<Func<Cliente, bool>> where =
            //    x =>
            //    (string.IsNullOrEmpty(denominacionFormateado) || SqlFunctions.PatIndex(denominacionFormateado, x.Denominacion) > 0) &&
            //    (string.IsNullOrEmpty(cuit) || SqlFunctions.PatIndex(cuitFormateado, x.Cuit) > 0) &&
            //    (!activo.HasValue || x.Activo == activo);

            Expression<Func<Cobrador, bool>> where =
              x =>
              (string.IsNullOrEmpty(denominacionFormateado)
               || x.Nombre.Contains(nombre)
              )
             && (string.IsNullOrEmpty(cuit)
             || x.Cuit.Contains(cuit)
             )
              && (!activo.HasValue || x.Activo == activo)
              ;

       
            var resultados = Uow.Cobradores.Listado(criteros,
                                                    where,
                                                    x => x.TiposDocumentosIdentidad,
                                                    x => x.Localidad
                                                    //, x => x.Profesione,
                                                    //x => x.Especialidad
                                                    );

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<CobradoresDto>().ToList();
        }

        public decimal DeudaTotal(int cobradorId, int? sucursalId)
        {
            var cuentasCorrientes = Uow.ClientesCuentasCorrientes.Listado()
                                                                 .Where(cc => cc.Venta.Cobradores.Id==cobradorId &&
                                                                       (!sucursalId.HasValue || cc.SucursalAltaId == sucursalId));

            return (decimal)cuentasCorrientes.Select(cc => cc.Importe - cc.Pagado).DefaultIfEmpty(0).Sum();
        }

        //public decimal DeudaVencida(Guid clienteId, int? sucursalId)
        //{
        //    var cuentasCorrientes = Uow.ClientesCuentasCorrientes.Listado()
        //                               .Where(cc => cc.ClienteId == clienteId &&
        //                                     (!sucursalId.HasValue || cc.SucursalAltaId == sucursalId) &&
        //                                      cc.FechaVencimiento <= _clock.Now);

        //    return (decimal)cuentasCorrientes.Select(cc => cc.Importe - cc.Pagado).DefaultIfEmpty(0).Sum();
        //}

        //public List<ClienteMontoFavor> Senias(string sortBy, string sortDirection, Guid? clienteId, int sucursalId, int pageIndex, int pageSize, out int pageTotal)
        //{
        //    var criteros = new PagingCriteria();

        //    criteros.PageNumber = pageIndex;
        //    criteros.PageSize = pageSize;
        //    criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
        //    criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

        //    Expression<Func<ClienteMontoFavor, bool>> where = x => x.ClienteId == clienteId &&
        //                                                     (x.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente ||
        //                                                      x.TipoComprobanteId == TipoComprobanteEnum.NotaCrédito)
        //                                                      && x.SucursalAltaId== sucursalId
        //                                                      ;

        //    var resultados = Uow.ClientesMontosFavor.Listado(criteros, where);

        //    pageTotal = resultados.PagedMetadata.TotalItemCount;

        //    return resultados.Entities.ToList();
        //}
    }
}
