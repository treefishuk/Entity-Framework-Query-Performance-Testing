CREATE TABLE [dbo].[Copy] (
    [CopyId] INT             IDENTITY (1, 1) NOT NULL,
    [BookId] INT             NULL,
    [Price]  DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Copy] PRIMARY KEY CLUSTERED ([CopyId] ASC),
    CONSTRAINT [FK_Copy_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([BookId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Copy_BookId]
    ON [dbo].[Copy]([BookId] ASC);

