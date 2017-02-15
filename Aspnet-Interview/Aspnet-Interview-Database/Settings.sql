CREATE TABLE [dbo].[Settings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SettingName] VARCHAR(50) NOT NULL, 
    [SettingValue] NVARCHAR(100) NULL
)
