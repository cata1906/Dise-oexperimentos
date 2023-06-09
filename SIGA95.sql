USE [master]
GO
/****** Object:  Database [SIGA]    Script Date: 22/06/2022 20:15:04 ******/
CREATE DATABASE [SIGA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SIGA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SIGA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SIGA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SIGA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SIGA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIGA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIGA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIGA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIGA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIGA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIGA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIGA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SIGA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIGA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIGA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIGA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIGA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIGA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIGA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIGA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIGA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SIGA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIGA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIGA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIGA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIGA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIGA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIGA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIGA] SET RECOVERY FULL 
GO
ALTER DATABASE [SIGA] SET  MULTI_USER 
GO
ALTER DATABASE [SIGA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIGA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SIGA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SIGA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SIGA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SIGA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SIGA', N'ON'
GO
ALTER DATABASE [SIGA] SET QUERY_STORE = OFF
GO
USE [SIGA]
GO
/****** Object:  Table [dbo].[Adoptantes]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adoptantes](
	[DNI] [int] NOT NULL,
	[Nombre] [nvarchar](150) NULL,
	[Apellido] [nvarchar](150) NOT NULL,
	[Telefono] [int] NULL,
	[Correo] [nvarchar](50) NULL,
	[Direccion] [nvarchar](150) NULL,
	[Motivo] [nvarchar](150) NULL,
 CONSTRAINT [PK_Adoptante] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animales]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animales](
	[Codigo] [int] NOT NULL,
	[Tipo] [nvarchar](150) NULL,
	[Nombre] [nvarchar](150) NULL,
	[Raza] [nvarchar](150) NULL,
	[Edad] [int] NULL,
	[Sexo] [nvarchar](150) NULL,
	[Color] [nvarchar](150) NULL,
	[Proveniencia] [nvarchar](150) NULL,
	[Estado] [nvarchar](150) NULL,
 CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalesxAdoptante]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalesxAdoptante](
	[CodigoAdopcion] [int] NOT NULL,
	[DNI] [int] NOT NULL,
	[Tipo] [nvarchar](150) NULL,
	[Nombre] [nvarchar](150) NULL,
	[Raza] [nvarchar](150) NULL,
	[Edad] [int] NULL,
	[Sexo] [nvarchar](150) NULL,
	[Color] [nvarchar](150) NULL,
	[Proveniencia] [nvarchar](150) NULL,
	[Estado] [nvarchar](150) NULL,
 CONSTRAINT [PK_AnimalesAdopcion] PRIMARY KEY CLUSTERED 
(
	[CodigoAdopcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalesxHistorial]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalesxHistorial](
	[Codigo] [int] NOT NULL,
	[Tipo] [nvarchar](150) NULL,
	[Nombre] [nvarchar](150) NULL,
	[Raza] [nvarchar](150) NULL,
	[Edad] [int] NULL,
	[Sexo] [nvarchar](150) NULL,
	[Color] [nvarchar](150) NULL,
	[Proveniencia] [nvarchar](150) NULL,
	[Estado] [nvarchar](150) NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_AnimalesxHistorial] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](150) NULL,
	[Descripcion] [nvarchar](150) NULL,
	[Cantidad] [int] NULL,
	[MontoUnitario] [money] NULL,
	[MontoTotal] [money] NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Gastos] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](150) NULL,
	[Cantidad] [int] NULL,
	[FechaIngreso] [datetime] NULL,
	[FechaCaducidad] [date] NULL,
 CONSTRAINT [PK_Medicamentos] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[DNI] [varchar](150) NOT NULL,
	[Correo] [varchar](150) NOT NULL,
	[pPassword] [varchar](150) NOT NULL,
	[Codigo] [varchar](150) NOT NULL,
	[aPassword] [varchar](150) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_adoptantes_delete]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_adoptantes_delete]
(
	@dni int
)
as
begin
	delete from dbo.Adoptantes where DNI = @dni
end
GO
/****** Object:  StoredProcedure [dbo].[sp_adoptantes_insert]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_adoptantes_insert]
(
	@dni int,
	@nombre nvarchar(150),
	@apellido nvarchar(150),
	@telefono int,
	@correo nvarchar(150),
	@direccion nvarchar(150),
	@motivo nvarchar(150)
)
as
begin
	insert into dbo.Adoptantes(DNI, Nombre, Apellido, Telefono, Correo, Direccion, Motivo) values (@dni, @nombre, @apellido, @telefono, @correo, @direccion, @motivo)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_adoptantes_list]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_adoptantes_list]
as
begin
	select * from dbo.Adoptantes
end
GO
/****** Object:  StoredProcedure [dbo].[sp_adoptantes_update]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_adoptantes_update]
(
	@newDNI int,
	@nombre nvarchar(150),
	@apellido nvarchar(150),
	@telefono int,
	@correo nvarchar(150),
	@direccion nvarchar(150),
	@motivo nvarchar(150),
	@dni int
)
as
begin
	update dbo.Adoptantes set
	DNI = @newDNI,
	Nombre = @nombre,
	Apellido = @apellido,
	Telefono = @telefono,
	Correo = @correo,
	Direccion = @direccion,
	Motivo = @motivo
	where DNI = @dni
end
GO
/****** Object:  StoredProcedure [dbo].[sp_adoptantes_update_DNI]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_adoptantes_update_DNI]
(
	@dni int,
	@oldDNI int
)
as
begin
	update dbo.Adoptantes set
	DNI = @dni
	where DNI = @oldDNI
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animales_delete]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animales_delete]
(
	@codigo int
)
as
begin
	delete from dbo.Animales where Codigo = @codigo;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animales_insert]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animales_insert]
(
	@codigo int,
	@tipo nvarchar(150),
	@nombre nvarchar(150),
	@raza nvarchar(150),
	@edad int,
	@sexo nvarchar(150),
	@color nvarchar(150),
	@proveniencia nvarchar(150),
	@estado nvarchar(150)
)
as
begin
	insert into dbo.Animales(Codigo, Tipo, Nombre, Raza, Edad, Sexo, Color, Proveniencia, Estado) values (@codigo, @tipo, @nombre, @raza, @edad, @sexo, @color, @proveniencia, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animales_list]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animales_list]
as
begin
	select * from dbo.Animales
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animales_update]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animales_update]
(
	@tipo nvarchar(150),
	@nombre nvarchar(150),
	@raza nvarchar(150),
	@edad int,
	@sexo nvarchar(150),
	@color nvarchar(150),
	@proveniencia nvarchar(150),
	@estado nvarchar(150),
	@codigo int
)
as
begin
	update dbo.Animales set
	Tipo = @tipo,
	Nombre = @nombre,
	Raza = @raza,
	Edad = @edad,
	Sexo = @sexo,
	Color = @color, 
	Proveniencia = @proveniencia,
	Estado = @estado
	where Codigo = @codigo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXadoptante_delete]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_animalesXadoptante_delete]
(
	@codigoadopcion int
)
as
begin
	delete from dbo.AnimalesxAdoptante where CodigoAdopcion = @codigoadopcion;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXadoptante_insert]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animalesXadoptante_insert]
(
	@codigoadopcion int,
	@dni int,
	@tipo nvarchar(150),
	@nombre nvarchar(150),
	@raza nvarchar(150),
	@edad int,
	@sexo nvarchar(150),
	@color nvarchar(150),
	@proveniencia nvarchar(150),
	@estado nvarchar(150)
)
as
begin
	insert into dbo.AnimalesxAdoptante(CodigoAdopcion, DNI, Tipo, Nombre, Raza, Edad, Sexo, Color, Proveniencia, Estado) values
	(
	@codigoadopcion,
	@dni,
	@tipo,
	@nombre,
	@raza,
	@edad,
	@sexo,
	@color,
	@proveniencia,
	@estado
	)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXadoptante_list]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_animalesXadoptante_list]
as
begin
	select * from dbo.AnimalesxAdoptante
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXadoptante_update]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animalesXadoptante_update]
(
	@dni int,
	@codigoadopcion int
)
as
begin
	update dbo.AnimalesxAdoptante set
	DNI = @dni
	where CodigoAdopcion = @codigoadopcion
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXhistorial_insert]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animalesXhistorial_insert]
(
	@codigo int,
	@tipo nvarchar(150),
	@nombre nvarchar(150),
	@raza nvarchar(150),
	@edad int,
	@sexo nvarchar(150),
	@color nvarchar(150),
	@proveniencia nvarchar(150),
	@estado nvarchar(150),
	@fecharegistro date
)
as
begin
	insert into dbo.AnimalesxHistorial(Codigo, Tipo, Nombre, Raza, Edad, Sexo, Color, Proveniencia, Estado, FechaRegistro) values (@codigo, @tipo, @nombre, @raza, @edad, @sexo, @color, @proveniencia, @estado, @fecharegistro)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXhistorial_list]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_animalesXhistorial_list]
as
begin
	select * from dbo.AnimalesxHistorial
end
GO
/****** Object:  StoredProcedure [dbo].[sp_animalesXhistorial_update]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_animalesXhistorial_update]
(
	@tipo nvarchar(150),
	@nombre nvarchar(150),
	@raza nvarchar(150),
	@edad int,
	@sexo nvarchar(150),
	@color nvarchar(150),
	@proveniencia nvarchar(150),
	@estado nvarchar(150),
	@fecharegistro date,
	@codigo int
)
as
begin
	update dbo.AnimalesxHistorial set
	Tipo = @tipo,
	Nombre = @nombre,
	Raza = @raza,
	Edad = @edad,
	Sexo = @sexo,
	Color = @tipo, 
	Proveniencia = @sexo,
	Estado = @tipo,
	FechaRegistro = @fecharegistro
	where Codigo = @codigo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_gastos_delete]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_gastos_delete]
(
	@codigo int
)
as
begin
	delete from SIGA.dbo.Gastos where Codigo = @codigo;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_gastos_insert]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_gastos_insert]
(
	@tipo nvarchar(150),
	@descripcion nvarchar(150),
	@cantidad int,
	@montounitario money,
	@montototal money,
	@fecharegistro datetime
)
as
begin
	insert into SIGA.dbo.Gastos(Tipo, Descripcion, Cantidad, MontoUnitario, MontoTotal, FechaRegistro) values (@tipo, @descripcion, @cantidad, @montounitario, @montototal, @fecharegistro)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_gastos_list]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_gastos_list]
as
begin
	select * from SIGA.dbo.Gastos
end
GO
/****** Object:  StoredProcedure [dbo].[sp_gastos_update]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_gastos_update]
(
	@tipo nvarchar(150),
	@descripcion nvarchar(150),
	@cantidad int,
	@montounitario money,
	@montototal money,
	@fecharegistro datetime,
	@codigo int
)
as
begin
	update SIGA.dbo.Gastos set
	Tipo = @tipo,
	Descripcion = @descripcion,
	Cantidad = @cantidad,
	MontoUnitario = @montounitario,
	MontoTotal = @montototal,
	FechaRegistro = @fecharegistro
	where Codigo = @codigo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_medicamentos_delete]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_medicamentos_delete]
(
	@codigo int
)
as
begin
	delete from dbo.Medicamentos where Codigo = @codigo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_medicamentos_insert]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_medicamentos_insert]
(
	@descripcion nvarchar(150),
	@cantidad int,
	@fechaingreso datetime,
	@fechacaducidad date
)
as
begin
	insert into dbo.Medicamentos(Descripcion, Cantidad, FechaIngreso, FechaCaducidad) values (@descripcion, @cantidad, @fechaingreso, @fechacaducidad)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_medicamentos_list]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_medicamentos_list]
as
begin
	select * from dbo.Medicamentos
end
GO
/****** Object:  StoredProcedure [dbo].[sp_medicamentos_update]    Script Date: 22/06/2022 20:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_medicamentos_update]
(
	@descripcion nvarchar(150),
	@cantidad int,
	@fechaingreso datetime,
	@fechacaducidad date,
	@codigo int
)
as
begin
	update dbo.Medicamentos set
	Descripcion = @descripcion,
	Cantidad = @cantidad,
	FechaIngreso = @fechaingreso,
	FechaCaducidad = @fechacaducidad
	where Codigo = @codigo
end
GO
USE [master]
GO
ALTER DATABASE [SIGA] SET  READ_WRITE 
GO
