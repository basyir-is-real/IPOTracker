CREATE TABLE Companies (
    CompanyId INT PRIMARY KEY IDENTITY,
    CompanyName NVARCHAR(50),
    Industry NVARCHAR(25),
    Ticker NVARCHAR(10),
    ListingDate DATE,
    ListingPrice DECIMAL(18, 2),
    CurrentPrice DECIMAL(18, 2)
);
