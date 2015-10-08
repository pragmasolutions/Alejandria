//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alejandria.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operador
    {
        public Operador()
        {
            this.Clientes = new HashSet<Cliente>();
            this.Clientes1 = new HashSet<Cliente>();
            this.ClientesCuentasCorrientes = new HashSet<ClientesCuentasCorriente>();
            this.ClientesCuentasCorrientes1 = new HashSet<ClientesCuentasCorriente>();
            this.EstadosVentas = new HashSet<EstadosVenta>();
            this.EstadosVentas1 = new HashSet<EstadosVenta>();
            this.Ventas = new HashSet<Venta>();
            this.Ventas1 = new HashSet<Venta>();
            this.Ventas2 = new HashSet<Venta>();
            this.Cajas = new HashSet<Caja>();
            this.Cajas1 = new HashSet<Caja>();
            this.Cajas2 = new HashSet<Caja>();
            this.CajasMovimientos = new HashSet<CajasMovimiento>();
            this.CajasMovimientos1 = new HashSet<CajasMovimiento>();
        }
    
        public System.Guid Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Nullable<System.DateTime> VigenteDesde { get; set; }
        public Nullable<System.DateTime> VigenteHasta { get; set; }
        public Nullable<System.Guid> PersonalId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public bool Habilitado { get; set; }
    
        public virtual Personal Personal { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Cliente> Clientes1 { get; set; }
        public virtual ICollection<ClientesCuentasCorriente> ClientesCuentasCorrientes { get; set; }
        public virtual ICollection<ClientesCuentasCorriente> ClientesCuentasCorrientes1 { get; set; }
        public virtual ICollection<EstadosVenta> EstadosVentas { get; set; }
        public virtual ICollection<EstadosVenta> EstadosVentas1 { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
        public virtual ICollection<Venta> Ventas1 { get; set; }
        public virtual ICollection<Venta> Ventas2 { get; set; }
        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<Caja> Cajas1 { get; set; }
        public virtual ICollection<Caja> Cajas2 { get; set; }
        public virtual ICollection<CajasMovimiento> CajasMovimientos { get; set; }
        public virtual ICollection<CajasMovimiento> CajasMovimientos1 { get; set; }
    }
}
