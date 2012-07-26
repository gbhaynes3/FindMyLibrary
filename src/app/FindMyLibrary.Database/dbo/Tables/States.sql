CREATE TABLE [dbo].[States] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Abbreviation] NVARCHAR (MAX) NULL,
    [Name]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED ([Id] ASC)
);

