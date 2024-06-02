create database hospital
Use hospital;

create table AgregarPaciente
(
Nombre varchar (150),
Correo varchar (300),
Contact bigint,
Edad int,
Sexo varchar (20),
Tipo_sangre varchar (20),
Enfermedades varchar (400),
pid bigint UNIQUE
);

SELECT * FROM AgregarPaciente;

CREATE TABLE Citas (
    pid INT PRIMARY KEY, 
    NombrePaciente NVARCHAR(100) NOT NULL,
    FechaCita DATE NOT NULL,
    HoraCita TIME NOT NULL,
    MotivoCita NVARCHAR(255) NOT NULL
);


INSERT INTO Citas (NombrePaciente, FechaCita, HoraCita, MotivoCita)
VALUES ('Juan Pérez', '2024-05-30', '10:00:00', 'Consulta de rutina'),
       ('María García', '2024-06-01', '14:30:00', 'Control de presión arterial'),
       ('Carlos Martínez', '2024-06-03', '11:15:00', 'Extracción de muela');

	   SELECT * FROM Citas;
	INSERT INTO AgregarPaciente (Nombre, Correo, Contact, Edad, Sexo, Tipo_sangre, Enfermedades, pid)
VALUES ('Ana López', 'ana@example.com', 1234567890, 30, 'Femenino', 'O+', 'Ninguna', 1),
       ('Pedro Ramírez', 'pedro@example.com', 9876543210, 45, 'Masculino', 'A-', 'Hipertensión', 2),
       ('María Torres', 'maria@example.com', 555444333, 25, 'Femenino', 'B+', 'Asma, Diabetes', 3);

CREATE TABLE PacienteMas (
    Sintomas NVARCHAR(255) NOT NULL,
    Procedimiento_med NVARCHAR(255) NOT NULL,
    Diagnosis NVARCHAR(255) NOT NULL,
    Alergias NVARCHAR(255) NOT NULL,
    Medicamentos NVARCHAR(255) NOT NULL,
    pid INT NOT NULL,
    CONSTRAINT FK_PacienteMas_Citas FOREIGN KEY (pid) REFERENCES Citas(pid)
);


INSERT INTO PacienteMas(Sintomas, Procedimiento_med, Diagnosis , Alergias, Medicamentos)
VALUES ('Fiebre', 'ninguno', 'Gripe', 'Penicilina', 'acetaminofen cada ocho horas');

CREATE TABLE NotasClinicas (
    pid INT NOT NULL,
    Sintomas NVARCHAR(MAX) NOT NULL,
    Observaciones NVARCHAR(MAX),
    DiagnosticoProvisional NVARCHAR(MAX),
    PlanTratamiento NVARCHAR(MAX)
);
CREATE TABLE Mensajes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Emisor NVARCHAR(100) NOT NULL,
    MensajeTexto NVARCHAR(MAX) NOT NULL,
);









