CREATE PROCEDURE [dbo].[AddPatient]
	 @FirstName nvarchar(50)
	,@LastName nvarchar(100)
	,@PatientId nchar(100)
	,@DOB date
	,@CountryId int
	,@Diseases nVARCHAR(max)
	,@PhoneNumber nvarchar(50)
	,@BloodTypeId int
AS
	INSERT INTO Patient(FirstName,LastName,PatientId,DOB,CountryId,Diseases,PhoneNumber,BloodTypeId) 
	VALUES(		@FirstName,@LastName,@PatientId,@DOB,@CountryId,@Diseases,@PhoneNumber,@BloodTypeId	);
RETURN 0
