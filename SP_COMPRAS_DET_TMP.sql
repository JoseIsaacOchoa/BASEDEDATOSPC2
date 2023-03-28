ALTER PROCEDURE SP_COMPRADETTMP
@OP TINYINT = 0,
@CT_FOLIO TINYINT = 0,
@CT_SERIE CHAR(3) = NULL,
@CT_ID_TIPODOCTO TINYINT = 0,
@CT_MONTO FLOAT = 0,
@CT_ID_PROVEEDOR TINYINT = 0,
@CT_ID_ALMACEN TINYINT = 0,
@CT_FACTURA VARCHAR(20) = 0,
@CT_FECHA DATETIME = NULL,
@CT_ID_PRODUCTO INT = 0,
@CT_CANTIDAD FLOAT = 0,
@CT_IMPORTE FLOAT = 0,
@CT_IVA FLOAT = 0,
@CT_UBICACION TINYINT = 0
AS
BEGIN
	--BUSCAR
	IF @OP=1
	BEGIN
		SELECT * from COMPRA_DET_TMP where CT_FOLIO = @CT_FOLIO
	END
	--GUARDA LOS DATOS DE LA COMPRA---------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 2
	BEGIN
		INSERT INTO COMPRA_DET_TMP(CT_FOLIO, CT_SERIE, CT_ID_TIPODOCTO, CT_MONTO, CT_ID_PROVEEDOR, CT_ID_ALMACEN, CT_FACTURA, CT_FECHA, CT_ID_PRODUCTO, CT_CANTIDAD, CT_IMPORTE, CT_IVA, CT_UBICACION)
		VALUES(@CT_FOLIO, @CT_SERIE, @CT_ID_TIPODOCTO, @CT_MONTO, @CT_ID_PROVEEDOR, @CT_ID_ALMACEN, @CT_FACTURA, @CT_FECHA, @CT_ID_PRODUCTO, @CT_CANTIDAD, @CT_IMPORTE, @CT_IVA, @CT_UBICACION)
	END
	--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 3
	BEGIN
		DELETE FROM COMPRA_DET_TMP WHERE CT_FOLIO = @CT_FOLIO AND CT_ID_PRODUCTO = @CT_ID_PRODUCTO AND CT_CANTIDAD = @CT_CANTIDAD AND CT_IMPORTE = @CT_IMPORTE AND CT_IVA = @CT_IVA
	END
	IF @OP = 4
	BEGIN
		DELETE FROM COMPRA_DET_TMP WHERE CT_FOLIO = @CT_FOLIO
	END
END