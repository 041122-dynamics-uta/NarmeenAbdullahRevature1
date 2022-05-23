

CREATE TABLE CosmoCustomer(

    [CosmoCustomerId] INT IDENTITY(1, 1) NOT NULL,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
    [MySecret] NVARCHAR(24) NOT NULL,
    [Email] NVARCHAR(60) NOT NULL,
    CONSTRAINT[PK_CosmoCustomer] PRIMARY KEY CLUSTERED([CosmoCustomerId])
);

CREATE TABLE CosmoOrder(
    CosmoOrderID int IDENTITY(1, 1) NOT NULL,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
    [ItemName] NVARCHAR(20) NOT NULL,
    [ItemDescription] NVARCHAR(200) NOT NULL,
    [Quantity] INT NOT NULL,
    [ItemPrice] int NOT NULL,
    [City] NVARCHAR(40) NOT NULL,
    CONSTRAINT [PK_CosmoOrder] Primary Key CLUSTERED([CosmoOrderID])
);


CREATE TABLE CosmoStoreLocations(
    [StoreLocationId] int IDENTITY(1, 1) NOT NULL,
    [City] NVARCHAR(40) NOT NULL,
	CONSTRAINT [PK_CosmoStoreLocations] Primary Key CLUSTERED([StoreLocationId])
);


CREATE TABLE CosmoOrderHistory(
    OrderHistoryId int IDENTITY(1, 1) NOT NULL,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
    [ItemName] NVARCHAR(20) NOT NULL,
    [ItemDescription] NVARCHAR(200) NOT NULL,
    [Quantity] int NOT NULL,
    [ItemPrice] int NOT NULL,
    [StoreLocationsId] NVARCHAR(200),
    [OrderHistoryDateTime] DateTime NOT NULL,
    CONSTRAINT[PK_CosmoOrderHistory] Primary Key CLUSTERED([OrderHistoryId])
);

CREATE TABLE CosmoInventory(
    [StoreInventoryId] int IDENTITY(1, 1) NOT NULL,
    [ItemName] NVARCHAR(20) NOT NULL,
    [ItemPrice] INT NOT NULL,
    [ItemDescription] NVARCHAR(200) NOT NULL,
    [Quantity] int NOT NULL,
    CONSTRAINT[PK_CosmoInventory] Primary Key CLUSTERED([StoreInventoryId])
);
