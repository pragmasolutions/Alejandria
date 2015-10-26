INSERT INTO [dbo].[EstadosVenta]
           ([Id]
           ,[Nombre]
           ,[OperadorAltaId]
           ,[SucursalAltaId]
		   )
     SELECT
           1
           ,'Entregada'
           ,'00000000-0000-0000-0000-000000000000'
           ,1
     WHERE NOT EXISTS (SELECT 1 FROM EstadosVenta WHERE Id=1)
GO


