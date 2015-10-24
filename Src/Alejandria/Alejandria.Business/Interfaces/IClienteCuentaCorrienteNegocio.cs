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
    public interface IClienteCuentaCorrienteNegocio : IDisposable
    {
        List<ClienteCuentaCorrienteDto> ListadoPorCobrador(int id);

    }
}
