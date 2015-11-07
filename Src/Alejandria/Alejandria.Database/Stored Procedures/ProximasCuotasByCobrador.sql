CREATE PROCEDURE [dbo].[ProximasCuotasByCobrador]
	@cobradorId int = 0
	
AS
	SELECT C.Denominacion,CONVERT (char(10), (V.FechaAlta), 103)  as FechaCompra, V.NumeroComprobante as VentaNro,
MIN(CCC.Cuota) as CuotaNro, CCC.Importe,
CONVERT (char(10), MIN(CCC.FechaVencimiento), 103) as FechaVencimiento,
MIN(DAY(CCC.FechaVencimiento)) as Desde, MIN(DAY(CCC.FechaVencimientoHasta)) as Hasta
FROM ClientesCuentasCorriente CCC
INNER JOIN Ventas V
ON V.Id= CCC.VentaId
INNER JOIN Clientes C
ON C.Id= V.ClienteId
WHERE CCC.VentaId
IN
	(
		SELECT CCC.VentaId
		FROM ClientesCuentasCorriente CCC
		INNER JOIN Ventas V
		ON V.Id = CCC.VentaId
		INNER JOIN Cobradores C
		ON C.Id=V.CobradorId
		WHERE CCC.Importe > CCC.Pagado
		AND CobradorId=@cobradorId
		GROUP BY CCC.VentaId
	)
		AND CCC.Importe > CCC.Pagado
	GROUP BY CCC.VentaId, V.NumeroComprobante,V.FechaAlta, C.Denominacion,
	CCC.Importe
	ORDER BY V.FechaAlta
RETURN 0
