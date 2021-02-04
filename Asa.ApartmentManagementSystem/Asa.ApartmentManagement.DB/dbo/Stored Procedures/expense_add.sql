CREATE PROCEDURE [dbo].[expense_add]
	@category_id int,
	@value decimal(5, 2),
	@from datetime,
	@to datetime,
	@description nvarchar(50)
AS
	INSERT INTO [dbo].[Expenses](
		[category_id],
		[value],
		[from],
		[to],
		[description]
	)VALUES(
		@category_id,
		@value,
		@from,
		@to,
		@description
	)
	SELECT SCOPE_IDENTITY()
RETURN 0
