CREATE TABLE [dbo].[LoginDetails] (
    [loginID] INT NOT NULL,
    [username] VARCHAR(10)    NOT NULL,
    [password] NCHAR(8) NOT NULL, 
    [permission ] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([loginID] ASC)
);

