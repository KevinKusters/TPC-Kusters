USE [master]
GO
/****** Object:  Database [peluvet]    Script Date: 17/5/2019 16:18:02 ******/
CREATE DATABASE [peluvet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'peluvet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\peluvet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'peluvet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\peluvet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [peluvet] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [peluvet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [peluvet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [peluvet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [peluvet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [peluvet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [peluvet] SET ARITHABORT OFF 
GO
ALTER DATABASE [peluvet] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [peluvet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [peluvet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [peluvet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [peluvet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [peluvet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [peluvet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [peluvet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [peluvet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [peluvet] SET  ENABLE_BROKER 
GO
ALTER DATABASE [peluvet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [peluvet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [peluvet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [peluvet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [peluvet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [peluvet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [peluvet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [peluvet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [peluvet] SET  MULTI_USER 
GO
ALTER DATABASE [peluvet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [peluvet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [peluvet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [peluvet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [peluvet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [peluvet] SET QUERY_STORE = OFF
GO
USE [peluvet]
GO
/****** Object:  Table [dbo].[animales]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idraza] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[especie] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[animalesxCliente]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animalesxCliente](
	[idanimal] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idanimal] ASC,
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[contacto] [varchar](50) NOT NULL,
	[localidad] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[puesto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[localidades](
	[idlocalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idlocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personasJuridicas]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personasJuridicas](
	[idperjuridica] [int] IDENTITY(1,1) NOT NULL,
	[Razonsocial] [varchar](50) NOT NULL,
	[cuit] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idperjuridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[marca] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductosXproveedores]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductosXproveedores](
	[idproveedor] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC,
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[idperjuridica] [int] NOT NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puestos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[razas]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[razas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicios]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turnos]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turnos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idmascota] [int] NOT NULL,
	[idservicio] [int] NOT NULL,
	[idempleado] [int] NOT NULL,
	[fecha] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[animales]  WITH CHECK ADD FOREIGN KEY([idraza])
REFERENCES [dbo].[razas] ([id])
GO
ALTER TABLE [dbo].[animalesxCliente]  WITH CHECK ADD FOREIGN KEY([idanimal])
REFERENCES [dbo].[animales] ([id])
GO
ALTER TABLE [dbo].[animalesxCliente]  WITH CHECK ADD FOREIGN KEY([idcliente])
REFERENCES [dbo].[clientes] ([id])
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD FOREIGN KEY([puesto])
REFERENCES [dbo].[puestos] ([id])
GO
ALTER TABLE [dbo].[ProductosXproveedores]  WITH CHECK ADD FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedores] ([idproveedor])
GO
ALTER TABLE [dbo].[ProductosXproveedores]  WITH CHECK ADD FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([id])
GO
ALTER TABLE [dbo].[proveedores]  WITH CHECK ADD FOREIGN KEY([idperjuridica])
REFERENCES [dbo].[personasJuridicas] ([idperjuridica])
GO
ALTER TABLE [dbo].[turnos]  WITH CHECK ADD FOREIGN KEY([idcliente])
REFERENCES [dbo].[clientes] ([id])
GO
ALTER TABLE [dbo].[turnos]  WITH CHECK ADD FOREIGN KEY([idempleado])
REFERENCES [dbo].[empleados] ([id])
GO
ALTER TABLE [dbo].[turnos]  WITH CHECK ADD FOREIGN KEY([idmascota])
REFERENCES [dbo].[animales] ([id])
GO
ALTER TABLE [dbo].[turnos]  WITH CHECK ADD FOREIGN KEY([idservicio])
REFERENCES [dbo].[servicios] ([id])
GO
/****** Object:  StoredProcedure [dbo].[sp_cargar_cbo_proveedores]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cargar_cbo_proveedores]
as 
begin
select idproveedor,nombre from proveedores
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_clientes]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_listar_clientes]
as
begin
select * from clientes
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_mascotas]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_mascotas]
as
begin
select * from animales as a
inner join razas as r on r.id = a.idraza
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_proveedores]    Script Date: 17/5/2019 16:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_proveedores]
as
begin
select p.idproveedor,p.nombre,p.email,p.telefono,pj.Razonsocial,pj.cuit as cuit_empresa,pj.idperjuridica from proveedores as p
inner join personasJuridicas as pj on pj.idperjuridica = p.idperjuridica
end 
GO
USE [master]
GO
ALTER DATABASE [peluvet] SET  READ_WRITE 
GO
