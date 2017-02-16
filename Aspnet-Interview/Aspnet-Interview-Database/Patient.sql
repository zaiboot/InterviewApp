CREATE TABLE [dbo].[Patient]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [PatientId] NCHAR(100) NOT NULL, 
    [DOB] DATE NOT NULL, 
    [CountryId] INT NOT NULL, 
    [Diseases] NTEXT NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [BloodTypeId] INT NOT NULL, 
    CONSTRAINT [FK_Patient_Country] FOREIGN KEY ([CountryId]) REFERENCES Country(Id), 
    CONSTRAINT [FK_Patient_BloodType] FOREIGN KEY ([BloodTypeId]) REFERENCES BloodType(Id)
)
