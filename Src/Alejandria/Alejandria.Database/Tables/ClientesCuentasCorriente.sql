CREATE TABLE [dbo].[ClientesCuentasCorriente](
	[Id] [uniqueidentifier] NOT NULL,
	[VentaId] [uniqueidentifier] NOT NULL,
	[ClienteId] [uniqueidentifier] NOT NULL,
	[Cuota] [tinyint] NOT NULL,
	[Fecha] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[FechaUltimoPago] [datetime] NULL,
	[Importe] [real] NULL,
	[Pagado] [real] NULL,
	[FechaGeneracion] [datetime] NULL,
	[Observaciones] [varchar](255) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 [FechaVencimientoHasta] DATETIME NULL, 
    CONSTRAINT [PK_ClientesCuentasCorriente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_ClientesCuentasCorriente_Clientes] FOREIGN KEY (ClienteId) REFERENCES Clientes(Id), 
    CONSTRAINT [FK_ClientesCuentasCorriente_SucursalAltaId] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ClientesCuentasCorriente_OperadorAltaId] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ClientesCuentasCorriente_SucursalModificacionId] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ClientesCuentasCorriente_OperadorModificacionId] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ClientesCuentasCorriente_VentasId] FOREIGN KEY (VentaId) REFERENCES Ventas(Id)
) ON [PRIMARY]

GO