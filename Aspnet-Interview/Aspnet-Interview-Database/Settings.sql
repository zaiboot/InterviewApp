CREATE TABLE [dbo].[Settings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SettingName] VARCHAR(50) NOT NULL, 
    [SettingValue] VARCHAR(50) NOT NULL
)
