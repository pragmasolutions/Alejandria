using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alejandria.Entities;
using Framework.Common.Mapping;

namespace Alejandria.Entities.Dto
{
    public class ClienteCuentaCorrienteDto : IMapFrom<ClientesCuentasCorriente>
    {
    //    public int Id { get; set; }
    //    public string Nombre { get; set; }
    //    public string TiposDocumentosIdentidadNombre { get; set; }
    //    public string Cuit { get; set; }
    //    public string Domicilio { get; set; }
    //    public string Telefono { get; set; }
    //    public string Celular { get; set; }
    //    public string Mail { get; set; }
    //    //public string LocalidadeNombre { get; set; }
    //    //public string ProfesioneNombre { get; set; }
    //    //public string EspecialidadeNombre { get; set; }

        public System.Guid Id { get; set; }
        public System.Guid VentaId { get; set; }
        public System.Guid ClienteId { get; set; }
        public byte Cuota { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<System.DateTime> FechaUltimoPago { get; set; }
        public Nullable<float> Importe { get; set; }
        public Nullable<float> Pagado { get; set; }
        public Nullable<System.DateTime> FechaGeneracion { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<System.DateTime> FechaVencimientoHasta { get; set; }

        //public int VentaCobradorId { get; set; }
       // public string ClienteDenominacion { get; set; }
        
    }
}
