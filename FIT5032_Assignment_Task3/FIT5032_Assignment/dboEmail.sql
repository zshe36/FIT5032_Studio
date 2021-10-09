CREATE TABLE [dbo].[Email] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [To]       VARCHAR (50)  NOT NULL,
    [Subject]  VARCHAR (50)  NOT NULL,
    [Contents] VARCHAR (150) NOT NULL,
	[Attachment] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

