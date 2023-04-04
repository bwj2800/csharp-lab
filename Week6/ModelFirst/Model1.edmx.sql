
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/20/2023 05:25:45
-- Generated from EDMX file: C:\Users\user\Desktop\MicrosoftC#\Week6\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Company];
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

-- Creating table 'DepartmentSet'
CREATE TABLE [dbo].[DepartmentSet] (
    [DepartmentId] int IDENTITY(1,1) NOT NULL,
    [DepartmentName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AddressSet'
CREATE TABLE [dbo].[AddressSet] (
    [AddressId] int IDENTITY(1,1) NOT NULL,
    [Address_] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ManagerSet'
CREATE TABLE [dbo].[ManagerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DepartmentId] int  NOT NULL
);
GO

-- Creating table 'ProjectSet'
CREATE TABLE [dbo].[ProjectSet] (
    [ProjectId] int IDENTITY(1,1) NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL
);
GO

-- Creating table 'ManagerSet_Employee'
CREATE TABLE [dbo].[ManagerSet_Employee] (
    [Job] nvarchar(max)  NOT NULL,
    [ManagerId] int  NOT NULL,
    [HireDate] datetime  NOT NULL,
    [Salary] int  NOT NULL,
    [AddressId] int  NOT NULL,
    [ProjectId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DepartmentId] in table 'DepartmentSet'
ALTER TABLE [dbo].[DepartmentSet]
ADD CONSTRAINT [PK_DepartmentSet]
    PRIMARY KEY CLUSTERED ([DepartmentId] ASC);
GO

-- Creating primary key on [AddressId] in table 'AddressSet'
ALTER TABLE [dbo].[AddressSet]
ADD CONSTRAINT [PK_AddressSet]
    PRIMARY KEY CLUSTERED ([AddressId] ASC);
GO

-- Creating primary key on [Id] in table 'ManagerSet'
ALTER TABLE [dbo].[ManagerSet]
ADD CONSTRAINT [PK_ManagerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ProjectId] in table 'ProjectSet'
ALTER TABLE [dbo].[ProjectSet]
ADD CONSTRAINT [PK_ProjectSet]
    PRIMARY KEY CLUSTERED ([ProjectId] ASC);
GO

-- Creating primary key on [Id] in table 'ManagerSet_Employee'
ALTER TABLE [dbo].[ManagerSet_Employee]
ADD CONSTRAINT [PK_ManagerSet_Employee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'ManagerSet_Employee'
ALTER TABLE [dbo].[ManagerSet_Employee]
ADD CONSTRAINT [FK_Employee_inherits_Manager]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[ManagerSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------