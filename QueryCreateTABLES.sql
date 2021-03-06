DROP TABLE IF EXISTS Product;
DROP TABLE IF EXISTS Brand;
DROP TABLE IF EXISTS ProductType;

CREATE TABLE Brand
(
	 ID INT IDENTITY(1, 1) PRIMARY KEY,
	 BrandName VARCHAR(50)
);

CREATE TABLE ProductType
(
	ID INT IDENTITY (1,1),
	ProductTypeName VARCHAR(50),

	CONSTRAINT PK_ProductType PRIMARY KEY(ID)

);

CREATE TABLE Product
(
	ID INT,
	ProductName VARCHAR(150),
	Quantity INT,
	Price float, -- This price is on per piece --
	BrandID INT,
	ProductTypeID INT,

	-- FK AND PK
	CONSTRAINT PK_Product PRIMARY KEY(ID),
	CONSTRAINT FK_ProductBrand FOREIGN KEY (BrandID) REFERENCES Brand(ID),
	CONSTRAINT FK_ProductProductType FOREIGN KEY (ProductTypeID) REFERENCES ProductType(ID)

);

CREATE TABLE BottleSacks
(
	ID INT IDENTITY(1,1),
	Quantity INT, -- Amount of bottle stored inside this sack of one ID --
	Stat VARCHAR(25),	-- to Valuate if its sold or not and not been sold
	ProductID INT,
	CONSTRAINT PK_BottleSacks PRIMARY KEY(ID),
	CONSTRAINT FK_BottleProduct FOREIGN KEY (ProductID) REFERENCES	Product(ID)
);
