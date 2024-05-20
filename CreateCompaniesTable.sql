CREATE TABLE Companies (
    CompanyId INT PRIMARY KEY IDENTITY,
    CompanyName NVARCHAR(100) NOT NULL,
    Industry NVARCHAR(50),
    Ticker VARCHAR(5),
    ListingPrice DECIMAL(18, 2),
    LastPrice DECIMAL(18, 2),
    ListingDate Date
);
