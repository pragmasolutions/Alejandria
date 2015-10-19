CREATE TABLE [dbo].[Cobradores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Abreviatura] [nvarchar](10) NULL,
	[Domicilio] NCHAR(100) NULL, 
    [Telefono] NCHAR(40) NULL, 
    [Celular] NCHAR(15) NULL, 
    [Cuit] NVARCHAR(11) NULL, 
    [Mail] NCHAR(40) NULL, 
    [ProvinciaId] INT NULL, 
    [LocalidadId] INT NULL, 
    [TipoDocumentoId] INT NULL, 
    [Activo] BIT NOT NULL, 
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
    CONSTRAINT [PK_Cobradores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_Cobradores_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Cobradores_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Cobradores_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Cobradores_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Cobradores_TipoDocumento] FOREIGN KEY (TipoDocumentoId) REFERENCES TiposDocumentosidentidad(Id), 
    CONSTRAINT [FK_Cobradores_Provincia] FOREIGN KEY (ProvinciaId) REFERENCES Provincias(Id), 
    CONSTRAINT [FK_Cobradores_Localidad] FOREIGN KEY (LocalidadId) REFERENCES Localidades(Id)
) ON [PRIMARY]

GO