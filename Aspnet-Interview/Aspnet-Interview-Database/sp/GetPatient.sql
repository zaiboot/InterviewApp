CREATE PROCEDURE [dbo].[GetPatient]
	@Id INT
AS
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
	WHERE Id = @id;

RETURN 0
