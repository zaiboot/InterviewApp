CREATE PROCEDURE [dbo].DeletePatient
	@Id Int
AS
	delete from  Patient WHERE Id = @id;
	
RETURN 0
