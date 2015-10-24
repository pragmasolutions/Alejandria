using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Entities;
using Framework.Common.Mapping;

namespace Alejandria.Entities.Dto
{
    public class VendedoresDto : IMapFrom<Vendedor>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TiposDocumentosIdentidadNombre { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Mail { get; set; }
        //public string LocalidadeNombre { get; set; }
        //public string ProfesioneNombre { get; set; }
        //public string EspecialidadeNombre { get; set; }
        
    }
}
