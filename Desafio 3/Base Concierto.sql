-- Crear la base de datos
CREATE DATABASE SistemaVentaEntradas;
USE SistemaVentaEntradas;

-- Crear tabla Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL
);

-- Crear tabla Conciertos
CREATE TABLE Conciertos (
    ConciertoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Fecha DATE NOT NULL,
    Lugar NVARCHAR(100) NOT NULL
);

-- Crear tabla Localidades
CREATE TABLE Localidades (
    LocalidadID INT PRIMARY KEY IDENTITY(1,1),
    ConciertoID INT NOT NULL,
    TipoLocalidad NVARCHAR(50) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    CantidadDisponible INT NOT NULL,
    FOREIGN KEY (ConciertoID) REFERENCES Conciertos(ConciertoID)
);

-- Crear tabla Entradas
CREATE TABLE Entradas (
    EntradaID INT PRIMARY KEY IDENTITY(1,1),
    UsuarioID INT NOT NULL,
    ConciertoID INT NOT NULL,
    LocalidadID INT NOT NULL,
    FechaCompra DATETIME DEFAULT GETDATE(),
    Cantidad INT NOT NULL,
    TotalPago DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    FOREIGN KEY (ConciertoID) REFERENCES Conciertos(ConciertoID),
    FOREIGN KEY (LocalidadID) REFERENCES Localidades(LocalidadID)
);


SELECT * FROM Usuarios;
SELECT * FROM Conciertos;
SELECT * FROM Localidades;
SELECT * FROM Entradas;

