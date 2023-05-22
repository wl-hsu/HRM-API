IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Interviewers] (
    [Id] int NOT NULL IDENTITY,
    [EmployeeIdentityId] uniqueidentifier NOT NULL,
    [Email] varchar(max) NOT NULL,
    [FirstName] varchar(50) NOT NULL,
    [LastName] varchar(50) NOT NULL,
    CONSTRAINT [PK_Interviewers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Interviews] (
    [Id] int NOT NULL IDENTITY,
    [BeginTime] datetime2 NOT NULL,
    [CandidateEmail] varchar(max) NOT NULL,
    [CandidateFirstName] varchar(50) NOT NULL,
    [CandidateLastName] varchar(50) NOT NULL,
    [CandidateIdentityId] uniqueidentifier NOT NULL,
    [EndTime] datetime2 NOT NULL,
    [Feedback] nvarchar(max) NULL,
    [InterviewerId] int NOT NULL,
    [InterviewTypeId] int NOT NULL,
    [Rating] int NULL,
    [Passed] int NULL,
    [SubmissionId] int NOT NULL,
    CONSTRAINT [PK_Interviews] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [InterviewTypeLookUps] (
    [Id] int NOT NULL IDENTITY,
    [InterviewTypeCode] varchar(50) NOT NULL,
    [InterviewTypeDescription] varchar(256) NOT NULL,
    CONSTRAINT [PK_InterviewTypeLookUps] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230518043706_InitDB', N'7.0.5');
GO

COMMIT;
GO

