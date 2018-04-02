SELECT 
	dataset.*,
	(dataset.Maximo - dataset.ExistReal) As CantidadPedir,
	(SELECT IF (dataset.proveedores > 0, concat(dataset.proveedores,' - Ver'), 'No Tiene'))
FROM ( 
	SELECT 
		p.Id_Producto, 
		p.Descripcion,
		p.Minimo, 
		p.Maximo, 
		(p.Existencias - COALESCE((SELECT SUM(lr.Cantidad) AS suma
			FROM LISTADO_RESUMEN lr INNER JOIN LISTADO_ENCABEZADO le ON lr.Id_Listado = le.Id_Listado 
			WHERE le.Impreso = 0
			GROUP BY lr.Id_Producto HAVING lr.Id_Producto = p.Id_Producto),0)) As ExistReal, 
		p.MaxVendido,
		(SELECT Count(*) FROM PRODUCTO_POR_PROVEEDOR as pp WHERE pp.Id_Producto = p.Id_Producto) as proveedores
	FROM PRODUCTO AS p
	WHERE 
		p.Descripcion like '%cachera%' 
		AND p.Id_Producto NOT IN (SELECT d.IdProducto from pedido_detalle as d where d.IdProducto = p.Id_Producto)
	ORDER BY p.Descripcion ASC) as dataset 
WHERE DataSet.Minimo > ExistReal