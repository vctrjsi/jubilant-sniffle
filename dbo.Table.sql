CREATE TABLE [dbo].[WorkerDetails] (
    [WorkerID]       INT          NOT NULL,
    [FirstName]      VARCHAR (50) NOT NULL,
    [LastName]       VARCHAR (50) NOT NULL,
    [ContactDetail1] NCHAR (11)   NOT NULL,
    [ContactDetail2] NCHAR (11)   NULL,
    [EmergencyContact]       NCHAR(11) NOT NULL,
    [Username] NCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([WorkerID] ASC)
);

