
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/30/2012 07:55:44
-- Generated from EDMX file: C:\Projects\Urbana\Marketing\Marketing.Data\MarketingDomainModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Marketing.CraigslistScraper];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryLog_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoryLog] DROP CONSTRAINT [FK_CategoryLog_Category];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryLog_Log]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoryLog] DROP CONSTRAINT [FK_CategoryLog_Log];
GO
IF OBJECT_ID(N'[dbo].[FK_ListingCategory_ListingGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ListingCategory] DROP CONSTRAINT [FK_ListingCategory_ListingGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_ListingContent_ListingUrl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ListingContent] DROP CONSTRAINT [FK_ListingContent_ListingUrl];
GO
IF OBJECT_ID(N'[dbo].[FK_ListingUrl_City]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ListingUrl] DROP CONSTRAINT [FK_ListingUrl_City];
GO
IF OBJECT_ID(N'[dbo].[FK_ListingUrl_ListingCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ListingUrl] DROP CONSTRAINT [FK_ListingUrl_ListingCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCity_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCity] DROP CONSTRAINT [FK_UserCity_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCity_City]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCity] DROP CONSTRAINT [FK_UserCity_City];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFile_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserFile] DROP CONSTRAINT [FK_UserFile_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFilter_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserFilter] DROP CONSTRAINT [FK_UserFilter_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserKeyword_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserKeyword] DROP CONSTRAINT [FK_UserKeyword_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingCategory_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingCategory] DROP CONSTRAINT [FK_UserListingCategory_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingCategory_ListingCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingCategory] DROP CONSTRAINT [FK_UserListingCategory_ListingCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingKeywordScore_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingKeywordScore] DROP CONSTRAINT [FK_UserListingKeywordScore_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingKeywordScore_UserListingUrl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingKeywordScore] DROP CONSTRAINT [FK_UserListingKeywordScore_UserListingUrl];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingResponse_UserListingResponse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingResponse] DROP CONSTRAINT [FK_UserListingResponse_UserListingResponse];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingResponse_UserListingUrl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingResponse] DROP CONSTRAINT [FK_UserListingResponse_UserListingUrl];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingUrl_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingUrl] DROP CONSTRAINT [FK_UserListingUrl_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserListingUrl_ListingUrl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserListingUrl] DROP CONSTRAINT [FK_UserListingUrl_ListingUrl];
GO
IF OBJECT_ID(N'[dbo].[FK_UserPreference_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserPreference] DROP CONSTRAINT [FK_UserPreference_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTemplate_aspnet_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserTemplate] DROP CONSTRAINT [FK_UserTemplate_aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTemplate_UserFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserTemplate] DROP CONSTRAINT [FK_UserTemplate_UserFile];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[aspnet_Membership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[BugReport]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BugReport];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[CategoryLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoryLog];
GO
IF OBJECT_ID(N'[dbo].[City]', 'U') IS NOT NULL
    DROP TABLE [dbo].[City];
GO
IF OBJECT_ID(N'[dbo].[ListingCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ListingCategory];
GO
IF OBJECT_ID(N'[dbo].[ListingContent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ListingContent];
GO
IF OBJECT_ID(N'[dbo].[ListingGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ListingGroup];
GO
IF OBJECT_ID(N'[dbo].[ListingUrl]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ListingUrl];
GO
IF OBJECT_ID(N'[dbo].[Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Log];
GO
IF OBJECT_ID(N'[dbo].[SystemSetting]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemSetting];
GO
IF OBJECT_ID(N'[dbo].[UserCity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCity];
GO
IF OBJECT_ID(N'[dbo].[UserFile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserFile];
GO
IF OBJECT_ID(N'[dbo].[UserFilter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserFilter];
GO
IF OBJECT_ID(N'[dbo].[UserKeyword]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserKeyword];
GO
IF OBJECT_ID(N'[dbo].[UserListingCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserListingCategory];
GO
IF OBJECT_ID(N'[dbo].[UserListingKeywordScore]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserListingKeywordScore];
GO
IF OBJECT_ID(N'[dbo].[UserListingResponse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserListingResponse];
GO
IF OBJECT_ID(N'[dbo].[UserListingUrl]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserListingUrl];
GO
IF OBJECT_ID(N'[dbo].[UserPreference]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserPreference];
GO
IF OBJECT_ID(N'[dbo].[UserTemplate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserTemplate];
GO
IF OBJECT_ID(N'[MarketingCraigslistScraperModelStoreContainer].[UserListingData]', 'U') IS NOT NULL
    DROP TABLE [MarketingCraigslistScraperModelStoreContainer].[UserListingData];
GO
IF OBJECT_ID(N'[MarketingCraigslistScraperModelStoreContainer].[UserListingRefresh]', 'U') IS NOT NULL
    DROP TABLE [MarketingCraigslistScraperModelStoreContainer].[UserListingRefresh];
GO
IF OBJECT_ID(N'[MarketingCraigslistScraperModelStoreContainer].[vw_aspnet_MembershipUsers]', 'U') IS NOT NULL
    DROP TABLE [MarketingCraigslistScraperModelStoreContainer].[vw_aspnet_MembershipUsers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'aspnet_Membership'
CREATE TABLE [dbo].[aspnet_Membership] (
    [ApplicationId] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Password] nvarchar(128)  NOT NULL,
    [PasswordFormat] int  NOT NULL,
    [PasswordSalt] nvarchar(128)  NOT NULL,
    [MobilePIN] nvarchar(16)  NULL,
    [Email] nvarchar(256)  NULL,
    [LoweredEmail] nvarchar(256)  NULL,
    [PasswordQuestion] nvarchar(256)  NULL,
    [PasswordAnswer] nvarchar(128)  NULL,
    [IsApproved] bit  NOT NULL,
    [IsLockedOut] bit  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [LastLoginDate] datetime  NOT NULL,
    [LastPasswordChangedDate] datetime  NOT NULL,
    [LastLockoutDate] datetime  NOT NULL,
    [FailedPasswordAttemptCount] int  NOT NULL,
    [FailedPasswordAttemptWindowStart] datetime  NOT NULL,
    [FailedPasswordAnswerAttemptCount] int  NOT NULL,
    [FailedPasswordAnswerAttemptWindowStart] datetime  NOT NULL,
    [Comment] nvarchar(max)  NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] uniqueidentifier  NOT NULL,
    [RegionName] nvarchar(50)  NOT NULL,
    [CityName] nvarchar(50)  NOT NULL,
    [CityBaseUrl] nvarchar(255)  NOT NULL,
    [Active] bit  NOT NULL,
    [StateProvince] nvarchar(50)  NULL
);
GO

-- Creating table 'UserCities'
CREATE TABLE [dbo].[UserCities] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [CityId] uniqueidentifier  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'ListingCategories'
CREATE TABLE [dbo].[ListingCategories] (
    [Id] uniqueidentifier  NOT NULL,
    [ListingGroupId] uniqueidentifier  NOT NULL,
    [ListingCategoryName] nvarchar(100)  NOT NULL,
    [CategoryBaseUrl] nvarchar(50)  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'ListingGroups'
CREATE TABLE [dbo].[ListingGroups] (
    [Id] uniqueidentifier  NOT NULL,
    [ListingGroupName] nvarchar(100)  NOT NULL,
    [ListingBaseUrl] nvarchar(50)  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'UserListingCategories'
CREATE TABLE [dbo].[UserListingCategories] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [ListingCategoryId] uniqueidentifier  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'UserKeywords'
CREATE TABLE [dbo].[UserKeywords] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Keyword] nvarchar(255)  NOT NULL,
    [WeightedScore] int  NOT NULL
);
GO

-- Creating table 'ListingContents'
CREATE TABLE [dbo].[ListingContents] (
    [Id] uniqueidentifier  NOT NULL,
    [ListingUrlId] uniqueidentifier  NOT NULL,
    [PostContent] nvarchar(max)  NOT NULL,
    [PostElement] nvarchar(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [PostDate] datetime  NOT NULL,
    [ReplyTo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ListingUrls'
CREATE TABLE [dbo].[ListingUrls] (
    [Id] uniqueidentifier  NOT NULL,
    [ListingCategoryId] uniqueidentifier  NOT NULL,
    [CityId] uniqueidentifier  NOT NULL,
    [Url] nvarchar(255)  NOT NULL,
    [Title] nvarchar(255)  NOT NULL,
    [PostId] bigint  NOT NULL,
    [Created] datetime  NOT NULL
);
GO

-- Creating table 'UserListingUrls'
CREATE TABLE [dbo].[UserListingUrls] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [ListingUrlId] uniqueidentifier  NOT NULL,
    [Created] datetime  NOT NULL,
    [IsHidden] bit  NOT NULL
);
GO

-- Creating table 'UserListingRefreshes'
CREATE TABLE [dbo].[UserListingRefreshes] (
    [ListingUrl] nvarchar(306)  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [ListingCategoryId] uniqueidentifier  NOT NULL,
    [ListingGroupId] uniqueidentifier  NOT NULL,
    [CityId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'UserListingResponses'
CREATE TABLE [dbo].[UserListingResponses] (
    [Id] uniqueidentifier  NOT NULL,
    [UserListingUrlId] uniqueidentifier  NOT NULL,
    [Response] nvarchar(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [ResponseSent] datetime  NULL,
    [ResponseText] nvarchar(max)  NOT NULL,
    [UserFileId] uniqueidentifier  NULL
);
GO

-- Creating table 'UserPreferences'
CREATE TABLE [dbo].[UserPreferences] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [LiveMode] bit  NOT NULL,
    [BCCEmailAddress] nvarchar(255)  NOT NULL,
    [SMTPUser] nvarchar(255)  NULL,
    [SMTPServer] nvarchar(255)  NULL,
    [SMTPPort] int  NOT NULL,
    [SMTPPassword] nvarchar(50)  NULL,
    [RequiresSSL] bit  NOT NULL,
    [MinimumKeywordScore] int  NOT NULL
);
GO

-- Creating table 'vw_aspnet_MembershipUsers'
CREATE TABLE [dbo].[vw_aspnet_MembershipUsers] (
    [UserId] uniqueidentifier  NOT NULL,
    [PasswordFormat] int  NOT NULL,
    [MobilePIN] nvarchar(16)  NULL,
    [Email] nvarchar(256)  NULL,
    [LoweredEmail] nvarchar(256)  NULL,
    [PasswordQuestion] nvarchar(256)  NULL,
    [PasswordAnswer] nvarchar(128)  NULL,
    [IsApproved] bit  NOT NULL,
    [IsLockedOut] bit  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [LastLoginDate] datetime  NOT NULL,
    [LastPasswordChangedDate] datetime  NOT NULL,
    [LastLockoutDate] datetime  NOT NULL,
    [FailedPasswordAttemptCount] int  NOT NULL,
    [FailedPasswordAttemptWindowStart] datetime  NOT NULL,
    [FailedPasswordAnswerAttemptCount] int  NOT NULL,
    [FailedPasswordAnswerAttemptWindowStart] datetime  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [ApplicationId] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [MobileAlias] nvarchar(16)  NULL,
    [IsAnonymous] bit  NOT NULL,
    [LastActivityDate] datetime  NOT NULL
);
GO

-- Creating table 'UserListingKeywordScores'
CREATE TABLE [dbo].[UserListingKeywordScores] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [UserListingId] uniqueidentifier  NOT NULL,
    [KeywordScore] int  NOT NULL,
    [KeywordDisplay] nvarchar(max)  NULL
);
GO

-- Creating table 'UserTemplates'
CREATE TABLE [dbo].[UserTemplates] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [IsDefault] bit  NOT NULL,
    [TemplateName] nvarchar(255)  NOT NULL,
    [TemplateHtml] nvarchar(max)  NOT NULL,
    [TemplateText] nvarchar(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [Updated] datetime  NULL,
    [UserFileId] uniqueidentifier  NULL
);
GO

-- Creating table 'UserFilters'
CREATE TABLE [dbo].[UserFilters] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [PostStart] datetime  NULL,
    [PostEnd] datetime  NULL,
    [ResponseStart] datetime  NULL,
    [ResponseEnd] datetime  NULL,
    [FilteredCities] nvarchar(max)  NULL,
    [FilteredStates] nvarchar(max)  NULL,
    [FilteredCountries] nvarchar(max)  NULL,
    [FilteredKeywords] nvarchar(max)  NULL,
    [ShowResponded] bit  NOT NULL,
    [ShowNotResponded] bit  NOT NULL,
    [FiltersEnabled] bit  NOT NULL
);
GO

-- Creating table 'BugReports'
CREATE TABLE [dbo].[BugReports] (
    [Id] uniqueidentifier  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Resolution] nvarchar(max)  NULL,
    [ReproductionSteps] nvarchar(max)  NULL,
    [Reported] datetime  NOT NULL,
    [Resolved] datetime  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryID] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(64)  NOT NULL
);
GO

-- Creating table 'CategoryLogs'
CREATE TABLE [dbo].[CategoryLogs] (
    [CategoryLogID] int IDENTITY(1,1) NOT NULL,
    [CategoryID] int  NOT NULL,
    [LogID] int  NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [LogID] int IDENTITY(1,1) NOT NULL,
    [EventID] int  NULL,
    [Priority] int  NOT NULL,
    [Severity] nvarchar(32)  NOT NULL,
    [Title] nvarchar(256)  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [MachineName] nvarchar(32)  NOT NULL,
    [AppDomainName] nvarchar(512)  NOT NULL,
    [ProcessID] nvarchar(256)  NOT NULL,
    [ProcessName] nvarchar(512)  NOT NULL,
    [ThreadName] nvarchar(512)  NULL,
    [Win32ThreadId] nvarchar(128)  NULL,
    [Message] nvarchar(1500)  NULL,
    [FormattedMessage] nvarchar(max)  NULL
);
GO

-- Creating table 'UserFiles'
CREATE TABLE [dbo].[UserFiles] (
    [Id] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Filename] nvarchar(255)  NOT NULL,
    [Extension] nvarchar(5)  NOT NULL,
    [RawFile] varbinary(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [Deleted] datetime  NULL,
    [ByteCount] bigint  NOT NULL
);
GO

-- Creating table 'SystemSettings'
CREATE TABLE [dbo].[SystemSettings] (
    [Id] uniqueidentifier  NOT NULL,
    [SettingName] nvarchar(50)  NOT NULL,
    [SettingValue] nvarchar(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [Updated] datetime  NOT NULL
);
GO

-- Creating table 'UserListingDatas'
CREATE TABLE [dbo].[UserListingDatas] (
    [UserListingUrlId] uniqueidentifier  NOT NULL,
    [ListingUrlId] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Url] nvarchar(255)  NOT NULL,
    [Title] nvarchar(255)  NOT NULL,
    [PostId] bigint  NOT NULL,
    [ListingUrlCreated] datetime  NOT NULL,
    [ListingCategoryName] nvarchar(100)  NOT NULL,
    [CategoryBaseUrl] nvarchar(50)  NOT NULL,
    [ListingCategoryActive] bit  NOT NULL,
    [ListingGroupName] nvarchar(100)  NOT NULL,
    [ListingBaseUrl] nvarchar(50)  NOT NULL,
    [ListingGroupActive] bit  NOT NULL,
    [RegionName] nvarchar(50)  NOT NULL,
    [StateProvince] nvarchar(50)  NULL,
    [CityName] nvarchar(50)  NOT NULL,
    [CityBaseUrl] nvarchar(255)  NOT NULL,
    [CityActive] bit  NOT NULL,
    [Response] nvarchar(max)  NULL,
    [ResponseText] nvarchar(max)  NULL,
    [ResponseSent] datetime  NULL,
    [UserListingCategoryActive] bit  NOT NULL,
    [UserCityActive] bit  NOT NULL,
    [Responded] datetime  NULL,
    [CityId] uniqueidentifier  NOT NULL,
    [UserListingCategoryId] uniqueidentifier  NOT NULL,
    [UserCityId] uniqueidentifier  NOT NULL,
    [ListingCategoryId] uniqueidentifier  NOT NULL,
    [ListingGroupId] uniqueidentifier  NOT NULL,
    [UserListingResponseId] uniqueidentifier  NULL,
    [ListingContentId] uniqueidentifier  NOT NULL,
    [PostText] nvarchar(max)  NULL,
    [PostContent] nvarchar(max)  NULL,
    [PostElement] nvarchar(max)  NULL,
    [PostDate] datetime  NOT NULL,
    [ReplyTo] nvarchar(max)  NOT NULL,
    [ListingContentCreated] datetime  NOT NULL,
    [KeywordScore] int  NULL,
    [KeywordDisplay] nvarchar(max)  NULL,
    [IsHidden] bit  NOT NULL,
    [UserFileId] uniqueidentifier  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'aspnet_Membership'
ALTER TABLE [dbo].[aspnet_Membership]
ADD CONSTRAINT [PK_aspnet_Membership]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserCities'
ALTER TABLE [dbo].[UserCities]
ADD CONSTRAINT [PK_UserCities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ListingCategories'
ALTER TABLE [dbo].[ListingCategories]
ADD CONSTRAINT [PK_ListingCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ListingGroups'
ALTER TABLE [dbo].[ListingGroups]
ADD CONSTRAINT [PK_ListingGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserListingCategories'
ALTER TABLE [dbo].[UserListingCategories]
ADD CONSTRAINT [PK_UserListingCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserKeywords'
ALTER TABLE [dbo].[UserKeywords]
ADD CONSTRAINT [PK_UserKeywords]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ListingContents'
ALTER TABLE [dbo].[ListingContents]
ADD CONSTRAINT [PK_ListingContents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ListingUrls'
ALTER TABLE [dbo].[ListingUrls]
ADD CONSTRAINT [PK_ListingUrls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserListingUrls'
ALTER TABLE [dbo].[UserListingUrls]
ADD CONSTRAINT [PK_UserListingUrls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ListingUrl], [UserId], [ListingCategoryId], [ListingGroupId], [CityId] in table 'UserListingRefreshes'
ALTER TABLE [dbo].[UserListingRefreshes]
ADD CONSTRAINT [PK_UserListingRefreshes]
    PRIMARY KEY CLUSTERED ([ListingUrl], [UserId], [ListingCategoryId], [ListingGroupId], [CityId] ASC);
GO

-- Creating primary key on [Id] in table 'UserListingResponses'
ALTER TABLE [dbo].[UserListingResponses]
ADD CONSTRAINT [PK_UserListingResponses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserPreferences'
ALTER TABLE [dbo].[UserPreferences]
ADD CONSTRAINT [PK_UserPreferences]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserId], [PasswordFormat], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [ApplicationId], [UserName], [IsAnonymous], [LastActivityDate] in table 'vw_aspnet_MembershipUsers'
ALTER TABLE [dbo].[vw_aspnet_MembershipUsers]
ADD CONSTRAINT [PK_vw_aspnet_MembershipUsers]
    PRIMARY KEY CLUSTERED ([UserId], [PasswordFormat], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [ApplicationId], [UserName], [IsAnonymous], [LastActivityDate] ASC);
GO

-- Creating primary key on [Id] in table 'UserListingKeywordScores'
ALTER TABLE [dbo].[UserListingKeywordScores]
ADD CONSTRAINT [PK_UserListingKeywordScores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserTemplates'
ALTER TABLE [dbo].[UserTemplates]
ADD CONSTRAINT [PK_UserTemplates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserFilters'
ALTER TABLE [dbo].[UserFilters]
ADD CONSTRAINT [PK_UserFilters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BugReports'
ALTER TABLE [dbo].[BugReports]
ADD CONSTRAINT [PK_BugReports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CategoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [CategoryLogID] in table 'CategoryLogs'
ALTER TABLE [dbo].[CategoryLogs]
ADD CONSTRAINT [PK_CategoryLogs]
    PRIMARY KEY CLUSTERED ([CategoryLogID] ASC);
GO

-- Creating primary key on [LogID] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([LogID] ASC);
GO

-- Creating primary key on [Id] in table 'UserFiles'
ALTER TABLE [dbo].[UserFiles]
ADD CONSTRAINT [PK_UserFiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SystemSettings'
ALTER TABLE [dbo].[SystemSettings]
ADD CONSTRAINT [PK_SystemSettings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserListingUrlId], [ListingUrlId], [UserId], [Url], [Title], [PostId], [ListingUrlCreated], [ListingCategoryName], [CategoryBaseUrl], [ListingCategoryActive], [ListingGroupName], [ListingBaseUrl], [ListingGroupActive], [RegionName], [CityName], [CityBaseUrl], [CityActive], [UserListingCategoryActive], [UserCityActive], [CityId], [UserListingCategoryId], [UserCityId], [ListingCategoryId], [ListingGroupId], [ListingContentId], [PostDate], [ReplyTo], [ListingContentCreated], [IsHidden] in table 'UserListingDatas'
ALTER TABLE [dbo].[UserListingDatas]
ADD CONSTRAINT [PK_UserListingDatas]
    PRIMARY KEY CLUSTERED ([UserListingUrlId], [ListingUrlId], [UserId], [Url], [Title], [PostId], [ListingUrlCreated], [ListingCategoryName], [CategoryBaseUrl], [ListingCategoryActive], [ListingGroupName], [ListingBaseUrl], [ListingGroupActive], [RegionName], [CityName], [CityBaseUrl], [CityActive], [UserListingCategoryActive], [UserCityActive], [CityId], [UserListingCategoryId], [UserCityId], [ListingCategoryId], [ListingGroupId], [ListingContentId], [PostDate], [ReplyTo], [ListingContentCreated], [IsHidden] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'UserCities'
ALTER TABLE [dbo].[UserCities]
ADD CONSTRAINT [FK_UserCity_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCity_aspnet_Membership'
CREATE INDEX [IX_FK_UserCity_aspnet_Membership]
ON [dbo].[UserCities]
    ([UserId]);
GO

-- Creating foreign key on [CityId] in table 'UserCities'
ALTER TABLE [dbo].[UserCities]
ADD CONSTRAINT [FK_UserCityCity]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCityCity'
CREATE INDEX [IX_FK_UserCityCity]
ON [dbo].[UserCities]
    ([CityId]);
GO

-- Creating foreign key on [UserId] in table 'UserListingCategories'
ALTER TABLE [dbo].[UserListingCategories]
ADD CONSTRAINT [FK_UserListingCategory_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingCategory_aspnet_Membership'
CREATE INDEX [IX_FK_UserListingCategory_aspnet_Membership]
ON [dbo].[UserListingCategories]
    ([UserId]);
GO

-- Creating foreign key on [ListingGroupId] in table 'ListingCategories'
ALTER TABLE [dbo].[ListingCategories]
ADD CONSTRAINT [FK_ListingCategory_ListingGroup]
    FOREIGN KEY ([ListingGroupId])
    REFERENCES [dbo].[ListingGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ListingCategory_ListingGroup'
CREATE INDEX [IX_FK_ListingCategory_ListingGroup]
ON [dbo].[ListingCategories]
    ([ListingGroupId]);
GO

-- Creating foreign key on [ListingCategoryId] in table 'UserListingCategories'
ALTER TABLE [dbo].[UserListingCategories]
ADD CONSTRAINT [FK_UserListingCategory_ListingCategory]
    FOREIGN KEY ([ListingCategoryId])
    REFERENCES [dbo].[ListingCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingCategory_ListingCategory'
CREATE INDEX [IX_FK_UserListingCategory_ListingCategory]
ON [dbo].[UserListingCategories]
    ([ListingCategoryId]);
GO

-- Creating foreign key on [UserId] in table 'UserKeywords'
ALTER TABLE [dbo].[UserKeywords]
ADD CONSTRAINT [FK_UserKeyword_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserKeyword_aspnet_Membership'
CREATE INDEX [IX_FK_UserKeyword_aspnet_Membership]
ON [dbo].[UserKeywords]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserListingUrls'
ALTER TABLE [dbo].[UserListingUrls]
ADD CONSTRAINT [FK_UserListingUrl_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingUrl_aspnet_Membership'
CREATE INDEX [IX_FK_UserListingUrl_aspnet_Membership]
ON [dbo].[UserListingUrls]
    ([UserId]);
GO

-- Creating foreign key on [ListingCategoryId] in table 'ListingUrls'
ALTER TABLE [dbo].[ListingUrls]
ADD CONSTRAINT [FK_ListingUrl_ListingCategory]
    FOREIGN KEY ([ListingCategoryId])
    REFERENCES [dbo].[ListingCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ListingUrl_ListingCategory'
CREATE INDEX [IX_FK_ListingUrl_ListingCategory]
ON [dbo].[ListingUrls]
    ([ListingCategoryId]);
GO

-- Creating foreign key on [ListingUrlId] in table 'ListingContents'
ALTER TABLE [dbo].[ListingContents]
ADD CONSTRAINT [FK_ListingContent_ListingUrl]
    FOREIGN KEY ([ListingUrlId])
    REFERENCES [dbo].[ListingUrls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ListingContent_ListingUrl'
CREATE INDEX [IX_FK_ListingContent_ListingUrl]
ON [dbo].[ListingContents]
    ([ListingUrlId]);
GO

-- Creating foreign key on [ListingUrlId] in table 'UserListingUrls'
ALTER TABLE [dbo].[UserListingUrls]
ADD CONSTRAINT [FK_UserListingUrl_ListingUrl]
    FOREIGN KEY ([ListingUrlId])
    REFERENCES [dbo].[ListingUrls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingUrl_ListingUrl'
CREATE INDEX [IX_FK_UserListingUrl_ListingUrl]
ON [dbo].[UserListingUrls]
    ([ListingUrlId]);
GO

-- Creating foreign key on [UserListingUrlId] in table 'UserListingResponses'
ALTER TABLE [dbo].[UserListingResponses]
ADD CONSTRAINT [FK_UserListingResponse_UserListingUrl]
    FOREIGN KEY ([UserListingUrlId])
    REFERENCES [dbo].[UserListingUrls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingResponse_UserListingUrl'
CREATE INDEX [IX_FK_UserListingResponse_UserListingUrl]
ON [dbo].[UserListingResponses]
    ([UserListingUrlId]);
GO

-- Creating foreign key on [UserId] in table 'UserPreferences'
ALTER TABLE [dbo].[UserPreferences]
ADD CONSTRAINT [FK_UserPreference_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPreference_aspnet_Membership'
CREATE INDEX [IX_FK_UserPreference_aspnet_Membership]
ON [dbo].[UserPreferences]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserListingKeywordScores'
ALTER TABLE [dbo].[UserListingKeywordScores]
ADD CONSTRAINT [FK_UserListingKeywordScore_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingKeywordScore_aspnet_Membership'
CREATE INDEX [IX_FK_UserListingKeywordScore_aspnet_Membership]
ON [dbo].[UserListingKeywordScores]
    ([UserId]);
GO

-- Creating foreign key on [UserListingId] in table 'UserListingKeywordScores'
ALTER TABLE [dbo].[UserListingKeywordScores]
ADD CONSTRAINT [FK_UserListingKeywordScore_UserListingUrl]
    FOREIGN KEY ([UserListingId])
    REFERENCES [dbo].[UserListingUrls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingKeywordScore_UserListingUrl'
CREATE INDEX [IX_FK_UserListingKeywordScore_UserListingUrl]
ON [dbo].[UserListingKeywordScores]
    ([UserListingId]);
GO

-- Creating foreign key on [UserId] in table 'UserTemplates'
ALTER TABLE [dbo].[UserTemplates]
ADD CONSTRAINT [FK_UserTemplate_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTemplate_aspnet_Membership'
CREATE INDEX [IX_FK_UserTemplate_aspnet_Membership]
ON [dbo].[UserTemplates]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserFilters'
ALTER TABLE [dbo].[UserFilters]
ADD CONSTRAINT [FK_UserFilter_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFilter_aspnet_Membership'
CREATE INDEX [IX_FK_UserFilter_aspnet_Membership]
ON [dbo].[UserFilters]
    ([UserId]);
GO

-- Creating foreign key on [CategoryID] in table 'CategoryLogs'
ALTER TABLE [dbo].[CategoryLogs]
ADD CONSTRAINT [FK_CategoryLog_Category]
    FOREIGN KEY ([CategoryID])
    REFERENCES [dbo].[Categories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryLog_Category'
CREATE INDEX [IX_FK_CategoryLog_Category]
ON [dbo].[CategoryLogs]
    ([CategoryID]);
GO

-- Creating foreign key on [LogID] in table 'CategoryLogs'
ALTER TABLE [dbo].[CategoryLogs]
ADD CONSTRAINT [FK_CategoryLog_Log]
    FOREIGN KEY ([LogID])
    REFERENCES [dbo].[Logs]
        ([LogID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryLog_Log'
CREATE INDEX [IX_FK_CategoryLog_Log]
ON [dbo].[CategoryLogs]
    ([LogID]);
GO

-- Creating foreign key on [CityId] in table 'ListingUrls'
ALTER TABLE [dbo].[ListingUrls]
ADD CONSTRAINT [FK_ListingUrl_City]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ListingUrl_City'
CREATE INDEX [IX_FK_ListingUrl_City]
ON [dbo].[ListingUrls]
    ([CityId]);
GO

-- Creating foreign key on [UserId] in table 'UserFiles'
ALTER TABLE [dbo].[UserFiles]
ADD CONSTRAINT [FK_UserFile_aspnet_Membership]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Membership]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFile_aspnet_Membership'
CREATE INDEX [IX_FK_UserFile_aspnet_Membership]
ON [dbo].[UserFiles]
    ([UserId]);
GO

-- Creating foreign key on [UserFileId] in table 'UserListingResponses'
ALTER TABLE [dbo].[UserListingResponses]
ADD CONSTRAINT [FK_UserListingResponse_UserListingResponse]
    FOREIGN KEY ([UserFileId])
    REFERENCES [dbo].[UserFiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserListingResponse_UserListingResponse'
CREATE INDEX [IX_FK_UserListingResponse_UserListingResponse]
ON [dbo].[UserListingResponses]
    ([UserFileId]);
GO

-- Creating foreign key on [UserFileId] in table 'UserTemplates'
ALTER TABLE [dbo].[UserTemplates]
ADD CONSTRAINT [FK_UserTemplate_UserFile]
    FOREIGN KEY ([UserFileId])
    REFERENCES [dbo].[UserFiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTemplate_UserFile'
CREATE INDEX [IX_FK_UserTemplate_UserFile]
ON [dbo].[UserTemplates]
    ([UserFileId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------