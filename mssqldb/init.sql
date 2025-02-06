USE master
GO

IF NOT EXISTS (
  SELECT [name]
    FROM sys.databases
    WHERE [name] = N'Sample'
)
CREATE DATABASE Sample
GO

IF OBJECT_ID('[dbo].[People]', 'U') IS NOT NULL
DROP TABLE [dbo].[People]
GO

CREATE TABLE [dbo].[People]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  [FirstName] NVARCHAR(50) NOT NULL,
  [LastName] NVARCHAR(50) NOT NULL
)
GO