USE [master]
GO
/****** Object:  Database [Veterinaria]    Script Date: 22/10/2022 20:22:34 ******/
CREATE DATABASE [Veterinaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veterinaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Veterinaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Veterinaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Veterinaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Veterinaria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veterinaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veterinaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veterinaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veterinaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veterinaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veterinaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veterinaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veterinaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veterinaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veterinaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veterinaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veterinaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veterinaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veterinaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veterinaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veterinaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veterinaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veterinaria] SET RECOVERY FULL 
GO
ALTER DATABASE [Veterinaria] SET  MULTI_USER 
GO
ALTER DATABASE [Veterinaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veterinaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veterinaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veterinaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Veterinaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Veterinaria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Veterinaria', N'ON'
GO
ALTER DATABASE [Veterinaria] SET QUERY_STORE = OFF
GO
USE [Veterinaria]
GO
/****** Object:  Table [dbo].[Calendario_Vacunacion]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendario_Vacunacion](
	[Nro_HC] [int] NOT NULL,
	[Id_vacuna] [int] NOT NULL,
	[Fecha_prevista] [datetime] NULL,
	[Fecha_real] [datetime] NULL,
	[Legajo] [int] NULL,
	[Dosis] [int] NULL,
 CONSTRAINT [Nro_vacuna_pk] PRIMARY KEY CLUSTERED 
(
	[Nro_HC] ASC,
	[Id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[Nro_HC] [int] NOT NULL,
	[Id_Consulta] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Legajo] [int] NOT NULL,
 CONSTRAINT [PK_Consultas] PRIMARY KEY CLUSTERED 
(
	[Nro_HC] ASC,
	[Id_Consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dueños]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dueños](
	[Id_dueño] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[Activo] [int] NULL,
	[Id_tipodoc] [int] NULL,
	[nro_doc] [varchar](50) NULL,
 CONSTRAINT [Id_dueño] PRIMARY KEY CLUSTERED 
(
	[Id_dueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Id_tipodoc] [int] NOT NULL,
	[Nro_doc] [varchar](50) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Fecha_nacimiento] [date] NOT NULL,
	[Fecha_ingreso] [date] NOT NULL,
	[Matricula] [varchar](10) NOT NULL,
	[Fecha_baja] [date] NULL,
	[Activo] [int] NOT NULL,
 CONSTRAINT [Legajo_pk] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[Id_medicamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [Id_medicamento_pk] PRIMARY KEY CLUSTERED 
(
	[Id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicamentosXConsulta]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicamentosXConsulta](
	[Id_medicamento] [int] NOT NULL,
	[Nro_HC] [int] NOT NULL,
	[Id_consulta] [int] NOT NULL,
 CONSTRAINT [Nro_Consulta_Medicamento_pk] PRIMARY KEY CLUSTERED 
(
	[Nro_HC] ASC,
	[Id_consulta] ASC,
	[Id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perros]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perros](
	[Nro_HC] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Fecha_nacimiento] [datetime] NULL,
	[Id_raza] [int] NOT NULL,
	[Id_owner] [int] NOT NULL,
	[Peso] [float] NULL,
	[Altura] [float] NULL,
	[Activo] [bit] NOT NULL,
	[Motivo] [varchar](100) NULL,
 CONSTRAINT [PK_Perros] PRIMARY KEY CLUSTERED 
(
	[Nro_HC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Razas]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Razas](
	[Id_raza] [int] IDENTITY(1,1) NOT NULL,
	[Denominacion] [varchar](20) NULL,
	[Peso_min_hembra] [float] NOT NULL,
	[Peso_max_hembra] [float] NULL,
	[Peso_min_macho] [float] NULL,
	[Peso_max_macho] [float] NULL,
	[Altura_media_hembra] [float] NULL,
	[Altura_media_hombre] [float] NULL,
 CONSTRAINT [Id_raza_pk] PRIMARY KEY CLUSTERED 
(
	[Id_raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sintomas]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sintomas](
	[Id_sintoma] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [Id_sintoma_pk] PRIMARY KEY CLUSTERED 
(
	[Id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SintomasXConsultas]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SintomasXConsultas](
	[Nro_HC] [int] NOT NULL,
	[Id_consulta] [int] NOT NULL,
	[Id_sintoma] [int] NOT NULL,
 CONSTRAINT [Nro_Consulta_Sintoma_pk] PRIMARY KEY CLUSTERED 
(
	[Nro_HC] ASC,
	[Id_consulta] ASC,
	[Id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Doc]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Doc](
	[Id_tipodoc] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Doc] PRIMARY KEY CLUSTERED 
(
	[Id_tipodoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Contra] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
	[Activo] [int] NULL,
 CONSTRAINT [Id_Usuario_pk] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacunas]    Script Date: 22/10/2022 20:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacunas](
	[Id_vacuna] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [Id_vacuna_pk] PRIMARY KEY CLUSTERED 
(
	[Id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Consultas] ([Nro_HC], [Id_Consulta], [Fecha], [Legajo]) VALUES (1, 1, CAST(N'2022-10-09T15:45:44.273' AS DateTime), 1)
INSERT [dbo].[Consultas] ([Nro_HC], [Id_Consulta], [Fecha], [Legajo]) VALUES (1, 2, CAST(N'2022-10-13T11:19:19.607' AS DateTime), 1)
INSERT [dbo].[Consultas] ([Nro_HC], [Id_Consulta], [Fecha], [Legajo]) VALUES (1, 3, CAST(N'2022-10-13T11:54:55.890' AS DateTime), 1)
INSERT [dbo].[Consultas] ([Nro_HC], [Id_Consulta], [Fecha], [Legajo]) VALUES (4, 1, CAST(N'2022-10-22T20:15:32.913' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Dueños] ON 

INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono], [Activo], [Id_tipodoc], [nro_doc]) VALUES (1, N'Santiago', N'Juarez', N'536-2486', 1, 1, N'43678569')
INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono], [Activo], [Id_tipodoc], [nro_doc]) VALUES (2, N'Tomas', N'Sueldo', N'536-2487', 1, 1, N'23475689')
INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono], [Activo], [Id_tipodoc], [nro_doc]) VALUES (3, N'rafa', N'perey', N'123-5647', 0, 1, N'38159705')
INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono], [Activo], [Id_tipodoc], [nro_doc]) VALUES (4, N'jorge', N'rafael', N'345-6231', 1, 2, N'27865923')
INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono], [Activo], [Id_tipodoc], [nro_doc]) VALUES (5, N'marcos', N'perez', N'234-1455', 0, 2, N'27865922')
SET IDENTITY_INSERT [dbo].[Dueños] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([Legajo], [Id_tipodoc], [Nro_doc], [Nombre], [Apellido], [Fecha_nacimiento], [Fecha_ingreso], [Matricula], [Fecha_baja], [Activo]) VALUES (1, 1, N'42106745', N'Tomas', N'Sueldo', CAST(N'1999-08-23' AS Date), CAST(N'2022-10-01' AS Date), N'11111', NULL, 1)
INSERT [dbo].[Empleados] ([Legajo], [Id_tipodoc], [Nro_doc], [Nombre], [Apellido], [Fecha_nacimiento], [Fecha_ingreso], [Matricula], [Fecha_baja], [Activo]) VALUES (2, 1, N'43605429', N'Santiago', N'Juarez', CAST(N'2001-09-10' AS Date), CAST(N'2019-08-15' AS Date), N'23456', NULL, 1)
INSERT [dbo].[Empleados] ([Legajo], [Id_tipodoc], [Nro_doc], [Nombre], [Apellido], [Fecha_nacimiento], [Fecha_ingreso], [Matricula], [Fecha_baja], [Activo]) VALUES (3, 1, N'34567823', N'Marcos', N'Gonzalez', CAST(N'1995-09-28' AS Date), CAST(N'2018-08-10' AS Date), N'23415', NULL, 0)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicamentos] ON 

INSERT [dbo].[Medicamentos] ([Id_medicamento], [Nombre]) VALUES (1, N'Paracetamol')
INSERT [dbo].[Medicamentos] ([Id_medicamento], [Nombre]) VALUES (2, N'Ibuprofeno')
SET IDENTITY_INSERT [dbo].[Medicamentos] OFF
GO
INSERT [dbo].[MedicamentosXConsulta] ([Id_medicamento], [Nro_HC], [Id_consulta]) VALUES (1, 1, 1)
INSERT [dbo].[MedicamentosXConsulta] ([Id_medicamento], [Nro_HC], [Id_consulta]) VALUES (1, 1, 2)
INSERT [dbo].[MedicamentosXConsulta] ([Id_medicamento], [Nro_HC], [Id_consulta]) VALUES (1, 1, 3)
INSERT [dbo].[MedicamentosXConsulta] ([Id_medicamento], [Nro_HC], [Id_consulta]) VALUES (2, 4, 1)
GO
SET IDENTITY_INSERT [dbo].[Perros] ON 

INSERT [dbo].[Perros] ([Nro_HC], [Nombre], [Fecha_nacimiento], [Id_raza], [Id_owner], [Peso], [Altura], [Activo], [Motivo]) VALUES (1, N'Tobi', CAST(N'2018-08-21T00:00:00.000' AS DateTime), 1, 2, 10, 150, 1, NULL)
INSERT [dbo].[Perros] ([Nro_HC], [Nombre], [Fecha_nacimiento], [Id_raza], [Id_owner], [Peso], [Altura], [Activo], [Motivo]) VALUES (2, N'Firulais', CAST(N'2017-06-14T00:00:00.000' AS DateTime), 2, 1, 20, 100, 0, NULL)
INSERT [dbo].[Perros] ([Nro_HC], [Nombre], [Fecha_nacimiento], [Id_raza], [Id_owner], [Peso], [Altura], [Activo], [Motivo]) VALUES (3, N'Uva', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 1, 2, 5, 60, 1, NULL)
INSERT [dbo].[Perros] ([Nro_HC], [Nombre], [Fecha_nacimiento], [Id_raza], [Id_owner], [Peso], [Altura], [Activo], [Motivo]) VALUES (4, N'Uma', CAST(N'2015-05-18T00:00:00.000' AS DateTime), 2, 2, 14, 135, 1, NULL)
SET IDENTITY_INSERT [dbo].[Perros] OFF
GO
SET IDENTITY_INSERT [dbo].[Razas] ON 

INSERT [dbo].[Razas] ([Id_raza], [Denominacion], [Peso_min_hembra], [Peso_max_hembra], [Peso_min_macho], [Peso_max_macho], [Altura_media_hembra], [Altura_media_hombre]) VALUES (1, N'Caniche', 1, 5, 1, 10, 50, 50)
INSERT [dbo].[Razas] ([Id_raza], [Denominacion], [Peso_min_hembra], [Peso_max_hembra], [Peso_min_macho], [Peso_max_macho], [Altura_media_hembra], [Altura_media_hombre]) VALUES (2, N'Golden', 10, 30, 10, 30, 130, 150)
SET IDENTITY_INSERT [dbo].[Razas] OFF
GO
INSERT [dbo].[Sintomas] ([Id_sintoma], [Descripcion]) VALUES (1, N'Fiebre')
GO
INSERT [dbo].[SintomasXConsultas] ([Nro_HC], [Id_consulta], [Id_sintoma]) VALUES (1, 1, 1)
INSERT [dbo].[SintomasXConsultas] ([Nro_HC], [Id_consulta], [Id_sintoma]) VALUES (1, 2, 1)
INSERT [dbo].[SintomasXConsultas] ([Nro_HC], [Id_consulta], [Id_sintoma]) VALUES (1, 3, 1)
INSERT [dbo].[SintomasXConsultas] ([Nro_HC], [Id_consulta], [Id_sintoma]) VALUES (4, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Tipo_Doc] ON 

INSERT [dbo].[Tipo_Doc] ([Id_tipodoc], [Nombre]) VALUES (1, N'DNI                                               ')
INSERT [dbo].[Tipo_Doc] ([Id_tipodoc], [Nombre]) VALUES (2, N'Pasaporte                                         ')
SET IDENTITY_INSERT [dbo].[Tipo_Doc] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [Usuario], [Contra], [Rol], [Activo]) VALUES (1, N'admin', N'admin', N'administrador', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [Usuario], [Contra], [Rol], [Activo]) VALUES (2, N'tomas', N'123', N'veterinario', 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Calendario_Vacunacion]  WITH CHECK ADD  CONSTRAINT [Calendario_Id_vacuna_fk] FOREIGN KEY([Id_vacuna])
REFERENCES [dbo].[Vacunas] ([Id_vacuna])
GO
ALTER TABLE [dbo].[Calendario_Vacunacion] CHECK CONSTRAINT [Calendario_Id_vacuna_fk]
GO
ALTER TABLE [dbo].[Calendario_Vacunacion]  WITH CHECK ADD  CONSTRAINT [Calendario_Legajo_fk] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Empleados] ([Legajo])
GO
ALTER TABLE [dbo].[Calendario_Vacunacion] CHECK CONSTRAINT [Calendario_Legajo_fk]
GO
ALTER TABLE [dbo].[Calendario_Vacunacion]  WITH CHECK ADD  CONSTRAINT [Calendario_Nro_HC_fk] FOREIGN KEY([Nro_HC])
REFERENCES [dbo].[Perros] ([Nro_HC])
GO
ALTER TABLE [dbo].[Calendario_Vacunacion] CHECK CONSTRAINT [Calendario_Nro_HC_fk]
GO
ALTER TABLE [dbo].[Dueños]  WITH CHECK ADD  CONSTRAINT [FK_Dueños_TipoDoc] FOREIGN KEY([Id_tipodoc])
REFERENCES [dbo].[Tipo_Doc] ([Id_tipodoc])
GO
ALTER TABLE [dbo].[Dueños] CHECK CONSTRAINT [FK_Dueños_TipoDoc]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_TipoDoc] FOREIGN KEY([Id_tipodoc])
REFERENCES [dbo].[Tipo_Doc] ([Id_tipodoc])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_TipoDoc]
GO
ALTER TABLE [dbo].[MedicamentosXConsulta]  WITH CHECK ADD  CONSTRAINT [MedicXCons_Id_Medicamento_fk] FOREIGN KEY([Id_medicamento])
REFERENCES [dbo].[Medicamentos] ([Id_medicamento])
GO
ALTER TABLE [dbo].[MedicamentosXConsulta] CHECK CONSTRAINT [MedicXCons_Id_Medicamento_fk]
GO
ALTER TABLE [dbo].[MedicamentosXConsulta]  WITH CHECK ADD  CONSTRAINT [MedicXCons_Nro_HC_Consulta_fk] FOREIGN KEY([Nro_HC], [Id_consulta])
REFERENCES [dbo].[Consultas] ([Nro_HC], [Id_Consulta])
GO
ALTER TABLE [dbo].[MedicamentosXConsulta] CHECK CONSTRAINT [MedicXCons_Nro_HC_Consulta_fk]
GO
ALTER TABLE [dbo].[Perros]  WITH CHECK ADD  CONSTRAINT [FK_Perros_Dueños] FOREIGN KEY([Id_owner])
REFERENCES [dbo].[Dueños] ([Id_dueño])
GO
ALTER TABLE [dbo].[Perros] CHECK CONSTRAINT [FK_Perros_Dueños]
GO
ALTER TABLE [dbo].[Perros]  WITH CHECK ADD  CONSTRAINT [FK_Perros_Razas] FOREIGN KEY([Id_raza])
REFERENCES [dbo].[Razas] ([Id_raza])
GO
ALTER TABLE [dbo].[Perros] CHECK CONSTRAINT [FK_Perros_Razas]
GO
ALTER TABLE [dbo].[SintomasXConsultas]  WITH CHECK ADD  CONSTRAINT [SintXCons_Id_Sintoma_fk] FOREIGN KEY([Id_sintoma])
REFERENCES [dbo].[Sintomas] ([Id_sintoma])
GO
ALTER TABLE [dbo].[SintomasXConsultas] CHECK CONSTRAINT [SintXCons_Id_Sintoma_fk]
GO
ALTER TABLE [dbo].[SintomasXConsultas]  WITH CHECK ADD  CONSTRAINT [SintXCons_Nro_HC_Consulta_fk] FOREIGN KEY([Nro_HC], [Id_consulta])
REFERENCES [dbo].[Consultas] ([Nro_HC], [Id_Consulta])
GO
ALTER TABLE [dbo].[SintomasXConsultas] CHECK CONSTRAINT [SintXCons_Nro_HC_Consulta_fk]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [Activo_ck] CHECK  (([Activo]>(-1) AND [Activo]<(2)))
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [Activo_ck]
GO
USE [master]
GO
ALTER DATABASE [Veterinaria] SET  READ_WRITE 
GO
