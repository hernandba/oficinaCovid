USE [master]
GO
/****** Object:  Database [projmintic]    Script Date: 19/09/2021 5:40:28 p. m. ******/
CREATE DATABASE [projmintic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'projmintic', FILENAME = N'C:\Users\ydhurtado\projmintic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'projmintic_log', FILENAME = N'C:\Users\ydhurtado\projmintic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [projmintic] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [projmintic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [projmintic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [projmintic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [projmintic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [projmintic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [projmintic] SET ARITHABORT OFF 
GO
ALTER DATABASE [projmintic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [projmintic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [projmintic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [projmintic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [projmintic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [projmintic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [projmintic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [projmintic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [projmintic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [projmintic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [projmintic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [projmintic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [projmintic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [projmintic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [projmintic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [projmintic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [projmintic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [projmintic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [projmintic] SET  MULTI_USER 
GO
ALTER DATABASE [projmintic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [projmintic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [projmintic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [projmintic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [projmintic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [projmintic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [projmintic] SET QUERY_STORE = OFF
GO
USE [projmintic]
GO
/****** Object:  Table [dbo].[diagnostico]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnostico](
	[id] [int] NOT NULL,
	[idSintomas] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[aislamiento] [int] NOT NULL,
 CONSTRAINT [PK_diagnostico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estadoCovid]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estadoCovid](
	[id] [int] NOT NULL,
	[infectado] [tinyint] NULL,
	[fiebre] [tinyint] NULL,
	[perdidaOlfato] [tinyint] NULL,
	[perdidaGusto] [tinyint] NULL,
	[tosSeca] [tinyint] NULL,
	[desaliento] [tinyint] NULL,
	[dolorGarganta] [tinyint] NULL,
	[dificultadRespirar] [tinyint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gobernador_asesor]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gobernador_asesor](
	[id] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
 CONSTRAINT [PK_gobernador_asesor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horarios]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horarios](
	[id] [int] NOT NULL,
	[inicioDia] [time](7) NOT NULL,
	[finDia] [time](7) NOT NULL,
	[inicioTarde] [time](7) NOT NULL,
	[finTarde] [time](7) NOT NULL,
 CONSTRAINT [PK_horarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oficina]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oficina](
	[id] [int] NOT NULL,
	[idSede] [int] NOT NULL,
	[nomenclatura] [int] NOT NULL,
	[aforo] [int] NOT NULL,
	[idHorario] [int] NOT NULL,
 CONSTRAINT [PK_oficina] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oficinas_visitadas]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oficinas_visitadas](
	[id] [int] NOT NULL,
	[idGobAs] [int] NOT NULL,
	[idOficina] [int] NOT NULL,
 CONSTRAINT [PK_oficinas_visitadas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] NOT NULL,
	[identificacion] [nchar](15) NOT NULL,
	[nombres] [nchar](25) NOT NULL,
	[apellidos] [nchar](35) NOT NULL,
	[idDiagnostivo] [nchar](10) NOT NULL,
	[edad] [int] NOT NULL,
	[genero] [nchar](10) NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personal_aseo]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal_aseo](
	[id] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[idSede] [int] NOT NULL,
	[horaIngreso] [time](7) NOT NULL,
	[horaSalida] [time](7) NOT NULL,
 CONSTRAINT [PK_personal_aseo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personal_proveedor]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal_proveedor](
	[id] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[idEmpresa] [int] NOT NULL,
	[servicioRealizado] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_personal_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[id] [int] NOT NULL,
	[nit] [nchar](16) NOT NULL,
	[razonSocial] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores_sedes]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores_sedes](
	[id] [int] NOT NULL,
	[idSedeGobernacion] [int] NOT NULL,
	[idProveedor] [int] NOT NULL,
 CONSTRAINT [PK_proveedores_sedes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[secretario]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[secretario](
	[id] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[oficina] [int] NOT NULL,
 CONSTRAINT [PK_secretario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sede]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sede](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[barrio] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_sede] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sintomas]    Script Date: 19/09/2021 5:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sintomas](
	[id] [int] NOT NULL,
	[infectado] [tinyint] NULL,
	[fiebre] [tinyint] NULL,
	[perdidaOlfato] [tinyint] NULL,
	[perdidaGusto] [tinyint] NULL,
	[tosSeca] [tinyint] NULL,
	[desaliento] [tinyint] NULL,
	[dolorGarganta] [tinyint] NULL,
	[dificultadRespirar] [tinyint] NULL,
 CONSTRAINT [PK_sintomas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_diagnostico_persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[diagnostico] CHECK CONSTRAINT [FK_diagnostico_persona]
GO
ALTER TABLE [dbo].[diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_diagnostico_sintomas] FOREIGN KEY([idSintomas])
REFERENCES [dbo].[sintomas] ([id])
GO
ALTER TABLE [dbo].[diagnostico] CHECK CONSTRAINT [FK_diagnostico_sintomas]
GO
ALTER TABLE [dbo].[gobernador_asesor]  WITH CHECK ADD  CONSTRAINT [FK_gobernador_asesor_persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[gobernador_asesor] CHECK CONSTRAINT [FK_gobernador_asesor_persona]
GO
ALTER TABLE [dbo].[oficina]  WITH CHECK ADD  CONSTRAINT [FK_oficina_horarios] FOREIGN KEY([idHorario])
REFERENCES [dbo].[horarios] ([id])
GO
ALTER TABLE [dbo].[oficina] CHECK CONSTRAINT [FK_oficina_horarios]
GO
ALTER TABLE [dbo].[oficina]  WITH CHECK ADD  CONSTRAINT [FK_oficina_sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[sede] ([id])
GO
ALTER TABLE [dbo].[oficina] CHECK CONSTRAINT [FK_oficina_sede]
GO
ALTER TABLE [dbo].[oficinas_visitadas]  WITH CHECK ADD  CONSTRAINT [FK_oficinas_visitadas_gobernador_asesor] FOREIGN KEY([idGobAs])
REFERENCES [dbo].[gobernador_asesor] ([id])
GO
ALTER TABLE [dbo].[oficinas_visitadas] CHECK CONSTRAINT [FK_oficinas_visitadas_gobernador_asesor]
GO
ALTER TABLE [dbo].[oficinas_visitadas]  WITH CHECK ADD  CONSTRAINT [FK_oficinas_visitadas_oficina] FOREIGN KEY([idOficina])
REFERENCES [dbo].[oficina] ([id])
GO
ALTER TABLE [dbo].[oficinas_visitadas] CHECK CONSTRAINT [FK_oficinas_visitadas_oficina]
GO
ALTER TABLE [dbo].[personal_aseo]  WITH CHECK ADD  CONSTRAINT [FK_personal_aseo_persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[personal_aseo] CHECK CONSTRAINT [FK_personal_aseo_persona]
GO
ALTER TABLE [dbo].[personal_aseo]  WITH CHECK ADD  CONSTRAINT [FK_personal_aseo_sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[sede] ([id])
GO
ALTER TABLE [dbo].[personal_aseo] CHECK CONSTRAINT [FK_personal_aseo_sede]
GO
ALTER TABLE [dbo].[personal_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_personal_proveedor_persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[personal_proveedor] CHECK CONSTRAINT [FK_personal_proveedor_persona]
GO
ALTER TABLE [dbo].[personal_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_personal_proveedor_proveedor] FOREIGN KEY([idEmpresa])
REFERENCES [dbo].[proveedor] ([id])
GO
ALTER TABLE [dbo].[personal_proveedor] CHECK CONSTRAINT [FK_personal_proveedor_proveedor]
GO
ALTER TABLE [dbo].[proveedores_sedes]  WITH CHECK ADD  CONSTRAINT [FK_proveedores_sedes_proveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[proveedor] ([id])
GO
ALTER TABLE [dbo].[proveedores_sedes] CHECK CONSTRAINT [FK_proveedores_sedes_proveedor]
GO
ALTER TABLE [dbo].[proveedores_sedes]  WITH CHECK ADD  CONSTRAINT [FK_proveedores_sedes_sede] FOREIGN KEY([idSedeGobernacion])
REFERENCES [dbo].[sede] ([id])
GO
ALTER TABLE [dbo].[proveedores_sedes] CHECK CONSTRAINT [FK_proveedores_sedes_sede]
GO
ALTER TABLE [dbo].[secretario]  WITH CHECK ADD  CONSTRAINT [FK_secretario_oficina] FOREIGN KEY([oficina])
REFERENCES [dbo].[oficina] ([id])
GO
ALTER TABLE [dbo].[secretario] CHECK CONSTRAINT [FK_secretario_oficina]
GO
ALTER TABLE [dbo].[secretario]  WITH CHECK ADD  CONSTRAINT [FK_secretario_persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[secretario] CHECK CONSTRAINT [FK_secretario_persona]
GO
USE [master]
GO
ALTER DATABASE [projmintic] SET  READ_WRITE 
GO
