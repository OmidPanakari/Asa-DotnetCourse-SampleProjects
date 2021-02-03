CREATE PROCEDURE [dbo].[person_unit_relation_create]
	@unit_id int,
	@person_id int,
	@relation_type int,
	@start_date date,
	@end_date date
AS

INSERT INTO [dbo].[PersonUnitRelation](
	[unit_id],
	[person_id],
	[relation_type],
	[start_date],
	[end_date]
)VALUES(
	@unit_id,
	@person_id,
	@relation_type,
	@start_date,
	@end_date
)
SELECT SCOPE_IDENTITY()
RETURN 0
