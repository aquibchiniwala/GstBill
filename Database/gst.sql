USE [GstBill]
GO
/****** Object:  Table [dbo].[MACMaster]    Script Date: 09/07/2017 01:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MACMaster](
	[MACID] [int] IDENTITY(1,1) NOT NULL,
	[MACAdd] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[ExpiryDate] [date] NULL,
 CONSTRAINT [PK_MACMaster] PRIMARY KEY CLUSTERED 
(
	[MACID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PartyMaster]    Script Date: 09/07/2017 01:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesDetail]    Script Date: 09/07/2017 01:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesDetail](
	[SalesDetailID] [int] IDENTITY(1,1) NOT NULL,
	[SalesID] [int] NULL,
	[Item] [varchar](50) NULL,
	[HSNCode] [varchar](20) NULL,
	[Taka] [varchar](20) NULL,
	[Metres] [int] NULL,
	[Rate] [decimal](10, 2) NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_SalesDetails] PRIMARY KEY CLUSTERED 
(
	[SalesDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesMaster]    Script Date: 09/07/2017 01:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesMaster](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[FirmID] [int] NULL,
	[PartyID] [int] NULL,
	[InvoiceNo] [varchar](20) NULL,
	[InvoiceDate] [varchar](20) NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FirmMaster]    Script Date: 09/07/2017 01:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ViewPartyByID]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[ViewFirmByID]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SalesMasterView]    Script Date: 09/07/2017 01:44:03 ******/
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
@SalesID int
AS
BEGIN
	select SalesID,FirmID,PartyID,InvoiceNo,InvoiceDate,ChallanNo,ChallanDate,Broker,DelTo,DelAddress,DelMobileNo,DelState,DelGST,State,Mode,VehicleNo,SupplyDate,SupplyPlace,SGST,CGST,IGST,Disc,NetAmount,DueDate,Bank,ChequeNo,ChequeDate,ChequeAmount from SalesMaster 
	where SalesID=(case when @SalesID=0 then SalesID else @SalesID end)
END
GO
/****** Object:  StoredProcedure [dbo].[SalesMasterUpdate]    Script Date: 09/07/2017 01:44:03 ******/
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
@InvoiceDate varchar(20),
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
/****** Object:  StoredProcedure [dbo].[SalesMasterInsert]    Script Date: 09/07/2017 01:44:03 ******/
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
@FirmID int
/*@PartyID int,
@InvoiceNo varchar(20),
@InvoiceDate varchar(20),
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
@ChequeAmount decimal(10, 2)*/
AS
BEGIN
	insert into SalesMaster (FirmID)
	values(@FirmID)
END
GO
/****** Object:  StoredProcedure [dbo].[SalesMasterDelete]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SalesDetailView]    Script Date: 09/07/2017 01:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SalesDetailView]
@SalesDetailID  int
AS
BEGIN
	select SalesDetailID,SalesID,Item,HSNCode,Taka,Metres,Rate,Amount from SalesDetail 
	where SalesDetailID=(case when @SalesDetailID=0 then SalesDetailID else @SalesDetailID end)
END
GO
/****** Object:  StoredProcedure [dbo].[SalesDetailUpdate]    Script Date: 09/07/2017 01:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SalesDetailUpdate]
@SalesDetailID  int,
@SalesID int,
@Item varchar(50),
@HSNCode varchar(20),
@Taka varchar(20),
@Metres int,
@Rate decimal(10, 2),
@Amount decimal(10, 2)
AS
BEGIN
	update SalesDetail set SalesID=@SalesID,Item=@Item,HSNCode=@HSNCode,Taka=@Taka,Metres=@Metres,Rate=@Rate,Amount=@Amount
	where SalesDetailID=@SalesDetailID
END
GO
/****** Object:  StoredProcedure [dbo].[SalesDetailInsert]    Script Date: 09/07/2017 01:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SalesDetailInsert]
@SalesID int,
@Item varchar(50),
@HSNCode varchar(20),
@Taka varchar(20),
@Metres int,
@Rate decimal(10, 2),
@Amount decimal(10, 2)
AS
BEGIN
	insert into SalesDetail (SalesID,Item,HSNCode,Taka,Metres,Rate,Amount)
	values(@SalesID,@Item,@HSNCode,@Taka,@Metres,@Rate,@Amount)
END
GO
/****** Object:  StoredProcedure [dbo].[SalesDetailDelete]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[PartyMasterView]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[PartyMasterUpdate]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[PartyMasterInsert]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[PartyMasterDelete]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[MACMasterView]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[MACMasterUpdate]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[MACMasterInsert]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[MACMasterDelete]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[MACCheck]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[ListAllParty]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[ListAllFirm]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[FirmMasterView]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[FirmMasterUpdate]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[FirmMasterInsert]    Script Date: 09/07/2017 01:44:03 ******/
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
/****** Object:  StoredProcedure [dbo].[FirmMasterDelete]    Script Date: 09/07/2017 01:44:03 ******/
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
