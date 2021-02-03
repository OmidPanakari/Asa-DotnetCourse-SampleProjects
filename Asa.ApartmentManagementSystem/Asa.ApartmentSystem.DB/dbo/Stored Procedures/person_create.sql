CREATE PROCEDURE [dbo].[person_create]
	@first_name nvarchar(50),
	@last_name	nvarchar(50),
	@phone_number nvarchar(20)
AS

INSERT INTO [dbo].[Person](
	[first_name],
	[last_name],
	[phone_number]
)VALUES(
	@first_name,
	@last_name,
	@phone_number
)
	SELECT SCOPE_IDENTITY()
RETURN 0
