USE Neptuno
GO

IF OBJECT_ID('SP_EliminarProducto', 'P') IS NOT NULL
    DROP PROCEDURE SP_EliminarProducto
GO

CREATE PROCEDURE SP_EliminarProducto
(
    @IdProducto INT
)
AS
DELETE FROM Productos WHERE IdProducto = @IdProducto
GO

IF OBJECT_ID('SP_ActualizarProducto', 'P') IS NOT NULL
    DROP PROCEDURE SP_ActualizarProducto
GO

CREATE PROCEDURE SP_ActualizarProducto
(
    @IdProducto INT,
    @NombreProducto NVARCHAR(40),
    @CantidadPorUnidad NVARCHAR(20),
    @PrecioUnidad MONEY
)
AS
UPDATE Productos
SET NombreProducto = @NombreProducto,
    CantidadPorUnidad = @CantidadPorUnidad,
    PrecioUnidad = @PrecioUnidad
WHERE IdProducto = @IdProducto
GO
