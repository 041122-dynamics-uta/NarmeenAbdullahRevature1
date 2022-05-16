

CREATE TABLE Cosmo_Costumers(
	costumerId int PRIMARY KEY,
	costumerName varchar(50),
	costumerNumber varchar(50),
	costumerAddress varchar(50),
	costumerEmail varchar(50)
)

CREATE TABLE Cosmo_Products(
	productId int PRIMARY KEY,
	productName varchar(50),
	productPrice float,
	productDescription varchar (800),
	productCategory varchar(50)
)

CREATE TABLE Cosmo_Stores(
	storeNumber int PRIMARY KEY,
	storeName varchar(50),
	storeAddress varchar(50)
)

CREATE TABLE Cosmo_Orders(
	orderNumber int PRIMARY KEY,
	costumerId int FOREIGN KEY REFERENCES Costumers(costumerId), --Foreign key reflecting costumerId or storeNumber
	storeNumber int FOREIGN KEY REFERENCES Stores(storeNumber),
	productId int FOREIGN KEY REFERENCES Products (productId)
)

CREATE TABLE Cosmo_LineItems(
	storeNumber int FOREIGN KEY REFERENCES Stores(storeNumber), -- Foreign key
	productId int FOREIGN KEY REFERENCES Products(productId), -- Foreign key
	quantity int
)

