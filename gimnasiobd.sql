-- Creación de la base de datos
CREATE DATABASE GimnasioDB;
GO
USE GimnasioDB;
GO

-- 1. Tabla Cliente
CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre_cliente VARCHAR(100) NOT NULL,
    correo_electronico VARCHAR(100) UNIQUE NOT NULL,
    celular VARCHAR(15) CHECK (ISNUMERIC(celular) = 1)
);

-- 2. Tabla Instructor
CREATE TABLE Instructor (
    id_instructor INT IDENTITY(1,1) PRIMARY KEY,
    nombre_instructor VARCHAR(100) NOT NULL
);

-- 3. Tabla [Plan]
CREATE TABLE [Plan] (
    id_plan INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(255) NOT NULL,
    horas_semanales INT CHECK (horas_semanales > 0),
    costo_mensual DECIMAL(8, 2) CHECK (costo_mensual > 0)
);

-- 4. Tabla Beneficio
CREATE TABLE Beneficio (
    id_beneficio INT IDENTITY(1,1) PRIMARY KEY,
    descripcion_beneficio VARCHAR(100) NOT NULL
);

-- 5. Tabla Clase
CREATE TABLE Clase (
    id_clase INT IDENTITY(1,1) PRIMARY KEY,
    descripcion_clase VARCHAR(100) NOT NULL
);

-- 6. Tabla Usuario
CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre_usuario VARCHAR(50) UNIQUE NOT NULL,
    contrasena VARCHAR(255) NOT NULL,
    rol VARCHAR(20) CHECK (rol = 'Administrador'),
    id_cliente INT,
    id_instructor INT,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE SET NULL,
    FOREIGN KEY (id_instructor) REFERENCES Instructor(id_instructor) ON DELETE SET NULL
);

-- 7. Tabla Plan_Beneficio
CREATE TABLE Plan_Beneficio (
    id_plan INT,
    id_beneficio INT,
    PRIMARY KEY (id_plan, id_beneficio),
    FOREIGN KEY (id_plan) REFERENCES [Plan](id_plan) ON DELETE CASCADE,
    FOREIGN KEY (id_beneficio) REFERENCES Beneficio(id_beneficio) ON DELETE CASCADE
);

-- 8. Tabla Horario_Clase
CREATE TABLE Horario_Clase (
    id_horario_clase INT IDENTITY(1,1) PRIMARY KEY,
    id_clase INT,
    id_grupo INT,
    dia_semana VARCHAR(20) CHECK (dia_semana IN ('Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado', 'Domingo')),
    hora TIME NOT NULL,
    id_instructor INT,
    max_participantes INT CHECK (max_participantes > 0),
    FOREIGN KEY (id_clase) REFERENCES Clase(id_clase) ON DELETE CASCADE,
    FOREIGN KEY (id_instructor) REFERENCES Instructor(id_instructor) ON DELETE SET NULL
);

-- 9. Tabla Afiliacion
CREATE TABLE Afiliacion (
    id_afiliacion INT IDENTITY(1,1) PRIMARY KEY,
    id_plan INT,
    id_instructor INT,
    id_cliente INT,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    FOREIGN KEY (id_plan) REFERENCES [Plan](id_plan) ON DELETE CASCADE,
    FOREIGN KEY (id_instructor) REFERENCES Instructor(id_instructor) ON DELETE SET NULL,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE CASCADE
);

-- 10. Tabla Inscripcion_Clase
CREATE TABLE Inscripcion_Clase (
    id_inscripcion INT IDENTITY(1,1) PRIMARY KEY,
    id_grupo INT,
    id_cliente INT,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente) ON DELETE CASCADE
);

-- Insertar datos de prueba
-- Instructor
INSERT INTO Instructor (nombre_instructor) VALUES ('Juan Pérez');

-- Plan
INSERT INTO [Plan] (descripcion, horas_semanales, costo_mensual) VALUES ('Plan Básico', 5, 25.99);

-- Beneficio
INSERT INTO Beneficio (descripcion_beneficio) VALUES ('Lockers y Duchas');

-- Clase
INSERT INTO Clase (descripcion_clase) VALUES ('Yoga');

-- Cliente
INSERT INTO Cliente (nombre_cliente, correo_electronico, celular) VALUES ('Ana Gómez', 'ana.gomez@email.com', '123456789');

-- Usuario (Cliente)
INSERT INTO Usuario (nombre_usuario, contrasena, rol, id_cliente, id_instructor) 
VALUES ('admin', 'contraseña123', 'Administrador', NULL, NULL);

-- Afiliacion
INSERT INTO Afiliacion (id_plan, id_instructor, id_cliente, fecha_inicio, fecha_fin) VALUES (1, 1, 1, '2024-01-01', '2024-12-31');

-- Plan_Beneficio (asignación de beneficio al plan)
INSERT INTO Plan_Beneficio (id_plan, id_beneficio) VALUES (1, 1);

-- Horario_Clase
INSERT INTO Horario_Clase (id_clase, id_grupo, dia_semana, hora, id_instructor, max_participantes) VALUES (1, 101, 'Lunes', '09:00:00', 1, 20);

-- Inscripcion_Clase
INSERT INTO Inscripcion_Clase (id_grupo, id_cliente, fecha_inicio, fecha_fin) VALUES (101, 1, '2024-02-01', '2024-02-28');
