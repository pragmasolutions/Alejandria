CREATE TABLE [dbo].[CajasMovimientos](
	[Id] [uniqueidentifier] NOT NULL,
	[CajaId] [uniqueidentifier] NOT NULL,
	[TipoMovimientoCajaId] [int] NULL,
	[TipoComprobante] [int] NULL,
	[ComprobanteId] [uniqueidentifier] NULL,
	[Senia] [money] NULL,
	[Recargo] [money] NULL,
	[Importe] [money] NULL,
	[ImpFac] [money] NULL,
	[Efectivo] [money] NULL,
	[Tarjeta] [money] NULL,
	[Cheque] [money] NULL,
	[Bono] [money] NULL,
	[fpcBono] [nvarchar](20) NULL,
	[Deposito] [money] NULL,
	[CajaIdAnt] [nchar](20) NULL,
	[CompIdAnt] [nchar](20) NULL,
	[CompLcnAnt] [nchar](20) NULL,
	[FacturaReservadas] [int] NULL,
	[PcAlta] [nvarchar](20) NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
	[Transferencia] [money] NULL,
 CONSTRAINT [PK_CajasMovimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CajasMovimientos]  WITH NOCHECK ADD  CONSTRAINT [FK_CajasMovimientos_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[CajasMovimientos] CHECK CONSTRAINT [FK_CajasMovimientos_OperadorAlta]
GO

ALTER TABLE [dbo].[CajasMovimientos]  WITH NOCHECK ADD  CONSTRAINT [FK_CajasMovimientos_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[CajasMovimientos] CHECK CONSTRAINT [FK_CajasMovimientos_OperadorModificacion]
GO

ALTER TABLE [dbo].[CajasMovimientos]  WITH NOCHECK ADD  CONSTRAINT [FK_CajasMovimientos_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[CajasMovimientos] CHECK CONSTRAINT [FK_CajasMovimientos_SucursalAlta]
GO

ALTER TABLE [dbo].[CajasMovimientos]  WITH NOCHECK ADD  CONSTRAINT [FK_CajasMovimientos_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[CajasMovimientos] CHECK CONSTRAINT [FK_CajasMovimientos_SucursalModificacion]
GO

ALTER TABLE [dbo].[CajasMovimientos]  WITH CHECK ADD  CONSTRAINT [FK_CajasMovimientos_TipoComprobante] FOREIGN KEY([TipoComprobante])
REFERENCES [dbo].[TiposComprobantes] ([Id])
GO

ALTER TABLE [dbo].[CajasMovimientos] CHECK CONSTRAINT [FK_CajasMovimientos_TipoComprobante]
GO

ALTER TABLE [dbo].[CajasMovimientos]  WITH CHECK ADD  CONSTRAINT [FK_CajasMovimientos_TipoMovimientoCaja] FOREIGN KEY([TipoMovimientoCajaId])
REFERENCES [dbo].[TiposMovimientosCajas] ([Id])
GO

ALTER TABLE [dbo].[CajasMovimientos] CHECK CONSTRAINT [FK_CajasMovimientos_TipoMovimientoCaja]
GO
