CREATE TABLE [dbo].[EstadosVenta](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Abreviatura] [nvarchar](10) NULL,
	[Decripcion] [nvarchar](50) NULL,
	[Prioridad] [int] NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_EstadosVentas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_EstadosVenta_OperadorAltaId] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_EstadosVenta_SucursalAltaId] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_EstadosVenta_OperadorModificacionId] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id),
    CONSTRAINT [FK_EstadosVenta_SucursalModificacionId] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO