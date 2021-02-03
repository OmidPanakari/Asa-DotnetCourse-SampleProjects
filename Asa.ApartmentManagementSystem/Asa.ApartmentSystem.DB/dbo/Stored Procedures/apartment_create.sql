CREATE PROCEDURE [dbo].[apartment_create]
	@building_id int,
	@number int,
	@area decimal(5,1),
	@description nvarchar(50)
AS

INSERT INTO [dbo].[Units](
	[building_id],
	[number],
	[area],
	[description]
)VALUES(
	@building_id,
	@number,
	@area,
	@description
)
	SELECT SCOPE_IDENTITY()
RETURN 0
