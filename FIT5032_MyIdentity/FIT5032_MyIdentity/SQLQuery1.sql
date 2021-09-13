-- create table 'Students'
CREATE TABLE [DBO].[Students] (
	[Id] int IDENTITY (1,1) NOT NULL,
	[FirstName] nvarchar (max) NOT NULL,
	[LastName] nvarchar (max) NOT NULL,
		[UserId] nvarchar (max) NOT NULL
	PRIMARY KEY (Id)
);
GO

-- create table 'Units'
CREATE TABLE [DBO].[Units] (
	[Id] int IDENTITY (1,1) NOT NULL,
	[name] nvarchar (max) NOT NULL,
	[Descrption] nvarchar (max) NOT NULL,
		[StudentId] int NOT NULL
	PRIMARY KEY (Id)
	FOREIGN KEY (StudentId) REFERENCES Students (Id)
);
GO
