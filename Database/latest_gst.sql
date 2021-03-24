USE [master]
GO
/****** Object:  Database [GstBill]    Script Date: 3/23/2021 11:31:20 PM ******/
CREATE DATABASE [GstBill]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GstBill', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\GstBill.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GstBill_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\GstBill_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GstBill] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GstBill].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GstBill] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GstBill] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GstBill] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GstBill] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GstBill] SET ARITHABORT OFF 
GO
ALTER DATABASE [GstBill] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GstBill] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GstBill] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GstBill] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GstBill] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GstBill] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GstBill] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GstBill] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GstBill] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GstBill] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GstBill] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GstBill] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GstBill] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GstBill] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GstBill] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GstBill] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GstBill] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GstBill] SET RECOVERY FULL 
GO
ALTER DATABASE [GstBill] SET  MULTI_USER 
GO
ALTER DATABASE [GstBill] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GstBill] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GstBill] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GstBill] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GstBill] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GstBill', N'ON'
GO
ALTER DATABASE [GstBill] SET QUERY_STORE = OFF
GO
USE [GstBill]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [GstBill]
GO
/****** Object:  Table [dbo].[FirmMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FirmMaster](
	[FirmID] [int] IDENTITY(1,1) NOT NULL,
	[FirmName] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[MobileNo] [varchar](50) NULL,
	[GSTIN] [varchar](20) NULL,
 CONSTRAINT [PK_FirmMaster] PRIMARY KEY CLUSTERED 
(
	[FirmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoginMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginMaster](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_LoginMaster] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MACMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MACMaster](
	[MACID] [int] IDENTITY(1,1) NOT NULL,
	[MACAdd] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[ExpiryDate] [date] NULL,
 CONSTRAINT [PK_MACMaster] PRIMARY KEY CLUSTERED 
(
	[MACID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartyMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartyMaster](
	[PartyID] [int] IDENTITY(1,1) NOT NULL,
	[PartyName] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[MobileNo] [varchar](50) NULL,
	[State] [varchar](20) NULL,
	[GSTIN] [varchar](20) NULL,
 CONSTRAINT [PK_PartyMaster] PRIMARY KEY CLUSTERED 
(
	[PartyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseDetail]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetail](
	[PurchaseDetailID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NULL,
	[InvoiceNo] [varchar](20) NULL,
	[Item] [varchar](50) NULL,
	[HSNCode] [varchar](20) NULL,
	[UOM] [varchar](20) NULL,
	[Grade] [varchar](20) NULL,
	[DescOfBale] [varchar](20) NULL,
	[Qty] [int] NULL,
	[Rate] [decimal](10, 2) NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PurchaseDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseMaster](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NULL,
	[InvoiceNo] [varchar](20) NULL,
	[InvoiceDate] [varchar](20) NULL,
	[ChallanNo] [varchar](20) NULL,
	[ChallanDate] [varchar](20) NULL,
	[SGST] [decimal](10, 2) NULL,
	[CGST] [decimal](10, 2) NULL,
	[IGST] [decimal](10, 2) NULL,
	[GrossAmount] [decimal](10, 2) NULL,
	[Disc] [decimal](10, 2) NULL,
	[NetAmount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PurchaseMaster] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesDetail]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetail](
	[SalesDetailID] [int] IDENTITY(1,1) NOT NULL,
	[FirmID] [int] NULL,
	[InvoiceNo] [varchar](20) NULL,
	[Item] [varchar](50) NULL,
	[HSNCode] [varchar](20) NULL,
	[Taka] [varchar](20) NULL,
	[Metres] [decimal](10, 2) NULL,
	[Rate] [decimal](10, 3) NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_SalesDetails] PRIMARY KEY CLUSTERED 
(
	[SalesDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesMaster](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[FirmID] [int] NULL,
	[PartyID] [int] NULL,
	[InvoiceNo] [varchar](20) NULL,
	[InvoiceDate] [datetime] NULL,
	[ChallanNo] [varchar](20) NULL,
	[ChallanDate] [varchar](20) NULL,
	[Broker] [varchar](50) NULL,
	[DelTo] [varchar](50) NULL,
	[DelAddress] [varchar](100) NULL,
	[DelMobileNo] [varchar](50) NULL,
	[DelState] [varchar](50) NULL,
	[DelGST] [varchar](20) NULL,
	[State] [varchar](20) NULL,
	[Mode] [varchar](20) NULL,
	[VehicleNo] [varchar](20) NULL,
	[SupplyDate] [varchar](20) NULL,
	[SupplyPlace] [varchar](20) NULL,
	[SGST] [decimal](10, 2) NULL,
	[CGST] [decimal](10, 2) NULL,
	[IGST] [decimal](10, 2) NULL,
	[Disc] [decimal](10, 2) NULL,
	[NetAmount] [decimal](10, 2) NULL,
	[DueDate] [varchar](20) NULL,
	[Bank] [varchar](20) NULL,
	[ChequeNo] [varchar](20) NULL,
	[ChequeDate] [varchar](20) NULL,
	[ChequeAmount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_SalesMaster] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Settings]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[SettingsID] [int] IDENTITY(1,1) NOT NULL,
	[PrinterName] [varchar](50) NULL,
	[HSNCode] [varchar](20) NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[SettingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SupplierMaster]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierMaster](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[MobileNo] [varchar](50) NULL,
	[State] [varchar](20) NULL,
	[GSTIN] [varchar](20) NULL,
 CONSTRAINT [PK_SupplierMaster] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckLogin]
@Username varchar(50),
@Password varchar(50)
AS
BEGIN
		select LoginID from LoginMaster
		where 
		Username=@Username and 
		Password=@Password COLLATE SQL_Latin1_General_CP1_CS_AS
END

GO
/****** Object:  StoredProcedure [dbo].[FirmMasterDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[FirmMasterDelete]
@FirmID int
AS
BEGIN
	delete from FirmMaster where FirmID=@FirmID
END

GO
/****** Object:  StoredProcedure [dbo].[FirmMasterInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FirmMasterInsert]
@FirmName varchar(50),
@Address varchar(100),
@MobileNo varchar(50),
@GSTIN varchar(20)
AS
BEGIN
	insert into FirmMaster (FirmName,Address,MobileNo,GSTIN)
	values(@FirmName,@Address,@MobileNo,@GSTIN)
END

GO
/****** Object:  StoredProcedure [dbo].[FirmMasterUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FirmMasterUpdate]
@FirmID int,
@FirmName varchar(50),
@Address varchar(100),
@MobileNo varchar(50),
@GSTIN varchar(20)
AS
BEGIN
	update FirmMaster set FirmName=@FirmName,Address=@Address,MobileNo=@MobileNo,GSTIN=@GSTIN
	where FirmID=@FirmID
END

GO
/****** Object:  StoredProcedure [dbo].[FirmMasterView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[FirmMasterView]
AS
BEGIN
	select FirmID,FirmName,Address,MobileNo,GSTIN from FirmMaster
END

GO
/****** Object:  StoredProcedure [dbo].[getSettings]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getSettings]
AS
BEGIN
		select SettingsID,PrinterName,HSNCode from Settings
		
END

GO
/****** Object:  StoredProcedure [dbo].[ListAllFirm]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ListAllFirm]
AS
BEGIN
	select FirmID,FirmName,Address,MobileNo,GSTIN from FirmMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListAllFirmSelect]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ListAllFirmSelect]
AS
BEGIN
    Select 0 as FirmID,'- - - SELECT - - -' as FirmName
    UNION
	select FirmID,FirmName from FirmMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListAllParty]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListAllParty]
AS
BEGIN
	select PartyID,PartyName,Address,MobileNo,State,GSTIN from PartyMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListAllPartySelect]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ListAllPartySelect]
AS
BEGIN
    Select 0 as PartyID,'- - - SELECT - - -' as PartyName
	UNION
	select PartyID,PartyName from PartyMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListAllSupplier]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ListAllSupplier]
AS
BEGIN
	select SupplierID,SupplierName,Address,MobileNo,GSTIN from SupplierMaster
END

GO
/****** Object:  StoredProcedure [dbo].[MACCheck]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- [CheckMAC] "54271E458CBC"
-- =============================================
Create PROCEDURE [dbo].[MACCheck]
@MACAdd varchar(50)
AS
BEGIN
	select MACID,MACAdd,Name,ExpiryDate from MACMaster
	where MACAdd=@MACAdd
	
END

GO
/****** Object:  StoredProcedure [dbo].[MACMasterDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[MACMasterDelete]
@MACID int
AS
BEGIN
	delete from MACMaster
	where MACID=@MACID
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[MACMasterInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MACMasterInsert]
@MACAdd varchar(50),
@Name varchar(50)
AS
BEGIN
	insert into MACMaster(MACAdd,Name)
	values (@MACAdd,@Name)
END

GO
/****** Object:  StoredProcedure [dbo].[MACMasterUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MACMasterUpdate]
@MACID int,
@MACAdd varchar(50),
@Name varchar(50)
AS
BEGIN
	update MACMaster set
	MACAdd=@MACAdd,
	Name=@Name
	where
	MACID=@MACID
END

GO
/****** Object:  StoredProcedure [dbo].[MACMasterView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MACMasterView]

AS
BEGIN
	select MACID,MACAdd,Name,ExpiryDate from MACMaster
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[PartyMasterDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PartyMasterDelete]
@PartyID int
AS
BEGIN
	delete from PartyMaster where PartyID=@PartyID
END

GO
/****** Object:  StoredProcedure [dbo].[PartyMasterInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PartyMasterInsert]
@PartyName varchar(50),
@Address varchar(100),
@MobileNo varchar(50),
@State varchar(20),
@GSTIN varchar(20)
AS
BEGIN
	insert into PartyMaster (PartyName,Address,MobileNo,State,GSTIN)
	values(@PartyName,@Address,@MobileNo,@State,@GSTIN)
END

GO
/****** Object:  StoredProcedure [dbo].[PartyMasterUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PartyMasterUpdate]
@PartyID int,
@PartyName varchar(50),
@Address varchar(100),
@MobileNo varchar(50),
@State varchar(20),
@GSTIN varchar(20)
AS
BEGIN
	update PartyMaster set PartyName=@PartyName,Address=@Address,MobileNo=@MobileNo,State=@State,GSTIN=@GSTIN
	where PartyID=@PartyID
END

GO
/****** Object:  StoredProcedure [dbo].[PartyMasterView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PartyMasterView]
AS
BEGIN
	select PartyID,PartyName,Address,MobileNo,State,GSTIN from PartyMaster
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseDetailDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[PurchaseDetailDelete]
@PurchaseDetailID  int
AS
BEGIN
	delete from PurchaseDetail 
	where PurchaseDetailID=@PurchaseDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseDetailInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[PurchaseDetailInsert]
@SupplierID int,
@InvoiceNo varchar(20),
@Item varchar(50),
@HSNCode varchar(20),
@UOM varchar(20),
@Grade varchar(20),
@DescOfBale varchar(20),
@Qty int,
@Rate decimal(10, 2),
@Amount decimal(10, 2)
AS
BEGIN
	insert into PurcahseDetail(SupplierID,InvoiceNo,Item,HSNCode,UOM,Grade,DescOfBale,Qty,Rate,Amount)
	values(@SupplierID,@InvoiceNo,@Item,@HSNCode,@UOM,@Grade,@DescOfBale,@Qty,@Rate,@Amount)
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseDetailUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[PurchaseDetailUpdate]
@PurchaseDetailID int,
@SupplierID int,
@InvoiceNo varchar(20),
@Item varchar(50),
@HSNCode varchar(20),
@UOM varchar(20),
@Grade varchar(20),
@DescOfBale varchar(20),
@Qty int,
@Rate decimal(10, 2),
@Amount decimal(10, 2)
AS
BEGIN
	update PurchaseDetail set SupplierID=@SupplierID,InvoiceNo=@InvoiceNo,Item=@Item,HSNCode=@HSNCode,UOM=@UOM,Grade=@Grade,DescOfBale=@DescOfBale,Qty=@Qty,Rate=@Rate,Amount=@Amount from PurchaseDetail
	where PurchaseDetailID=@PurchaseDetailID
	
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseDetailView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[PurchaseDetailView]
@InvoiceNo varchar(20),
@SupplierID int

AS
BEGIN
	select SupplierID,InvoiceNo,Item,HSNCode,UOM,Grade,DescOfBale,Qty,Rate,Amount from PurchaseDetail
	where SupplierID=@SupplierID and InvoiceNo=@invoiceNo
	
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseMasterDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PurchaseMasterDelete]
@PurchaseID int

AS
BEGIN
	delete from PurchaseMaster 
	where PurchaseID=@PurchaseID
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseMasterInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PurchaseMasterInsert] 
@SupplierID int,
@InvoiceNo varchar(20),
@InvoiceDate varchar(20),
@ChallanNo varchar(20),
@ChallanDate varchar(20),
@SGST decimal(10, 2),
@CGST decimal(10, 2),
@IGST decimal(10, 2),
@GrossAmount decimal(10, 2),
@Disc decimal(10, 2),
@NetAmount decimal(10, 2)

AS
BEGIN
	insert into PurchaseMaster(SupplierID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,SGST,CGST,IGST,GrossAmount,Disc,NetAmount)
	values (@SupplierID,@InvoiceNo,@InvoiceDate,@ChallanNo,@ChallanDate,@SGST,@CGST,@IGST,@GrossAmount,@Disc,@NetAmount)
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseMasterUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PurchaseMasterUpdate]
@PurchaseID int,
@SupplierID int,
@InvoiceNo varchar(20),
@InvoiceDate varchar(20),
@ChallanNo varchar(20),
@ChallanDate varchar(20),
@SGST decimal(10, 2),
@CGST decimal(10, 2),
@IGST decimal(10, 2),
@GrossAmount decimal(10, 2),
@Disc decimal(10, 2),
@NetAmount decimal(10, 2)

AS
BEGIN
	update PurchaseMaster set SupplierID=@SupplierID,InvoiceNo=@InvoiceNo,InvoiceDate=@InvoiceDate,ChallanNo=@ChallanNo,ChallanDate=@ChallanDate,SGST=@SGST,CGST=@CGST,IGST=@IGST,GrossAmount=@GrossAmount,Disc=@Disc,NetAmount=@NetAmount
	where PurchaseID=@PurchaseID
END

GO
/****** Object:  StoredProcedure [dbo].[PurchaseMasterView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PurchaseMasterView] 
@InvoiceNo varchar(20),
@SupplierID int


AS
BEGIN
	select PurchaseID,SupplierID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,SGST,CGST,IGST,GrossAmount,Disc,NetAmount from  PurchaseMaster
	where SupplierID=@SupplierID and InvoiceNo=@InvoiceNo
END

GO
/****** Object:  StoredProcedure [dbo].[rptSales]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- rptSales '',0,0,'01/03/2018 12:00:00 AM','01/03/2018 12:00:00 AM'
-- =============================================
CREATE PROCEDURE [dbo].[rptSales]
@InvoiceNo varchar(20),
@FirmID int,
@PartyID int,
@FromDate date,
@ToDate date
AS
BEGIN
if(@InvoiceNo='')
Begin
	select SalesID,FirmMaster.FirmID,FirmName,PartyMaster.PartyID,PartyName,PartyMaster.GSTIN,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,Broker,DelTo,DelAddress,DelMobileNo,DelState,DelGST,SalesMaster.State,Mode,VehicleNo,SupplyDate,SupplyPlace,SGST,CGST,IGST,Disc,NetAmount,DueDate,Bank,ChequeNo,ChequeDate,ChequeAmount from SalesMaster 
	left join FirmMaster on FirmMaster.FirmID=SalesMaster.FirmID
	left join PartyMaster on PartyMaster.PartyID=SalesMaster.PartyID
	where 
	FirmMaster.FirmID=(case when @FirmID=0 then FirmMaster. FirmID else @FirmID end) AND
	PartyMaster.PartyID=(case when @PartyID=0 then PartyMaster.PartyID else @PartyID end) AND
	InvoiceDate between @FromDate AND @ToDate
	order by InvoiceNo
end
else if(@InvoiceNo!='')
Begin
select SalesID,FirmMaster.FirmID,FirmName,PartyMaster.PartyID,PartyName,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,Broker,DelTo,DelAddress,DelMobileNo,DelState,DelGST,SalesMaster.State,Mode,VehicleNo,SupplyDate,SupplyPlace,SGST,CGST,IGST,Disc,NetAmount,DueDate,Bank,ChequeNo,ChequeDate,ChequeAmount from SalesMaster 
	left join FirmMaster on FirmMaster.FirmID=SalesMaster.FirmID
	left join PartyMaster on PartyMaster.PartyID=SalesMaster.PartyID
	where 
	InvoiceNo=(case when @InvoiceNo='' then InvoiceNo else @InvoiceNo end) 
	order by InvoiceNo
	
End
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[SalesDetailDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SalesDetailDelete]
@SalesDetailID  int
AS
BEGIN
	delete from SalesDetail 
	where SalesDetailID=@SalesDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[SalesDetailInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesDetailInsert]
@FirmID int,
@InvoiceNo varchar(20),
@Item varchar(50),
@HSNCode varchar(20),
@Taka varchar(20),
@Metres decimal(10, 2),
@Rate decimal(10, 3),
@Amount decimal(10, 2)
AS
BEGIN
	insert into SalesDetail (FirmID,InvoiceNo,Item,HSNCode,Taka,Metres,Rate,Amount)
	values(@FirmID,@InvoiceNo,@Item,@HSNCode,@Taka,@Metres,@Rate,@Amount)
END

GO
/****** Object:  StoredProcedure [dbo].[SalesDetailUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesDetailUpdate]
@FirmID int,
@SalesDetailID  int,
@InvoiceNo varchar(20),
@Item varchar(50),
@HSNCode varchar(20),
@Taka varchar(20),
@Metres decimal(10, 2),
@Rate decimal(10, 3),
@Amount decimal(10, 2)
AS
BEGIN
	update SalesDetail set FirmID=@FirmID, InvoiceNo=@InvoiceNo,Item=@Item,HSNCode=@HSNCode,Taka=@Taka,Metres=@Metres,Rate=@Rate,Amount=@Amount
	where SalesDetailID=@SalesDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[SalesDetailView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesDetailView]
@InvoiceNo varchar(20),
@FirmID int
AS
BEGIN
	select SalesDetailID,FirmID,InvoiceNo,Item,HSNCode,Taka,Metres,Rate,Amount from SalesDetail 
	where InvoiceNo=@InvoiceNo and
	FirmID= @FirmID 
END

GO
/****** Object:  StoredProcedure [dbo].[SalesMasterDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesMasterDelete]
@SalesID int
AS
BEGIN
	delete from SalesMaster where SalesID=@SalesID
END

GO
/****** Object:  StoredProcedure [dbo].[SalesMasterInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesMasterInsert]
@FirmID int,
@PartyID int,
@InvoiceNo varchar(20),
@InvoiceDate datetime,
@ChallanNo varchar(20),
@ChallanDate varchar(20),
@Broker varchar(50),
@DelTo varchar(50),
@DelAddress varchar(100),
@DelMobileNo varchar(50),
@DelState varchar(50),
@DelGST varchar(20),
@State varchar(20),
@Mode varchar(20),
@VehicleNo varchar(20),
@SupplyDate varchar(20),
@SupplyPlace varchar(20),
@SGST decimal(10, 2),
@CGST decimal(10, 2),
@IGST decimal(10, 2),
@Disc decimal(10, 2),
@NetAmount decimal(10, 2),
@DueDate varchar(20),
@Bank varchar(20),
@ChequeNo varchar(20),
@ChequeDate varchar(20),
@ChequeAmount decimal(10, 2)
AS
BEGIN
	insert into SalesMaster (FirmID,PartyID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,Broker,DelTo,DelAddress,DelMobileNo,DelState,DelGST,State,Mode,VehicleNo,SupplyDate,SupplyPlace,SGST,CGST,IGST,Disc,NetAmount,DueDate,Bank,ChequeNo,ChequeDate,ChequeAmount)
	values(@FirmID,@PartyID,@InvoiceNo,@InvoiceDate,@ChallanNo,@ChallanDate,@Broker,@DelTo,@DelAddress,@DelMobileNo,@DelState,@DelGST,@State,@Mode,@VehicleNo,@SupplyDate,@SupplyPlace,@SGST,@CGST,@IGST,@Disc,@NetAmount,@DueDate,@Bank,@ChequeNo,@ChequeDate,@ChequeAmount)
END

GO
/****** Object:  StoredProcedure [dbo].[SalesMasterUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesMasterUpdate]
@SalesID int,
@FirmID int,
@PartyID int,
@InvoiceNo varchar(20),
@InvoiceDate datetime,
@ChallanNo varchar(20),
@ChallanDate varchar(20),
@Broker varchar(50),
@DelTo varchar(50),
@DelAddress varchar(100),
@DelMobileNo varchar(50),
@DelState varchar(50),
@DelGST varchar(20),
@State varchar(20),
@Mode varchar(20),
@VehicleNo varchar(20),
@SupplyDate varchar(20),
@SupplyPlace varchar(20),
@SGST decimal(10, 2),
@CGST decimal(10, 2),
@IGST decimal(10, 2),
@Disc decimal(10, 2),
@NetAmount decimal(10, 2),
@DueDate varchar(20),
@Bank varchar(20),
@ChequeNo varchar(20),
@ChequeDate varchar(20),
@ChequeAmount decimal(10, 2)
AS
BEGIN
	update SalesMaster set FirmID=@FirmID,PartyID=@PartyID,InvoiceNo=@InvoiceNo,InvoiceDate=@InvoiceDate,ChallanNo=@ChallanNo,ChallanDate=@ChallanDate,Broker=@Broker,DelTo=@DelTo,DelAddress=@DelAddress,DelMobileNo=@DelMobileNo,DelState=@DelState,DelGST=@DelGST,State=@State,Mode=@Mode,VehicleNo=@VehicleNo,SupplyDate=@SupplyDate,SupplyPlace=@SupplyPlace,SGST=@SGST,CGST=@CGST,IGST=@IGST,Disc=@Disc,NetAmount=@NetAmount,DueDate=@DueDate,Bank=@Bank,ChequeNo=@ChequeNo,ChequeDate=@ChequeDate,ChequeAmount=@ChequeAmount
	where SalesID=@SalesID
END

GO
/****** Object:  StoredProcedure [dbo].[SalesMasterView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesMasterView]
@InvoiceNo varchar(20),
@FirmID int
AS
BEGIN
	select SalesID,FirmID,PartyID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,Broker,DelTo,DelAddress,DelMobileNo,DelState,DelGST,State,Mode,VehicleNo,SupplyDate,SupplyPlace,SGST,CGST,IGST,Disc,NetAmount,DueDate,Bank,ChequeNo,ChequeDate,ChequeAmount from SalesMaster 
	where InvoiceNo=@InvoiceNo and
	FirmID= @FirmID 
	END

GO
/****** Object:  StoredProcedure [dbo].[SupplierMasterDelete]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SupplierMasterDelete]
@SupplierID int
AS
BEGIN
	delete from SupplierMaster where SupplierID=@SupplierID
END

GO
/****** Object:  StoredProcedure [dbo].[SupplierMasterInsert]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SupplierMasterInsert]
@SupplierName varchar(50),
@Address varchar(100),
@MobileNo varchar(50),
@State varchar(20),
@GSTIN varchar(20)
AS
BEGIN
	insert into SupplierMaster (SupplierName,Address,MobileNo,State,GSTIN)
	values(@SupplierName,@Address,@MobileNo,@State,@GSTIN)
END

GO
/****** Object:  StoredProcedure [dbo].[SupplierMasterUpdate]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SupplierMasterUpdate]
@SupplierID int,
@SupplierName varchar(50),
@Address varchar(100),
@MobileNo varchar(50),
@State varchar(20),
@GSTIN varchar(20)
AS
BEGIN
	update SupplierMaster set SupplierName=@SupplierName,Address=@Address,MobileNo=@MobileNo,State=@State,GSTIN=@GSTIN
	where SupplierID=@SupplierID
END

GO
/****** Object:  StoredProcedure [dbo].[SupplierMasterView]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SupplierMasterView]
AS
BEGIN
	select SupplierID,SupplierName,Address,MobileNo,State,GSTIN from SupplierMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ViewFirmByID]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ViewFirmByID]
@FirmID int
AS
BEGIN
	select FirmID,FirmName,Address,MobileNo,GSTIN from FirmMaster
	where FirmID=@FirmID
END

GO
/****** Object:  StoredProcedure [dbo].[ViewPartyByID]    Script Date: 3/23/2021 11:31:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ViewPartyByID]
@PartyID int
AS
BEGIN
	select PartyID,PartyName,Address,MobileNo,State,GSTIN from PartyMaster
	where PartyID=@PartyID
END

GO
USE [master]
GO
ALTER DATABASE [GstBill] SET  READ_WRITE 
GO
