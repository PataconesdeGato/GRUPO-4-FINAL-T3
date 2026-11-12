

IF DB_ID(N'LaESTAMPIDA') IS NULL
    CREATE DATABASE LaESTAMPIDA;
GO
USE LaESTAMPIDA;
GO

IF SCHEMA_ID(N'mant') IS NULL EXEC(N'CREATE SCHEMA mant');
GO
IF SCHEMA_ID(N'core') IS NULL EXEC(N'CREATE SCHEMA core');
GO

/* =====================================================================
   MANTENEDORES
   ===================================================================== */

CREATE TABLE mant.CategoriaProducto (
    idCategoriaProducto INT IDENTITY(1,1) CONSTRAINT PK_CategoriaProducto PRIMARY KEY,
    nombre              NVARCHAR(50) NOT NULL CONSTRAINT UQ_CategoriaProducto_nombre UNIQUE,
    estado              BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.CategoriaInsumo (
    idCategoriaInsumo INT IDENTITY(1,1) CONSTRAINT PK_CategoriaInsumo PRIMARY KEY,
    nombre            NVARCHAR(50) NOT NULL CONSTRAINT UQ_CategoriaInsumo_nombre UNIQUE,
    estado            BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Mesa (
    idMesa    INT IDENTITY(1,1) CONSTRAINT PK_Mesa PRIMARY KEY,
    numero    INT NOT NULL CONSTRAINT UQ_Mesa_numero UNIQUE,
    capacidad INT NOT NULL CONSTRAINT CK_Mesa_capacidad CHECK (capacidad > 0),
    ubicacion NVARCHAR(50) NULL,
    estado    BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Cliente (
    idCliente          INT IDENTITY(1,1) CONSTRAINT PK_Cliente PRIMARY KEY,
    documentoIdentidad VARCHAR(15) NOT NULL CONSTRAINT UQ_Cliente_documento UNIQUE,
    nombres            NVARCHAR(150) NOT NULL,
    telefono           VARCHAR(15) NULL,
    estado             BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Proveedor (
    idProveedor INT IDENTITY(1,1) CONSTRAINT PK_Proveedor PRIMARY KEY,
    ruc         VARCHAR(11) NOT NULL CONSTRAINT UQ_Proveedor_ruc UNIQUE
                CONSTRAINT CK_Proveedor_ruc CHECK (LEN(ruc) = 11 AND ruc NOT LIKE '%[^0-9]%'),
    razonSocial NVARCHAR(150) NOT NULL,
    telefono    VARCHAR(15) NULL,
    correo      VARCHAR(100) NULL,
    direccion   NVARCHAR(200) NULL,
    estado      BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Empleado (
    idEmpleado INT IDENTITY(1,1) CONSTRAINT PK_Empleado PRIMARY KEY,
    dni        VARCHAR(8) NOT NULL CONSTRAINT UQ_Empleado_dni UNIQUE
               CONSTRAINT CK_Empleado_dni CHECK (LEN(dni) = 8 AND dni NOT LIKE '%[^0-9]%'),
    nombres    NVARCHAR(150) NOT NULL,
    cargo      VARCHAR(20) NOT NULL
               CONSTRAINT CK_Empleado_cargo CHECK (cargo IN ('Chef','JefeCocina','Mesero','Almacenero','JefeAlmacen','Recepcionista','Administrador')),
    turno      VARCHAR(10) NOT NULL
               CONSTRAINT CK_Empleado_turno CHECK (turno IN ('Manana','Tarde','Noche')),
    telefono   VARCHAR(15) NULL,
    correo     VARCHAR(100) NULL,
    estado     BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Usuario (
    idUsuario  INT IDENTITY(1,1) CONSTRAINT PK_Usuario PRIMARY KEY,
    idEmpleado INT NOT NULL CONSTRAINT UQ_Usuario_empleado UNIQUE
               CONSTRAINT FK_Usuario_Empleado REFERENCES mant.Empleado (idEmpleado),
    usuario    VARCHAR(30) NOT NULL CONSTRAINT UQ_Usuario_usuario UNIQUE,
    claveHash  VARCHAR(256) NOT NULL,
    rol        VARCHAR(20) NOT NULL
               CONSTRAINT CK_Usuario_rol CHECK (rol IN ('Recepcionista','Mesero','JefeCocina','JefeAlmacen','Administrador')),
    estado     BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Producto (
    idProducto          INT IDENTITY(1,1) CONSTRAINT PK_Producto PRIMARY KEY,
    codigo              VARCHAR(20) NOT NULL CONSTRAINT UQ_Producto_codigo UNIQUE,
    nombre              NVARCHAR(100) NOT NULL,
    precio              DECIMAL(10,2) NOT NULL CONSTRAINT CK_Producto_precio CHECK (precio >= 0),
    idCategoriaProducto INT NOT NULL CONSTRAINT FK_Producto_Categoria REFERENCES mant.CategoriaProducto (idCategoriaProducto),
    estado              BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Insumo (
    idInsumo          INT IDENTITY(1,1) CONSTRAINT PK_Insumo PRIMARY KEY,
    codigo            VARCHAR(20) NOT NULL CONSTRAINT UQ_Insumo_codigo UNIQUE,
    nombre            NVARCHAR(100) NOT NULL,
    unidadMedida      VARCHAR(10) NOT NULL,
    idCategoriaInsumo INT NOT NULL CONSTRAINT FK_Insumo_Categoria REFERENCES mant.CategoriaInsumo (idCategoriaInsumo),
    stockAlmacen      DECIMAL(12,3) NOT NULL DEFAULT 0 CONSTRAINT CK_Insumo_stockAlmacen CHECK (stockAlmacen >= 0),
    stockCocina       DECIMAL(12,3) NOT NULL DEFAULT 0 CONSTRAINT CK_Insumo_stockCocina CHECK (stockCocina >= 0),
    stockMinimo       DECIMAL(12,3) NOT NULL DEFAULT 0 CONSTRAINT CK_Insumo_stockMinimo CHECK (stockMinimo >= 0),
    estado            BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.Receta (
    idReceta    INT IDENTITY(1,1) CONSTRAINT PK_Receta PRIMARY KEY,
    idProducto  INT NOT NULL CONSTRAINT UQ_Receta_producto UNIQUE
                CONSTRAINT FK_Receta_Producto REFERENCES mant.Producto (idProducto),
    descripcion NVARCHAR(200) NULL,
    estado      BIT NOT NULL DEFAULT 1
);

CREATE TABLE mant.RecetaDetalle (
    idRecetaDetalle INT IDENTITY(1,1) CONSTRAINT PK_RecetaDetalle PRIMARY KEY,
    idReceta        INT NOT NULL CONSTRAINT FK_RecetaDetalle_Receta REFERENCES mant.Receta (idReceta),
    idInsumo        INT NOT NULL CONSTRAINT FK_RecetaDetalle_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidad        DECIMAL(12,3) NOT NULL CONSTRAINT CK_RecetaDetalle_cantidad CHECK (cantidad > 0),
    CONSTRAINT UQ_RecetaDetalle UNIQUE (idReceta, idInsumo)
);

/* =====================================================================
   PROCESOS CORE
   ===================================================================== */

-- CORE 1: Registrar reserva
CREATE TABLE core.Reserva (
    idReserva        INT IDENTITY(1,1) CONSTRAINT PK_Reserva PRIMARY KEY,
    codigoVale       VARCHAR(20) NOT NULL CONSTRAINT UQ_Reserva_vale UNIQUE,
    fecha            DATE NOT NULL,
    hora             TIME(0) NOT NULL,
    numeroComensales INT NOT NULL CONSTRAINT CK_Reserva_comensales CHECK (numeroComensales > 0),
    idCliente        INT NOT NULL CONSTRAINT FK_Reserva_Cliente REFERENCES mant.Cliente (idCliente),
    idMesa           INT NOT NULL CONSTRAINT FK_Reserva_Mesa REFERENCES mant.Mesa (idMesa),
    idUsuario        INT NOT NULL CONSTRAINT FK_Reserva_Usuario REFERENCES mant.Usuario (idUsuario),
    estado           VARCHAR(15) NOT NULL DEFAULT 'Registrada'
                     CONSTRAINT CK_Reserva_estado CHECK (estado IN ('Registrada','Atendida','Anulada','Inasistencia')),
    fechaRegistro    DATETIME2(0) NOT NULL DEFAULT SYSDATETIME()
);

-- CORE 2: Registrar pedido (venta)
CREATE TABLE core.Pedido (
    idPedido   INT IDENTITY(1,1) CONSTRAINT PK_Pedido PRIMARY KEY,
    fecha      DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    fechaEnvio DATETIME2(0) NULL,
    idMesa     INT NOT NULL CONSTRAINT FK_Pedido_Mesa REFERENCES mant.Mesa (idMesa),
    idReserva  INT NULL CONSTRAINT FK_Pedido_Reserva REFERENCES core.Reserva (idReserva),
    idCliente  INT NULL CONSTRAINT FK_Pedido_Cliente REFERENCES mant.Cliente (idCliente),
    idUsuario  INT NOT NULL CONSTRAINT FK_Pedido_Usuario REFERENCES mant.Usuario (idUsuario),
    estado     VARCHAR(15) NOT NULL DEFAULT 'Registrado'
               CONSTRAINT CK_Pedido_estado CHECK (estado IN ('Registrado','Enviado','Anulado'))
);

CREATE TABLE core.DetallePedido (
    idDetallePedido INT IDENTITY(1,1) CONSTRAINT PK_DetallePedido PRIMARY KEY,
    idPedido        INT NOT NULL CONSTRAINT FK_DetallePedido_Pedido REFERENCES core.Pedido (idPedido),
    idProducto      INT NOT NULL CONSTRAINT FK_DetallePedido_Producto REFERENCES mant.Producto (idProducto),
    cantidad        INT NOT NULL CONSTRAINT CK_DetallePedido_cantidad CHECK (cantidad > 0),
    precioUnitario  DECIMAL(10,2) NOT NULL CONSTRAINT CK_DetallePedido_precio CHECK (precioUnitario >= 0),
    modificacion    NVARCHAR(200) NULL
);

-- CORE 3: Registrar preparación de pedido
CREATE TABLE core.Preparacion (
    idPreparacion     INT IDENTITY(1,1) CONSTRAINT PK_Preparacion PRIMARY KEY,
    idPedido          INT NOT NULL CONSTRAINT UQ_Preparacion_pedido UNIQUE
                      CONSTRAINT FK_Preparacion_Pedido REFERENCES core.Pedido (idPedido),
    idChef            INT NULL CONSTRAINT FK_Preparacion_Chef REFERENCES mant.Empleado (idEmpleado),
    idUsuario         INT NOT NULL CONSTRAINT FK_Preparacion_Usuario REFERENCES mant.Usuario (idUsuario),
    fechaVerificacion DATETIME2(0) NULL,
    fechaInicio       DATETIME2(0) NULL,
    fechaEmplatado    DATETIME2(0) NULL,
    fechaAviso        DATETIME2(0) NULL,
    estado            VARCHAR(15) NOT NULL DEFAULT 'Pendiente'
                      CONSTRAINT CK_Preparacion_estado CHECK (estado IN ('Pendiente','EnPreparacion','Emplatado','Avisado'))
);

-- CORE 6: Registrar orden de compra
CREATE TABLE core.OrdenCompra (
    idOrdenCompra        INT IDENTITY(1,1) CONSTRAINT PK_OrdenCompra PRIMARY KEY,
    fecha                DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    fechaEstimadaEntrega DATE NULL,
    idProveedor          INT NOT NULL CONSTRAINT FK_OrdenCompra_Proveedor REFERENCES mant.Proveedor (idProveedor),
    idUsuario            INT NOT NULL CONSTRAINT FK_OrdenCompra_Usuario REFERENCES mant.Usuario (idUsuario),
    total                DECIMAL(12,2) NOT NULL DEFAULT 0 CONSTRAINT CK_OrdenCompra_total CHECK (total >= 0),
    estado               VARCHAR(20) NOT NULL DEFAULT 'Emitida'
                         CONSTRAINT CK_OrdenCompra_estado CHECK (estado IN ('Emitida','RecibidaParcial','Recibida','Anulada'))
);

CREATE TABLE core.DetalleOrdenCompra (
    idDetalleOrdenCompra INT IDENTITY(1,1) CONSTRAINT PK_DetalleOrdenCompra PRIMARY KEY,
    idOrdenCompra        INT NOT NULL CONSTRAINT FK_DetalleOC_OrdenCompra REFERENCES core.OrdenCompra (idOrdenCompra),
    idInsumo             INT NOT NULL CONSTRAINT FK_DetalleOC_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidad             DECIMAL(12,3) NOT NULL CONSTRAINT CK_DetalleOC_cantidad CHECK (cantidad > 0),
    precioUnitario       DECIMAL(10,2) NOT NULL CONSTRAINT CK_DetalleOC_precio CHECK (precioUnitario >= 0),
    cantidadRecibida     DECIMAL(12,3) NOT NULL DEFAULT 0,
    importe              AS (cantidad * precioUnitario),
    CONSTRAINT UQ_DetalleOC UNIQUE (idOrdenCompra, idInsumo),
    CONSTRAINT CK_DetalleOC_recibida CHECK (cantidadRecibida >= 0 AND cantidadRecibida <= cantidad)
);

-- CORE 7: Registrar ingreso de insumos
CREATE TABLE core.IngresoInsumos (
    idIngreso       INT IDENTITY(1,1) CONSTRAINT PK_IngresoInsumos PRIMARY KEY,
    fecha           DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    idOrdenCompra   INT NOT NULL CONSTRAINT FK_Ingreso_OrdenCompra REFERENCES core.OrdenCompra (idOrdenCompra),
    idUsuario       INT NOT NULL CONSTRAINT FK_Ingreso_Usuario REFERENCES mant.Usuario (idUsuario),
    tipoDocumento   VARCHAR(10) NOT NULL CONSTRAINT CK_Ingreso_tipo CHECK (tipoDocumento IN ('Factura','Guia')),
    numeroDocumento VARCHAR(20) NOT NULL,
    estado          VARCHAR(10) NOT NULL DEFAULT 'Registrado'
                    CONSTRAINT CK_Ingreso_estado CHECK (estado IN ('Registrado','Anulado'))
);

CREATE TABLE core.DetalleIngreso (
    idDetalleIngreso INT IDENTITY(1,1) CONSTRAINT PK_DetalleIngreso PRIMARY KEY,
    idIngreso        INT NOT NULL CONSTRAINT FK_DetalleIngreso_Ingreso REFERENCES core.IngresoInsumos (idIngreso),
    idInsumo         INT NOT NULL CONSTRAINT FK_DetalleIngreso_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidadRecibida DECIMAL(12,3) NOT NULL CONSTRAINT CK_DetalleIngreso_cantidad CHECK (cantidadRecibida > 0),
    peso             DECIMAL(10,3) NULL,
    resultado        VARCHAR(10) NOT NULL CONSTRAINT CK_DetalleIngreso_resultado CHECK (resultado IN ('Aceptado','Rechazado'))
);

CREATE TABLE core.Incidencia (
    idIncidencia INT IDENTITY(1,1) CONSTRAINT PK_Incidencia PRIMARY KEY,
    idIngreso    INT NOT NULL CONSTRAINT FK_Incidencia_Ingreso REFERENCES core.IngresoInsumos (idIngreso),
    idInsumo     INT NOT NULL CONSTRAINT FK_Incidencia_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidad     DECIMAL(12,3) NOT NULL CONSTRAINT CK_Incidencia_cantidad CHECK (cantidad > 0),
    motivo       VARCHAR(10) NOT NULL CONSTRAINT CK_Incidencia_motivo CHECK (motivo IN ('Calidad','Peso')),
    fecha        DATETIME2(0) NOT NULL DEFAULT SYSDATETIME()
);

-- CORE 4 y CORE 8: Registrar pedido de insumos (cocina)
CREATE TABLE core.PedidoInsumos (
    idPedidoInsumos INT IDENTITY(1,1) CONSTRAINT PK_PedidoInsumos PRIMARY KEY,
    fecha           DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    idUsuario       INT NOT NULL CONSTRAINT FK_PedidoInsumos_Usuario REFERENCES mant.Usuario (idUsuario),
    idOrdenCompra   INT NULL CONSTRAINT FK_PedidoInsumos_OrdenCompra REFERENCES core.OrdenCompra (idOrdenCompra),
    estado          VARCHAR(25) NOT NULL DEFAULT 'Pendiente'
                    CONSTRAINT CK_PedidoInsumos_estado CHECK (estado IN ('Pendiente','Atendido','ConDesabastecimiento','Anulado'))
);

CREATE TABLE core.DetallePedidoInsumos (
    idDetallePedidoInsumos INT IDENTITY(1,1) CONSTRAINT PK_DetallePedidoInsumos PRIMARY KEY,
    idPedidoInsumos        INT NOT NULL CONSTRAINT FK_DetPedInsumos_Pedido REFERENCES core.PedidoInsumos (idPedidoInsumos),
    idInsumo               INT NOT NULL CONSTRAINT FK_DetPedInsumos_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidadSolicitada     DECIMAL(12,3) NOT NULL CONSTRAINT CK_DetPedInsumos_cantidad CHECK (cantidadSolicitada > 0),
    CONSTRAINT UQ_DetPedInsumos UNIQUE (idPedidoInsumos, idInsumo)
);

-- CORE 9: Registrar salida de insumos
CREATE TABLE core.SalidaInsumos (
    idSalidaInsumos INT IDENTITY(1,1) CONSTRAINT PK_SalidaInsumos PRIMARY KEY,
    idPedidoInsumos INT NOT NULL CONSTRAINT UQ_SalidaInsumos_pedido UNIQUE
                    CONSTRAINT FK_SalidaInsumos_Pedido REFERENCES core.PedidoInsumos (idPedidoInsumos),
    fecha           DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    idUsuario       INT NOT NULL CONSTRAINT FK_SalidaInsumos_Usuario REFERENCES mant.Usuario (idUsuario)
);

CREATE TABLE core.DetalleSalida (
    idDetalleSalida   INT IDENTITY(1,1) CONSTRAINT PK_DetalleSalida PRIMARY KEY,
    idSalidaInsumos   INT NOT NULL CONSTRAINT FK_DetalleSalida_Salida REFERENCES core.SalidaInsumos (idSalidaInsumos),
    idInsumo          INT NOT NULL CONSTRAINT FK_DetalleSalida_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidadEntregada DECIMAL(12,3) NOT NULL CONSTRAINT CK_DetalleSalida_cantidad CHECK (cantidadEntregada > 0),
    CONSTRAINT UQ_DetalleSalida UNIQUE (idSalidaInsumos, idInsumo)
);

-- CORE 5: Registrar nota de insumos (confirmación de recepción en cocina)
CREATE TABLE core.NotaInsumos (
    idNotaInsumos   INT IDENTITY(1,1) CONSTRAINT PK_NotaInsumos PRIMARY KEY,
    idPedidoInsumos INT NOT NULL CONSTRAINT UQ_NotaInsumos_pedido UNIQUE
                    CONSTRAINT FK_NotaInsumos_Pedido REFERENCES core.PedidoInsumos (idPedidoInsumos),
    fecha           DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    idUsuario       INT NOT NULL CONSTRAINT FK_NotaInsumos_Usuario REFERENCES mant.Usuario (idUsuario),
    estado          VARCHAR(10) NOT NULL DEFAULT 'Registrada'
                    CONSTRAINT CK_NotaInsumos_estado CHECK (estado IN ('Registrada','Anulada'))
);

CREATE TABLE core.DetalleNotaInsumos (
    idDetalleNota    INT IDENTITY(1,1) CONSTRAINT PK_DetalleNotaInsumos PRIMARY KEY,
    idNotaInsumos    INT NOT NULL CONSTRAINT FK_DetalleNota_Nota REFERENCES core.NotaInsumos (idNotaInsumos),
    idInsumo         INT NOT NULL CONSTRAINT FK_DetalleNota_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidadRecibida DECIMAL(12,3) NOT NULL CONSTRAINT CK_DetalleNota_cantidad CHECK (cantidadRecibida >= 0),
    CONSTRAINT UQ_DetalleNota UNIQUE (idNotaInsumos, idInsumo)
);

-- CORE 10: Registrar inventario físico
CREATE TABLE core.InventarioFisico (
    idInventarioFisico INT IDENTITY(1,1) CONSTRAINT PK_InventarioFisico PRIMARY KEY,
    fechaProgramada    DATE NOT NULL,
    fechaRealizacion   DATETIME2(0) NULL,
    idUsuario          INT NOT NULL CONSTRAINT FK_InventarioFisico_Usuario REFERENCES mant.Usuario (idUsuario),
    estado             VARCHAR(20) NOT NULL DEFAULT 'Programado'
                       CONSTRAINT CK_InventarioFisico_estado CHECK (estado IN ('Programado','Conforme','ConDiferencias','Ajustado','Anulado'))
);

CREATE TABLE core.DetalleInventario (
    idDetalleInventario INT IDENTITY(1,1) CONSTRAINT PK_DetalleInventario PRIMARY KEY,
    idInventarioFisico  INT NOT NULL CONSTRAINT FK_DetalleInv_Inventario REFERENCES core.InventarioFisico (idInventarioFisico),
    idInsumo            INT NOT NULL CONSTRAINT FK_DetalleInv_Insumo REFERENCES mant.Insumo (idInsumo),
    stockRegistrado     DECIMAL(12,3) NOT NULL,
    stockContado        DECIMAL(12,3) NOT NULL CONSTRAINT CK_DetalleInv_contado CHECK (stockContado >= 0),
    diferencia          AS (stockContado - stockRegistrado),
    causa               NVARCHAR(200) NULL,
    CONSTRAINT UQ_DetalleInv UNIQUE (idInventarioFisico, idInsumo)
);

CREATE TABLE core.ReporteDiferencias (
    idReporteDiferencias   INT IDENTITY(1,1) CONSTRAINT PK_ReporteDiferencias PRIMARY KEY,
    idInventarioFisico     INT NOT NULL CONSTRAINT UQ_ReporteDif_inventario UNIQUE
                           CONSTRAINT FK_ReporteDif_Inventario REFERENCES core.InventarioFisico (idInventarioFisico),
    fecha                  DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    idUsuario              INT NOT NULL CONSTRAINT FK_ReporteDif_Usuario REFERENCES mant.Usuario (idUsuario),
    idUsuarioAdministrador INT NULL CONSTRAINT FK_ReporteDif_Admin REFERENCES mant.Usuario (idUsuario),
    fechaRevision          DATETIME2(0) NULL,
    decision               VARCHAR(20) NULL
                           CONSTRAINT CK_ReporteDif_decision CHECK (decision IN ('AjusteAutorizado','AccionCorrectiva')),
    observacion            NVARCHAR(300) NULL
);

-- CORE 11: Registrar ajuste de inventario
CREATE TABLE core.AjusteInventario (
    idAjusteInventario   INT IDENTITY(1,1) CONSTRAINT PK_AjusteInventario PRIMARY KEY,
    idReporteDiferencias INT NOT NULL CONSTRAINT FK_Ajuste_Reporte REFERENCES core.ReporteDiferencias (idReporteDiferencias),
    idInsumo             INT NOT NULL CONSTRAINT FK_Ajuste_Insumo REFERENCES mant.Insumo (idInsumo),
    cantidad             DECIMAL(12,3) NOT NULL CONSTRAINT CK_Ajuste_cantidad CHECK (cantidad <> 0),
    motivo               NVARCHAR(200) NOT NULL,
    idUsuario            INT NOT NULL CONSTRAINT FK_Ajuste_Usuario REFERENCES mant.Usuario (idUsuario),
    idUsuarioAutoriza    INT NOT NULL CONSTRAINT FK_Ajuste_Autoriza REFERENCES mant.Usuario (idUsuario),
    fecha                DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    estado               VARCHAR(10) NOT NULL DEFAULT 'Registrado'
                         CONSTRAINT CK_Ajuste_estado CHECK (estado IN ('Registrado','Anulado'))
);

/* =====================================================================
   ÍNDICES
   ===================================================================== */

CREATE INDEX IX_Reserva_Fecha_Mesa          ON core.Reserva (fecha, idMesa) INCLUDE (estado);
CREATE INDEX IX_Pedido_Fecha                ON core.Pedido (fecha) INCLUDE (idMesa, estado);
CREATE INDEX IX_Pedido_Mesa_Estado          ON core.Pedido (idMesa, estado);
CREATE INDEX IX_PedidoInsumos_Estado        ON core.PedidoInsumos (estado, fecha);
CREATE INDEX IX_OrdenCompra_Proveedor_Estado ON core.OrdenCompra (idProveedor, estado);
CREATE INDEX IX_IngresoInsumos_OrdenCompra  ON core.IngresoInsumos (idOrdenCompra);
CREATE INDEX IX_Insumo_Categoria            ON mant.Insumo (idCategoriaInsumo);
CREATE INDEX IX_Producto_Categoria          ON mant.Producto (idCategoriaProducto);
GO

/* =====================================================================
   PROCEDIMIENTOS ALMACENADOS - MANTENEDORES
   Patrón por entidad: Listar, Insertar, Editar, Deshabilitar
   (Deshabilitar = baja lógica, estado = 0; no se borra historial)
   ===================================================================== */

/* ---------- CategoriaProducto ---------- */
CREATE OR ALTER PROCEDURE mant.usp_CategoriaProducto_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idCategoriaProducto, nombre, estado
    FROM mant.CategoriaProducto
    WHERE @soloActivos = 0 OR estado = 1
    ORDER BY nombre;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_CategoriaProducto_Insertar
    @nombre NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.CategoriaProducto (nombre) VALUES (@nombre);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idCategoriaProducto;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_CategoriaProducto_Editar
    @idCategoriaProducto INT,
    @nombre NVARCHAR(50),
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.CategoriaProducto WHERE idCategoriaProducto = @idCategoriaProducto)
        THROW 50001, N'La categoría de producto no existe.', 1;
    UPDATE mant.CategoriaProducto
    SET nombre = @nombre, estado = @estado
    WHERE idCategoriaProducto = @idCategoriaProducto;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_CategoriaProducto_Deshabilitar
    @idCategoriaProducto INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.CategoriaProducto WHERE idCategoriaProducto = @idCategoriaProducto)
        THROW 50001, N'La categoría de producto no existe.', 1;
    UPDATE mant.CategoriaProducto SET estado = 0 WHERE idCategoriaProducto = @idCategoriaProducto;
END;
GO

/* ---------- CategoriaInsumo ---------- */
CREATE OR ALTER PROCEDURE mant.usp_CategoriaInsumo_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idCategoriaInsumo, nombre, estado
    FROM mant.CategoriaInsumo
    WHERE @soloActivos = 0 OR estado = 1
    ORDER BY nombre;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_CategoriaInsumo_Insertar
    @nombre NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.CategoriaInsumo (nombre) VALUES (@nombre);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idCategoriaInsumo;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_CategoriaInsumo_Editar
    @idCategoriaInsumo INT,
    @nombre NVARCHAR(50),
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.CategoriaInsumo WHERE idCategoriaInsumo = @idCategoriaInsumo)
        THROW 50001, N'La categoría de insumo no existe.', 1;
    UPDATE mant.CategoriaInsumo
    SET nombre = @nombre, estado = @estado
    WHERE idCategoriaInsumo = @idCategoriaInsumo;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_CategoriaInsumo_Deshabilitar
    @idCategoriaInsumo INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.CategoriaInsumo WHERE idCategoriaInsumo = @idCategoriaInsumo)
        THROW 50001, N'La categoría de insumo no existe.', 1;
    UPDATE mant.CategoriaInsumo SET estado = 0 WHERE idCategoriaInsumo = @idCategoriaInsumo;
END;
GO

/* ---------- Mesa ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Mesa_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idMesa, numero, capacidad, ubicacion, estado
    FROM mant.Mesa
    WHERE @soloActivos = 0 OR estado = 1
    ORDER BY numero;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Mesa_Insertar
    @numero INT,
    @capacidad INT,
    @ubicacion NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Mesa (numero, capacidad, ubicacion) VALUES (@numero, @capacidad, @ubicacion);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idMesa;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Mesa_Editar
    @idMesa INT,
    @numero INT,
    @capacidad INT,
    @ubicacion NVARCHAR(50) = NULL,
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Mesa WHERE idMesa = @idMesa)
        THROW 50001, N'La mesa no existe.', 1;
    UPDATE mant.Mesa
    SET numero = @numero, capacidad = @capacidad, ubicacion = @ubicacion, estado = @estado
    WHERE idMesa = @idMesa;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Mesa_Deshabilitar
    @idMesa INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Mesa WHERE idMesa = @idMesa)
        THROW 50001, N'La mesa no existe.', 1;
    UPDATE mant.Mesa SET estado = 0 WHERE idMesa = @idMesa;
END;
GO

/* ---------- Cliente ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Cliente_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idCliente, documentoIdentidad, nombres, telefono, estado
    FROM mant.Cliente
    WHERE @soloActivos = 0 OR estado = 1
    ORDER BY nombres;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Cliente_Insertar
    @documentoIdentidad VARCHAR(15),
    @nombres NVARCHAR(150),
    @telefono VARCHAR(15) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Cliente (documentoIdentidad, nombres, telefono)
    VALUES (@documentoIdentidad, @nombres, @telefono);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idCliente;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Cliente_Editar
    @idCliente INT,
    @documentoIdentidad VARCHAR(15),
    @nombres NVARCHAR(150),
    @telefono VARCHAR(15) = NULL,
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Cliente WHERE idCliente = @idCliente)
        THROW 50001, N'El cliente no existe.', 1;
    UPDATE mant.Cliente
    SET documentoIdentidad = @documentoIdentidad, nombres = @nombres, telefono = @telefono, estado = @estado
    WHERE idCliente = @idCliente;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Cliente_Deshabilitar
    @idCliente INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Cliente WHERE idCliente = @idCliente)
        THROW 50001, N'El cliente no existe.', 1;
    UPDATE mant.Cliente SET estado = 0 WHERE idCliente = @idCliente;
END;
GO

/* ---------- Proveedor ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Proveedor_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idProveedor, ruc, razonSocial, telefono, correo, direccion, estado
    FROM mant.Proveedor
    WHERE @soloActivos = 0 OR estado = 1
    ORDER BY razonSocial;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Proveedor_Insertar
    @ruc VARCHAR(11),
    @razonSocial NVARCHAR(150),
    @telefono VARCHAR(15) = NULL,
    @correo VARCHAR(100) = NULL,
    @direccion NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Proveedor (ruc, razonSocial, telefono, correo, direccion)
    VALUES (@ruc, @razonSocial, @telefono, @correo, @direccion);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idProveedor;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Proveedor_Editar
    @idProveedor INT,
    @ruc VARCHAR(11),
    @razonSocial NVARCHAR(150),
    @telefono VARCHAR(15) = NULL,
    @correo VARCHAR(100) = NULL,
    @direccion NVARCHAR(200) = NULL,
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Proveedor WHERE idProveedor = @idProveedor)
        THROW 50001, N'El proveedor no existe.', 1;
    UPDATE mant.Proveedor
    SET ruc = @ruc, razonSocial = @razonSocial, telefono = @telefono,
        correo = @correo, direccion = @direccion, estado = @estado
    WHERE idProveedor = @idProveedor;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Proveedor_Deshabilitar
    @idProveedor INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Proveedor WHERE idProveedor = @idProveedor)
        THROW 50001, N'El proveedor no existe.', 1;
    UPDATE mant.Proveedor SET estado = 0 WHERE idProveedor = @idProveedor;
END;
GO

/* ---------- Empleado ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Empleado_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idEmpleado, dni, nombres, cargo, turno, telefono, correo, estado
    FROM mant.Empleado
    WHERE @soloActivos = 0 OR estado = 1
    ORDER BY nombres;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Empleado_Insertar
    @dni VARCHAR(8),
    @nombres NVARCHAR(150),
    @cargo VARCHAR(20),
    @turno VARCHAR(10),
    @telefono VARCHAR(15) = NULL,
    @correo VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Empleado (dni, nombres, cargo, turno, telefono, correo)
    VALUES (@dni, @nombres, @cargo, @turno, @telefono, @correo);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idEmpleado;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Empleado_Editar
    @idEmpleado INT,
    @dni VARCHAR(8),
    @nombres NVARCHAR(150),
    @cargo VARCHAR(20),
    @turno VARCHAR(10),
    @telefono VARCHAR(15) = NULL,
    @correo VARCHAR(100) = NULL,
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Empleado WHERE idEmpleado = @idEmpleado)
        THROW 50001, N'El empleado no existe.', 1;
    UPDATE mant.Empleado
    SET dni = @dni, nombres = @nombres, cargo = @cargo, turno = @turno,
        telefono = @telefono, correo = @correo, estado = @estado
    WHERE idEmpleado = @idEmpleado;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Empleado_Deshabilitar
    @idEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Empleado WHERE idEmpleado = @idEmpleado)
        THROW 50001, N'El empleado no existe.', 1;
    BEGIN TRANSACTION;
        UPDATE mant.Empleado SET estado = 0 WHERE idEmpleado = @idEmpleado;
        UPDATE mant.Usuario  SET estado = 0 WHERE idEmpleado = @idEmpleado;
    COMMIT TRANSACTION;
END;
GO

/* ---------- Usuario ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Usuario_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.idUsuario, u.idEmpleado, e.nombres, e.cargo, u.usuario, u.rol, u.estado
    FROM mant.Usuario u
    INNER JOIN mant.Empleado e ON e.idEmpleado = u.idEmpleado
    WHERE @soloActivos = 0 OR u.estado = 1
    ORDER BY u.usuario;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Usuario_Insertar
    @idEmpleado INT,
    @usuario VARCHAR(30),
    @claveHash VARCHAR(256),
    @rol VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Usuario (idEmpleado, usuario, claveHash, rol)
    VALUES (@idEmpleado, @usuario, @claveHash, @rol);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idUsuario;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Usuario_Editar
    @idUsuario INT,
    @usuario VARCHAR(30),
    @claveHash VARCHAR(256) = NULL,
    @rol VARCHAR(20),
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Usuario WHERE idUsuario = @idUsuario)
        THROW 50001, N'El usuario no existe.', 1;
    UPDATE mant.Usuario
    SET usuario = @usuario,
        claveHash = ISNULL(@claveHash, claveHash),
        rol = @rol,
        estado = @estado
    WHERE idUsuario = @idUsuario;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Usuario_Deshabilitar
    @idUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Usuario WHERE idUsuario = @idUsuario)
        THROW 50001, N'El usuario no existe.', 1;
    UPDATE mant.Usuario SET estado = 0 WHERE idUsuario = @idUsuario;
END;
GO

/* ---------- Producto ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Producto_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT p.idProducto, p.codigo, p.nombre, p.precio,
           p.idCategoriaProducto, c.nombre AS categoria, p.estado
    FROM mant.Producto p
    INNER JOIN mant.CategoriaProducto c ON c.idCategoriaProducto = p.idCategoriaProducto
    WHERE @soloActivos = 0 OR p.estado = 1
    ORDER BY p.nombre;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Producto_Insertar
    @codigo VARCHAR(20),
    @nombre NVARCHAR(100),
    @precio DECIMAL(10,2),
    @idCategoriaProducto INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Producto (codigo, nombre, precio, idCategoriaProducto)
    VALUES (@codigo, @nombre, @precio, @idCategoriaProducto);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idProducto;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Producto_Editar
    @idProducto INT,
    @codigo VARCHAR(20),
    @nombre NVARCHAR(100),
    @precio DECIMAL(10,2),
    @idCategoriaProducto INT,
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Producto WHERE idProducto = @idProducto)
        THROW 50001, N'El producto no existe.', 1;
    UPDATE mant.Producto
    SET codigo = @codigo, nombre = @nombre, precio = @precio,
        idCategoriaProducto = @idCategoriaProducto, estado = @estado
    WHERE idProducto = @idProducto;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Producto_Deshabilitar
    @idProducto INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Producto WHERE idProducto = @idProducto)
        THROW 50001, N'El producto no existe.', 1;
    UPDATE mant.Producto SET estado = 0 WHERE idProducto = @idProducto;
END;
GO

/* ---------- Insumo ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Insumo_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT i.idInsumo, i.codigo, i.nombre, i.unidadMedida,
           i.idCategoriaInsumo, c.nombre AS categoria,
           i.stockAlmacen, i.stockCocina, i.stockMinimo, i.estado
    FROM mant.Insumo i
    INNER JOIN mant.CategoriaInsumo c ON c.idCategoriaInsumo = i.idCategoriaInsumo
    WHERE @soloActivos = 0 OR i.estado = 1
    ORDER BY i.nombre;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Insumo_Insertar
    @codigo VARCHAR(20),
    @nombre NVARCHAR(100),
    @unidadMedida VARCHAR(10),
    @idCategoriaInsumo INT,
    @stockInicial DECIMAL(12,3) = 0,
    @stockMinimo DECIMAL(12,3) = 0
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Insumo (codigo, nombre, unidadMedida, idCategoriaInsumo, stockAlmacen, stockMinimo)
    VALUES (@codigo, @nombre, @unidadMedida, @idCategoriaInsumo, @stockInicial, @stockMinimo);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idInsumo;
END;
GO

-- Los stocks no se editan aquí: solo cambian con los procesos CORE (ingreso, salida, nota, ajuste).
CREATE OR ALTER PROCEDURE mant.usp_Insumo_Editar
    @idInsumo INT,
    @codigo VARCHAR(20),
    @nombre NVARCHAR(100),
    @unidadMedida VARCHAR(10),
    @idCategoriaInsumo INT,
    @stockMinimo DECIMAL(12,3),
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Insumo WHERE idInsumo = @idInsumo)
        THROW 50001, N'El insumo no existe.', 1;
    UPDATE mant.Insumo
    SET codigo = @codigo, nombre = @nombre, unidadMedida = @unidadMedida,
        idCategoriaInsumo = @idCategoriaInsumo, stockMinimo = @stockMinimo, estado = @estado
    WHERE idInsumo = @idInsumo;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Insumo_Deshabilitar
    @idInsumo INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Insumo WHERE idInsumo = @idInsumo)
        THROW 50001, N'El insumo no existe.', 1;
    UPDATE mant.Insumo SET estado = 0 WHERE idInsumo = @idInsumo;
END;
GO

/* ---------- Receta ---------- */
CREATE OR ALTER PROCEDURE mant.usp_Receta_Listar
    @soloActivos BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SELECT r.idReceta, r.idProducto, p.nombre AS producto, r.descripcion, r.estado
    FROM mant.Receta r
    INNER JOIN mant.Producto p ON p.idProducto = r.idProducto
    WHERE @soloActivos = 0 OR r.estado = 1
    ORDER BY p.nombre;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Receta_Insertar
    @idProducto INT,
    @descripcion NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.Receta (idProducto, descripcion) VALUES (@idProducto, @descripcion);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idReceta;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Receta_Editar
    @idReceta INT,
    @descripcion NVARCHAR(200) = NULL,
    @estado BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Receta WHERE idReceta = @idReceta)
        THROW 50001, N'La receta no existe.', 1;
    UPDATE mant.Receta SET descripcion = @descripcion, estado = @estado WHERE idReceta = @idReceta;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_Receta_Deshabilitar
    @idReceta INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.Receta WHERE idReceta = @idReceta)
        THROW 50001, N'La receta no existe.', 1;
    UPDATE mant.Receta SET estado = 0 WHERE idReceta = @idReceta;
END;
GO

/* ---------- RecetaDetalle (insumos de cada receta) ---------- */
CREATE OR ALTER PROCEDURE mant.usp_RecetaDetalle_Listar
    @idReceta INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT d.idRecetaDetalle, d.idInsumo, i.nombre AS insumo, i.unidadMedida, d.cantidad
    FROM mant.RecetaDetalle d
    INNER JOIN mant.Insumo i ON i.idInsumo = d.idInsumo
    WHERE d.idReceta = @idReceta
    ORDER BY i.nombre;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_RecetaDetalle_Insertar
    @idReceta INT,
    @idInsumo INT,
    @cantidad DECIMAL(12,3)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO mant.RecetaDetalle (idReceta, idInsumo, cantidad) VALUES (@idReceta, @idInsumo, @cantidad);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idRecetaDetalle;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_RecetaDetalle_Editar
    @idRecetaDetalle INT,
    @cantidad DECIMAL(12,3)
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.RecetaDetalle WHERE idRecetaDetalle = @idRecetaDetalle)
        THROW 50001, N'El insumo de la receta no existe.', 1;
    UPDATE mant.RecetaDetalle SET cantidad = @cantidad WHERE idRecetaDetalle = @idRecetaDetalle;
END;
GO

CREATE OR ALTER PROCEDURE mant.usp_RecetaDetalle_Eliminar
    @idRecetaDetalle INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM mant.RecetaDetalle WHERE idRecetaDetalle = @idRecetaDetalle)
        THROW 50001, N'El insumo de la receta no existe.', 1;
    DELETE FROM mant.RecetaDetalle WHERE idRecetaDetalle = @idRecetaDetalle;
END;
GO
