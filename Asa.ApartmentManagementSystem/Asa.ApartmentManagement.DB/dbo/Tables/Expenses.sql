CREATE TABLE [dbo].[Expenses]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [category_id] INT NOT NULL, 
    [value] DECIMAL(5, 2) NOT NULL, 
    [from] DATETIME NOT NULL, 
    [to] DATETIME NOT NULL, 
    [description] NVARCHAR(50) NOT NULL
)
