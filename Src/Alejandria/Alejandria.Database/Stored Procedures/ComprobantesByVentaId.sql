CREATE PROCEDURE [dbo].[ComprobantesByVentaId]
	@ventaId uniqueidentifier
	
AS
		SELECT V.NumeroComprobante as VentaNro, C.Cuenta, C.Denominacion, C.Domicilio, C.Telefono,
	convert(nvarchar(max),C.Comentarios) as Referencia,
	V.Concepto , CM.Importe AS Anticipo,
	V.CantidadCuota AS Cuotas, ccc.Importe as ValorCuota, ccc.Cuota as Cuota, Vn.Nombre AS Vendedor, 
	Cb.Nombre as Cobrador,	CCC.FechaVencimiento, DAY(CCC.FechaVencimiento) as Desde, DAY(FechaVencimientoHasta) as Hasta
	, Month(CCC.FechaVencimiento) as Mes,  Year(CCC.FechaVencimiento) as Anio
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
	CCC.Cuota, Vn.Nombre, CCC.FechaVencimiento, CCC.FechaVencimientoHasta, V.NumeroComprobante, C.Denominacion, Cb.Nombre,
	convert(nvarchar(max),C.Comentarios),V.CantidadCuota
	ORDER BY CCC.Cuota
--RETURN 0
