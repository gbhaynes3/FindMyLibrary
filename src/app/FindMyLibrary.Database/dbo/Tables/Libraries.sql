CREATE TABLE [dbo].[Libraries] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (MAX) NULL,
    [Phone]             NVARCHAR (MAX) NULL,
    [Latitue]           FLOAT (53)     NOT NULL,
    [Longitude]         FLOAT (53)     NOT NULL,
    [Address_AddressId] INT            NULL,
    CONSTRAINT [PK_Libraries] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Libraries_Addresses_Address_AddressId] FOREIGN KEY ([Address_AddressId]) REFERENCES [dbo].[Addresses] ([AddressId])
);


GO
ALTER TABLE [dbo].[Libraries] NOCHECK CONSTRAINT [FK_Libraries_Addresses_Address_AddressId];


GO
CREATE NONCLUSTERED INDEX [IX_Address_AddressId]
    ON [dbo].[Libraries]([Address_AddressId] ASC);

