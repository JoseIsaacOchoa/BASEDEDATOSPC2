ALTER PROCEDURE SP_UNIDAD
@OP TINYINT = 0,
@UN_ID TINYINT = 0,
@UN_DESCRIPCION VARCHAR(100) = NULL
AS
BEGIN
	--BUSCAR
	IF @OP=1
	BEGIN
		SELECT * from UNIDAD where UN_ID = @UN_ID
	END
	--GUARDA Y ACTUALIZA LOS DATOS DE LA UNIDAD---------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 2
	BEGIN
		IF NOT EXISTS(SELECT * FROM UNIDAD WHERE UN_ID = @UN_ID)
			BEGIN
				--OBTIENE EL CONSECUTIVO DE LA UNIDAD
				SET @UN_ID = (SELECT ISNULL(MAX(UN_ID),0) + 1 FROM UNIDAD)
				INSERT INTO UNIDAD(UN_ID, UN_DESCRIPCION)
				VALUES(@UN_ID, @UN_DESCRIPCION)
			END
		ELSE
			BEGIN
				UPDATE UNIDAD SET UN_DESCRIPCION = @UN_DESCRIPCION
				WHERE UN_ID = @UN_ID
			END
	END
	--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 3
	BEGIN
		DELETE FROM UNIDAD WHERE UN_ID = @UN_ID
	END
END

