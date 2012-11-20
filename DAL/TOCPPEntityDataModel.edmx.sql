
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/20/2012 17:08:51
-- Generated from EDMX file: C:\Users\Mo\Documents\GitHub\Manee.INV\Manee.INV\DAL\TOCPPEntityDataModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_CarCarType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_CarCarType];
GO
IF OBJECT_ID(N'[dbo].[FK_DeliveryNotesNoteLineItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteLineItemSets] DROP CONSTRAINT [FK_DeliveryNotesNoteLineItem];
GO
IF OBJECT_ID(N'[dbo].[FK_DeliveryNotesReceitpNote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeliveryNotes] DROP CONSTRAINT [FK_DeliveryNotesReceitpNote];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationTypeLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocationTypes] DROP CONSTRAINT [FK_LocationTypeLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerMethod]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Workers] DROP CONSTRAINT [FK_WorkerMethod];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO
IF OBJECT_ID(N'[dbo].[CarTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarTypes];
GO
IF OBJECT_ID(N'[dbo].[DeliveryNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliveryNotes];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[LocationTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocationTypes];
GO
IF OBJECT_ID(N'[dbo].[Methods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Methods];
GO
IF OBJECT_ID(N'[dbo].[NoteLineItemSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoteLineItemSets];
GO
IF OBJECT_ID(N'[dbo].[ReceitpNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReceitpNotes];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Workers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Workers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [CarTypeId] decimal(18,0)  NOT NULL,
    [CarLicensePlate] nvarchar(max)  NOT NULL,
    [CarTypes_Id] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'CarTypes'
CREATE TABLE [dbo].[CarTypes] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [CarTypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DeliveryNotes'
CREATE TABLE [dbo].[DeliveryNotes] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [OriginId] decimal(18,0)  NULL,
    [DestinationId] decimal(18,0)  NULL,
    [DeliveryDate] datetime  NULL,
    [DocumentDate] datetime  NULL,
    [SerderName] nvarchar(max)  NULL,
    [SenderCode] nvarchar(max)  NULL,
    [CarType] nvarchar(max)  NULL,
    [CarLicensePlate] nvarchar(max)  NULL,
    [Code] nvarchar(max)  NOT NULL,
    [FK_DeliveryNotesReceitpNote_DeliveryNotes_Id] decimal(18,0)  NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LocationTypeId] decimal(18,0)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [ProjectManagerId] decimal(18,0)  NULL
);
GO

-- Creating table 'LocationTypes'
CREATE TABLE [dbo].[LocationTypes] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [LocationTypeName] nvarchar(max)  NOT NULL,
    [Locations_Id] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Methods'
CREATE TABLE [dbo].[Methods] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [MethodName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NoteLineItemSets'
CREATE TABLE [dbo].[NoteLineItemSets] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [ItemCode] nvarchar(max)  NULL,
    [Qty] decimal(18,0)  NULL,
    [Unit] nvarchar(max)  NULL,
    [Status] decimal(18,0)  NULL,
    [DeliveryNoteId] decimal(18,0)  NULL,
    [DeliveryNotes_Id] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'ReceitpNotes'
CREATE TABLE [dbo].[ReceitpNotes] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NULL,
    [DeliveryNoteId] decimal(18,0)  NULL,
    [ReceiverCode] nvarchar(max)  NULL,
    [ReceiverName] nvarchar(max)  NULL,
    [ReceiveDate] datetime  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Workers'
CREATE TABLE [dbo].[Workers] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NULL,
    [Code] nvarchar(max)  NULL,
    [IdCardNumber] nvarchar(max)  NULL,
    [MethodId] decimal(18,0)  NOT NULL,
    [Methods_Id] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarTypes'
ALTER TABLE [dbo].[CarTypes]
ADD CONSTRAINT [PK_CarTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeliveryNotes'
ALTER TABLE [dbo].[DeliveryNotes]
ADD CONSTRAINT [PK_DeliveryNotes]
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

-- Creating primary key on [Id] in table 'Methods'
ALTER TABLE [dbo].[Methods]
ADD CONSTRAINT [PK_Methods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoteLineItemSets'
ALTER TABLE [dbo].[NoteLineItemSets]
ADD CONSTRAINT [PK_NoteLineItemSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReceitpNotes'
ALTER TABLE [dbo].[ReceitpNotes]
ADD CONSTRAINT [PK_ReceitpNotes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [PK_Workers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CarTypes_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CarCarType]
    FOREIGN KEY ([CarTypes_Id])
    REFERENCES [dbo].[CarTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarCarType'
CREATE INDEX [IX_FK_CarCarType]
ON [dbo].[Cars]
    ([CarTypes_Id]);
GO

-- Creating foreign key on [DeliveryNotes_Id] in table 'NoteLineItemSets'
ALTER TABLE [dbo].[NoteLineItemSets]
ADD CONSTRAINT [FK_DeliveryNotesNoteLineItem]
    FOREIGN KEY ([DeliveryNotes_Id])
    REFERENCES [dbo].[DeliveryNotes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeliveryNotesNoteLineItem'
CREATE INDEX [IX_FK_DeliveryNotesNoteLineItem]
ON [dbo].[NoteLineItemSets]
    ([DeliveryNotes_Id]);
GO

-- Creating foreign key on [FK_DeliveryNotesReceitpNote_DeliveryNotes_Id] in table 'DeliveryNotes'
ALTER TABLE [dbo].[DeliveryNotes]
ADD CONSTRAINT [FK_DeliveryNotesReceitpNote]
    FOREIGN KEY ([FK_DeliveryNotesReceitpNote_DeliveryNotes_Id])
    REFERENCES [dbo].[ReceitpNotes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeliveryNotesReceitpNote'
CREATE INDEX [IX_FK_DeliveryNotesReceitpNote]
ON [dbo].[DeliveryNotes]
    ([FK_DeliveryNotesReceitpNote_DeliveryNotes_Id]);
GO

-- Creating foreign key on [Locations_Id] in table 'LocationTypes'
ALTER TABLE [dbo].[LocationTypes]
ADD CONSTRAINT [FK_LocationTypeLocation]
    FOREIGN KEY ([Locations_Id])
    REFERENCES [dbo].[Locations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationTypeLocation'
CREATE INDEX [IX_FK_LocationTypeLocation]
ON [dbo].[LocationTypes]
    ([Locations_Id]);
GO

-- Creating foreign key on [Methods_Id] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [FK_WorkerMethod]
    FOREIGN KEY ([Methods_Id])
    REFERENCES [dbo].[Methods]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerMethod'
CREATE INDEX [IX_FK_WorkerMethod]
ON [dbo].[Workers]
    ([Methods_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------