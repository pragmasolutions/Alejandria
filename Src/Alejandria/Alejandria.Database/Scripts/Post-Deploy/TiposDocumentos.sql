INSERT INTO [dbo].[TiposDocumentosIdentidad]
           ([Id]
           ,[Nombre]
           ,[Abreviatura]
           ,[Descripcion]
           )
     SELECT
           1
           ,'DNI'
           ,'DNI'
           ,'DOCUMENTO NACIONAL DE IDENTIDAD'
     WHERE NOT EXISTS (SELECT 1 FROM TiposDocumentosIdentidad WHERE Id=1)
GO


