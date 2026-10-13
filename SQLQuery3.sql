SELECT Id, Total FROM Ventas;
SELECT VentaId, ProductoId, Cantidad, Subtotal FROM DetalleVentas;
SELECT Id, Nombre, Stock FROM Productos WHERE Id IN (1, 2, 3);