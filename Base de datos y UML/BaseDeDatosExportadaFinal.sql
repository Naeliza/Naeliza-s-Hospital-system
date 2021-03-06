USE [master]
GO
/****** Object:  Database [FinalProg1]    Script Date: 7/27/2020 7:02:35 PM ******/
CREATE DATABASE [FinalProg1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalProg1', FILENAME = N'D:\program files\MSSQL15.MSSQLSERVER\MSSQL\DATA\FinalProg1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinalProg1_log', FILENAME = N'D:\program files\MSSQL15.MSSQLSERVER\MSSQL\DATA\FinalProg1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FinalProg1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalProg1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinalProg1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinalProg1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinalProg1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinalProg1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinalProg1] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinalProg1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinalProg1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinalProg1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinalProg1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinalProg1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinalProg1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinalProg1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinalProg1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinalProg1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinalProg1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FinalProg1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinalProg1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinalProg1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinalProg1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinalProg1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinalProg1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinalProg1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinalProg1] SET RECOVERY FULL 
GO
ALTER DATABASE [FinalProg1] SET  MULTI_USER 
GO
ALTER DATABASE [FinalProg1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinalProg1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinalProg1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinalProg1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FinalProg1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FinalProg1', N'ON'
GO
ALTER DATABASE [FinalProg1] SET QUERY_STORE = OFF
GO
USE [FinalProg1]
GO
/****** Object:  Table [dbo].[Alta_Medica]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alta_Medica](
	[ID_Alta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Internamiento] [int] NOT NULL,
	[Fecha_Salida] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Alta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas_Medicas]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas_Medicas](
	[ID_Cita] [int] IDENTITY(1,1) NOT NULL,
	[ID_Medico] [int] NOT NULL,
	[ID_Paciente] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Hora] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Crud_Habitaciones]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crud_Habitaciones](
	[ID_Habitacion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[tipo] [varchar](60) NULL,
	[Precio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Crud_Medicos]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crud_Medicos](
	[ID_Medico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](60) NULL,
	[Exequatur] [varchar](6) NULL,
	[Especialidad] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Crud_Pacientes]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crud_Pacientes](
	[ID_Paciente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](13) NULL,
	[Nombre] [varchar](60) NULL,
	[Asegurado] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingresos_Internamientos]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos_Internamientos](
	[ID_Internamiento] [int] IDENTITY(1,1) NOT NULL,
	[ID_Paciente] [int] NOT NULL,
	[ID_Habitacion] [int] NOT NULL,
	[Fecha_Ingreso] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Internamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](60) NULL,
	[Contraseña] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alta_Medica] ON 

INSERT [dbo].[Alta_Medica] ([ID_Alta], [ID_Internamiento], [Fecha_Salida]) VALUES (1, 2, CAST(N'2020-08-09' AS Date))
INSERT [dbo].[Alta_Medica] ([ID_Alta], [ID_Internamiento], [Fecha_Salida]) VALUES (5, 3, CAST(N'2020-07-28' AS Date))
INSERT [dbo].[Alta_Medica] ([ID_Alta], [ID_Internamiento], [Fecha_Salida]) VALUES (6, 4, CAST(N'2020-07-31' AS Date))
INSERT [dbo].[Alta_Medica] ([ID_Alta], [ID_Internamiento], [Fecha_Salida]) VALUES (7, 5, CAST(N'2020-08-01' AS Date))
INSERT [dbo].[Alta_Medica] ([ID_Alta], [ID_Internamiento], [Fecha_Salida]) VALUES (8, 6, CAST(N'2020-09-25' AS Date))
SET IDENTITY_INSERT [dbo].[Alta_Medica] OFF
GO
SET IDENTITY_INSERT [dbo].[Citas_Medicas] ON 

INSERT [dbo].[Citas_Medicas] ([ID_Cita], [ID_Medico], [ID_Paciente], [Fecha], [Hora]) VALUES (1, 4, 5, CAST(N'2020-07-31' AS Date), N'17:15')
INSERT [dbo].[Citas_Medicas] ([ID_Cita], [ID_Medico], [ID_Paciente], [Fecha], [Hora]) VALUES (2, 5, 6, CAST(N'2020-07-25' AS Date), N'8:30')
INSERT [dbo].[Citas_Medicas] ([ID_Cita], [ID_Medico], [ID_Paciente], [Fecha], [Hora]) VALUES (3, 2, 1, CAST(N'2020-07-28' AS Date), N'17:30')
SET IDENTITY_INSERT [dbo].[Citas_Medicas] OFF
GO
SET IDENTITY_INSERT [dbo].[Crud_Habitaciones] ON 

INSERT [dbo].[Crud_Habitaciones] ([ID_Habitacion], [Numero], [tipo], [Precio]) VALUES (1, 2626, N'Doble', 2000)
INSERT [dbo].[Crud_Habitaciones] ([ID_Habitacion], [Numero], [tipo], [Precio]) VALUES (2, 303, N'Privada', 5000)
INSERT [dbo].[Crud_Habitaciones] ([ID_Habitacion], [Numero], [tipo], [Precio]) VALUES (3, 102, N'Doble', 2000)
INSERT [dbo].[Crud_Habitaciones] ([ID_Habitacion], [Numero], [tipo], [Precio]) VALUES (4, 1103, N'Suite', 15000)
SET IDENTITY_INSERT [dbo].[Crud_Habitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Crud_Medicos] ON 

INSERT [dbo].[Crud_Medicos] ([ID_Medico], [Nombre], [Exequatur], [Especialidad]) VALUES (1, N'Whitney', N'060102', N'Forense')
INSERT [dbo].[Crud_Medicos] ([ID_Medico], [Nombre], [Exequatur], [Especialidad]) VALUES (2, N'Alvaro', N'070102', N'Cirujano Plastico')
INSERT [dbo].[Crud_Medicos] ([ID_Medico], [Nombre], [Exequatur], [Especialidad]) VALUES (3, N'David', N'638573', N'Medico General')
INSERT [dbo].[Crud_Medicos] ([ID_Medico], [Nombre], [Exequatur], [Especialidad]) VALUES (4, N'Eymi', N'110602', N'Pediatra')
INSERT [dbo].[Crud_Medicos] ([ID_Medico], [Nombre], [Exequatur], [Especialidad]) VALUES (5, N'Abel', N'061116', N'Neurologo')
INSERT [dbo].[Crud_Medicos] ([ID_Medico], [Nombre], [Exequatur], [Especialidad]) VALUES (6, N'Alex', N'057701', N'Pediatra')
SET IDENTITY_INSERT [dbo].[Crud_Medicos] OFF
GO
SET IDENTITY_INSERT [dbo].[Crud_Pacientes] ON 

INSERT [dbo].[Crud_Pacientes] ([ID_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (1, N'402-2365478-9', N'Enrique', N'Asegurado')
INSERT [dbo].[Crud_Pacientes] ([ID_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (2, N'402-1234158-6', N'Carlos', N'Asegurado')
INSERT [dbo].[Crud_Pacientes] ([ID_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (3, N'402-7359517-2', N'Milciades', N'No Asegurado')
INSERT [dbo].[Crud_Pacientes] ([ID_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (4, N'402-0500057-3', N'Elian', N'Asegurado')
INSERT [dbo].[Crud_Pacientes] ([ID_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (5, N'402-3513723-6', N'Naomi', N'Asegurado')
INSERT [dbo].[Crud_Pacientes] ([ID_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (6, N'111-1111111-1', N'Carlo', N'Asegurado')
SET IDENTITY_INSERT [dbo].[Crud_Pacientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Ingresos_Internamientos] ON 

INSERT [dbo].[Ingresos_Internamientos] ([ID_Internamiento], [ID_Paciente], [ID_Habitacion], [Fecha_Ingreso]) VALUES (2, 5, 1, CAST(N'2020-07-25' AS Date))
INSERT [dbo].[Ingresos_Internamientos] ([ID_Internamiento], [ID_Paciente], [ID_Habitacion], [Fecha_Ingreso]) VALUES (3, 1, 3, CAST(N'2020-07-26' AS Date))
INSERT [dbo].[Ingresos_Internamientos] ([ID_Internamiento], [ID_Paciente], [ID_Habitacion], [Fecha_Ingreso]) VALUES (4, 4, 2, CAST(N'2020-07-26' AS Date))
INSERT [dbo].[Ingresos_Internamientos] ([ID_Internamiento], [ID_Paciente], [ID_Habitacion], [Fecha_Ingreso]) VALUES (5, 6, 4, CAST(N'2020-07-25' AS Date))
INSERT [dbo].[Ingresos_Internamientos] ([ID_Internamiento], [ID_Paciente], [ID_Habitacion], [Fecha_Ingreso]) VALUES (6, 1, 1, CAST(N'2020-08-15' AS Date))
SET IDENTITY_INSERT [dbo].[Ingresos_Internamientos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [Nombre], [Contraseña]) VALUES (1, N'Naomi', N'123n')
INSERT [dbo].[Usuarios] ([ID], [Nombre], [Contraseña]) VALUES (2, N'Juan', N'123j')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Alta_Medica]  WITH CHECK ADD  CONSTRAINT [FK_internamiento_altas] FOREIGN KEY([ID_Internamiento])
REFERENCES [dbo].[Ingresos_Internamientos] ([ID_Internamiento])
GO
ALTER TABLE [dbo].[Alta_Medica] CHECK CONSTRAINT [FK_internamiento_altas]
GO
ALTER TABLE [dbo].[Citas_Medicas]  WITH CHECK ADD  CONSTRAINT [FK_medico_citas] FOREIGN KEY([ID_Medico])
REFERENCES [dbo].[Crud_Medicos] ([ID_Medico])
GO
ALTER TABLE [dbo].[Citas_Medicas] CHECK CONSTRAINT [FK_medico_citas]
GO
ALTER TABLE [dbo].[Citas_Medicas]  WITH CHECK ADD  CONSTRAINT [FK_paciente_citas] FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[Crud_Pacientes] ([ID_Paciente])
GO
ALTER TABLE [dbo].[Citas_Medicas] CHECK CONSTRAINT [FK_paciente_citas]
GO
ALTER TABLE [dbo].[Ingresos_Internamientos]  WITH CHECK ADD  CONSTRAINT [FK_habitacion_internamiento] FOREIGN KEY([ID_Habitacion])
REFERENCES [dbo].[Crud_Habitaciones] ([ID_Habitacion])
GO
ALTER TABLE [dbo].[Ingresos_Internamientos] CHECK CONSTRAINT [FK_habitacion_internamiento]
GO
ALTER TABLE [dbo].[Ingresos_Internamientos]  WITH CHECK ADD  CONSTRAINT [FK_paciente_internamiento] FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[Crud_Pacientes] ([ID_Paciente])
GO
ALTER TABLE [dbo].[Ingresos_Internamientos] CHECK CONSTRAINT [FK_paciente_internamiento]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarAlta]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ActualizarAlta]

@IDAlta Int,
@IDInter int,
@FechaSal Date

as

if exists (Select ID_Alta from Alta_Medica where ID_Alta=@IDAlta)
update Alta_Medica set ID_Internamiento=@IDInter, Fecha_Salida=@FechaSal where ID_Alta=@IDAlta
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCitas]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ActualizarCitas]

@IDCita Int,
@IDDoctor int,
@IDPaciente int,
@Fecha Date,
@Hora varchar(6)

as

if exists (Select ID_Cita from Citas_Medicas where ID_Cita=@IDCita)
update Citas_Medicas set ID_Medico=@IDDoctor,ID_Paciente=@IDPaciente, Fecha=@Fecha, Hora=@Hora where ID_Cita=@IDCita

--Eliminar
GO
/****** Object:  StoredProcedure [dbo].[ActualizarDoctores]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ActualizarDoctores]

@ID_Medico int,
@Nombre Varchar(60),
@Exequatur varchar(6),
@Especialidad Varchar(60)

as

if exists (Select ID_Medico from Crud_Medicos where ID_Medico = @ID_Medico)
update Crud_Medicos set Nombre=@Nombre,Exequatur=@Exequatur,Especialidad=@Especialidad where ID_Medico=@ID_Medico


--Eliminar
GO
/****** Object:  StoredProcedure [dbo].[ActualizarHabitacion]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ActualizarHabitacion]

@ID_Habitacion int,
@Numero int,
@tipo Varchar(60),
@Precio int

as

if exists (Select ID_Habitacion from Crud_Habitaciones where ID_Habitacion=@ID_Habitacion)
update Crud_Habitaciones set Numero=@Numero,tipo=@tipo, Precio=@Precio where ID_Habitacion=@ID_Habitacion

--Eliminar
GO
/****** Object:  StoredProcedure [dbo].[ActualizarInter]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ActualizarInter]

@IDInter Int,
@IDHabi int,
@IDPaciente int,
@Fecha Date

as

if exists (Select ID_Internamiento from Ingresos_Internamientos where ID_Internamiento=@IDInter)
update Ingresos_Internamientos set ID_Habitacion=@IDHabi,ID_Paciente=@IDPaciente, Fecha_Ingreso=@Fecha where ID_Internamiento=@IDInter

--Eliminar
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPacientes]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  Procedure [dbo].[ActualizarPacientes]

@ID_Paciente int,
@Cedula Varchar(13),
@Nombre Varchar(60),
@Asegurado varchar(60)

as

if exists (Select ID_Paciente from Crud_Pacientes where ID_Paciente = @ID_Paciente)
update Crud_Pacientes set Nombre=@Nombre,Cedula=@Cedula, Asegurado=@Asegurado  where ID_Paciente = @ID_Paciente

--Eliminar
GO
/****** Object:  StoredProcedure [dbo].[EliminarAlta]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EliminarAlta]

@IDAlta int

as

delete from Alta_Medica where ID_Alta = @IDAlta
GO
/****** Object:  StoredProcedure [dbo].[EliminarCitas]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EliminarCitas]

@IDCita int

as

delete from Citas_Medicas where ID_Cita = @IDCita

--Internamiento

--Insertar
GO
/****** Object:  StoredProcedure [dbo].[EliminarDoctores]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EliminarDoctores]

@ID_Medico int

as

delete from Crud_Medicos where ID_Medico = @ID_Medico

--Pacientes CRUD

--Insertar
GO
/****** Object:  StoredProcedure [dbo].[EliminarHabitacion]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EliminarHabitacion]

@ID_Habitacion int

as

delete from Crud_Habitaciones where ID_Habitacion = @ID_Habitacion

--Citas

--Insertar
GO
/****** Object:  StoredProcedure [dbo].[EliminarInter]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EliminarInter]

@IDInter int

as

delete from Ingresos_Internamientos where ID_Internamiento = @IDInter

--Alta Medica

--Insertar
GO
/****** Object:  StoredProcedure [dbo].[EliminarPacientes]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EliminarPacientes]

@ID_Paciente int

as

delete from Crud_Pacientes where ID_Paciente = @ID_Paciente

--Habitaciones CRUD

--Insertar
GO
/****** Object:  StoredProcedure [dbo].[FacturarAltaFecha]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FacturarAltaFecha]	

@Fecha varchar(60)

as
Begin

Select AL.ID_Alta as 'ID', Hab.Numero As 'Habitacion', Hab.tipo as 'Tipo', Hab.Precio as 'Precio', P.Nombre as 'Paciente', 
Inter.Fecha_Ingreso as 'Ingreso', Al.Fecha_Salida as 'Salida' 
From Alta_Medica AL
Inner Join Ingresos_Internamientos Inter on (AL.ID_Internamiento = Inter.ID_Internamiento)
Inner Join Crud_Habitaciones Hab on (Inter.ID_Habitacion = Hab.ID_Habitacion)
inner join Crud_Pacientes P on (Inter.ID_Paciente = P.ID_Paciente) where AL.Fecha_Salida = @Fecha
Group By Al.ID_Alta, Hab.Numero, Hab.tipo, Hab.Precio, P.Nombre, Inter.Fecha_Ingreso, AL.Fecha_Salida 

End
GO
/****** Object:  StoredProcedure [dbo].[FacturarAltaPaciente]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FacturarAltaPaciente]

@Paciente varchar(60)

as
Begin

Select AL.ID_Alta as 'ID', Hab.Numero As 'Habitacion', Hab.tipo as 'Tipo', Hab.Precio as 'Precio', P.Nombre as 'Paciente', 
Inter.Fecha_Ingreso as 'Ingreso', Al.Fecha_Salida as 'Salida'
From Alta_Medica AL
Inner Join Ingresos_Internamientos Inter on (AL.ID_Internamiento = Inter.ID_Internamiento)
Inner Join Crud_Habitaciones Hab on (Inter.ID_Habitacion = Hab.ID_Habitacion)
inner join Crud_Pacientes P on (Inter.ID_Paciente = P.ID_Paciente) where P.Nombre = @Paciente
Group By Al.ID_Alta, Hab.Numero, Hab.tipo, Hab.Precio, P.Nombre, Inter.Fecha_Ingreso, AL.Fecha_Salida 

End
GO
/****** Object:  StoredProcedure [dbo].[FacturarCitasDoctor]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FacturarCitasDoctor]

@Doctor Varchar(60)

as

begin

Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha,
Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico)
Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente) where D.Nombre like @Doctor

end
GO
/****** Object:  StoredProcedure [dbo].[FacturarCitasFechas]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FacturarCitasFechas]

@Fecha Varchar(60)

as

begin

Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha,
Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico)
Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente) where Ci.Fecha like @Fecha

end
GO
/****** Object:  StoredProcedure [dbo].[FacturarCitasPaciente]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FacturarCitasPaciente]

@Paciente Varchar(60)

as

begin

Select Ci.ID_Cita, D.Nombre 'Doctor', P.Nombre 'Paciente', Ci.Fecha,
Ci.Hora From Citas_Medicas Ci Inner Join Crud_Medicos D on(D.ID_Medico = Ci.ID_Medico)
Inner Join Crud_Pacientes P on(P.ID_Paciente = Ci.ID_Paciente) where P.Nombre like @Paciente

end
GO
/****** Object:  StoredProcedure [dbo].[FacturarHabitaciones]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FacturarHabitaciones]

@Tipo varchar(60)

as
Begin

SELECT * FROM Crud_Habitaciones where tipo like @Tipo

End
GO
/****** Object:  StoredProcedure [dbo].[FacturarIngresosFechas]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FacturarIngresosFechas]

@Fecha Varchar(60)

as

begin

Select Ig.ID_Internamiento, P.Nombre as 'Paciente', H.Numero as 'Habitacion', Ig.Fecha_Ingreso as 'Fecha' 
From Ingresos_Internamientos Ig
Inner Join Crud_Pacientes P on(P.ID_Paciente = Ig.ID_Paciente)
Inner Join Crud_Habitaciones H on(H.ID_Habitacion = Ig.ID_Habitacion) where Ig.Fecha_Ingreso like @Fecha

end
GO
/****** Object:  StoredProcedure [dbo].[FacturarIngresosTipo]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FacturarIngresosTipo]

@Tipo Varchar(60)

as

begin

Select Ig.ID_Internamiento, P.Nombre as 'Paciente', H.Numero as 'Habitacion', Ig.Fecha_Ingreso as 'Fecha' 
From Ingresos_Internamientos Ig
Inner Join Crud_Pacientes P on(P.ID_Paciente = Ig.ID_Paciente)
Inner Join Crud_Habitaciones H on(H.ID_Habitacion = Ig.ID_Habitacion) where H.tipo like @Tipo

end
GO
/****** Object:  StoredProcedure [dbo].[FacturarMedicosEspecialidad]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[FacturarMedicosEspecialidad]

@Especialidad varchar(60)

as
Begin

SELECT * FROM Crud_Medicos where Especialidad like @Especialidad

End
GO
/****** Object:  StoredProcedure [dbo].[FacturarMedicosNombre]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[FacturarMedicosNombre]

@Nombre varchar(60)

as
Begin

SELECT * FROM Crud_Medicos where Nombre like @Nombre

End

GO
/****** Object:  StoredProcedure [dbo].[FacturarPacientesAsegurado]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FacturarPacientesAsegurado]

@Asegurado varchar(60)

as
Begin

SELECT * FROM Crud_Pacientes where Asegurado like @Asegurado

End
GO
/****** Object:  StoredProcedure [dbo].[FacturarPacientesCedula]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FacturarPacientesCedula]

@Cedula varchar(60)

as
Begin

SELECT * FROM Crud_Pacientes where Cedula like @Cedula

End
GO
/****** Object:  StoredProcedure [dbo].[FacturarPacientesNombre]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FacturarPacientesNombre]

@Nombre varchar(60)

as
Begin

SELECT * FROM Crud_Pacientes where Nombre like @Nombre

End
GO
/****** Object:  StoredProcedure [dbo].[InsertarAlta]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarAlta]

@IDInter int,
@FechaSal Date

as

insert into Alta_Medica(ID_Internamiento, Fecha_Salida) values(@IDInter, @FechaSal)

--Actualizar
GO
/****** Object:  StoredProcedure [dbo].[InsertarCitas]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarCitas]

@IDDoctor int,
@IDPaciente int,
@Fecha Date,
@Hora varchar(6)

as

insert into Citas_Medicas (ID_Medico,ID_Paciente,Fecha, Hora) values(@IDDoctor, @IDPaciente, @Fecha, @Hora)

--Actualizar
GO
/****** Object:  StoredProcedure [dbo].[InsertarDoctores]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarDoctores]

@Nombre Varchar(60),
@Exequatur varchar(6),
@Especialidad Varchar(60)

as

insert into Crud_Medicos(Nombre,Exequatur,Especialidad) values(@Nombre, @Exequatur,@Especialidad)

--Actualizar
GO
/****** Object:  StoredProcedure [dbo].[InsertarHabitacion]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarHabitacion]

@Numero int,
@tipo Varchar(60),
@Precio int

as

insert into Crud_Habitaciones(Numero,tipo,Precio) values(@Numero,@tipo,@Precio)

--Actualizar
GO
/****** Object:  StoredProcedure [dbo].[InsertarInter]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarInter]

@IDHabi int,
@IDPaciente int,
@Fecha Date

as

insert into Ingresos_Internamientos(ID_Habitacion,ID_Paciente,Fecha_Ingreso) values(@IDHabi, @IDPaciente, @Fecha)

--Actualizar
GO
/****** Object:  StoredProcedure [dbo].[InsertarPacientes]    Script Date: 7/27/2020 7:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarPacientes]

@Cedula Varchar(13),
@Nombre Varchar(60),
@Asegurado varchar(60)

as

insert into Crud_Pacientes(Nombre,Cedula, Asegurado) values(@Nombre, @Cedula,@Asegurado)

--Actualizar
GO
USE [master]
GO
ALTER DATABASE [FinalProg1] SET  READ_WRITE 
GO
