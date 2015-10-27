CREATE TABLE [dbo].[Vendedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Abreviatura] [nvarchar](10) NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
 [Domicilio] NCHAR(100) NULL, 
    [Telefono] NCHAR(40) NULL, 
    [Celular] NCHAR(20) NULL, 
    [Cuit] NCHAR(11) NULL, 
    [Mail] NCHAR(40) NULL, 
    [ProvinciaId] INT NULL, 
    [LocalidadId] INT NULL, 
    [TipoDocumentoId] INT NULL, 
    [Activo] BIT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_Vendedores_OperadorAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Vendedores_Provincia] FOREIGN KEY (ProvinciaId) REFERENCES Provincias(Id), 
    CONSTRAINT [FK_Vendedores_Localidad] FOREIGN KEY (LocalidadId) REFERENCES Localidades(Id), 
    CONSTRAINT [FK_Vendedores_TipoDocumento] FOREIGN KEY (TipoDocumentoId) REFERENCES TiposDocumentosIdentidad(Id), 
    CONSTRAINT [FK_Vendedores_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Vendedores_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Vendedores_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO