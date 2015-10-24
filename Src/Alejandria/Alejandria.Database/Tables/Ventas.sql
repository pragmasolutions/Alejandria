CREATE TABLE [dbo].[Ventas](
	[Id] [uniqueidentifier] NOT NULL,
	[LCN] [varchar](15) NOT NULL,
	[ComprobanteId] [int] NOT NULL,
	[ClienteId] [uniqueidentifier] NOT NULL,
	[LetraComprobante] [char](1) NOT NULL,
	[PuntoVenta] [int] NOT NULL,
	[NumeroComprobante] [int] NOT NULL,
	[FechaComprobante] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[CondicionVentaId] [int] NULL,
	[Concepto] [nvarchar](50) NULL,
	[ImporteNeto] [money] NOT NULL,
	[ImporteIva] [money] NOT NULL,
	[ImporteSena] [money] NULL,
	[FechaUltimoPago] [datetime] NULL,
	[TotalPagado] [money] NULL,
	[EstadoVentaId] [int] NOT NULL,
	[FechaAlta] [datetime] NULL,
	[SucursalAltaId] [int] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[OperadorAutoriza] [uniqueidentifier] NULL,
	[ValidacionUsuario] [nvarchar](50) NULL,
 [CobradorId] INT NULL, 
    [VendedorId] INT NULL, 
    CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_Ventas_Cobradores] FOREIGN KEY (CobradorId) REFERENCES Cobradores(Id), 
    CONSTRAINT [FK_Ventas_Vendedor] FOREIGN KEY (VendedorId) REFERENCES Vendedores(Id)
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_Cliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Cliente]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_Comprobante] FOREIGN KEY([ComprobanteId])
REFERENCES [dbo].[TiposComprobantes] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Comprobante]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_CondicionVenta] FOREIGN KEY([CondicionVentaId])
REFERENCES [dbo].[CondicionesVenta] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_CondicionVenta]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_EstadoVenta] FOREIGN KEY([EstadoVentaId])
REFERENCES [dbo].[EstadosVenta] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_EstadoVenta]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_OperadorAlta]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_OperadorAutoriza] FOREIGN KEY([OperadorAutoriza])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_OperadorAutoriza]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_OperadorModificacion]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_SucursalAlta]
GO

ALTER TABLE [dbo].[Ventas]  WITH NOCHECK ADD  CONSTRAINT [FK_Ventas_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_SucursalModificacion]
GO