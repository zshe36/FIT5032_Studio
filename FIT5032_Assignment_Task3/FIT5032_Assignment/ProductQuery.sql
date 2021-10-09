-- Create table 'Products'
CREATE TABLE [dbo].[Products](
	[Id] int IDENTITY (1,1) NOT NULL,
	[ProductName] nvarchar (max) NOT NULL,
	[Category] nvarchar (max) NOT NULL,
	[Description] nvarchar (max) NOT NULL,
	[Price] nvarchar (max) NOT NULL,
	[Quantity] nvarchar (max) NOT NULL,
	PRIMARY KEY (Id)
);
GO
