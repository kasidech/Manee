
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/14/2012 16:22:45
-- Generated from EDMX file: C:\Users\Mo\Documents\GitHub\Pillar1ProcurementSystem\MvcApplication2\Models\Model1.edmx
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

-- Creating table 'NoteLineItems'
CREATE TABLE [dbo].[NoteLineItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeliveryNoteId] int  NOT NULL
);
GO

-- Creating table 'Documents'
CREATE TABLE [dbo].[Documents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DocType] time  NOT NULL
);
GO

-- Creating table 'Documents_DeliveryNote'
CREATE TABLE [dbo].[Documents_DeliveryNote] (
    [DeliveryDate] datetime  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'NoteLineItems'
ALTER TABLE [dbo].[NoteLineItems]
ADD CONSTRAINT [PK_NoteLineItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Documents'
ALTER TABLE [dbo].[Documents]
ADD CONSTRAINT [PK_Documents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Documents_DeliveryNote'
ALTER TABLE [dbo].[Documents_DeliveryNote]
ADD CONSTRAINT [PK_Documents_DeliveryNote]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeliveryNoteId] in table 'NoteLineItems'
ALTER TABLE [dbo].[NoteLineItems]
ADD CONSTRAINT [FK_DeliveryNoteNoteLineItem]
    FOREIGN KEY ([DeliveryNoteId])
    REFERENCES [dbo].[Documents_DeliveryNote]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeliveryNoteNoteLineItem'
CREATE INDEX [IX_FK_DeliveryNoteNoteLineItem]
ON [dbo].[NoteLineItems]
    ([DeliveryNoteId]);
GO

-- Creating foreign key on [Id] in table 'Documents_DeliveryNote'
ALTER TABLE [dbo].[Documents_DeliveryNote]
ADD CONSTRAINT [FK_DeliveryNote_inherits_Document]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Documents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------