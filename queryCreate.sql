USE [master]
GO
/****** Object:  Database [TPFINAL-BIBLIOTECA]    Script Date: 13/11/2024 20:01:13 ******/
CREATE DATABASE [TPFINAL-BIBLIOTECA]
 CONTAINMENT = NONE
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPFINAL-BIBLIOTECA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET  MULTI_USER 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET QUERY_STORE = ON
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TPFINAL-BIBLIOTECA]
GO
/****** Object:  Table [dbo].[ALUMNOS]    Script Date: 13/11/2024 20:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOS](
	[DNI_ALUMNO] [int] NOT NULL,
	[NOMBRE_COMPLETO] [nvarchar](255) NOT NULL,
	[DIRECCION] [nvarchar](255) NULL,
	[TELEFONO] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[FECHA_REGISTRO] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DNI_ALUMNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[EMAIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LIBROS]    Script Date: 13/11/2024 20:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIBROS](
	[ID_LIBRO] [int] NOT NULL,
	[TITULO] [nvarchar](255) NOT NULL,
	[AUTOR] [nvarchar](255) NOT NULL,
	[GENERO] [nvarchar](100) NULL,
	[CANTIDAD_DISPONIBLE] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LIBRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRESTAMOS]    Script Date: 13/11/2024 20:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRESTAMOS](
	[ID_PRESTAMO] [int] NOT NULL,
	[ID_LIBRO] [int] NOT NULL,
	[DNI_ALUMNO] [int] NOT NULL,
	[FECHA_PRESTAMO] [date] NOT NULL,
	[FECHA_DEVOLUCION] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PRESTAMO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PRESTAMOS]  WITH CHECK ADD  CONSTRAINT [FK_AlumnoID] FOREIGN KEY([DNI_ALUMNO])
REFERENCES [dbo].[ALUMNOS] ([DNI_ALUMNO])
GO
ALTER TABLE [dbo].[PRESTAMOS] CHECK CONSTRAINT [FK_AlumnoID]
GO
ALTER TABLE [dbo].[PRESTAMOS]  WITH CHECK ADD  CONSTRAINT [FK_LibroID] FOREIGN KEY([ID_LIBRO])
REFERENCES [dbo].[LIBROS] ([ID_LIBRO])
GO
ALTER TABLE [dbo].[PRESTAMOS] CHECK CONSTRAINT [FK_LibroID]
GO
USE [master]
GO
ALTER DATABASE [TPFINAL-BIBLIOTECA] SET  READ_WRITE 
GO
