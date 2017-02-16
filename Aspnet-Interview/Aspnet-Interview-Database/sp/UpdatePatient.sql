CREATE PROCEDURE [dbo].[UpdatePatient]
	 @Id int
	,@FirstName nvarchar(50)
	,@LastName nvarchar(100)
	,@PatientId nchar(100)
	,@DOB date
	,@CountryId int
	,@Diseases nVARCHAR(max)
	,@PhoneNumber nvarchar(50)
	,@BloodTypeId int
AS
	UPDATE Patient
	SET 
		FirstName = @FirstName
		,LastName = @LastName
		,PatientId = @PatientId
		,DOB = @DOB
		,CountryId = @CountryId
		,Diseases = @Diseases
		,PhoneNumber = @PhoneNumber
		,BloodTypeId = @BloodTypeId
	WHERE Id = @id;
RETURN 0
