
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/16/2012 11:14:11
-- Generated from EDMX file: C:\Users\Mo\Documents\GitHub\manee\DAL\Models\TOCPP.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TOCPP];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DeliveryNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliveryNotes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeliveryNotes'
CREATE TABLE [dbo].[DeliveryNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OriginId] nvarchar(max)  NOT NULL,
    [DestinationId] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DeliveryNotes'
ALTER TABLE [dbo].[DeliveryNotes]
ADD CONSTRAINT [PK_DeliveryNotes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------