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
    public interface IClienteNegocio : IDisposable
    {
        List<ClienteDto> Listado(string sortBy, string sortDirection, string denominacion, string cuit,bool? activo, int pageIndex, int pageSize, out int pageTotal);
        decimal DeudaTotal(Guid clienteId, int? sucursalId);
        decimal DeudaVencida(Guid clienteId, int? sucursalId);
        //List<ClienteMontoFavor> Senias(string sortBy, string sortDirection, Guid? clienteId,int sucursalId, int pageIndex, int pageSize,
        //                               out int pageTotal);

        Cliente ObtenerPorId(Guid clienteId);
    }
}
