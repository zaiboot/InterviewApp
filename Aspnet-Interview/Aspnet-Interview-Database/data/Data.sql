/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO SocialNetworking(SocialNetworkName, [Url]) VALUES ('Facebook','https://www.facebook.com/edgar.madrigalfallas?fref=nf');
INSERT INTO SocialNetworking(SocialNetworkName, [Url]) VALUES ('LinkedIn','https://www.linkedin.com/in/edgar-madrigal-fallas-4b85a019');
INSERT INTO SocialNetworking(SocialNetworkName, [Url]) VALUES ('GitHub','https://github.com/zaiboot');


