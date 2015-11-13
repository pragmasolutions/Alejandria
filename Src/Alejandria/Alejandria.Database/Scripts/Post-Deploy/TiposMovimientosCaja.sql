INSERT INTO [dbo].[TiposMovimientosCajas]
           ([Id]
           ,[Nombre]
		   ,[Abreviatura]
		   ,[TipoMovimiento]
           )
     SELECT
           3
           ,'ANULACIÓN FAC. CTA CTE'
		   ,'An.F.CtaCte'
		   ,2
     WHERE NOT EXISTS (SELECT 1 FROM TiposMovimientosCajas WHERE Id=3)
GO


