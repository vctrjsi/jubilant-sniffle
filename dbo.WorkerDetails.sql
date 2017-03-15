CREATE TABLE [dbo].[WorkerDetails] (
    [WorkerID]         INT          NOT NULL,
    [firstName]        VARCHAR (50) NOT NULL,
    [lastName]         VARCHAR (50) NOT NULL,
    [contactDetail1]   NCHAR (11)   NOT NULL,
    [contactDetail2]   NCHAR (11)   NULL,
    [emergencyContact] NCHAR (11)   NOT NULL,
    [dbsCheck]         BINARY (50)  NOT NULL,
    [loginID]         INT NOT NULL,
    PRIMARY KEY CLUSTERED ([WorkerID] ASC),
    CONSTRAINT [FK_WorkerDetails] FOREIGN KEY ([loginID]) REFERENCES [dbo].[LoginDetails] ([loginID])
);

