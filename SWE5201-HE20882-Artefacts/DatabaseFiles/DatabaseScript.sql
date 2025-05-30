USE [master]
GO
/****** Object:  Database [BankingDB]    Script Date: 30/05/2025 12:05:01 ******/
CREATE DATABASE [BankingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BankingDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BankingDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BankingDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BankingDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BankingDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BankingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BankingDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BankingDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BankingDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BankingDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BankingDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BankingDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BankingDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BankingDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BankingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BankingDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BankingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BankingDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BankingDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BankingDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BankingDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BankingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BankingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BankingDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BankingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BankingDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BankingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BankingDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BankingDB] SET RECOVERY FULL 
GO
ALTER DATABASE [BankingDB] SET  MULTI_USER 
GO
ALTER DATABASE [BankingDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BankingDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BankingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BankingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BankingDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BankingDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BankingDB', N'ON'
GO
ALTER DATABASE [BankingDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [BankingDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BankingDB]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[AccountType] [nvarchar](20) NULL,
	[Balance] [decimal](18, 2) NULL,
	[CreatedAt] [datetime] NULL,
	[BankID] [int] NULL,
	[Status] [varchar](20) NULL,
	[BranchID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATM]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATM](
	[ATMID] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](100) NULL,
	[AcceptedCardType] [nvarchar](50) NULL,
	[CashAvailable] [float] NULL,
	[BankID] [int] NULL,
	[BranchID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ATMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[BankID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Bank_BankName] UNIQUE NONCLUSTERED 
(
	[BankName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankBranches]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankBranches](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[BankID] [int] NOT NULL,
	[BankBranch] [nvarchar](100) NOT NULL,
	[BankName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_BankID_Branch] UNIQUE NONCLUSTERED 
(
	[BankID] ASC,
	[BankBranch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankStaff]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankStaff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[CreatedAt] [datetime] NULL,
	[Address] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[CardNumber] [nvarchar](20) NULL,
	[Pin] [nvarchar](10) NULL,
	[Status] [nvarchar](20) NULL,
	[CustomerUsername] [nvarchar](50) NOT NULL,
	[CustomerPassword] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 30/05/2025 12:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[TransactionType] [nvarchar](20) NULL,
	[TransactionDate] [datetime] NULL,
	[PreBalance] [float] NULL,
	[PostBalance] [float] NULL,
	[ReceiptPrinted] [bit] NULL,
	[ATMID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Accounts] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[BankStaff] ADD  DEFAULT ('Admin') FOR [Role]
GO
ALTER TABLE [dbo].[BankStaff] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('tempuser') FOR [CustomerUsername]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('temppass') FOR [CustomerPassword]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT (getdate()) FOR [TransactionDate]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Bank] FOREIGN KEY([BankID])
REFERENCES [dbo].[Bank] ([BankID])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Bank]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Branch] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BankBranches] ([BranchID])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Branch]
GO
ALTER TABLE [dbo].[ATM]  WITH CHECK ADD  CONSTRAINT [FK_ATM_Bank] FOREIGN KEY([BankID])
REFERENCES [dbo].[Bank] ([BankID])
GO
ALTER TABLE [dbo].[ATM] CHECK CONSTRAINT [FK_ATM_Bank]
GO
ALTER TABLE [dbo].[ATM]  WITH CHECK ADD  CONSTRAINT [FK_ATM_Branch] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BankBranches] ([BranchID])
GO
ALTER TABLE [dbo].[ATM] CHECK CONSTRAINT [FK_ATM_Branch]
GO
ALTER TABLE [dbo].[BankBranches]  WITH CHECK ADD FOREIGN KEY([BankID])
REFERENCES [dbo].[Bank] ([BankID])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Account]
GO
USE [master]
GO
ALTER DATABASE [BankingDB] SET  READ_WRITE 
GO
