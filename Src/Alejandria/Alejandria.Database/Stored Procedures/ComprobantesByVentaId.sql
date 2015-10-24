CREATE PROCEDURE [dbo].[ComprobantesByVentaId]
	@ventaId uniqueidentifier
	
AS
		SELECT V.NumeroComprobante as VentaNro, C.Cuenta, C.Denominacion, C.Domicilio, C.Telefono,
	C.Denominacion as Referencia, V.Concepto , CM.Importe AS Anticipo,
	COUNT(CCC.Id) AS Cuotas, ccc.Importe as ValorCuota, ccc.Cuota as Cuota, Vn.Nombre AS Vendedor, 
	Cb.Nombre as Cobrador,	CCC.FechaVencimiento
	FROM Ventas V
	INNER JOIN ClientesCuentasCorriente CCC
	ON CCC.VentaId= V.Id
	INNER JOIN Clientes C
	ON C.Id = V.ClienteId
	INNER JOIN CajasMovimientos CM
	ON CM.ComprobanteId=V.Id
	INNER JOIN Operadores O
	ON O.Id= V.OperadorAltaId
	INNER JOIN Vendedores Vn
	ON Vn.Id= V.VendedorId
	INNER JOIN Cobradores Cb
	ON Cb.Id= V.CobradorId
	WHERE V.id= @ventaId
	GROUP BY C.Cuenta, C.Denominacion, C.Denominacion, C.Domicilio, C.Telefono, V.Concepto, CM.Importe, CCC.Importe,
	CCC.Cuota, Vn.Nombre, CCC.FechaVencimiento, V.NumeroComprobante, C.Denominacion, Cb.Nombre
	ORDER BY CCC.Cuota
--RETURN 0
