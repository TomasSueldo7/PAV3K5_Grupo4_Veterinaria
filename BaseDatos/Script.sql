USE [master]
GO
/****** Object:  Database [Veterinaria]    Script Date: 5/10/2022 18:04:49 ******/
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
ALTER DATABASE [Veterinaria] SET  ENABLE_BROKER 
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
/****** Object:  Table [dbo].[Calendario_Vacunacion]    Script Date: 5/10/2022 18:04:50 ******/
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
/****** Object:  Table [dbo].[Dueños]    Script Date: 5/10/2022 18:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dueños](
	[Id_dueño] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Telefono] [int] NULL,
 CONSTRAINT [Id_dueño] PRIMARY KEY CLUSTERED 
(
	[Id_dueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 5/10/2022 18:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_doc] [varchar](10) NOT NULL,
	[Nro_doc] [varchar](10) NOT NULL,
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
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 5/10/2022 18:04:50 ******/
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
/****** Object:  Table [dbo].[Perros]    Script Date: 5/10/2022 18:04:50 ******/
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
/****** Object:  Table [dbo].[Razas]    Script Date: 5/10/2022 18:04:50 ******/
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
/****** Object:  Table [dbo].[Sintomas]    Script Date: 5/10/2022 18:04:50 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 5/10/2022 18:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Contra] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
 CONSTRAINT [Id_Usuario_pk] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacunas]    Script Date: 5/10/2022 18:04:50 ******/
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
SET IDENTITY_INSERT [dbo].[Dueños] ON 

INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono]) VALUES (1, N'Santiago', N'Juarez', 123456789)
INSERT [dbo].[Dueños] ([Id_dueño], [Nombre], [Apellido], [Telefono]) VALUES (2, N'Tomas', N'Sueldo', 123456789)
SET IDENTITY_INSERT [dbo].[Dueños] OFF
GO
SET IDENTITY_INSERT [dbo].[Perros] ON 

INSERT [dbo].[Perros] ([Nro_HC], [Nombre], [Fecha_nacimiento], [Id_raza], [Id_owner], [Peso], [Altura], [Activo], [Motivo]) VALUES (1, N'Tobi', CAST(N'2018-08-21T00:00:00.000' AS DateTime), 1, 2, 10, 150, 1, NULL)
INSERT [dbo].[Perros] ([Nro_HC], [Nombre], [Fecha_nacimiento], [Id_raza], [Id_owner], [Peso], [Altura], [Activo], [Motivo]) VALUES (2, N'Firulais', CAST(N'2017-06-14T00:00:00.000' AS DateTime), 2, 1, 20, 100, 0, NULL)
SET IDENTITY_INSERT [dbo].[Perros] OFF
GO
SET IDENTITY_INSERT [dbo].[Razas] ON 

INSERT [dbo].[Razas] ([Id_raza], [Denominacion], [Peso_min_hembra], [Peso_max_hembra], [Peso_min_macho], [Peso_max_macho], [Altura_media_hembra], [Altura_media_hombre]) VALUES (1, N'Caniche', 1, 5, 1, 10, 50, 50)
INSERT [dbo].[Razas] ([Id_raza], [Denominacion], [Peso_min_hembra], [Peso_max_hembra], [Peso_min_macho], [Peso_max_macho], [Altura_media_hembra], [Altura_media_hombre]) VALUES (2, N'Golden', 10, 30, 10, 30, 130, 150)
SET IDENTITY_INSERT [dbo].[Razas] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [Usuario], [Contra], [Rol]) VALUES (1, N'admin', N'admin', N'administrador')
INSERT [dbo].[Usuarios] ([id_usuario], [Usuario], [Contra], [Rol]) VALUES (2, N'tomas', N'123', N'veterinario')
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
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [Activo_ck] CHECK  (([Activo]>(-1) AND [Activo]<(2)))
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [Activo_ck]
GO
USE [master]
GO
ALTER DATABASE [Veterinaria] SET  READ_WRITE 
GO
