CREATE TABLE [dbo].[ClientesMovimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [uniqueidentifier] NOT NULL,
	[IdTipoComprobante] [int] NULL,
	[IdComprobante] [uniqueidentifier] NULL,
	[Concepto] [nvarchar](50) NULL,
	[Debe] [money] NULL,
	[Haber] [money] NULL,
	[Observaciones] [nvarchar](100) NULL,
	[FechaGeneracion] [datetime] NULL,
	[FechaAlta] [datetime] NULL,
	[SucursalAltaId] [int] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ClientesMovimiento_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_ClientesMovimiento_Cliente] FOREIGN KEY (IdCliente) REFERENCES Clientes(Id), 
    CONSTRAINT [FK_ClientesMovimiento_TipoComprobante] FOREIGN KEY (IdTipoComprobante) REFERENCES TiposComprobantes(Id), 
    CONSTRAINT [FK_ClientesMovimiento_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ClientesMovimiento_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ClientesMovimiento_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ClientesMovimiento_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO
