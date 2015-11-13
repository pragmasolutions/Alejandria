INSERT INTO [dbo].[TiposComprobantes]
           ([Id]
           ,[Nombre]
           ,[Abreviatura]
           ,[Descripcion]
           ,[Prioridad]
           )
     SELECT
          3
           ,'Factura Anulada'
           ,'Anulada'
           ,'Factura Anulada'
           ,1
     WHERE NOT EXISTS (SELECT 1 FROM TiposComprobantes WHERE Id=3)
GO



