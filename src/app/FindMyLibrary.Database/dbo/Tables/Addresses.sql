CREATE TABLE [dbo].[Addresses] (
    [AddressId] INT            IDENTITY (1, 1) NOT NULL,
    [Line1]     NVARCHAR (MAX) NULL,
    [Line2]     NVARCHAR (MAX) NULL,
    [City]      NVARCHAR (MAX) NULL,
    [Zip]       NVARCHAR (MAX) NULL,
    [State_Id]  INT            NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [FK_Addresses_States_State_Id] FOREIGN KEY ([State_Id]) REFERENCES [dbo].[States] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_State_Id]
    ON [dbo].[Addresses]([State_Id] ASC);

