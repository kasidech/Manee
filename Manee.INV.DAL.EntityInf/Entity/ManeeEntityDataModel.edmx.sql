
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/27/2012 14:09:10
-- Generated from EDMX file: D:\LonGKonG\Manee\Manee.INV.DAL.EntityInf\Entity\ManeeEntityDataModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_CarTypeCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cars] DROP CONSTRAINT [FK_CarTypeCar];
GO
IF OBJECT_ID(N'[dbo].[FK_DeliveryNoteNoteLineItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteLineItems] DROP CONSTRAINT [FK_DeliveryNoteNoteLineItem];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationLocationType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Locations] DROP CONSTRAINT [FK_LocationLocationType];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerMethodWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Workers] DROP CONSTRAINT [FK_WorkerMethodWorker];
GO
IF OBJECT_ID(N'[dbo].[FK_DeliveryNoteReceiveNote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiveNotes] DROP CONSTRAINT [FK_DeliveryNoteReceiveNote];
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
IF OBJECT_ID(N'[dbo].[WorkerMethods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkerMethods];
GO
IF OBJECT_ID(N'[dbo].[NoteLineItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoteLineItems];
GO
IF OBJECT_ID(N'[dbo].[ReceiveNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReceiveNotes];
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
    [Id] int IDENTITY(1,1) NOT NULL,
    [CarLicensePlate] nvarchar(max)  NOT NULL,
    [CarType_Id] int  NOT NULL
);
GO

-- Creating table 'CarTypes'
CREATE TABLE [dbo].[CarTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CarTypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DeliveryNotes'
CREATE TABLE [dbo].[DeliveryNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OriginId] decimal(18,0)  NULL,
    [DestinationId] decimal(18,0)  NULL,
    [DeliveryDate] datetime  NULL,
    [DocumentDate] datetime  NULL,
    [SenderName] nvarchar(max)  NULL,
    [SenderCode] nvarchar(max)  NULL,
    [CarType] nvarchar(max)  NULL,
    [CarLicensePlate] nvarchar(max)  NULL,
    [Code] nvarchar(max)  NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [ProjectManagerId] decimal(18,0)  NULL,
    [LocationType_Id] int  NOT NULL
);
GO

-- Creating table 'LocationTypes'
CREATE TABLE [dbo].[LocationTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LocationTypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WorkerMethods'
CREATE TABLE [dbo].[WorkerMethods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MethodName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NoteLineItems'
CREATE TABLE [dbo].[NoteLineItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemCode] nvarchar(max)  NULL,
    [Qty] decimal(18,0)  NULL,
    [Unit] nvarchar(max)  NULL,
    [Status] decimal(18,0)  NULL,
    [DeliveryNoteId] int  NULL
);
GO

-- Creating table 'ReceiveNotes'
CREATE TABLE [dbo].[ReceiveNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NULL,
    [ReceiverCode] nvarchar(max)  NULL,
    [ReceiverName] nvarchar(max)  NULL,
    [ReceiveDate] datetime  NULL,
    [DeliveryNoteId] int  NOT NULL,
    [DeliveryNote_Id] int  NOT NULL
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
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NULL,
    [Code] nvarchar(max)  NULL,
    [IdCardNumber] nvarchar(max)  NULL,
    [WorkerMethod_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'WorkerMethods'
ALTER TABLE [dbo].[WorkerMethods]
ADD CONSTRAINT [PK_WorkerMethods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoteLineItems'
ALTER TABLE [dbo].[NoteLineItems]
ADD CONSTRAINT [PK_NoteLineItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReceiveNotes'
ALTER TABLE [dbo].[ReceiveNotes]
ADD CONSTRAINT [PK_ReceiveNotes]
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

-- Creating foreign key on [CarType_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CarTypeCar]
    FOREIGN KEY ([CarType_Id])
    REFERENCES [dbo].[CarTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarTypeCar'
CREATE INDEX [IX_FK_CarTypeCar]
ON [dbo].[Cars]
    ([CarType_Id]);
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

-- Creating foreign key on [WorkerMethod_Id] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [FK_WorkerMethodWorker]
    FOREIGN KEY ([WorkerMethod_Id])
    REFERENCES [dbo].[WorkerMethods]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerMethodWorker'
CREATE INDEX [IX_FK_WorkerMethodWorker]
ON [dbo].[Workers]
    ([WorkerMethod_Id]);
GO

-- Creating foreign key on [DeliveryNote_Id] in table 'ReceiveNotes'
ALTER TABLE [dbo].[ReceiveNotes]
ADD CONSTRAINT [FK_DeliveryNoteReceiveNote]
    FOREIGN KEY ([DeliveryNote_Id])
    REFERENCES [dbo].[DeliveryNotes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeliveryNoteReceiveNote'
CREATE INDEX [IX_FK_DeliveryNoteReceiveNote]
ON [dbo].[ReceiveNotes]
    ([DeliveryNote_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------