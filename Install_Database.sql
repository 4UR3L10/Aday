/*
    SQL Server Tools:
        01 - View -> Server Explorer
        02 - Right Click on "Data Connections"
        03 - Click on "Add Connection"
        04 - Select "Microsoft SQL Server" or ""Microsoft SQL Server Database File"
        05 - Install and Continue the Steps.
*/

CREATE TABLE [dbo].[Customer]
(
	[CustomerID] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [First Name] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [EmailAddress] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL
)

INSERT INTO [dbo].[Customer] ([CustomerID], [First Name], [LastName], [EmailAddress], [Password]) VALUES (N'1', N'123', N'123', N'123', N'123')

