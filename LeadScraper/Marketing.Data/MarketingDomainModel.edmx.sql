
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/26/2011 07:02:45
-- Generated from EDMX file: C:\Projects\Urbana\Marketing\LeadScraper\Marketing.Data\MarketingDomainModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Marketing];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CraigslistPosts1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CraigslistPosts1];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CraigslistPosts'
CREATE TABLE [dbo].[CraigslistPosts] (
    [Id] uniqueidentifier  NOT NULL,
    [PostDate] datetime  NOT NULL,
    [PostsElement] time  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CraigslistPosts'
ALTER TABLE [dbo].[CraigslistPosts]
ADD CONSTRAINT [PK_CraigslistPosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------