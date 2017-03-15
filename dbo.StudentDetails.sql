CREATE TABLE [dbo].[StudentDetails] (
    [StudentID]    INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [DateOfBirth]  DATE         NOT NULL,
    [Sex]          NCHAR (10)   NOT NULL,
    [Allergies]    VARCHAR (50) NULL,
    [MedicalNotes] VARCHAR (50) NULL,
    [ParentID]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC), 
    CONSTRAINT [FK_StudentDetails] FOREIGN KEY (ParentID) REFERENCES [ParentDetails]([ParentID])
);

