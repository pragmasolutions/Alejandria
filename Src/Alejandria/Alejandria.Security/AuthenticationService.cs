using Alejandria.Entities;
using Alejandria.Security.Interfaces;
using Alejandria.Data.Interfaces;
using System;
using System.Linq;
using Alejandria.Security.Interfaces;

namespace Alejandria.Security
{
    public class AuthenticationService : IAuthenticationService
    {
        private IAlejandriaUow _uow;
        private readonly IEncryptionService _encryptionService;

        public AuthenticationService(IAlejandriaUow uow, IEncryptionService encryptionService)
        {
            _uow = uow;
            _encryptionService = encryptionService;
        }

        public Operador AuthenticateUser(string username, string clearTextPassword)
        {
            var hashPassword = _encryptionService.CalculateHash(clearTextPassword, username);
            //var operador =
            //    _uow.Operadores.Obtener(
            //        o => o.Usuario.ToUpper().Equals(username) && o.Clave.Equals(hashPassword) && o.Habilitado,
            //        o => o.Roles,
            //        o => o.Personal,
            //        o => o.Personal.Provincia,
            //        o => o.Personal.Localidad,
            //        o => o.OperadorSucursals.Select(op => op.Sucursal));
            var operador =
                _uow.Operadores.Obtener(
                    o => o.Usuario.ToUpper().Equals(username) && o.Clave.Equals(hashPassword) && o.Habilitado);

            if (operador == null)
                throw new UnauthorizedAccessException("Access denied. Please provide some valid credentials.");

            return operador;
        }

        public void Dispose()
        {
            if (_uow != null)
            {
                _uow.Dispose();
                _uow = null;
            }
        }
    }
}
