using Alejandria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandria.Security.Interfaces
{
    public interface IEncryptionService
    {
        string CalculateHash(string clearTextPassword, string salt);
    }
}
