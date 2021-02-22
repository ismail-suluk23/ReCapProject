CREATE TABLE Cars (
    CarId      INT        NOT NULL,
    DailyPrice  INT        NULL,
    ModelYear   INT        NULL,
    Description NCHAR (10) NULL,
    BrandId     INT        NULL,
    ColorId     INT        NULL, 
   
    )
    CREATE TABLE Colors (
    ColorId   INT       NOT NULL,
    ColorName NCHAR (1) NOT NULL

)
CREATE TABLE Brands (
    BrandId   INT       NOT NULL,
    BrandName NCHAR (1) NOT NULL
);