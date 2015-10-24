﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alejandria.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Alejandria.Entities;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AlejandriaDbContext : DbContext
    {
        public AlejandriaDbContext()
            : base("name=AlejandriaDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoriaOperador> CategoriaOperadors { get; set; }
        public virtual DbSet<CondicionesIVA> CondicionesIVAs { get; set; }
        public virtual DbSet<CondicionesVenta> CondicionesVentas { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<EstadosCliente> EstadosClientes { get; set; }
        public virtual DbSet<Localidad> Localidads { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Profesion> Profesions { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<TiposDocumentosIdentidad> TiposDocumentosIdentidads { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientesCuentasCorriente> ClientesCuentasCorrientes { get; set; }
        public virtual DbSet<EstadosVenta> EstadosVentas { get; set; }
        public virtual DbSet<TiposComprobante> TiposComprobantes { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<CajasMovimiento> CajasMovimientos { get; set; }
        public virtual DbSet<TiposMovimientosCaja> TiposMovimientosCajas { get; set; }
        public virtual DbSet<Cobrador> Cobrador { get; set; }
        public virtual DbSet<ClientesMovimiento> ClientesMovimientoes { get; set; }
        public virtual DbSet<Vendedor> Vendedors { get; set; }
        public virtual DbSet<Operador> Operadors { get; set; }
    
        public virtual ObjectResult<ComprobantesByVentaId_Result> ComprobantesByVentaId(Nullable<System.Guid> ventaId)
        {
            var ventaIdParameter = ventaId.HasValue ?
                new ObjectParameter("ventaId", ventaId) :
                new ObjectParameter("ventaId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComprobantesByVentaId_Result>("ComprobantesByVentaId", ventaIdParameter);
        }
    
        public virtual ObjectResult<ComprobantesDelDia_Result> ComprobantesDelDia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComprobantesDelDia_Result>("ComprobantesDelDia");
        }
    }
}
