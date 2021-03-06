﻿using Alejandria.Entities;
using Framework.Data.Repository;

namespace Alejandria.Data.Interfaces
{
    public interface IAlejandriaUow : IUow
    {
        IRepository<CategoriaOperador> CategoriaOperadores { get; }
        IRepository<CondicionesIVA> CondicionesIVAs { get; }
        IRepository<CondicionesVenta> CondicionesVentas { get; }
        IRepository<Especialidad> Especialidades { get; }
        IRepository<EstadosCliente> EstadosClientes { get; }
        IRepository<Localidad> Localidades { get; }
        IRepository<Operador> Operadores { get; }
        IRepository<Personal> Personales { get; }
        IRepository<Profesion> Profesiones { get; }
        IRepository<Provincia> Provincias { get; }
        IRepository<Sucursal> Sucursales { get; }
        IRepository<TiposDocumentosIdentidad> TiposDocumentosIdentidades { get; }
        IRepository<ClientesCuentasCorriente> ClientesCuentasCorrientes { get; }
        IRepository<EstadosVenta> EstadosVentas{ get; }
        IRepository<TiposComprobante> TiposComprobantes { get; }
        IRepository<Venta> Ventas { get; }
        IRepository<Caja> Cajas { get; }
        IRepository<CajasMovimiento> CajasMovimientos { get; }
        IRepository<TiposMovimientosCaja> TiposMovimientosCajas { get; }
        IRepository<Cliente> Clientes { get; }
        IRepository<Cobrador> Cobradores { get; }
        IRepository<ClientesMovimiento> ClientesMovimientos { get; }
        IReporteRepository Reportes { get; }
        IRepository<Vendedor> Vendedores { get; }


        AlejandriaDbContext DbContext { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}
