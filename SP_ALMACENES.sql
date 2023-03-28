CREATE PROCEDURE SP_ALMACENES
@OP TINYINT = 0,
@AL_ID TINYINT = 0,
@AL_NOMBRE VARCHAR(50) = NULL
AS
BEGIN
	--BUSCAR
	IF @OP=1
	BEGIN
		SELECT * from ALMACENES where AL_ID = @AL_ID
	END
	--GUARDA Y ACTUALIZA LOS DATOS DEL ALMACEN---------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 2
	BEGIN
		IF NOT EXISTS(SELECT * FROM ALMACENES WHERE AL_ID = @AL_ID)
			BEGIN
				--OBTIENE EL CONSECUTIVO DEL ALMACEN
				SET @AL_ID = (SELECT ISNULL(MAX(AL_ID),0) + 1 FROM ALMACENES)
				INSERT INTO ALMACENES(AL_ID, AL_NOMBRE)
				VALUES(@AL_ID, @AL_NOMBRE)
			END
		ELSE
			BEGIN
				UPDATE ALMACENES SET AL_NOMBRE = @AL_NOMBRE
				WHERE AL_ID = @AL_ID
			END
	END
	--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 3
	BEGIN
		DELETE FROM ALMACENES WHERE AL_ID = @AL_ID
	END
END