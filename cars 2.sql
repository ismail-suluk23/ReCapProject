CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [CarName]     VARCHAR (255) NOT NULL,
    [ModelYear]   INT           NOT NULL,
    [DailyPrice]  DECIMAL (18)  NOT NULL,
    [Description] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([CarId] ASC)
);
