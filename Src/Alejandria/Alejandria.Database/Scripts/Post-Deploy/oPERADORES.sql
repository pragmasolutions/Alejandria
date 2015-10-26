INSERT INTO  [dbo].[Operadores]
           ([Id]
           ,[Usuario]
           ,[PersonalId]
           ,[Habilitado]
           )
     SELECT
          '00000000-0000-0000-0000-000000000000'
           ,'USUARIO'
           ,'00000000-0000-0000-0000-000000000000'
           ,1
     WHERE NOT EXISTS (SELECT 1 FROM Operadores WHERE Id='00000000-0000-0000-0000-000000000000')
GO


