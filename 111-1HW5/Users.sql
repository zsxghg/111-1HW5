﻿CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Birthday] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);