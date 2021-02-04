CREATE PROCEDURE [dbo].[expense_category_add]
	@name nvarchar(20),
	@formula int
AS
	INSERT INTO [dbo].[ExpenseCategory](
		[name],
		[formula]
	)VALUES(
		@name,
		@formula
	)
	SELECT SCOPE_IDENTITY()
RETURN 0
