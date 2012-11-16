
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/14/2012 16:08:13
-- Generated from EDMX file: C:\Users\Mo\Documents\GitHub\Pillar1ProcurementSystem\MvcApplication1\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
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

-- Creating table 'SampleLineItems'
CREATE TABLE [dbo].[SampleLineItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DocId] int  NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Docs'
CREATE TABLE [dbo].[Docs] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SampleLineItems'
ALTER TABLE [dbo].[SampleLineItems]
ADD CONSTRAINT [PK_SampleLineItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Docs'
ALTER TABLE [dbo].[Docs]
ADD CONSTRAINT [PK_Docs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DocId] in table 'SampleLineItems'
ALTER TABLE [dbo].[SampleLineItems]
ADD CONSTRAINT [FK_DocSampleLineItem]
    FOREIGN KEY ([DocId])
    REFERENCES [dbo].[Docs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DocSampleLineItem'
CREATE INDEX [IX_FK_DocSampleLineItem]
ON [dbo].[SampleLineItems]
    ([DocId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------