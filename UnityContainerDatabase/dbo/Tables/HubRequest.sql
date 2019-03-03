CREATE TABLE [dbo].[HubRequest] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [AgencyCode]      NVARCHAR (50) NULL,
    [AgencyID]        INT           NULL,
    [FamilyName]      NVARCHAR (50) NULL,
    [DOBOfYear]       INT           NULL,
    [SleepSeconds]    INT           NULL,
    [TimeStamp]       DATETIME2 (7) NULL,
    [CreatedDateTime] DATETIME2 (7) CONSTRAINT [DF_HubRequest_CreatedDateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_HubRequest] PRIMARY KEY CLUSTERED ([ID] ASC)
);

