USE [master]
GO
/****** Object:  Database [CampeonatoPav]    Script Date: 27/9/2018 14:56:23 ******/
CREATE DATABASE [CampeonatoPav]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CampeonatoPav', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CampeonatoPav.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CampeonatoPav_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CampeonatoPav_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
ALTER DATABASE [CampeonatoPav] SET RECOVERY FULL 
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
EXEC sys.sp_db_vardecimal_storage_format N'CampeonatoPav', N'ON'
GO
ALTER DATABASE [CampeonatoPav] SET QUERY_STORE = OFF
GO
USE [CampeonatoPav]
GO
/****** Object:  Table [dbo].[Arbitro]    Script Date: 27/9/2018 14:56:23 ******/
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
/****** Object:  Table [dbo].[Campeonato]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campeonato](
	[id_campeonato] [int]  NOT NULL,
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
/****** Object:  Table [dbo].[Ciudad]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[id_ciudad] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubFutbol]    Script Date: 27/9/2018 14:56:24 ******/
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
	[id_estado_club] [int] NULL,
 CONSTRAINT [PK__ClubFutb__6FA6EEEF067C88B4] PRIMARY KEY CLUSTERED 
(
	[id_club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodigoPostal]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[Estadio]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadio](
	[id_estadio] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
	[cod_postal] [int] NULL,
	[numero_calle] [int] NULL,
	[calle] [varchar](50) NULL,
	[id_estadoEstadio] [int] NULL,
	[capacidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estadio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCampeonato]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[EstadoClub]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoClub](
	[id_estado_club] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoEstadio]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[EstadoExamenMedico]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[EstadoFecha]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoFecha](
	[id_estado] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoJugador]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[EstadoPartido]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[EstadoSesion]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[FechaXCampeonato]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FechaXCampeonato](
	[id_campeonato] [int] NOT NULL,
	[anio] [int] NOT NULL,
	[numero_fecha] [int] NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_fin] [date] NULL,
	[id_estado_fecha] [int] NULL,
	[fecha_retomo_suspencion] [date] NULL,
 CONSTRAINT [PK_FechaXCampeonato] PRIMARY KEY CLUSTERED 
