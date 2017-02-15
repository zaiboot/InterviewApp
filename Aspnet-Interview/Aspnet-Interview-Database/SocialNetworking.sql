CREATE TABLE [dbo].[SocialNetworking]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SocialNetworkName] NVARCHAR(50) NOT NULL, 
    [Url] NVARCHAR(200) NOT NULL
)
