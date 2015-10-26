INSERT INTO [dbo].[CondicionesVenta]
           ([Id]
           ,[Nombre]
           )
     SELECT
           1
           ,'CUENTA CORRIENTE'
     WHERE NOT EXISTS (SELECT 1 FROM CondicionesVenta WHERE Id=1)
GO


