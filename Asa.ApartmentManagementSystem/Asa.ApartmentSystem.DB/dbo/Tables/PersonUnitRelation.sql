CREATE TABLE [dbo].[PersonUnitRelation]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [unit_id] INT NOT NULL, 
    [person_id] INT NOT NULL, 
    [relation_type] INT NOT NULL, 
    [start_date] DATE NOT NULL, 
    [end_date] DATE NULL
)
