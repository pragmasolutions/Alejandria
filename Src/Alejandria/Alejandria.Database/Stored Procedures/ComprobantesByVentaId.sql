CREATE PROCEDURE [dbo].[ComprobantesByVentaId]
	@ventaId uniqueidentifier
	
AS
	SELECT C.Cuenta, C.Denominacion, C.Domicilio, C.Telefono, V.Concepto , CM.Importe AS Anticipo,
	COUNT(CCC.Id) AS Cuotas, ccc.Importe as ValorCuota, ccc.Cuota as Cuota, P.Nombre AS Vendedor, 
	CCC.FechaVencimiento
	FROM Ventas V
	INNER JOIN ClientesCuentasCorriente CCC
	ON CCC.VentaId= V.Id
	INNER JOIN Clientes C
	ON C.Id = V.ClienteId
	INNER JOIN CajasMovimientos CM
	ON CM.ComprobanteId=V.Id
	INNER JOIN Operadores O
	ON O.Id= V.OperadorAltaId
	INNER JOIN Personal P
	ON P.Id= O.PersonalId
	WHERE V.id= @ventaId 
	GROUP BY C.Cuenta, C.Denominacion, C.Denominacion, C.Domicilio, C.Telefono, V.Concepto, CM.Importe, CCC.Importe,
	CCC.Cuota, P.Nombre, CCC.FechaVencimiento
	ORDER BY CCC.Cuota
--RETURN 0
