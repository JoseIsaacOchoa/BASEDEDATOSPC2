ALTER PROCEDURE SP_PRODUCTOS
@OP TINYINT = 0,
@PR_ID INT = 0,
@PR_NOMBRE VARCHAR(100) = NULL,
@PR_ID_UNIDAD TINYINT = 0,
@PR_STOCK_MIN FLOAT = 0,
@PR_STOCK_MAX FLOAT = 0,
@PR_ID_TP TINYINT = 0,
@PR_PRECIO FLOAT = 0,
@PR_IVA FLOAT = 0
AS
BEGIN
	--BUSCAR
	IF @OP=1
	BEGIN
		SELECT * from PRODUCTOS where PR_ID = @PR_ID
	END
	--GUARDA Y ACTUALIZA LOS DATOS DEL PRODUCTO---------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 2
	BEGIN
		IF NOT EXISTS(SELECT * FROM PRODUCTOS WHERE PR_ID = @PR_ID)
			BEGIN
				--OBTIENE EL CONSECUTIVO DEL PRODUCTO
				SET @PR_ID = (SELECT ISNULL(MAX(PR_ID),0) + 1 FROM PRODUCTOS)
				INSERT INTO PRODUCTOS(PR_ID, PR_NOMBRE, PR_ID_UNIDAD, PR_STOCK_MIN, PR_STOCK_MAX, PR_ID_TP, PR_PRECIO, PR_IVA)
				VALUES(@PR_ID, @PR_NOMBRE, @PR_ID_UNIDAD, @PR_STOCK_MIN, @PR_STOCK_MAX, @PR_ID_TP, @PR_PRECIO, @PR_IVA)
			END
		ELSE
			BEGIN
				UPDATE PRODUCTOS SET PR_NOMBRE = @PR_NOMBRE, PR_ID_UNIDAD = @PR_ID_UNIDAD, PR_STOCK_MIN = @PR_STOCK_MIN,
				PR_STOCK_MAX = @PR_STOCK_MAX, PR_ID_TP = @PR_ID_TP, PR_PRECIO = @PR_PRECIO, PR_IVA = @PR_IVA
				WHERE PR_ID = @PR_ID
			END
	END
	--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 3
	BEGIN
		DELETE FROM PRODUCTOS WHERE PR_ID = @PR_ID
	END
	IF @OP = 4
	BEGIN
		select dbo.FN_REPORTE(@PR_ID) as 'EXISTENCIA'
	END
END

--select * from PRODUCTOS
--exec SP_PRODUCTOS 2, 1, 'Producto1', 2, 10, 30, 1, 25, 29
--select * from ALMACENES