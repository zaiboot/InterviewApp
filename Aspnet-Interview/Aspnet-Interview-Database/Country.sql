CREATE TABLE Country
(
     [Id] INT NOT NULL
    ,CountryName VARCHAR(50) NOT NULL
    ,TwoCharCountryCode CHAR(2) NOT NULL
    ,ThreeCharCountryCode CHAR(3) NOT NULL, 
    CONSTRAINT [PK_tbl_Countries] PRIMARY KEY ([Id])    
);