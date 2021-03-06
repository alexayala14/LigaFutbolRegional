USE [master]
GO
/****** Object:  Database [CampeonatoPav]    Script Date: 30/10/2018 15:15:59 ******/
CREATE DATABASE [CampeonatoPav]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CampeonatoPav', FILENAME = N'C:\Users\Andres\CampeonatoPav.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CampeonatoPav_log', FILENAME = N'C:\Users\Andres\CampeonatoPav_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CampeonatoPav] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CampeonatoPav].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CampeonatoPav] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CampeonatoPav] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CampeonatoPav] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CampeonatoPav] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CampeonatoPav] SET ARITHABORT OFF 
GO
ALTER DATABASE [CampeonatoPav] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CampeonatoPav] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CampeonatoPav] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CampeonatoPav] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CampeonatoPav] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CampeonatoPav] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CampeonatoPav] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CampeonatoPav] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CampeonatoPav] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CampeonatoPav] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CampeonatoPav] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CampeonatoPav] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CampeonatoPav] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CampeonatoPav] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CampeonatoPav] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CampeonatoPav] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CampeonatoPav] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CampeonatoPav] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CampeonatoPav] SET  MULTI_USER 
GO
ALTER DATABASE [CampeonatoPav] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CampeonatoPav] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CampeonatoPav] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CampeonatoPav] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CampeonatoPav] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CampeonatoPav] SET QUERY_STORE = OFF
GO
USE [CampeonatoPav]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CampeonatoPav]
GO
/****** Object:  Table [dbo].[Arbitro]    Script Date: 30/10/2018 15:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arbitro](
	[id_arbitro] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc] [int] NOT NULL,
	[DNI] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[rol_autoridad] [int] NULL,
 CONSTRAINT [PK__Arbitro__335ACBC6B6D098CA] PRIMARY KEY CLUSTERED 
(
	[id_arbitro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campeonato]    Script Date: 30/10/2018 15:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campeonato](
	[id_campeonato] [int] IDENTITY(1,1) NOT NULL,
	[anio] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[fecha_inicio] [date] NULL,
	[fecha_fin] [date] NULL,
	[puntaje_victoria] [int] NULL,
	[puntaje_empate] [int] NULL,
	[id_estado_campeonato] [int] NULL,
 CONSTRAINT [PK_Campeonato] PRIMARY KEY CLUSTERED 
(
	[id_campeonato] ASC,
	[anio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 30/10/2018 15:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[id_ciudad] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_provincia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubFutbol]    Script Date: 30/10/2018 15:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubFutbol](
	[id_club] [int] IDENTITY(1,1) NOT NULL,
	[siglas] [varchar](50) NULL,
	[nombre_club] [varchar](50) NULL,
	[nro_cuil] [varchar](50) NULL,
	[calle] [varchar](50) NULL,
	[nro_calle] [int] NULL,
	[cod_postal] [int] NULL,
	[fecha_fundaciòn] [date] NULL,
	[id_estadio] [int] NULL,
 CONSTRAINT [PK__ClubFutb__6FA6EEEF067C88B4] PRIMARY KEY CLUSTERED 
(
	[id_club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodigoPostal]    Script Date: 30/10/2018 15:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigoPostal](
	[id_codPostal] [int] NOT NULL,
	[id_ciudad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_codPostal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estadio]    Script Date: 30/10/2018 15:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadio](
	[id_estadio] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
	[id_estadoEstadio] [int] NULL,
	[capacidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estadio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCampeonato]    Script Date: 30/10/2018 15:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCampeonato](
	[id_estado_campeonato] [int] NOT NULL,
	[nombre_estado] [varchar](50) NULL,
	[detalle_estado] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_campeonato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoEstadio]    Script Date: 30/10/2018 15:16:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoEstadio](
	[id_estado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoExamenMedico]    Script Date: 30/10/2018 15:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoExamenMedico](
	[id_examen_medico] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_examen_medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoInscripcion]    Script Date: 30/10/2018 15:16:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoInscripcion](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_EstadoInscripcion] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoJugador]    Script Date: 30/10/2018 15:16:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoJugador](
	[id_estado_jugador] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_jugador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoJugadorVigencia]    Script Date: 30/10/2018 15:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoJugadorVigencia](
	[id_estado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_EstadoJugadorVigencia] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPartido]    Script Date: 30/10/2018 15:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPartido](
	[id_estado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoSesion]    Script Date: 30/10/2018 15:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoSesion](
	[id_estado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FechaXCampeonato]    Script Date: 30/10/2018 15:16:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FechaXCampeonato](
	[id_campeonato] [int] NOT NULL,
	[anio] [int] NOT NULL,
	[numero_fecha] [int] NOT NULL,
	[fecha_inicio] [date] NOT NULL,
 CONSTRAINT [PK_FechaXCampeonato] PRIMARY KEY CLUSTERED 
(
	[id_campeonato] ASC,
	[anio] ASC,
	[numero_fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 30/10/2018 15:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[id_campeonato] [int] NOT NULL,
	[anio_campeonato] [int] NOT NULL,
	[id_club] [int] NOT NULL,
	[estado] [int] NULL,
	[fechaInscripcion] [date] NULL,
	[fechaCierre] [date] NULL,
 CONSTRAINT [PK_Inscripcion] PRIMARY KEY CLUSTERED 
(
	[id_campeonato] ASC,
	[anio_campeonato] ASC,
	[id_club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugador]    Script Date: 30/10/2018 15:16:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugador](
	[tipo_doc] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[calle] [varchar](50) NULL,
	[nro_calle] [int] NULL,
	[cod_postal] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Jugador] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JugadorXClub]    Script Date: 30/10/2018 15:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JugadorXClub](
	[id_club] [int] NOT NULL,
	[tipo_doc] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[fecha_inicio_actividad] [date] NULL,
	[fecha_fin_actividad] [date] NULL,
	[estado_examen_medico] [int] NOT NULL,
	[estado_jugador] [int] NULL,
 CONSTRAINT [PK_JugadorXClub] PRIMARY KEY CLUSTERED 
(
	[id_club] ASC,
	[tipo_doc] ASC,
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JugadorXClubXCampeonato]    Script Date: 30/10/2018 15:16:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JugadorXClubXCampeonato](
	[idClub] [int] NOT NULL,
	[dni_jugador] [int] NOT NULL,
	[tipo_doc] [int] NOT NULL,
	[id_campeonato] [int] NOT NULL,
	[anio_campeonato] [int] NOT NULL,
	[nroCamiseta] [int] NULL,
	[posicion_designada] [int] NULL,
 CONSTRAINT [PK_JugadorXClubXCampeonato_1] PRIMARY KEY CLUSTERED 
(
	[idClub] ASC,
	[dni_jugador] ASC,
	[tipo_doc] ASC,
	[id_campeonato] ASC,
	[anio_campeonato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JugadorXClubXCampeonatoXPartido]    Script Date: 30/10/2018 15:16:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JugadorXClubXCampeonatoXPartido](
	[idClub] [int] NOT NULL,
	[tipoDoc_jugador] [int] NOT NULL,
	[dni_jugador] [int] NOT NULL,
	[id_campeonato] [int] NOT NULL,
	[anio_campeonato] [int] NOT NULL,
	[id_club_local] [int] NOT NULL,
	[id_club_visitante] [int] NOT NULL,
	[numero_fecha] [int] NOT NULL,
	[id_resultado] [int] NOT NULL,
	[id_detalle_resultado] [int] NOT NULL,
	[goles_a_favor] [int] NULL,
	[goles_en_contra] [int] NULL,
	[cantidad_rojas] [int] NULL,
	[cantidad_amarillas] [int] NULL,
	[faltas_cometidas] [int] NULL,
 CONSTRAINT [PK_JugadorXClubXCampeonatoXPartido] PRIMARY KEY CLUSTERED 
(
	[idClub] ASC,
	[tipoDoc_jugador] ASC,
	[dni_jugador] ASC,
	[id_campeonato] ASC,
	[anio_campeonato] ASC,
	[id_club_local] ASC,
	[id_club_visitante] ASC,
	[numero_fecha] ASC,
	[id_resultado] ASC,
	[id_detalle_resultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 30/10/2018 15:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partido](
	[id_club_local] [int] NOT NULL,
	[id_club_visitante] [int] NOT NULL,
	[id_estado_partido] [int] NULL,
	[goles_locales] [int] NULL,
	[goles_visitante] [int] NULL,
	[fecha_hora_inicio] [date] NULL,
 CONSTRAINT [PK_Partido] PRIMARY KEY CLUSTERED 
(
	[id_club_local] ASC,
	[id_club_visitante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartidoXFechaXCampeonato]    Script Date: 30/10/2018 15:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartidoXFechaXCampeonato](
	[id_club_local] [int] NOT NULL,
	[id_club_visitante] [int] NOT NULL,
	[id_campeonato] [int] NOT NULL,
	[anio] [int] NOT NULL,
	[numero_fecha] [int] NOT NULL,
	[id_arbitro] [int] NULL,
 CONSTRAINT [PK_PartidoXFechaXCampeonato] PRIMARY KEY CLUSTERED 
(
	[id_club_local] ASC,
	[id_club_visitante] ASC,
	[id_campeonato] ASC,
	[anio] ASC,
	[numero_fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PosicionJugador]    Script Date: 30/10/2018 15:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PosicionJugador](
	[id_posicion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[siglas] [varchar](50) NULL,
 CONSTRAINT [PK__Posicion__2234F810EB71E234] PRIMARY KEY CLUSTERED 
(
	[id_posicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 30/10/2018 15:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReporteClub]    Script Date: 30/10/2018 15:16:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReporteClub](
	[id_club] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[puntos] [int] NULL,
	[partidos_ganados] [int] NULL,
	[partidos_empatados] [int] NULL,
	[partidos_jugados] [int] NULL,
	[goles] [int] NULL,
 CONSTRAINT [PK_ReporteClub] PRIMARY KEY CLUSTERED 
(
	[id_club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultadosPartido]    Script Date: 30/10/2018 15:16:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultadosPartido](
	[id_club_local] [int] NOT NULL,
	[id_club_visitante] [int] NOT NULL,
	[goles_locales] [int] NULL,
	[goles_visitantes] [int] NULL,
	[id_campeonato] [int] NOT NULL,
	[anio] [int] NOT NULL,
	[numero_fecha] [int] NOT NULL,
	[id_resultado] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ResultadosPartido_1] PRIMARY KEY CLUSTERED 
(
	[id_club_local] ASC,
	[id_club_visitante] ASC,
	[id_campeonato] ASC,
	[anio] ASC,
	[numero_fecha] ASC,
	[id_resultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolArbitro]    Script Date: 30/10/2018 15:16:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolArbitro](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK__RolArbit__6ABCB5E086D23C65] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sancion]    Script Date: 30/10/2018 15:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sancion](
	[id_sancion] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sancion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 30/10/2018 15:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[id_sesion] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[estado_sesion] [int] NULL,
	[fecha_hs_inicio] [date] NULL,
	[fecha_hs_fin] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 30/10/2018 15:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[id_tipoDoc] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK__TipoDoc__FBF85D31D85D03B9] PRIMARY KEY CLUSTERED 
(
	[id_tipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/10/2018 15:16:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] NOT NULL,
	[nombre] [varchar](1) NOT NULL,
	[contraseña] [varchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Arbitro] ON 

INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (10, 1, 23584521, N'Nèstor', N'Pitana', CAST(N'1958-01-01' AS Date), 1)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (11, 1, 24841235, N'Juan Pablo ', N'Belatti', CAST(N'1978-10-09' AS Date), 1)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (13, 1, 25484689, N'Hernan', N'Maldana', CAST(N'1986-05-12' AS Date), 1)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (14, 1, 25215800, N'Patricio', N'Loustau', CAST(N'1979-05-10' AS Date), 1)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (15, 1, 25484241, N'Horacio', N'Elizondo', CAST(N'1980-07-05' AS Date), 1)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (16, 1, 34054898, N'Dario', N'Herrera', CAST(N'1987-11-01' AS Date), 3)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (17, 1, 25654840, N'Mauro', N'Vigliano', CAST(N'1984-10-12' AS Date), 3)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (18, 1, 35485495, N'German', N'Delfino', CAST(N'1978-05-31' AS Date), 3)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (19, 1, 25455684, N'Federico', N'Beligoy', CAST(N'1981-10-10' AS Date), 3)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (20, 1, 21456412, N'Pablo', N'Lunati', CAST(N'1987-11-25' AS Date), 3)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (21, 1, 23545652, N'Diego', N'Abal', CAST(N'1990-01-05' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (22, 1, 33440054, N'Angel', N'Coerezza', CAST(N'1968-09-25' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (23, 1, 22354841, N'Francisco', N'Lamolina', CAST(N'1979-10-01' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (24, 1, 35484987, N'Diego', N'Ceballos', CAST(N'1985-06-09' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (25, 1, 32356648, N'Saul', N'Laverni', CAST(N'1983-07-05' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (26, 1, 35151651, N'Angel', N'Sanchez', CAST(N'1987-05-23' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (27, 1, 34112050, N'Juan Carlos', N'Loustau', CAST(N'1990-09-17' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (28, 1, 26082490, N'Sergio', N'Pezzotta', CAST(N'1981-10-31' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (29, 1, 32415468, N'Ricardo', N'Casas', CAST(N'1980-05-15' AS Date), 2)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (30, 1, 29452165, N'Fabian', N'Modorràn', CAST(N'1979-07-13' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Arbitro] OFF
SET IDENTITY_INSERT [dbo].[Campeonato] ON 

INSERT [dbo].[Campeonato] ([id_campeonato], [anio], [nombre], [fecha_inicio], [fecha_fin], [puntaje_victoria], [puntaje_empate], [id_estado_campeonato]) VALUES (2, 2018, N'Apertura', CAST(N'2018-12-01' AS Date), CAST(N'2018-12-06' AS Date), 3, 1, 3)
INSERT [dbo].[Campeonato] ([id_campeonato], [anio], [nombre], [fecha_inicio], [fecha_fin], [puntaje_victoria], [puntaje_empate], [id_estado_campeonato]) VALUES (11, 2018, N'Clausura', CAST(N'2018-10-15' AS Date), CAST(N'2018-11-15' AS Date), 3, 2, 3)
SET IDENTITY_INSERT [dbo].[Campeonato] OFF
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (1, N'Cordoba', 1)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (2, N'Buenos Aires', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (3, N'Rosario', 19)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (4, N'Ciudad de Salta', 16)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (5, N'San Juan', 17)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (6, N'Cosquin', 1)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (7, N'San Miguel de Tucuman', 22)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (8, N'Paranà', 7)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (9, N'Usuhaia', 21)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (10, N'Tigre', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (11, N'Colòn', 19)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (12, N'Mar del Plata', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (13, N'Ciudad de Santa Fe', 19)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (14, N'Lanùs', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (15, N'Ciudad de Corrientes', 6)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (16, N'Bahìa Blanca', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (17, N'San Isidro', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (18, N'Resistencia', 4)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (19, N'Vicente Lopez', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (20, N'Posadas', 13)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (21, N'Merlo', 23)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (22, N'San Salvador de Jujuy', 9)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (23, N'Quilmes', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (24, N'Banfield', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (25, N'Pilar', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (26, N'Godoy Cruz', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (27, N'Concordia', 7)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (28, N'Ciudad de la Rioja', 11)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (29, N'Comodoro Rivadavia', 5)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (30, N'Ituzaingò', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (31, N'Avellaneda', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (32, N'Santa Rosa', 10)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (33, N'Villaguay', 7)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (34, N'La Plata', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (35, N'Victoria', 2)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre], [id_provincia]) VALUES (36, N'Carlos Paz', 1)
SET IDENTITY_INSERT [dbo].[ClubFutbol] ON 

INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (8, N'CAT (C)', N'Talleres', N'35458426902', N'	Av. Pablo Richieri ', 1595, 5000, CAST(N'1913-10-13' AS Date), 17)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (10, N'RACING', N'Racing Club', N'2487954210', N'Pasaje Mozart ', 320, 5300, CAST(N'1903-03-25' AS Date), 1)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (11, N'CAT (T)', N'Atletico de Tucuman', N'2548421540', N'25 de Mayo', 1351, 5060, CAST(N'1902-09-27' AS Date), 2)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (12, N'CAH', N'Huracan', N'5412480065', N'	Av. Amancio Alcorta', 2570, 5010, CAST(N'1908-11-01' AS Date), 3)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (13, N'CARP', N'Plate', N'3254584521', N'Av. Figueroa Alcorta', 7597, 5010, CAST(N'1901-05-25' AS Date), 4)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (14, N'CABJ', N'Boca Juniors', N'3545215423', N'Brandsen ', 805, 5010, CAST(N'1905-04-03' AS Date), 5)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (15, N'DYJ', N'Defensa y Justicia', N'5421879230', N'Av. Humahuaca ', 244, 5310, CAST(N'1935-03-20' AS Date), 6)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (16, N'CAU', N'Union', N'5424351322', N'Av. Vicente López', 3513, 5120, CAST(N'1907-04-15' AS Date), 7)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (17, N'CAA', N'Aldosivi', N'2654524850', N'Av. de las Olimpíadas', 810, 5110, CAST(N'1913-03-29' AS Date), 8)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (18, N'CAVS', N'Velez', N'2654521541', N'	Av. Juan B. Justo', 9200, 5010, CAST(N'1910-01-01' AS Date), 9)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (19, N'CARC', N'Rosario Central', N'2154612354', N'	Bv. Avellaneda', 1540, 5020, CAST(N'1889-12-24' AS Date), 10)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (20, N'CDGCAT', N'Godoy Cruz', N'4512645210', N'Balcarce', 477, 5250, CAST(N'1921-06-01' AS Date), 11)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (21, N'CAB', N'Banfield', N'1235412354', N'Peña y Arenales', 1235, 5230, CAST(N'1896-01-21' AS Date), 12)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (22, N'CGE', N'Gimnasia (LP)', N'5412658790', N'Av. 60', 118, 5330, CAST(N'1887-06-03' AS Date), 13)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (23, N'CAI', N'Independiente', N'2545542154', N'Bochini', 751, 5300, CAST(N'1904-08-04' AS Date), 14)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (24, N'CASLA', N'San Lorenzo', N'3548499098', N'Av. Perito Moreno ', 4554, 5010, CAST(N'1908-04-01' AS Date), 15)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (25, N'CAB', N'Belgrano', N'5462451235', N'Arturo Orgaz', 510, 5000, CAST(N'1905-03-19' AS Date), 16)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (26, N'TIGRE', N'Tigre', N'5451235421', N'Av. Presidente Perón', 2650, 5340, CAST(N'1902-08-03' AS Date), 18)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (27, N'AAAJ', N'Argentinos Juniors', N'5421380703', N'Gavilán', 2151, 5010, CAST(N'1904-08-15' AS Date), 19)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (28, N'CAC', N'Colon', N'2354584521', N'	Av Juan José Paso', 3535, 5120, CAST(N'1905-05-05' AS Date), 20)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (29, N'NOB', N'Newell''s Old Boys', N'3254123554', N'	Parque de la Independencia', 2321, 5020, CAST(N'1903-11-03' AS Date), 21)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (30, N'SAN MARTIN', N'San Martin (SJ)', N'3545215484', N'	Mendoza Norte', 1164, 5040, CAST(N'1907-09-27' AS Date), 22)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (31, N'EdeLP', N'Estudiantes (LP)', N'5421235456', N'Ucrania', 3254, 5330, CAST(N'1905-08-04' AS Date), 23)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (32, N'CAST', N'San Martin (T)', N'5421523541', N'Bolívar', 1969, 5060, CAST(N'1909-11-02' AS Date), 24)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (33, N'CAP', N'Patronato', N'3542151459', N'	Padre Bartolomé Grella', 874, 5070, CAST(N'1914-02-01' AS Date), 25)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [fecha_fundaciòn], [id_estadio]) VALUES (34, N'CAL', N'Lanus', N'4551223541', N'Gral. Arias', 2125, 5130, CAST(N'1915-01-03' AS Date), 26)
SET IDENTITY_INSERT [dbo].[ClubFutbol] OFF
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5000, 1)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5010, 2)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5020, 3)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5030, 4)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5040, 5)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5050, 6)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5060, 7)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5070, 8)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5080, 9)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5090, 10)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5100, 11)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5110, 12)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5120, 13)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5130, 14)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5140, 15)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5150, 16)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5160, 17)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5170, 18)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5180, 19)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5190, 20)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5200, 21)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5210, 22)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5220, 23)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5230, 24)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5240, 25)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5250, 26)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5260, 27)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5270, 28)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5280, 29)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5290, 30)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5300, 31)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5310, 32)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5320, 33)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5330, 34)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5340, 35)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (1, N'Estadio Presidente Perón', N'El Cilindro', 1, 51400)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (2, N'Estadio Monumental José Fierro', N'	

Maracaná del rugby tucumano', 1, 35200)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (3, N'Estadio Tomás Adolfo Ducó', N'Globo', 1, 48310)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (4, N'Estadio Antonio Vespucio Liberti', N'Estadio Monumental', 1, 75700)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (5, N'Estadio Alberto José Armando', N'La Bombonera', 1, 49000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (6, N'Estadio Norberto Tomaghello', N'Sin apodo', 1, 18000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (7, N'Estadio 15 de Abril', N'Sin apodo', 1, 27600)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (8, N'Estadio José María Minella', N'Sin apodo', 1, 35200)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (9, N'Estadio José Amalfitani', N'El Fortìn', 1, 49600)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (10, N'Estadio Gigante de Arroyito', N'Sin apodo', 1, 45700)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (11, N'Estadio Malvinas Argentinas', N'Sin apodo', 1, 42500)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (12, N'Estadio Florencio Sola', N'El Lencho', 1, 34900)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (13, N'Estadio Juan Carmelo Zerillo', N'El Bosque', 1, 21000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (14, N'Estadio Libertadores de América', N'La Caldera del Diablo', 1, 55000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (15, N'Estadio Pedro Bidegain', N'El Nuevo Gasómetro', 1, 48000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (16, N'Estadio Julio César Villagra', N'Gigante de Alberdi', 1, 30500)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (17, N'Estadio Mario Alberto Kempes', N'Sin apodo', 1, 57000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (18, N'Estadio José Dellagiovanna ', N'Coliseo de Victoria', 1, 26300)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (19, N'Estadio Diego Armando Maradona', N'Sin apodo', 1, 26000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (20, N'Brigadier General Estanislao López', N'El cementerio de los elefantes', 1, 40000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (21, N'Estadio Marcelo Bielsa', N'Coloso del Parque', 1, 42000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (22, N'Estadio Ingeniero Hilario Sánchez', N'Sin apodo', 1, 26500)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (23, N'Estadio Jorge Luis Hirschi', N'Sin apodo', 1, 25000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (24, N'Estadio La Ciudadela', N'Sin apodo', 1, 26500)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (25, N'Estadio Presbítero Bartolomé Grella', N'Sin apodo', 1, 30000)
INSERT [dbo].[Estadio] ([id_estadio], [nombre], [descripcion], [id_estadoEstadio], [capacidad]) VALUES (26, N'Estadio Ciudad de Lanús - Néstor Díaz Pérez', N'La Fortaleza', 1, 47100)
INSERT [dbo].[EstadoCampeonato] ([id_estado_campeonato], [nombre_estado], [detalle_estado]) VALUES (1, N'En Curso', N'Esta Iniciado')
INSERT [dbo].[EstadoCampeonato] ([id_estado_campeonato], [nombre_estado], [detalle_estado]) VALUES (2, N'Finalizado', N'Esta Finalizado')
INSERT [dbo].[EstadoCampeonato] ([id_estado_campeonato], [nombre_estado], [detalle_estado]) VALUES (3, N'En Inscripcion', N'Esta en Inscripcion')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (1, N'Disponible', N'Disponible para disputar partido')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (2, N'Ocupado', N'Ocupado por evento o partido')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (3, N'Clausurado', N'Cerrado por autoridades estatales')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (4, N'Inhabilitado', N'Inhabilitado por reforma o fuera de condiciòn')
INSERT [dbo].[EstadoExamenMedico] ([id_examen_medico], [nombre], [descripcion]) VALUES (1, N'Aprobado', N'Se Aprobo')
INSERT [dbo].[EstadoExamenMedico] ([id_examen_medico], [nombre], [descripcion]) VALUES (2, N'Desaprobado', N'Reprobo')
SET IDENTITY_INSERT [dbo].[EstadoInscripcion] ON 

INSERT [dbo].[EstadoInscripcion] ([id_estado], [descripcion]) VALUES (1, N'En curso')
INSERT [dbo].[EstadoInscripcion] ([id_estado], [descripcion]) VALUES (2, N'Finalizado')
SET IDENTITY_INSERT [dbo].[EstadoInscripcion] OFF
INSERT [dbo].[EstadoJugador] ([id_estado_jugador], [nombre], [descripcion]) VALUES (1, N'Activo', N'Jugador en condiciones apropiadas para la actividad')
INSERT [dbo].[EstadoJugador] ([id_estado_jugador], [nombre], [descripcion]) VALUES (2, N'Suspendido', N'Sancionado por acumulacion de tarjetas o mal comportamiento fuera de cancha')
INSERT [dbo].[EstadoJugador] ([id_estado_jugador], [nombre], [descripcion]) VALUES (3, N'Lesionado', N'Con carpeta Medica')
INSERT [dbo].[EstadoJugadorVigencia] ([id_estado], [nombre]) VALUES (1, N'Con Contrato')
INSERT [dbo].[EstadoJugadorVigencia] ([id_estado], [nombre]) VALUES (2, N'Sin Contrato')
INSERT [dbo].[EstadoJugadorVigencia] ([id_estado], [nombre]) VALUES (3, N'Retirado')
INSERT [dbo].[EstadoPartido] ([id_estado], [nombre]) VALUES (1, N'Por disputar')
INSERT [dbo].[EstadoPartido] ([id_estado], [nombre]) VALUES (2, N'Disputado')
INSERT [dbo].[EstadoPartido] ([id_estado], [nombre]) VALUES (3, N'Suspendido')
INSERT [dbo].[EstadoSesion] ([id_estado], [nombre]) VALUES (1, N'Abierta')
INSERT [dbo].[EstadoSesion] ([id_estado], [nombre]) VALUES (2, N'Cerrada')
INSERT [dbo].[FechaXCampeonato] ([id_campeonato], [anio], [numero_fecha], [fecha_inicio]) VALUES (11, 2018, 1, CAST(N'2018-10-15' AS Date))
INSERT [dbo].[FechaXCampeonato] ([id_campeonato], [anio], [numero_fecha], [fecha_inicio]) VALUES (11, 2018, 2, CAST(N'2018-10-25' AS Date))
INSERT [dbo].[FechaXCampeonato] ([id_campeonato], [anio], [numero_fecha], [fecha_inicio]) VALUES (11, 2018, 3, CAST(N'2018-11-04' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (2, 2018, 14, 1, CAST(N'2018-10-07' AS Date), CAST(N'2018-11-30' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (2, 2018, 21, 1, CAST(N'2018-10-08' AS Date), CAST(N'2018-11-30' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (2, 2018, 23, 1, CAST(N'2018-10-08' AS Date), CAST(N'2018-11-30' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (2, 2018, 26, 1, CAST(N'2018-10-07' AS Date), CAST(N'2018-11-30' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (2, 2018, 32, 1, CAST(N'2018-10-07' AS Date), CAST(N'2018-11-30' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (2, 2018, 33, 1, CAST(N'2018-10-07' AS Date), CAST(N'2018-11-30' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (11, 2018, 8, 1, CAST(N'2018-10-13' AS Date), CAST(N'2018-10-14' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (11, 2018, 10, 1, CAST(N'2018-10-13' AS Date), CAST(N'2018-10-14' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (11, 2018, 11, 1, CAST(N'2018-10-13' AS Date), CAST(N'2018-10-14' AS Date))
INSERT [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club], [estado], [fechaInscripcion], [fechaCierre]) VALUES (11, 2018, 12, 1, CAST(N'2018-10-13' AS Date), CAST(N'2018-10-14' AS Date))
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 22154400, N'Sergio', N'Gonzales', CAST(N'1993-01-16' AS Date), N'Marinos', 2233, 5290, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 22331557, N'Ulises', N'Fernandez', CAST(N'1995-08-23' AS Date), N'Luis Cabrera', 6548, 5000, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 22850001, N'Franco', N'Shonfel', CAST(N'1996-09-04' AS Date), N'Carcano', 985, 5090, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23215112, N'Marcos', N'Zabala', CAST(N'1994-04-20' AS Date), N'Sol de noviembre', 80, 5010, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23223544, N'Felipe', N'Lampara', CAST(N'1990-05-07' AS Date), N'Tucumán', 478, 5000, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23244565, N'Luis', N'Posadas', CAST(N'1964-11-26' AS Date), N'La Linda', 2121, 5060, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23254568, N'Juan', N'Canilla', CAST(N'1997-03-08' AS Date), N'Fender', 5001, 5140, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23533333, N'Frabriano', N'Tucuman', CAST(N'1994-01-11' AS Date), N'Pilar', 9997, 5180, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23540000, N'Matias', N'Di Pietro', CAST(N'1997-03-27' AS Date), N'Armenia', 4566, 5280, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23541223, N'Martin', N'De la Cuesta', CAST(N'1996-06-06' AS Date), N'Cordoba', 2001, 5190, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23542154, N'Jacinto', N'Moon', CAST(N'1993-07-17' AS Date), N'Bulnes', 456, 5090, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23548000, N'Julian', N'Afilado', CAST(N'1999-07-12' AS Date), N'Arenales', 2549, 5180, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23548421, N'Jesùs', N'Cabildo', CAST(N'1999-11-01' AS Date), N'Candelario ', 936, 5240, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23554484, N'Marcos', N'Bini', CAST(N'1996-12-01' AS Date), N'Los pinos', 6554, 5120, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 23554487, N'Emmanuel', N'Orquesta', CAST(N'2001-11-24' AS Date), N'Arbolada', 230, 5000, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25445022, N'Jose', N'Paredes', CAST(N'1984-04-06' AS Date), N'Azucar', 1231, 5050, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25445654, N'Orpfelio', N'Riquelme', CAST(N'2000-06-01' AS Date), N'Los Monos', 322, 5080, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25449001, N'Martin', N'Piña', CAST(N'1993-05-05' AS Date), N'Rincòn', 126, 5100, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25455655, N'Hernan', N'Magliano', CAST(N'1995-03-03' AS Date), N'Las Partidas', 120, 5220, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25455684, N'Oliver', N'Atom', CAST(N'1988-04-12' AS Date), N'Japòn', 1252, 5100, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25456289, N'Sebastian', N'Puertas', CAST(N'1999-04-13' AS Date), N'Arboles Azules', 110, 5080, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25484521, N'Cristian', N'Compuerta', CAST(N'1998-06-11' AS Date), N'Posadas', 1257, 5170, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25484623, N'Mariano', N'Ruald', CAST(N'1998-01-20' AS Date), N'Pitagoras', 354, 5260, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25487894, N'Eduardo', N'Sandoval', CAST(N'1998-12-12' AS Date), N'Dragones', 154, 5250, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25542213, N'Eugenio', N'Segobian', CAST(N'1984-02-13' AS Date), N'Peròn', 2354, 5090, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 25887664, N'Daniel', N'Bini', CAST(N'1998-01-01' AS Date), N'Las Palmeras', 5212, 5100, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 26054884, N'Julio', N'Brites', CAST(N'1975-07-07' AS Date), N'Calle 5', 8, 5130, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 26358488, N'Dario', N'Gonzales', CAST(N'1998-03-28' AS Date), N'Los reyes', 1223, 5260, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 26545452, N'Nicolas', N'Torres', CAST(N'1989-12-05' AS Date), N'Bosque Azul', 2135, 5200, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 27000254, N'Danilo', N'Corrientes', CAST(N'1993-09-11' AS Date), N'Evita', 7005, 5050, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 28456899, N'Alberto', N'Lopez', CAST(N'1996-10-31' AS Date), N'Juniors', 235, 5210, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 28654254, N'Gino', N'Dualde', CAST(N'1998-01-21' AS Date), N'Colòn', 254, 5270, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 28987321, N'Enrrique', N'Telona', CAST(N'1998-06-08' AS Date), N'La Niña', 5440, 5130, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 29100255, N'Franco', N'Ariza', CAST(N'1999-05-13' AS Date), N'Adolfo II', 3654, 5270, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 29544456, N'Adrian', N'Giñazu', CAST(N'1981-05-28' AS Date), N'Oncativo', 823, 5030, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 29545321, N'Bartolomeo', N'Ruè', CAST(N'1995-11-30' AS Date), N'Estados Unidos', 852, 5220, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30025001, N'Roman', N'Ventanal', CAST(N'2000-01-06' AS Date), N'Salta', 3560, 5080, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30125870, N'Alejo', N'Rojas', CAST(N'1999-04-24' AS Date), N'Lima', 6210, 5270, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30140054, N'Emmanuel', N'Lampara', CAST(N'1999-05-21' AS Date), N'Rios Seguros', 241, 5250, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30205048, N'Rodrigo', N'Venanales', CAST(N'2002-12-11' AS Date), N'Cosquin', 1547, 5010, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30215484, N'Facundo', N'Jolato', CAST(N'1997-03-05' AS Date), N'Malvinas Argentinas', 789, 5200, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30251023, N'Agustin', N'Pietro', CAST(N'1995-02-05' AS Date), N'Libra', 3561, 5100, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30358456, N'Gillermo', N'Giardino', CAST(N'1995-09-11' AS Date), N'Papa III', 2123, 5060, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 30548905, N'Manuel', N'Circulos Redondos', CAST(N'1999-05-23' AS Date), N'Viamonete', 2005, 5260, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 31102030, N'Federico', N'Lampiño', CAST(N'1993-08-01' AS Date), N'Mares del Este', 850, 5190, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 31545800, N'Umberto', N'De Santana', CAST(N'1997-09-30' AS Date), N'Pueyrredon', 2654, 5200, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 31545846, N'Camilo', N'Beanz', CAST(N'1997-08-31' AS Date), N'Milagros Sierras', 54, 5220, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 31549850, N'Carmelo', N'Mercedez', CAST(N'1997-01-08' AS Date), N'Salamandra', 20, 5230, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32100020, N'Guillermo', N'Rosales', CAST(N'2001-04-18' AS Date), N'Paris', 321, 5050, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32123842, N'Pedro', N'Tesla', CAST(N'1997-05-10' AS Date), N'Yamaha', 1546, 5160, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32151522, N'Lucas', N'Reynoso', CAST(N'1999-08-07' AS Date), N'Geronico', 901, 5000, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32154500, N'Julio', N'Rojas', CAST(N'1996-04-22' AS Date), N'Italia', 7563, 5030, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32540012, N'Mauricio', N'Macri', CAST(N'2000-10-04' AS Date), N'Los Marineros', 987, 5070, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32546842, N'Luis', N'Narton', CAST(N'1996-04-09' AS Date), N'Gibson', 5003, 5150, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32554229, N'Marcos', N'Farelli', CAST(N'1998-06-08' AS Date), N'Concepcion Uruguay', 500, 5130, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 32554584, N'Gustavo', N'Gallardo', CAST(N'1990-03-16' AS Date), N'Urquiza', 2234, 5170, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 33120858, N'Marcelo', N'Arandanos', CAST(N'1992-12-12' AS Date), N'Carlos Paz', 541, 5160, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 33215544, N'Orlando', N'Florida', CAST(N'2000-06-06' AS Date), N'De San Juan', 654, 5060, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 33255456, N'Nicolas', N'Striker', CAST(N'1991-06-09' AS Date), N'Los Pericos', 1554, 5010, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 33421254, N'Josuè', N'De las Rosas', CAST(N'1998-01-17' AS Date), N'Urquiza', 4511, 5000, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34025482, N'Raul', N'Rosas', CAST(N'1993-08-07' AS Date), N'Francia', 159, 5040, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34059778, N'Nahuel', N'Cordoba', CAST(N'1989-11-21' AS Date), N'Belgrano', 5452, 5180, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34082498, N'Lautaro', N'Castillos', CAST(N'1991-05-31' AS Date), N'La voz', 3548, 5110, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34215485, N'Alfonso', N'Camiseta', CAST(N'1997-06-08' AS Date), N'Las Lechuzas', 154, 5120, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34254060, N'Jonathan', N'Ciruelas', CAST(N'1998-02-10' AS Date), N'Patria', 5128, 5280, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34512510, N'Martino', N'Gonzales', CAST(N'1989-04-04' AS Date), N'Uritorco', 2235, 5090, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34521685, N'Geremias', N'Lechuga', CAST(N'1999-03-20' AS Date), N'24 Septiembre', 2154, 5290, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34777845, N'Alfredo', N'Huerta Grande', CAST(N'1998-08-13' AS Date), N'General Paz', 1254, 5190, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34825492, N'Mariano', N'Diaz', CAST(N'1985-11-20' AS Date), N'Jose Paredes', 1458, 5000, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 34854120, N'Seleno', N'Sanchez', CAST(N'1993-11-24' AS Date), N'Romanos', 753, 5020, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35112521, N'Matias', N'Leumulle', CAST(N'1991-09-04' AS Date), N'Luceros ', 210, 5150, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35421002, N'Javier', N'Luna', CAST(N'1999-02-26' AS Date), N'Piratas Caribeños', 789, 5080, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35421500, N'Samuel', N'Di Afston', CAST(N'1997-05-31' AS Date), N'Alem', 123, 5100, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35421568, N'Hernan', N'Horno', CAST(N'1997-01-16' AS Date), N'Los Alamos', 658, 5110, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35435125, N'Lucas', N'Muelles', CAST(N'1991-10-16' AS Date), N'Zodiacos', 5410, 5140, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35448256, N'Ezequiel', N'Paredes', CAST(N'1999-07-07' AS Date), N'Paranà', 212, 5030, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35452100, N'Adrian', N'Soleado', CAST(N'1988-12-31' AS Date), N'Esquina Tres', 121, 5070, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35458456, N'Ariel', N'Sanchez', CAST(N'1989-01-02' AS Date), N'Sarmiento', 5870, 5000, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35460589, N'Manuel', N'Mesada', CAST(N'1984-05-08' AS Date), N'Divididos', 2544, 5130, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35480045, N'Jorge', N'Gitano', CAST(N'1996-10-11' AS Date), N'Ramòn J. Carcano', 9132, 5020, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35489651, N'Thiago', N'Celestiales', CAST(N'1997-01-01' AS Date), N'Roma', 321, 5240, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35642154, N'Alejandro', N'Tomates Rojos', CAST(N'1999-03-21' AS Date), N'Oncativo', 2356, 5280, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35689740, N'Leonel', N'Fuentes', CAST(N'1998-12-13' AS Date), N'Astrales', 2013, 5120, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 35889878, N'Naum', N'Capitan Trompa', CAST(N'2000-05-07' AS Date), N'San Martìn', 2164, 5000, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 38445854, N'Tomas', N'Fuseneco', CAST(N'2001-08-30' AS Date), N'Lucky', 2213, 5160, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 38452135, N'Claudio', N'Been', CAST(N'1997-08-25' AS Date), N'Rosa Calamuchita', 652, 5210, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 53255458, N'Fernando', N'Segol', CAST(N'1998-03-28' AS Date), N'Chile', 988, 5290, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (1, 55845684, N'Claudio', N'Benegas', CAST(N'1992-05-07' AS Date), N'Juen B ', 5546, 5150, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 18212354, N'David', N'Dominguez', CAST(N'1992-06-08' AS Date), N'Belgrano', 845, 5070, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 23542213, N'Alex', N'Piedras', CAST(N'1993-12-25' AS Date), N'Hercules', 22354, 5010, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 23548421, N'Orphen', N'Pereyra', CAST(N'1992-01-10' AS Date), N'Temple', 210, 5170, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 25448432, N'Damian', N'Pereyra', CAST(N'1984-01-08' AS Date), N'Rios Dorados', 1254, 5110, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 28778984, N'Marcelo', N'Petenian', CAST(N'1997-05-03' AS Date), N'Sarmiento', 5681, 5090, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 29456213, N'Marcos', N'Los Maderos', CAST(N'1996-08-17' AS Date), N'Los Tamales', 2456, 5130, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 29540213, N'Romeo', N'Lopez', CAST(N'1994-10-29' AS Date), N'Japòn', 741, 5230, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (2, 32221540, N'Gabriel', N'Gambogi', CAST(N'2000-05-24' AS Date), N'Palemòn', 3546, 5120, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (3, 15545684, N'Rodrigo', N'Mathot', CAST(N'1990-07-09' AS Date), N'Santa Rosa', 213, 5130, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (3, 32125484, N'Giovan', N'Ferrari', CAST(N'1993-09-24' AS Date), N'Santiago Ruiz', 500, 5180, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (3, 38004925, N'Axel', N'De la Fuente', CAST(N'1998-10-01' AS Date), N'Olimpo', 2011, 5110, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_estado]) VALUES (3, 39998412, N'Marcos', N'Navarro', CAST(N'1988-11-25' AS Date), N'Parque Verde', 6445, 5210, 1)
GO
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 15545684, 3, 11, 2018, 3, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 18212354, 2, 11, 2018, 10, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 23542213, 2, 11, 2018, 9, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 23548421, 1, 11, 2018, 8, 4)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 25448432, 2, 11, 2018, 7, 5)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 28778984, 2, 11, 2018, 6, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 29456213, 2, 11, 2018, 5, 6)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 29540213, 2, 11, 2018, 4, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 32125484, 3, 11, 2018, 2, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (8, 55845684, 1, 11, 2018, 11, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 23541223, 1, 11, 2018, 1, 6)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35458456, 1, 11, 2018, 11, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35460589, 1, 11, 2018, 10, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35480045, 1, 11, 2018, 9, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35489651, 1, 11, 2018, 8, 4)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35642154, 1, 11, 2018, 7, 4)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35689740, 1, 11, 2018, 6, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 35889878, 1, 11, 2018, 5, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 38445854, 1, 11, 2018, 4, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (10, 38452135, 1, 11, 2018, 3, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 34825492, 1, 11, 2018, 7, 5)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 34854120, 1, 11, 2018, 6, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 35421002, 1, 11, 2018, 4, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 35421500, 1, 11, 2018, 3, 5)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 35421568, 1, 11, 2018, 2, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 35448256, 1, 11, 2018, 10, 6)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 35452100, 1, 11, 2018, 8, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 38004925, 3, 11, 2018, 11, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (11, 53255458, 1, 11, 2018, 9, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 22154400, 1, 11, 2018, 11, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 22331557, 1, 11, 2018, 10, 6)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 28456899, 1, 11, 2018, 3, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 29545321, 1, 11, 2018, 7, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 30125870, 1, 11, 2018, 4, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 30251023, 1, 11, 2018, 2, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 31545800, 1, 11, 2018, 9, 4)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 31545846, 1, 11, 2018, 8, 2)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 34215485, 1, 11, 2018, 5, 3)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (12, 34777845, 1, 11, 2018, 6, 5)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato], [nroCamiseta], [posicion_designada]) VALUES (14, 32221540, 2, 2, 2018, 4, 1)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (8, 1, 23548421, 11, 2018, 12, 8, 1, 1005, 3, 0, 0, 0, 1, 3)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (8, 2, 29540213, 11, 2018, 12, 8, 1, 1005, 2, 1, 0, 0, 1, 2)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (8, 3, 15545684, 11, 2018, 12, 8, 1, 1005, 1, 1, 0, 0, 0, 0)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (10, 1, 35458456, 11, 2018, 10, 11, 1, 2, 1, 1, 0, 0, 1, 3)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (10, 1, 35460589, 11, 2018, 10, 11, 1, 2, 2, 1, 0, 0, 0, 0)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (10, 1, 35889878, 11, 2018, 8, 10, 2, 1006, 1, 0, 0, 1, 0, 1)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (11, 1, 35421568, 11, 2018, 10, 11, 1, 2, 4, 0, 0, 1, 2, 5)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (11, 1, 35421568, 11, 2018, 11, 12, 2, 1007, 1, 2, 0, 0, 0, 1)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (11, 3, 38004925, 11, 2018, 10, 11, 1, 2, 3, 1, 0, 0, 0, 0)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (12, 1, 30125870, 11, 2018, 11, 12, 2, 1007, 2, 1, 0, 0, 0, 0)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (12, 1, 31545800, 11, 2018, 12, 8, 1, 1005, 4, 1, 0, 0, 0, 1)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (12, 1, 34215485, 11, 2018, 11, 12, 2, 1007, 3, 1, 0, 0, 0, 0)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (12, 1, 34777845, 11, 2018, 11, 12, 2, 1007, 4, 1, 0, 0, 1, 1)
INSERT [dbo].[JugadorXClubXCampeonatoXPartido] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [id_club_local], [id_club_visitante], [numero_fecha], [id_resultado], [id_detalle_resultado], [goles_a_favor], [goles_en_contra], [cantidad_rojas], [cantidad_amarillas], [faltas_cometidas]) VALUES (12, 1, 34777845, 11, 2018, 12, 8, 1, 1005, 5, 0, 0, 1, 2, 3)
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (8, 10, 11, 2018, 2, 25)
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (10, 11, 11, 2018, 1, 21)
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (11, 8, 11, 2018, 3, 17)
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (11, 12, 11, 2018, 2, 20)
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (12, 8, 11, 2018, 1, 18)
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (12, 10, 11, 2018, 3, 25)
SET IDENTITY_INSERT [dbo].[PosicionJugador] ON 

INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (1, N'DEFENSOR', N'DEF')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (2, N'DELANTERO', N'DEL')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (3, N'MEDIO CAMPO', N'MED')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (4, N'LATERAL IZQUIERDO', N'LAT IZQ')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (5, N'LATERAL DERECHO', N'LAT DER')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (6, N'ARQUERO', N'ARQ')
SET IDENTITY_INSERT [dbo].[PosicionJugador] OFF
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (2, N'Buenos Aires')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (3, N'Catamarca')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (4, N'Chaco')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (5, N'Chubut')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (6, N'Corrientes')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (7, N'Entre Rios')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (8, N'Formosa')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (9, N'Jujuy')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (10, N'La Pampa')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (11, N'La Rioja')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (12, N'Mendoza')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (13, N'Misiones')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (14, N'Neuquèn')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (15, N'Rio Negro')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (16, N'Salta')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (17, N'San Juan')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (18, N'Santa Cruz')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (19, N'Santa Fe')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (20, N'Santiago del Estero')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (21, N'Tierra del Fuego')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (22, N'Tucumàn')
INSERT [dbo].[Provincias] ([id], [nombre]) VALUES (23, N'San Luis')
INSERT [dbo].[ReporteClub] ([id_club], [nombre], [puntos], [partidos_ganados], [partidos_empatados], [partidos_jugados], [goles]) VALUES (8, N'Talleres  ', 4, 1, 1, 2, 2)
INSERT [dbo].[ReporteClub] ([id_club], [nombre], [puntos], [partidos_ganados], [partidos_empatados], [partidos_jugados], [goles]) VALUES (10, N'RacingClub', 4, 1, 1, 2, 2)
INSERT [dbo].[ReporteClub] ([id_club], [nombre], [puntos], [partidos_ganados], [partidos_empatados], [partidos_jugados], [goles]) VALUES (11, N'Atletico de Tucuman', 0, 0, 0, 2, 3)
INSERT [dbo].[ReporteClub] ([id_club], [nombre], [puntos], [partidos_ganados], [partidos_empatados], [partidos_jugados], [goles]) VALUES (12, N'Huracan', 3, 1, 0, 2, 4)
SET IDENTITY_INSERT [dbo].[ResultadosPartido] ON 

INSERT [dbo].[ResultadosPartido] ([id_club_local], [id_club_visitante], [goles_locales], [goles_visitantes], [id_campeonato], [anio], [numero_fecha], [id_resultado]) VALUES (8, 10, 0, 0, 11, 2018, 2, 1006)
INSERT [dbo].[ResultadosPartido] ([id_club_local], [id_club_visitante], [goles_locales], [goles_visitantes], [id_campeonato], [anio], [numero_fecha], [id_resultado]) VALUES (10, 11, 2, 1, 11, 2018, 1, 2)
INSERT [dbo].[ResultadosPartido] ([id_club_local], [id_club_visitante], [goles_locales], [goles_visitantes], [id_campeonato], [anio], [numero_fecha], [id_resultado]) VALUES (11, 12, 2, 3, 11, 2018, 2, 1007)
INSERT [dbo].[ResultadosPartido] ([id_club_local], [id_club_visitante], [goles_locales], [goles_visitantes], [id_campeonato], [anio], [numero_fecha], [id_resultado]) VALUES (12, 8, 1, 2, 11, 2018, 1, 1005)
SET IDENTITY_INSERT [dbo].[ResultadosPartido] OFF
SET IDENTITY_INSERT [dbo].[RolArbitro] ON 

INSERT [dbo].[RolArbitro] ([id_rol], [nombre]) VALUES (1, N'Principal')
INSERT [dbo].[RolArbitro] ([id_rol], [nombre]) VALUES (2, N'Asistente')
INSERT [dbo].[RolArbitro] ([id_rol], [nombre]) VALUES (3, N'Cuarto')
SET IDENTITY_INSERT [dbo].[RolArbitro] OFF
INSERT [dbo].[Sancion] ([id_sancion], [nombre], [descripcion]) VALUES (1, N'Amarilla', N'Amolestado')
INSERT [dbo].[Sancion] ([id_sancion], [nombre], [descripcion]) VALUES (2, N'Roja', N'Expulsado')
SET IDENTITY_INSERT [dbo].[TipoDoc] ON 

INSERT [dbo].[TipoDoc] ([id_tipoDoc], [nombre]) VALUES (1, N'DNI')
INSERT [dbo].[TipoDoc] ([id_tipoDoc], [nombre]) VALUES (2, N'CEDULA')
INSERT [dbo].[TipoDoc] ([id_tipoDoc], [nombre]) VALUES (3, N'PASAPORTE')
SET IDENTITY_INSERT [dbo].[TipoDoc] OFF
ALTER TABLE [dbo].[Campeonato]  WITH CHECK ADD  CONSTRAINT [FK_estadoCampeonato] FOREIGN KEY([id_estado_campeonato])
REFERENCES [dbo].[EstadoCampeonato] ([id_estado_campeonato])
GO
ALTER TABLE [dbo].[Campeonato] CHECK CONSTRAINT [FK_estadoCampeonato]
GO
ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Ciudadxprovinmcia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincias] ([id])
GO
ALTER TABLE [dbo].[Ciudad] CHECK CONSTRAINT [FK_Ciudadxprovinmcia]
GO
ALTER TABLE [dbo].[ClubFutbol]  WITH CHECK ADD  CONSTRAINT [FK_codigoPostalClub] FOREIGN KEY([cod_postal])
REFERENCES [dbo].[CodigoPostal] ([id_codPostal])
GO
ALTER TABLE [dbo].[ClubFutbol] CHECK CONSTRAINT [FK_codigoPostalClub]
GO
ALTER TABLE [dbo].[ClubFutbol]  WITH CHECK ADD  CONSTRAINT [FK_EstadioClubFutbol] FOREIGN KEY([id_estadio])
REFERENCES [dbo].[Estadio] ([id_estadio])
GO
ALTER TABLE [dbo].[ClubFutbol] CHECK CONSTRAINT [FK_EstadioClubFutbol]
GO
ALTER TABLE [dbo].[CodigoPostal]  WITH CHECK ADD  CONSTRAINT [FK_ciudadCodigoPostal] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [dbo].[CodigoPostal] CHECK CONSTRAINT [FK_ciudadCodigoPostal]
GO
ALTER TABLE [dbo].[Estadio]  WITH CHECK ADD  CONSTRAINT [FK_estadoEstad] FOREIGN KEY([id_estadoEstadio])
REFERENCES [dbo].[EstadoEstadio] ([id_estado])
GO
ALTER TABLE [dbo].[Estadio] CHECK CONSTRAINT [FK_estadoEstad]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_Campeonato] FOREIGN KEY([id_campeonato], [anio_campeonato])
REFERENCES [dbo].[Campeonato] ([id_campeonato], [anio])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_Campeonato]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_ClubFutbol] FOREIGN KEY([id_club])
REFERENCES [dbo].[ClubFutbol] ([id_club])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_ClubFutbol]
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Inscripcion_EstadoInscripcion] FOREIGN KEY([estado])
REFERENCES [dbo].[EstadoInscripcion] ([id_estado])
GO
ALTER TABLE [dbo].[Inscripcion] CHECK CONSTRAINT [FK_Inscripcion_EstadoInscripcion]
GO
ALTER TABLE [dbo].[Jugador]  WITH CHECK ADD  CONSTRAINT [FK_codigoPostalJugador] FOREIGN KEY([cod_postal])
REFERENCES [dbo].[CodigoPostal] ([id_codPostal])
GO
ALTER TABLE [dbo].[Jugador] CHECK CONSTRAINT [FK_codigoPostalJugador]
GO
ALTER TABLE [dbo].[Jugador]  WITH CHECK ADD  CONSTRAINT [FK_JugadoEstadoVigencia] FOREIGN KEY([id_estado])
REFERENCES [dbo].[EstadoJugadorVigencia] ([id_estado])
GO
ALTER TABLE [dbo].[Jugador] CHECK CONSTRAINT [FK_JugadoEstadoVigencia]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClubXCampeonato_Inscripcion] FOREIGN KEY([id_campeonato], [anio_campeonato], [idClub])
REFERENCES [dbo].[Inscripcion] ([id_campeonato], [anio_campeonato], [id_club])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato] CHECK CONSTRAINT [FK_JugadorXClubXCampeonato_Inscripcion]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClubXCampeonato_Jugador] FOREIGN KEY([tipo_doc], [dni_jugador])
REFERENCES [dbo].[Jugador] ([tipo_doc], [dni])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato] CHECK CONSTRAINT [FK_JugadorXClubXCampeonato_Jugador]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_posicionDesignada] FOREIGN KEY([posicion_designada])
REFERENCES [dbo].[PosicionJugador] ([id_posicion])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato] CHECK CONSTRAINT [FK_posicionDesignada]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClubXCampeonatoXPartido_JugadorXClubXCampeonato] FOREIGN KEY([idClub], [dni_jugador], [tipoDoc_jugador], [id_campeonato], [anio_campeonato])
REFERENCES [dbo].[JugadorXClubXCampeonato] ([idClub], [dni_jugador], [tipo_doc], [id_campeonato], [anio_campeonato])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido] CHECK CONSTRAINT [FK_JugadorXClubXCampeonatoXPartido_JugadorXClubXCampeonato]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClubXCampeonatoXPartido_ResultadosPartido] FOREIGN KEY([id_club_local], [id_club_visitante], [id_campeonato], [anio_campeonato], [numero_fecha], [id_resultado])
REFERENCES [dbo].[ResultadosPartido] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_resultado])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido] CHECK CONSTRAINT [FK_JugadorXClubXCampeonatoXPartido_ResultadosPartido]
GO
ALTER TABLE [dbo].[Partido]  WITH CHECK ADD  CONSTRAINT [FK_EstadoPartido] FOREIGN KEY([id_estado_partido])
REFERENCES [dbo].[EstadoPartido] ([id_estado])
GO
ALTER TABLE [dbo].[Partido] CHECK CONSTRAINT [FK_EstadoPartido]
GO
ALTER TABLE [dbo].[PartidoXFechaXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_arbitro_PXFXC] FOREIGN KEY([id_arbitro])
REFERENCES [dbo].[Arbitro] ([id_arbitro])
GO
ALTER TABLE [dbo].[PartidoXFechaXCampeonato] CHECK CONSTRAINT [FK_arbitro_PXFXC]
GO
ALTER TABLE [dbo].[PartidoXFechaXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_PartidoXFechaXCampeonato_FechaXCampeonato] FOREIGN KEY([id_campeonato], [anio], [numero_fecha])
REFERENCES [dbo].[FechaXCampeonato] ([id_campeonato], [anio], [numero_fecha])
GO
ALTER TABLE [dbo].[PartidoXFechaXCampeonato] CHECK CONSTRAINT [FK_PartidoXFechaXCampeonato_FechaXCampeonato]
GO
ALTER TABLE [dbo].[ReporteClub]  WITH CHECK ADD  CONSTRAINT [FK_ReporteClub_ClubFutbol] FOREIGN KEY([id_club])
REFERENCES [dbo].[ClubFutbol] ([id_club])
GO
ALTER TABLE [dbo].[ReporteClub] CHECK CONSTRAINT [FK_ReporteClub_ClubFutbol]
GO
ALTER TABLE [dbo].[ResultadosPartido]  WITH CHECK ADD  CONSTRAINT [FK_ResultadosPartido_PartidoXFechaXCampeonato] FOREIGN KEY([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha])
REFERENCES [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha])
GO
ALTER TABLE [dbo].[ResultadosPartido] CHECK CONSTRAINT [FK_ResultadosPartido_PartidoXFechaXCampeonato]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_estadoSes] FOREIGN KEY([estado_sesion])
REFERENCES [dbo].[EstadoSesion] ([id_estado])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_estadoSes]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_usuario]
GO
USE [master]
GO
ALTER DATABASE [CampeonatoPav] SET  READ_WRITE 
GO
