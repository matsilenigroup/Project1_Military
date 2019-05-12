USE [master]
GO
/****** Object:  Database [MilitaryCommunications]    Script Date: 5/12/2019 10:56:42 PM ******/
CREATE DATABASE [MilitaryCommunications]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MilitaryCommunications', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MilitaryCommunications.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MilitaryCommunications_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MilitaryCommunications_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MilitaryCommunications] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MilitaryCommunications].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MilitaryCommunications] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET ARITHABORT OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MilitaryCommunications] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MilitaryCommunications] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MilitaryCommunications] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MilitaryCommunications] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MilitaryCommunications] SET  MULTI_USER 
GO
ALTER DATABASE [MilitaryCommunications] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MilitaryCommunications] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MilitaryCommunications] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MilitaryCommunications] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MilitaryCommunications]
GO
/****** Object:  Table [dbo].[tblDecryptedMessageDetails]    Script Date: 5/12/2019 10:56:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDecryptedMessageDetails](
	[MessageID] [int] IDENTITY(100,1) NOT NULL,
	[EcryptedDateTime] [datetime] NOT NULL,
	[Message] [nvarchar](50) NOT NULL,
	[DecryptionStatus] [nvarchar](50) NOT NULL,
	[LastReadUserID] [nvarchar](50) NOT NULL,
	[EmailUserEnrypted] [nvarchar](50) NOT NULL,
	[DurationofDecryption] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/12/2019 10:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[Idnumber] [nvarchar](13) NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[age] [int] NULL,
	[rank] [nvarchar](50) NULL,
	[password] [nvarchar](10) NULL,
	[username] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[Idnumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MilitaryCommunications] SET  READ_WRITE 
GO
