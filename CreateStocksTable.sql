CREATE TABLE [dbo].[Stocks] (
    [StockId]    INT             IDENTITY (1, 1) NOT NULL,
    [CompanyName]  NVARCHAR (50)   NULL,
    [Industry]     NVARCHAR (25)   NULL,
    [Ticker]       NVARCHAR (10)   NULL,
    [ListingDate]  DATE            NULL,
    [ListingPrice] DECIMAL (18, 2) NULL,
    [LastPrice] DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([StockId] ASC)
);