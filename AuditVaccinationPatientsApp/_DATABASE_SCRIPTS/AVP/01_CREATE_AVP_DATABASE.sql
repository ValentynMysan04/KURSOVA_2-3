
--=============================================================================

USE [master]
GO

DECLARE @DatabaseName nvarchar(50)
SET @DatabaseName = N'AVP'

DECLARE @SQL varchar(max)

SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
FROM MASTER..SysProcesses
WHERE DBId = DB_ID(@DatabaseName) AND SPId <> @@SPId

--SELECT @SQL 
EXEC(@SQL)
GO


--=============================================================================


USE [master]
GO


IF EXISTS (SELECT * FROM master.sys.server_principals WHERE NAME = 'avp') 
BEGIN
	DROP LOGIN [avp]
END
GO


IF DB_ID('AVP') IS NOT NULL
BEGIN
	DROP DATABASE [AVP]
END
GO

--=============================================================================


CREATE DATABASE [AVP]
 CONTAINMENT = NONE
 ON  PRIMARY ( NAME = N'AVP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AVP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON ( NAME = N'AVP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AVP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 --COLLATE Cyrillic_General_CI_AS
GO

ALTER DATABASE [AVP] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AVP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AVP] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AVP] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AVP] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AVP] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AVP] SET ARITHABORT OFF 
GO

ALTER DATABASE [AVP] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AVP] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AVP] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AVP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AVP] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AVP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AVP] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AVP] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AVP] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AVP] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AVP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AVP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AVP] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AVP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AVP] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AVP] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AVP] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AVP] SET RECOVERY FULL 
GO

ALTER DATABASE [AVP] SET  MULTI_USER 
GO

ALTER DATABASE [AVP] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AVP] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AVP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AVP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AVP] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AVP] SET QUERY_STORE = OFF
GO

USE [AVP]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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

ALTER DATABASE [AVP] SET  READ_WRITE 
GO




USE [master]
GO
CREATE LOGIN [avp] WITH PASSWORD=N'avp', DEFAULT_DATABASE=[AVP], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [avp]
GO
USE [AVP]
GO
CREATE USER [avp] FOR LOGIN [avp]
GO
USE [AVP]
GO
ALTER ROLE [db_owner] ADD MEMBER [avp]
GO
USE [AVP]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [avp]
GO

USE [AVP]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_owner] TO [avp]
GO