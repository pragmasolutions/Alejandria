CREATE TABLE [dbo].[Cajas](
	[Id] [uniqueidentifier] NOT NULL,
	[SucursalId] [int] NOT NULL,
	[OperadorId] [uniqueidentifier] NULL,
	[Fecha] [datetime] NOT NULL,
	[FCierre] [datetime] NULL,
	[Inicio] [real] NULL,
	[Ingresos] [real] NULL,
	[Egresos] [real] NULL,
	[Saldo] [real] NULL,
	[Cheques] [real] NULL,
	[Bonos] [real] NULL,
	[PcAlta] [nvarchar](20) NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_Cajas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Cajas]  WITH NOCHECK ADD  CONSTRAINT [FK_Cajas_Operador] FOREIGN KEY([OperadorId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_Operador]
GO

ALTER TABLE [dbo].[Cajas]  WITH NOCHECK ADD  CONSTRAINT [FK_Cajas_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_OperadorAlta]
GO

ALTER TABLE [dbo].[Cajas]  WITH NOCHECK ADD  CONSTRAINT [FK_Cajas_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_OperadorModificacion]
GO

ALTER TABLE [dbo].[Cajas]  WITH NOCHECK ADD  CONSTRAINT [FK_Cajas_Sucursal] FOREIGN KEY([SucursalId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_Sucursal]
GO

ALTER TABLE [dbo].[Cajas]  WITH NOCHECK ADD  CONSTRAINT [FK_Cajas_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_SucursalAlta]
GO

ALTER TABLE [dbo].[Cajas]  WITH NOCHECK ADD  CONSTRAINT [FK_Cajas_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Cajas] CHECK CONSTRAINT [FK_Cajas_SucursalModificacion]
GO