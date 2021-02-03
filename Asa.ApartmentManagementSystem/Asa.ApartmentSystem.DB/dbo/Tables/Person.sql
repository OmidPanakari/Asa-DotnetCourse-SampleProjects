CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [building_id] INT NOT NULL, 
    [first_name] NCHAR(20) NOT NULL, 
    [last_name] NCHAR(20) NOT NULL, 
    CONSTRAINT [FK_Person_Building] FOREIGN KEY ([building_id]) REFERENCES [dbo].[Building]([id])
)
