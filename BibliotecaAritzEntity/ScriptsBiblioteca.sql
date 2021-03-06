USE [master]
GO
/****** Object:  Database [BibliotecaRecuperacionAritz]    Script Date: 03/06/2020 19:49:43 ******/
CREATE DATABASE [BibliotecaRecuperacionAritz]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BibliotecaRecuperacionAritz', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BibliotecaRecuperacionAritz.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BibliotecaRecuperacionAritz_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BibliotecaRecuperacionAritz_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BibliotecaRecuperacionAritz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET ARITHABORT OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET RECOVERY FULL 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET  MULTI_USER 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BibliotecaRecuperacionAritz', N'ON'
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET QUERY_STORE = OFF
GO
USE [BibliotecaRecuperacionAritz]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lectores]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lectores](
	[NCarnet] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Contrasena] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lectores] PRIMARY KEY CLUSTERED 
(
	[NCarnet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[Isbn] [nvarchar](50) NOT NULL,
	[Titulo] [nvarchar](50) NULL,
	[Editorial] [nvarchar](50) NULL,
	[Sinopsis] [nvarchar](50) NULL,
	[Caratula] [nvarchar](50) NULL,
	[Unidades] [int] NULL,
	[Disponibilidad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibrosAutores]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibrosAutores](
	[IdAutor] [int] NOT NULL,
	[Isbn] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LibrosAutores] PRIMARY KEY CLUSTERED 
(
	[IdAutor] ASC,
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibrosCategorias]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibrosCategorias](
	[Isbn] [nvarchar](50) NOT NULL,
	[IdCategoria] [int] NOT NULL,
 CONSTRAINT [PK_LibrosCategorias] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC,
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibrosLectores]    Script Date: 03/06/2020 19:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibrosLectores](
	[Isbn] [nvarchar](50) NOT NULL,
	[NCarnet] [int] NOT NULL,
	[FechaPrestamo] [datetime] NULL,
	[FechaDevolucion] [datetime] NULL,
 CONSTRAINT [PK_LibrosLectores] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC,
	[NCarnet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LibrosAutores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosAutores_Autores] FOREIGN KEY([IdAutor])
REFERENCES [dbo].[Autores] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosAutores] CHECK CONSTRAINT [FK_LibrosAutores_Autores]
GO
ALTER TABLE [dbo].[LibrosAutores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosAutores_Libros] FOREIGN KEY([Isbn])
REFERENCES [dbo].[Libros] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosAutores] CHECK CONSTRAINT [FK_LibrosAutores_Libros]
GO
ALTER TABLE [dbo].[LibrosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_LibrosCategorias_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosCategorias] CHECK CONSTRAINT [FK_LibrosCategorias_Categorias]
GO
ALTER TABLE [dbo].[LibrosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_LibrosCategorias_Libros] FOREIGN KEY([Isbn])
REFERENCES [dbo].[Libros] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosCategorias] CHECK CONSTRAINT [FK_LibrosCategorias_Libros]
GO
ALTER TABLE [dbo].[LibrosLectores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosLectores_Lectores] FOREIGN KEY([NCarnet])
REFERENCES [dbo].[Lectores] ([NCarnet])
GO
ALTER TABLE [dbo].[LibrosLectores] CHECK CONSTRAINT [FK_LibrosLectores_Lectores]
GO
ALTER TABLE [dbo].[LibrosLectores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosLectores_Libros] FOREIGN KEY([Isbn])
REFERENCES [dbo].[Libros] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LibrosLectores] CHECK CONSTRAINT [FK_LibrosLectores_Libros]
GO
USE [master]
GO
ALTER DATABASE [BibliotecaRecuperacionAritz] SET  READ_WRITE 
GO
