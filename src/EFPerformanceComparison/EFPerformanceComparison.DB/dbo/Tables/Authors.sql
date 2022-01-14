CREATE TABLE [dbo].[Authors] (
    [AuthorId] INT            IDENTITY (1, 1) NOT NULL,
    [FullName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED ([AuthorId] ASC)
);

