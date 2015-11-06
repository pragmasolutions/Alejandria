CREATE PROCEDURE [dbo].[ProximasCuotasByCobrador]
	@cobradorId int = 0
	
AS
	SELECT C.Denominacion,CONVERT (char(10), (V.FechaAlta), 103)  as FechaCompra, V.NumeroComprobante as VentaNro,
MAX(CCC.Cuota) as CuotaNro, CCC.Importe,
CONVERT (char(10), MAX(CCC.FechaVencimiento), 103) as FechaVencimiento,
MAX(DAY(CCC.FechaVencimiento)) as Desde, MAX(DAY(CCC.FechaVencimientoHasta)) as Hasta
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
	GROUP BY CCC.VentaId, V.NumeroComprobante,V.FechaAlta, C.Denominacion,
	CCC.Importe
	ORDER BY V.FechaAlta
RETURN 0
