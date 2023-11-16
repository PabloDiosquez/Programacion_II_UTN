USE [master]
GO

/****** Object:  Database [BUFFET_UTN]    Script Date: 15/11/2023 17:09:07 ******/
CREATE DATABASE [BUFFET_UTN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BUFFET_UTN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BUFFET_UTN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BUFFET_UTN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BUFFET_UTN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BUFFET_UTN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BUFFET_UTN] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET ARITHABORT OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BUFFET_UTN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BUFFET_UTN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BUFFET_UTN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BUFFET_UTN] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BUFFET_UTN] SET  MULTI_USER 
GO

ALTER DATABASE [BUFFET_UTN] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BUFFET_UTN] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BUFFET_UTN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BUFFET_UTN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BUFFET_UTN] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BUFFET_UTN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BUFFET_UTN] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BUFFET_UTN] SET  READ_WRITE 
GO