(
	[id_campeonato] ASC,
	[anio] ASC,
	[numero_fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugador]    Script Date: 27/9/2018 14:56:24 ******/
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
	[id_posicion_preferente] [int] NULL,
 CONSTRAINT [PK_Jugador] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JugadorXClub]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[JugadorXClubXCampeonato]    Script Date: 27/9/2018 14:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JugadorXClubXCampeonato](
	[idClub] [int] NOT NULL,
	[tipoDoc_jugador] [int] NOT NULL,
	[dni_jugador] [int] NOT NULL,
	[id_campeonato] [int] NOT NULL,
	[anio_campeonato] [int] NOT NULL,
	[fecha_inicio] [date] NULL,
	[fecha_fin] [date] NULL,
	[nroCamiseta] [int] NULL,
	[posicion_designada] [int] NULL,
 CONSTRAINT [PK_JugadorXClubXCampeonato] PRIMARY KEY CLUSTERED 
(
	[idClub] ASC,
	[tipoDoc_jugador] ASC,
	[dni_jugador] ASC,
	[id_campeonato] ASC,
	[anio_campeonato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JugadorXClubXCampeonatoXPartido]    Script Date: 27/9/2018 14:56:24 ******/
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
	[goles_a_favor] [int] NULL,
	[goles_en_contra] [int] NULL,
	[cantidad_rojas] [int] NULL,
	[cantidad_amarillas] [int] NULL,
	[faltas_cometidas] [int] NULL,
	[id_sancion] [int] NULL,
	[minutos_jugados] [int] NULL,
 CONSTRAINT [PK_JugadorXClubXCampeonatoXPartido] PRIMARY KEY CLUSTERED 
(
	[idClub] ASC,
	[tipoDoc_jugador] ASC,
	[dni_jugador] ASC,
	[id_campeonato] ASC,
	[anio_campeonato] ASC,
	[id_club_local] ASC,
	[id_club_visitante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[PartidoXFechaXCampeonato]    Script Date: 27/9/2018 14:56:24 ******/
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
/****** Object:  Table [dbo].[PosicionJugador]    Script Date: 27/9/2018 14:56:25 ******/
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
/****** Object:  Table [dbo].[RolArbitro]    Script Date: 27/9/2018 14:56:25 ******/
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
/****** Object:  Table [dbo].[Sancion]    Script Date: 27/9/2018 14:56:25 ******/
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
/****** Object:  Table [dbo].[Sesion]    Script Date: 27/9/2018 14:56:25 ******/
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
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 27/9/2018 14:56:25 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/9/2018 14:56:25 ******/
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

INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (10, 3, 333, N'ffffff', N'ssss', CAST(N'2018-01-01' AS Date), 3)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (11, 1, 8, N'ppppp', N'ggggg', CAST(N'2016-02-03' AS Date), 1)
INSERT [dbo].[Arbitro] ([id_arbitro], [tipo_doc], [DNI], [nombre], [apellido], [fecha_nacimiento], [rol_autoridad]) VALUES (12, 2, 4, N'uuuuuuuuuuu', N'rrrrrrrr', CAST(N'2018-01-06' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Arbitro] OFF
INSERT [dbo].[Campeonato] ([id_campeonato], [anio], [nombre], [fecha_inicio], [fecha_fin], [puntaje_victoria], [puntaje_empate], [id_estado_campeonato]) VALUES (1, 2018, N'Clausuras', CAST(N'2018-03-03' AS Date), CAST(N'2018-06-15' AS Date), 3, 1, 1)
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre]) VALUES (2, N'Buenos Aires')
INSERT [dbo].[Ciudad] ([id_ciudad], [nombre]) VALUES (3, N'Rosario')
SET IDENTITY_INSERT [dbo].[ClubFutbol] ON 

INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [id_estado_club]) VALUES (1, N'MAT', N'Matienzo', N'20', N'avenida siempre viva', 75, 1000, 1)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [id_estado_club]) VALUES (4, N'I.A.C.C', N'Instituto Atletico Central Cordoba', N'2003141', N'Jujuy', 2606, 1000, 2)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [id_estado_club]) VALUES (5, N'C.A.T', N'Club Atletico Talles', N'12346', N'Av. Pablo Richeri', 3250, 1000, 1)
INSERT [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [id_estado_club]) VALUES (7, N'MAT', N'Matienzo Cambiado', N'20', N'avenida siempre viva', 75, 1000, 1)
SET IDENTITY_INSERT [dbo].[ClubFutbol] OFF
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (1000, 1)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (2000, 2)
INSERT [dbo].[CodigoPostal] ([id_codPostal], [id_ciudad]) VALUES (5000, 3)
INSERT [dbo].[EstadoCampeonato] ([id_estado_campeonato], [nombre_estado], [detalle_estado]) VALUES (1, N'En Curso', N'Esta Iniciado')
INSERT [dbo].[EstadoCampeonato] ([id_estado_campeonato], [nombre_estado], [detalle_estado]) VALUES (2, N'Finalizado', N'Esta Finalizado')
INSERT [dbo].[EstadoClub] ([id_estado_club], [nombre], [descripcion]) VALUES (1, N'a', N's')
INSERT [dbo].[EstadoClub] ([id_estado_club], [nombre], [descripcion]) VALUES (2, N'bien', N's')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (1, N'Activo', N'Con Fecha')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (2, N'Suspendido', N'Sancionado')
INSERT [dbo].[EstadoEstadio] ([id_estado], [nombre], [descripcion]) VALUES (3, N'Libre', N'Sin Fecha')
INSERT [dbo].[EstadoExamenMedico] ([id_examen_medico], [nombre], [descripcion]) VALUES (1, N'Aprobado', N'Se Aprobo')
INSERT [dbo].[EstadoExamenMedico] ([id_examen_medico], [nombre], [descripcion]) VALUES (2, N'Desaprobado', N'Reprobo')
INSERT [dbo].[EstadoFecha] ([id_estado], [nombre], [descripcion]) VALUES (1, N'En Curso', N'Jugando')
INSERT [dbo].[EstadoFecha] ([id_estado], [nombre], [descripcion]) VALUES (2, N'Cerrada', N'Ya se Jugo')
INSERT [dbo].[EstadoJugador] ([id_estado_jugador], [nombre], [descripcion]) VALUES (1, N'Activo', N'Normal')
INSERT [dbo].[EstadoJugador] ([id_estado_jugador], [nombre], [descripcion]) VALUES (2, N'Suspendido', N'Sancionado')
INSERT [dbo].[EstadoJugador] ([id_estado_jugador], [nombre], [descripcion]) VALUES (3, N'Lesionado', N'Con carpeta Medica')
INSERT [dbo].[EstadoPartido] ([id_estado], [nombre]) VALUES (1, N'Por Jugar')
INSERT [dbo].[EstadoPartido] ([id_estado], [nombre]) VALUES (2, N'Jugado')
INSERT [dbo].[EstadoPartido] ([id_estado], [nombre]) VALUES (3, N'Suspendido')
INSERT [dbo].[EstadoSesion] ([id_estado], [nombre]) VALUES (1, N'Abierta')
INSERT [dbo].[EstadoSesion] ([id_estado], [nombre]) VALUES (2, N'Cerrada')
INSERT [dbo].[FechaXCampeonato] ([id_campeonato], [anio], [numero_fecha], [fecha_inicio], [fecha_fin], [id_estado_fecha], [fecha_retomo_suspencion]) VALUES (1, 2018, 1, CAST(N'2018-03-03' AS Date), CAST(N'2018-06-06' AS Date), 1, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (0, 4, N'jjj', N'oooo', CAST(N'2015-01-04' AS Date), N'uuuu', 45, 1000, 3)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (0, 36, N'afafaaa', N'ffffff', CAST(N'2018-12-25' AS Date), N'ffff', 36, 1000, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (0, 34953159, N'Carloss', N'Gonzalez', CAST(N'1991-07-11' AS Date), N'Rio Negro', 4200, 5000, 2)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (0, 35581993, N'Carlos Andres', N'Acosta', CAST(N'1991-07-05' AS Date), N'Lorenzo Miguel', 4110, 1000, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (1, 31896485, N'marcos', N'aguilar', CAST(N'2005-05-05' AS Date), N'pepinos', 50000, 1000, 1)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (3, 5, N'hhhh', N'jjjjj', CAST(N'2012-01-01' AS Date), N'yyy', 25, 1000, 3)
INSERT [dbo].[Jugador] ([tipo_doc], [dni], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [cod_postal], [id_posicion_preferente]) VALUES (3, 6, N'fgfg', N'fgfgfgGGG', CAST(N'1986-01-01' AS Date), N'fgfgf', 14, 5000, 3)
INSERT [dbo].[JugadorXClub] ([id_club], [tipo_doc], [dni], [fecha_inicio_actividad], [fecha_fin_actividad], [estado_examen_medico], [estado_jugador]) VALUES (1, 0, 4, CAST(N'2010-03-03' AS Date), CAST(N'2020-06-06' AS Date), 1, 1)
INSERT [dbo].[JugadorXClubXCampeonato] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato], [fecha_inicio], [fecha_fin], [nroCamiseta], [posicion_designada]) VALUES (1, 0, 4, 1, 2018, CAST(N'2018-03-03' AS Date), CAST(N'2018-06-06' AS Date), 10, 4)
INSERT [dbo].[Partido] ([id_club_local], [id_club_visitante], [id_estado_partido], [goles_locales], [goles_visitante], [fecha_hora_inicio]) VALUES (1, 2, 1, 5, 4, CAST(N'2018-04-04' AS Date))
INSERT [dbo].[PartidoXFechaXCampeonato] ([id_club_local], [id_club_visitante], [id_campeonato], [anio], [numero_fecha], [id_arbitro]) VALUES (1, 2, 1, 2018, 1, 10)
SET IDENTITY_INSERT [dbo].[PosicionJugador] ON 

INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (1, N'DEFENSOR', N'DEF')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (2, N'DELANTERO', N'DEL')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (3, N'MEDIO CAMPO', N'MED')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (4, N'LATERAL IZQUIERDO', N'LAT IZQ')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (5, N'LATERAL DERECHO', N'LAT DER')
INSERT [dbo].[PosicionJugador] ([id_posicion], [nombre], [siglas]) VALUES (6, N'ARQUERO', N'ARQ')
SET IDENTITY_INSERT [dbo].[PosicionJugador] OFF
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
ALTER TABLE [dbo].[Arbitro]  WITH CHECK ADD  CONSTRAINT [FK_rolArbitro] FOREIGN KEY([rol_autoridad])
REFERENCES [dbo].[RolArbitro] ([id_rol])
GO
ALTER TABLE [dbo].[Arbitro] CHECK CONSTRAINT [FK_rolArbitro]
GO
ALTER TABLE [dbo].[Campeonato]  WITH CHECK ADD  CONSTRAINT [FK_estadoCampeonato] FOREIGN KEY([id_estado_campeonato])
REFERENCES [dbo].[EstadoCampeonato] ([id_estado_campeonato])
GO
ALTER TABLE [dbo].[Campeonato] CHECK CONSTRAINT [FK_estadoCampeonato]
GO
ALTER TABLE [dbo].[ClubFutbol]  WITH CHECK ADD  CONSTRAINT [FK_codigoPostalClub] FOREIGN KEY([cod_postal])
REFERENCES [dbo].[CodigoPostal] ([id_codPostal])
GO
ALTER TABLE [dbo].[ClubFutbol] CHECK CONSTRAINT [FK_codigoPostalClub]
GO
ALTER TABLE [dbo].[ClubFutbol]  WITH CHECK ADD  CONSTRAINT [FK_estadoClub] FOREIGN KEY([id_estado_club])
REFERENCES [dbo].[EstadoClub] ([id_estado_club])
GO
ALTER TABLE [dbo].[ClubFutbol] CHECK CONSTRAINT [FK_estadoClub]
GO
ALTER TABLE [dbo].[CodigoPostal]  WITH CHECK ADD  CONSTRAINT [FK_ciudadCodigoPostal] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [dbo].[CodigoPostal] CHECK CONSTRAINT [FK_ciudadCodigoPostal]
GO
ALTER TABLE [dbo].[Estadio]  WITH CHECK ADD  CONSTRAINT [FK_codigoPostalEstadio] FOREIGN KEY([cod_postal])
REFERENCES [dbo].[CodigoPostal] ([id_codPostal])
GO
ALTER TABLE [dbo].[Estadio] CHECK CONSTRAINT [FK_codigoPostalEstadio]
GO
ALTER TABLE [dbo].[Estadio]  WITH CHECK ADD  CONSTRAINT [FK_estadoEstad] FOREIGN KEY([id_estadoEstadio])
REFERENCES [dbo].[EstadoEstadio] ([id_estado])
GO
ALTER TABLE [dbo].[Estadio] CHECK CONSTRAINT [FK_estadoEstad]
GO
ALTER TABLE [dbo].[FechaXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_EstadoFecha] FOREIGN KEY([id_estado_fecha])
REFERENCES [dbo].[EstadoFecha] ([id_estado])
GO
ALTER TABLE [dbo].[FechaXCampeonato] CHECK CONSTRAINT [FK_EstadoFecha]
GO
ALTER TABLE [dbo].[FechaXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_FechaXCampeonato_Campeonato] FOREIGN KEY([id_campeonato], [anio])
REFERENCES [dbo].[Campeonato] ([id_campeonato], [anio])
GO
ALTER TABLE [dbo].[FechaXCampeonato] CHECK CONSTRAINT [FK_FechaXCampeonato_Campeonato]
GO
ALTER TABLE [dbo].[Jugador]  WITH CHECK ADD  CONSTRAINT [FK_codigoPostalJugador] FOREIGN KEY([cod_postal])
REFERENCES [dbo].[CodigoPostal] ([id_codPostal])
GO
ALTER TABLE [dbo].[Jugador] CHECK CONSTRAINT [FK_codigoPostalJugador]
GO
ALTER TABLE [dbo].[Jugador]  WITH CHECK ADD  CONSTRAINT [FK_posicionJugador] FOREIGN KEY([id_posicion_preferente])
REFERENCES [dbo].[PosicionJugador] ([id_posicion])
GO
ALTER TABLE [dbo].[Jugador] CHECK CONSTRAINT [FK_posicionJugador]
GO
ALTER TABLE [dbo].[JugadorXClub]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClub] FOREIGN KEY([tipo_doc], [dni])
REFERENCES [dbo].[Jugador] ([tipo_doc], [dni])
GO
ALTER TABLE [dbo].[JugadorXClub] CHECK CONSTRAINT [FK_JugadorXClub]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClubXCampeonato_Campeonato] FOREIGN KEY([id_campeonato], [anio_campeonato])
REFERENCES [dbo].[Campeonato] ([id_campeonato], [anio])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato] CHECK CONSTRAINT [FK_JugadorXClubXCampeonato_Campeonato]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_JugadorXClubXCampeonato_JugadorXClub] FOREIGN KEY([idClub], [tipoDoc_jugador], [dni_jugador])
REFERENCES [dbo].[JugadorXClub] ([id_club], [tipo_doc], [dni])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato] CHECK CONSTRAINT [FK_JugadorXClubXCampeonato_JugadorXClub]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_posicionDesignada] FOREIGN KEY([posicion_designada])
REFERENCES [dbo].[PosicionJugador] ([id_posicion])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonato] CHECK CONSTRAINT [FK_posicionDesignada]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido]  WITH CHECK ADD  CONSTRAINT [FK_sansionJXCXCXP] FOREIGN KEY([id_sancion])
REFERENCES [dbo].[Sancion] ([id_sancion])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido] CHECK CONSTRAINT [FK_sansionJXCXCXP]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido]  WITH CHECK ADD  CONSTRAINT [PK_JugadorXClubXCampeonatoXPartido_JXCXC] FOREIGN KEY([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato])
REFERENCES [dbo].[JugadorXClubXCampeonato] ([idClub], [tipoDoc_jugador], [dni_jugador], [id_campeonato], [anio_campeonato])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido] CHECK CONSTRAINT [PK_JugadorXClubXCampeonatoXPartido_JXCXC]
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido]  WITH CHECK ADD  CONSTRAINT [PK_JugadorXClubXCampeonatoXPartido_Partido] FOREIGN KEY([id_club_local], [id_club_visitante])
REFERENCES [dbo].[Partido] ([id_club_local], [id_club_visitante])
GO
ALTER TABLE [dbo].[JugadorXClubXCampeonatoXPartido] CHECK CONSTRAINT [PK_JugadorXClubXCampeonatoXPartido_Partido]
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
ALTER TABLE [dbo].[PartidoXFechaXCampeonato]  WITH CHECK ADD  CONSTRAINT [FK_PartidoXFechaXCampeonato_Partido] FOREIGN KEY([id_club_local], [id_club_visitante])
REFERENCES [dbo].[Partido] ([id_club_local], [id_club_visitante])
GO
ALTER TABLE [dbo].[PartidoXFechaXCampeonato] CHECK CONSTRAINT [FK_PartidoXFechaXCampeonato_Partido]
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
/****** Object:  StoredProcedure [dbo].[Buscar]    Script Date: 27/9/2018 14:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buscar]
(
	@Param2 int
)
AS
	SET NOCOUNT ON;
SELECT tipo_doc, dni, nombre, apellido, fecha_nacimiento, calle, nro_calle, cod_postal, id_posicion_preferente FROM dbo.Jugador WHERE dni=@Param2
GO
/****** Object:  StoredProcedure [dbo].[Eliminar]    Script Date: 27/9/2018 14:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar]
(
	@Param1 int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[ClubFutbol] WHERE (([id_club] = @Param1))
GO
/****** Object:  StoredProcedure [dbo].[Insertar]    Script Date: 27/9/2018 14:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar]
(
	@Param1 int,
	@Param2 varchar(50),
	@Param3 varchar(50),
	@Param4 int,
	@Param5 varchar(50),
	@Param6 int,
	@Param7l int,
	@Param8 int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[ClubFutbol] ([id_club], [siglas], [nombre_club], [nro_cuil], [calle], [nro_calle], [cod_postal], [id_estado_club]) VALUES (@Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7l, @Param8);
	
SELECT id_club, siglas, nombre_club, nro_cuil, calle, nro_calle, cod_postal, id_estado_club FROM ClubFutbol WHERE (id_club = @Param1)
GO
USE [master]
GO
ALTER DATABASE [CampeonatoPav] SET  READ_WRITE 
GO
