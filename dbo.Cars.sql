CREATE TABLE [dbo].[Cars] (
    [Id]          INT           NOT NULL,
    [CarId]       INT           NULL,
    [ModelYear]   INT           NULL,
    [Description] NVARCHAR (50) NULL,
    [BrandId]     INT           NULL,
    [ColorId]     INT           NULL,
    [DailyPrice]  DECIMAL NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

