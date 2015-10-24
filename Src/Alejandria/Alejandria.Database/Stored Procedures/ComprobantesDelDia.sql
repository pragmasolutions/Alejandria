CREATE PROCEDURE [dbo].[ComprobantesDelDia]
	AS
	SELECT V.NumeroComprobante as VentaNro, C.Cuenta, C.Denominacion, C.Domicilio, C.Telefono,
	convert(nvarchar(max),C.Comentarios) as Referencia,
	 V.Concepto , CM.Importe AS Anticipo,
	V.CantidadCuota AS Cuotas, ccc.Importe as ValorCuota, ccc.Cuota as Cuota, Vn.Nombre AS Vendedor, 
	Cb.Nombre as Cobrador,	CCC.FechaVencimiento, DAY(CCC.FechaVencimiento) as Desde, DAY(FechaVencimientoHasta) as Hasta
	, Month(CCC.FechaVencimiento) as Mes,  Year(CCC.FechaVencimiento) as Año
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
	-- WHERE V.id= 'C44A38FD-3B81-4BFA-AC18-ED9D83272C0D' 
	WHERE CONVERT (char(10), (V.FechaAlta), 103)   =CONVERT (char(10), getdate(), 103) 
	GROUP BY V.NumeroComprobante, C.Cuenta, C.Denominacion,  C.Domicilio, C.Telefono, V.Concepto, CM.Importe, CCC.Importe,
	CCC.Cuota, Vn.Nombre, CCC.FechaVencimiento, CCC.FechaVencimientoHasta, C.Denominacion, Cb.Nombre,V.CantidadCuota
	,convert(nvarchar(max),C.Comentarios)
	ORDER BY V.NumeroComprobante
RETURN 0
