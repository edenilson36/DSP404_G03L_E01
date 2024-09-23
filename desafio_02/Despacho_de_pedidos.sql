CREATE DATABASE Despacho_de_pedidos;

USE Despacho_de_pedidos;

CREATE TABLE Clientes (
    ClienteId INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Dirección VARCHAR(200),
    Teléfono VARCHAR(15),
    CorreoElectrónico VARCHAR(100)
);

CREATE TABLE Empleados (
    EmpleadoId INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Cargo VARCHAR(50),
    FechaContratación DATE,
    Teléfono VARCHAR(15),
    CorreoElectrónico VARCHAR(100)
);

CREATE TABLE Menú (
    PlatoId INT PRIMARY KEY IDENTITY(1,1),
    NombrePlato VARCHAR(100),
    Descripción VARCHAR(255),
    Precio DECIMAL(10,2)
);

CREATE TABLE Pedidos (
    PedidoId INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT FOREIGN KEY REFERENCES Clientes(ClienteId),
    EmpleadoId INT FOREIGN KEY REFERENCES Empleados(EmpleadoId),
    FechaPedido DATE,
    Estado VARCHAR(50),
    FormaPago VARCHAR(50),
    Comentarios VARCHAR(255)
);

CREATE TABLE DetallePedido (
    DetallePedidoId INT PRIMARY KEY IDENTITY(1,1),
    PedidoId INT FOREIGN KEY REFERENCES Pedidos(PedidoId),
    PlatoId INT FOREIGN KEY REFERENCES Menú(PlatoId),
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2)
);


