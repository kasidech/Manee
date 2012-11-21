
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/21/2012 14:48:40
-- Generated from EDMX file: C:\Users\Mo\Documents\GitHub\manee\Manee.INV.DAL.EntityInf\ManeeEntityDataModel.edmx
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


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [CarLicensePlate] nvarchar(max)  NOT NULL,
    [CarType_Id] decimal(18,0)  NOT NULL
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
    [Code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [ProjectManagerId] decimal(18,0)  NULL,
    [LocationType_Id] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'LocationTypes'
CREATE TABLE [dbo].[LocationTypes] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [LocationTypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WorkerMethods'
CREATE TABLE [dbo].[WorkerMethods] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [MethodName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NoteLineItems'
CREATE TABLE [dbo].[NoteLineItems] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [ItemCode] nvarchar(max)  NULL,
    [Qty] decimal(18,0)  NULL,
    [Unit] nvarchar(max)  NULL,
    [Status] decimal(18,0)  NULL,
    [DeliveryNoteId] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'ReceitpNotes'
CREATE TABLE [dbo].[ReceitpNotes] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NULL,
    [ReceiverCode] nvarchar(max)  NULL,
    [ReceiverName] nvarchar(max)  NULL,
    [ReceiveDate] datetime  NULL,
    [DeliveryNote_Id] decimal(18,0)  NOT NULL
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
    [WorkerMethod_Id] decimal(18,0)  NOT NULL
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

-- Creating foreign key on [DeliveryNote_Id] in table 'ReceitpNotes'
ALTER TABLE [dbo].[ReceitpNotes]
ADD CONSTRAINT [FK_ReceitpNoteDeliveryNote]
    FOREIGN KEY ([DeliveryNote_Id])
    REFERENCES [dbo].[DeliveryNotes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceitpNoteDeliveryNote'
CREATE INDEX [IX_FK_ReceitpNoteDeliveryNote]
ON [dbo].[ReceitpNotes]
    ([DeliveryNote_Id]);
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------