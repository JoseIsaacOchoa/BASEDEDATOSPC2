ALTER PROCEDURE SP_COMPRAS
@OP TINYINT = 0,
@CO_FOLIO TINYINT = 0,
@CO_SERIE CHAR(3) = NULL,
@CO_ID_TIPODOCTO TINYINT = 0,
@CO_MONTO TINYINT = 0,
@CO_ID_PROVEEDOR TINYINT = 0,
@CO_ID_ALMACEN TINYINT = 0,
@CO_FACTURA VARCHAR(20),
@CO_FECHA DATETIME = NULL
AS
BEGIN
	--BUSCAR
	IF @OP=1
	BEGIN
		SELECT * from COMPRAS where CO_FOLIO = @CO_FOLIO
	END
	--GUARDA Y ACTUALIZA LOS DATOS DE LA COMPRA---------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 2
	BEGIN
		IF NOT EXISTS(SELECT * FROM COMPRAS WHERE CO_FOLIO = @CO_FOLIO)
			BEGIN
				--OBTIENE EL CONSECUTIVO DE LA COMPRA
				SET @CO_FOLIO = (SELECT ISNULL(MAX(CO_FOLIO),0) + 1 FROM COMPRAS)
				INSERT INTO COMPRAS(CO_FOLIO, CO_SERIE, CO_ID_TIPODOCTO, CO_MONTO, CO_ID_PROVEEDOR, CO_ID_ALMACEN, CO_FACTURA, CO_FECHA)
				VALUES(@CO_FOLIO, @CO_SERIE, @CO_ID_TIPODOCTO, @CO_MONTO, @CO_ID_PROVEEDOR, @CO_ID_ALMACEN, @CO_FACTURA, @CO_FECHA)
			END
		ELSE
			BEGIN
				UPDATE COMPRAS SET CO_SERIE = @CO_SERIE, CO_ID_TIPODOCTO = @CO_ID_TIPODOCTO, CO_MONTO = @CO_MONTO, CO_ID_PROVEEDOR = @CO_ID_PROVEEDOR,
				CO_ID_ALMACEN = @CO_ID_ALMACEN, CO_FACTURA = @CO_FACTURA, CO_FECHA = @CO_FECHA
				WHERE CO_FOLIO = @CO_FOLIO
			END
	END
	--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 3
	BEGIN
		DELETE FROM COMPRAS WHERE CO_FOLIO = @CO_FOLIO
	END
END