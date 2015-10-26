INSERT INTO  [dbo].[Personal]
           ([Id]
           ,[Nombre]
           )
     SELECT
          '00000000-0000-0000-0000-000000000000'
           ,'USUARIO'
     WHERE NOT EXISTS (SELECT 1 FROM Personal WHERE Id='00000000-0000-0000-0000-000000000000')
GO


