CREATE TABLE [dbo].[ParentDetails]
(
	[ParentID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [ContactDetail1] INT NOT NULL, 
    [ContactDetail2] INT NULL, 
    [EmergencyContact] INT NOT NULL
)
