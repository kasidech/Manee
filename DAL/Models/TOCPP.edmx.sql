
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/15/2012 17:14:18
-- Generated from EDMX file: C:\Users\Mo\Documents\GitHub\Pillar1ProcurementSystem\DAL\Models\TOCPP.edmx
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

IF OBJECT_ID(N'[dbo].[FK_DeliveryNoteReceiptNote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptNotes] DROP CONSTRAINT [FK_DeliveryNoteReceiptNote];
GO
IF OBJECT_ID(N'[dbo].[FK_DeliveryNoteNoteLineItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteLineItems] DROP CONSTRAINT [FK_DeliveryNoteNoteLineItem];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationLocationType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Locations] DROP CONSTRAINT [FK_LocationLocationType];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DeliveryNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliveryNotes];
GO
IF OBJECT_ID(N'[dbo].[ReceiptNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReceiptNotes];
GO
IF OBJECT_ID(N'[dbo].[NoteLineItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoteLineItems];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[LocationTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocationTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeliveryNotes'
CREATE TABLE [dbo].[DeliveryNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SenderName] nvarchar(max)  NULL,
    [OriginId] decimal(18,0)  NULL,
    [DestinationId] decimal(18,0)  NULL,
    [DriverName] nvarchar(max)  NULL,
    [CarLicensePlate] nvarchar(max)  NULL,
    [Cartype] nvarchar(max)  NULL,
    [SenderCode] nvarchar(max)  NULL
);
GO

-- Creating table 'ReceiptNotes'
CREATE TABLE [dbo].[ReceiptNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeliveryNoteId] int  NULL,
    [ReceiverName] nvarchar(max)  NOT NULL,
    [ReceiverCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NoteLineItems'
CREATE TABLE [dbo].[NoteLineItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemCode] nvarchar(max)  NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL,
    [ItemStatus] nvarchar(max)  NOT NULL,
    [Qty] nvarchar(max)  NOT NULL,
    [Unit] nvarchar(max)  NOT NULL,
    [KindOfItem] nvarchar(max)  NOT NULL,
    [DeliveryNoteId] int  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LocationName] nvarchar(max)  NOT NULL,
    [LocationTypeId] nvarchar(max)  NOT NULL,
    [LocationType_Id] int  NOT NULL
);
GO

-- Creating table 'LocationTypes'
CREATE TABLE [dbo].[LocationTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LocationTypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Workers'
CREATE TABLE [dbo].[Workers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkerName] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Id] in table 'ReceiptNotes'
ALTER TABLE [dbo].[ReceiptNotes]
ADD CONSTRAINT [PK_ReceiptNotes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoteLineItems'
ALTER TABLE [dbo].[NoteLineItems]
ADD CONSTRAINT [PK_NoteLineItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LocationTypes'
ALTER TABLE [dbo].[LocationTypes]
ADD CONSTRAINT [PK_LocationTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [PK_Workers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'ReceiptNotes'
ALTER TABLE [dbo].[ReceiptNotes]
ADD CONSTRAINT [FK_DeliveryNoteReceiptNote]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[DeliveryNotes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DeliveryNoteId] in table 'NoteLineItems'
ALTER TABLE [dbo].[NoteLineItems]
ADD CONSTRAINT [FK_DeliveryNoteNoteLineItem]
    FOREIGN KEY ([DeliveryNoteId])
    REFERENCES [dbo].[DeliveryNotes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeliveryNoteNoteLineItem'
CREATE INDEX [IX_FK_DeliveryNoteNoteLineItem]
ON [dbo].[NoteLineItems]
    ([DeliveryNoteId]);
GO

-- Creating foreign key on [LocationType_Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_LocationLocationType]
    FOREIGN KEY ([LocationType_Id])
    REFERENCES [dbo].[LocationTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationLocationType'
CREATE INDEX [IX_FK_LocationLocationType]
ON [dbo].[Locations]
    ([LocationType_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------