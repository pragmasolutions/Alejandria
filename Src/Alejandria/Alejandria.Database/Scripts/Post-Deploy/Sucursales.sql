INSERT INTO [dbo].[Sucursales]
           ([Id]
           ,[Nombre]
           ,[ProvinciaId]
           ,[LocalidadId]
           ,[MaximoImporteVenta]
           ,[MaximoPorcentajeDescuento]
           ,[MaximoNroLineasPorVenta]
           ,[SucursalNumero]
           )
     SELECT
          1
           ,'ALEJANDRIA'
           ,3
           ,158
           ,1000,00
           ,0.00
           ,10
           ,1
     WHERE NOT EXISTS (SELECT 1 FROM Sucursales WHERE Id=1)
GO


