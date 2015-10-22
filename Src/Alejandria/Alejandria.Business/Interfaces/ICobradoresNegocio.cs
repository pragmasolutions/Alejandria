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
    public interface ICobradoresNegocio : IDisposable
    {
        List<CobradoresDto> Listado(string sortBy, string sortDirection, string nombre, string cuit,bool? activo, int pageIndex, int pageSize, out int pageTotal);
        decimal DeudaTotal(int cobradorId, int? sucursalId);
        //decimal DeudaVencida(Guid clienteId, int? sucursalId);
        //List<ClienteMontoFavor> Senias(string sortBy, string sortDirection, Guid? clienteId,int sucursalId, int pageIndex, int pageSize,
        //                               out int pageTotal);

        Cobrador ObtenerPorId(int cobradorGuid);
    }
}
