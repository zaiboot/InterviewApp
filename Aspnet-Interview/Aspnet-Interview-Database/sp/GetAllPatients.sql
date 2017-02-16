CREATE PROCEDURE [dbo].[GetAllPatients]
	@PageNumber int
AS
BEGIN
	
	DECLARE @RowsPerPage INT = (SELECT CAST([SettingValue] as INT) FROM [Settings] WHERE  [SettingName] = 'RowsPerPage' );

	SELECT
		  Id
		, FirstName
		, LastName
		, PatientId
		, DOB
		, CountryId
		, Diseases
		, PhoneNumber
		, BloodTypeId

	FROM Patient	
	order by id
	OFFSET (@PageNumber-1)* @RowsPerPage ROWS
	FETCH NEXT @RowsPerPage ROWS ONLY
END