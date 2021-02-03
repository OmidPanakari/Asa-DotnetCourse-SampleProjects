CREATE PROCEDURE [dbo].[show_unit_details] AS
	SELECT
		[u].[Id] AS UnitId,
		[p].[first_name] AS FirstName,
		[p].[last_name] AS LastName,
		[pur].[start_date] AS StartDate,
		[pur].[end_date] AS EndDate
	FROM
		PersonUnitRelation AS pur
	INNER JOIN Person AS p ON p.Id = pur.person_id
	INNER JOIN Units AS u ON u.Id = pur.unit_id
RETURN 0
