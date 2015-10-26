INSERT INTO [dbo].[TiposComprobantes]
           ([Id]
           ,[Nombre]
           ,[Abreviatura]
           ,[Descripcion]
           ,[Prioridad]
           )
     SELECT
          1
           ,'FAC.VTA.CTA.CTE.'
           ,'Fac.Vta.CC'
           ,'Fac.Vta.Cta.Cte.'
           ,1
     WHERE NOT EXISTS (SELECT 1 FROM TiposComprobantes WHERE Id=1)
GO

INSERT INTO [dbo].[TiposComprobantes]
           ([Id]
           ,[Nombre]
           ,[Abreviatura]
           ,[Descripcion]
           ,[Prioridad]
           )
     SELECT
          2
           ,'PAGOCUOTA'
           ,'Pago.Cuota'
           ,'Pago.Cuota.CtaCte'
           ,1
     WHERE NOT EXISTS (SELECT 1 FROM TiposComprobantes WHERE Id=2)
GO


