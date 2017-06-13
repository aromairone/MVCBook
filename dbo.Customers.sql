USE [SportStore]
GO

/****** Object: Table [dbo].[Customers] Script Date: 6/12/2017 2:15:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers] (
    [CustomerId] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50) NOT NULL,
    [LastName]   NVARCHAR (50) NOT NULL,
    [Address]    NVARCHAR (50) NOT NULL,
    [City]       NVARCHAR (25) NOT NULL,
    [State]      NVARCHAR (50) NOT NULL,
    [ZipCode]    INT           NOT NULL
);


