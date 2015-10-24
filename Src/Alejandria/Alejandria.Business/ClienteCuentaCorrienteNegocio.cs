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
    public class ClienteCuentaCorrienteNegocio : BusinessBase, IClienteCuentaCorrienteNegocio
    {
        private IClock _clock;

        public ClienteCuentaCorrienteNegocio(IAlejandriaUow uow, IClock clock)
        {
            Uow = uow;
           _clock = clock;
        }

        public List<ClienteCuentaCorrienteDto> ListadoPorCobrador(int id)
        {
            var criteros = new PagingCriteria();

            //criteros.PageNumber = pageIndex;
          //  criteros.PageSize = pageSize;
            criteros.SortBy =  "FechaVencimiento";
            criteros.SortDirection =  "ASC";

            //Expression<Func<ClientesCuentasCorriente, bool>> where =
            //    x =>x.Cuota == id;
            //    //(!activo.HasValue || x.Activo == activo);

       
            //var resultados = Uow.ClientesCuentasCorrientes.Listado(criteros,
            //                                        x=>x.Venta.CobradorId==id,
                                                    
            //                                        x => x.Venta
            //                                       );




            Expression<Func<ClientesCuentasCorriente, bool>> where =
                x => x.Cuota > 0;
               //(string.IsNullOrEmpty(denominacionFormateado) || SqlFunctions.PatIndex(denominacionFormateado, x.Denominacion) > 0) &&
               //(string.IsNullOrEmpty(cuit) || SqlFunctions.PatIndex(cuitFormateado, x.Cuit) > 0) &&
               //(!activo.HasValue || x.Activo == activo);

            //var resultados = Uow.ClientesCuentasCorrientes.Listado(criteros,
            //                                        where,
            //                                        x => x.Venta,
            //                                        x => x.Cliente);

            var resultados = Uow.ClientesCuentasCorrientes.Listado(criteros,
                                                    where
);

            return resultados.Entities.Project().To<ClienteCuentaCorrienteDto>().ToList();
        }

      
    }
}
