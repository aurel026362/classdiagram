﻿/*
Deployment script for DBIntroduction

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DBIntroduction"
:setvar DefaultFilePrefix "DBIntroduction"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.TOMANDJERRY\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.TOMANDJERRY\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[GROUPS]...';


GO
CREATE TABLE [dbo].[GROUPS] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (30) NULL,
    [StartDate] DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Interns]...';


GO
CREATE TABLE [dbo].[Interns] (
    [Id]        BIGINT IDENTITY (1, 1) NOT NULL,
    [GroupId]   BIGINT NOT NULL,
    [UserId]    BIGINT NOT NULL,
    [MenthorId] BIGINT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([MenthorId] ASC),
    UNIQUE NONCLUSTERED ([UserId] ASC)
);


GO
PRINT N'Creating [dbo].[Menthors]...';


GO
CREATE TABLE [dbo].[Menthors] (
    [Id]     BIGINT IDENTITY (1, 1) NOT NULL,
    [UserId] BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([UserId] ASC)
);


GO
PRINT N'Creating [dbo].[Modules]...';


GO
CREATE TABLE [dbo].[Modules] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (30) NOT NULL,
    [StartDate] SMALLDATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[ThemeMarks]...';


GO
CREATE TABLE [dbo].[ThemeMarks] (
    [Id]       BIGINT     IDENTITY (1, 1) NOT NULL,
    [ThemeId]  BIGINT     NOT NULL,
    [InternId] BIGINT     NOT NULL,
    [Mark]     FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Themes]...';


GO
CREATE TABLE [dbo].[Themes] (
    [Id]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (40) NOT NULL,
    [TimeOfTheme] SMALLDATETIME NULL,
    [Source]      NVARCHAR (40) NULL,
    [MenthorId]   BIGINT        NULL,
    [ModuleId]    BIGINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Users]...';


GO
CREATE TABLE [dbo].[Users] (
    [Id]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (20) NOT NULL,
    [LastName]    NVARCHAR (20) NOT NULL,
    [DateOfBirth] SMALLDATETIME NOT NULL,
    [NumberPhone] NVARCHAR (15) NULL,
    [Login]       VARCHAR (20)  NOT NULL,
    [Password]    VARCHAR (20)  NOT NULL,
    [EMail]       VARCHAR (30)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Interns]...';


GO
ALTER TABLE [dbo].[Interns] WITH NOCHECK
    ADD FOREIGN KEY ([GroupId]) REFERENCES [dbo].[GROUPS] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Interns]...';


GO
ALTER TABLE [dbo].[Interns] WITH NOCHECK
    ADD FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Interns]...';


GO
ALTER TABLE [dbo].[Interns] WITH NOCHECK
    ADD FOREIGN KEY ([MenthorId]) REFERENCES [dbo].[Menthors] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Menthors]...';


GO
ALTER TABLE [dbo].[Menthors] WITH NOCHECK
    ADD FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[ThemeMarks]...';


GO
ALTER TABLE [dbo].[ThemeMarks] WITH NOCHECK
    ADD FOREIGN KEY ([ThemeId]) REFERENCES [dbo].[Themes] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[ThemeMarks]...';


GO
ALTER TABLE [dbo].[ThemeMarks] WITH NOCHECK
    ADD FOREIGN KEY ([InternId]) REFERENCES [dbo].[Interns] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Themes]...';


GO
ALTER TABLE [dbo].[Themes] WITH NOCHECK
    ADD FOREIGN KEY ([MenthorId]) REFERENCES [dbo].[Menthors] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Themes]...';


GO
ALTER TABLE [dbo].[Themes] WITH NOCHECK
    ADD FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[Modules] ([Id]);


GO
PRINT N'Creating unnamed constraint on [dbo].[ThemeMarks]...';


GO
ALTER TABLE [dbo].[ThemeMarks] WITH NOCHECK
    ADD CHECK (Mark> 0 AND Mark <=10);


GO
PRINT N'Creating unnamed constraint on [dbo].[Users]...';


GO
ALTER TABLE [dbo].[Users] WITH NOCHECK
    ADD CHECK (EMail like '%@%');


GO

--INSERT USERS
INSERT INTO Users(FirstName, LastName, DateOfBirth, NumberPhone, [Login], [Password], EMail)
VALUES ('Aurel', 'Starciuc', '1999-05-22', '+37367620932', 'aurel99', '12345', 'aur.99.s@mail.ru'),
		('Cristi', 'Anghelenici', '1996-06-15', '+373543677', 'cristi96', '54313', 'cristi@mail.ru'),
		 ('Ion', 'Gandrabura', '1984-02-02', '+37354395054', 'Ion12345', '432213', 'ion@mail.ru'),
		 ('Alexandr', 'Racovschi', '1987-07-20', '+3734325435', 'Alexandr789', 'under12345', 'alexandr@mail.ru'),
		 ('Ernest', 'Bitca', '1996-07-23', '+3736574835', 'ernestbitca', 'er1234', 'ernest@mail.ru'),
		 ('Oleg', 'Horan', '1986-05-12', '+3734356345', 'olegqwe', 'pass123', 'olhor@mail.ru');

INSERT INTO Users(FirstName, LastName, DateOfBirth, NumberPhone, [Login], [Password], EMail)
VALUES('Eliodor', 'Popov', '1996-06-04', '+3735435435', 'elipopov', 'ep5643', 'eliodor@mail.ru'),
					('Marian', 'Bejenari', '1986-08-23', '+373753543', 'mbejenari', 'mb12345', 'marian@mail.ru');

--INSERT MENTHORS
INSERT INTO Menthors(UserId)
VALUES (3),
		(4),
		(6),
		(8);

INSERT INTO Groups(Name, StartDate)
VALUES ('INTERNS31321', '2019-02-01');

--INSERT INTERNS
Insert INTO Interns(GroupId, UserId, MenthorId)
VALUES (1,1,1),
		(1,2,2),
		(1,5,3),
		(1,7,4);



--INSERT MODULES
INSERT INTO Modules([Name], StartDate)
VALUES ('C#', '2019-02-01'),
('SQL', '2019-03-01'),
('WEB', '2019-04-01');

--INSERT THEME
INSERT INTO Themes([Name], TimeOfTheme, [Source], MenthorId, ModuleId)
VALUES ('GIT', '2019-02-02', 'S:\Internship', 2, 1),
('Select Advanced', '2019-03-13 09:30:00', 'S:\Internship', 1, 2),
('Sql Introduction', '2019-03-12 11:00', 'S:\Internship', 4,2);

--INSERT ThemeMarks
INSERT INTO ThemeMarks(ThemeId, InternId, Mark)
VALUES	(1, 1, 9),
		(2, 1, 10),
		(1,2,7),
		(2,2,9),
		(3,2,10),
		(1,3,10);

--INSERT Exams
INSERT INTO Exams(ModuleId, DateOfExamen)
VALUES (1, '2019-03-09'),
		(2, '2019-03-30'),
		(3, '2019-04-29');

--INSERT ExamMarks
INSERT INTO ExamMarks(ExamenId, InternId, Mark)
VALUES (1, 1, 8.7),
		(2, 1, 8),
		(3, 1, 9),
		(1, 2, 7),
		(2, 3, 10);
GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
CREATE TABLE [#__checkStatus] (
    id           INT            IDENTITY (1, 1) PRIMARY KEY CLUSTERED,
    [Schema]     NVARCHAR (256),
    [Table]      NVARCHAR (256),
    [Constraint] NVARCHAR (256)
);

SET NOCOUNT ON;

DECLARE tableconstraintnames CURSOR LOCAL FORWARD_ONLY
    FOR SELECT SCHEMA_NAME([schema_id]),
               OBJECT_NAME([parent_object_id]),
               [name],
               0
        FROM   [sys].[objects]
        WHERE  [parent_object_id] IN (OBJECT_ID(N'dbo.Interns'), OBJECT_ID(N'dbo.Menthors'), OBJECT_ID(N'dbo.ThemeMarks'), OBJECT_ID(N'dbo.Themes'), OBJECT_ID(N'dbo.Users'))
               AND [type] IN (N'F', N'C')
                   AND [object_id] IN (SELECT [object_id]
                                       FROM   [sys].[check_constraints]
                                       WHERE  [is_not_trusted] <> 0
                                              AND [is_disabled] = 0
                                       UNION
                                       SELECT [object_id]
                                       FROM   [sys].[foreign_keys]
                                       WHERE  [is_not_trusted] <> 0
                                              AND [is_disabled] = 0);

DECLARE @schemaname AS NVARCHAR (256);

DECLARE @tablename AS NVARCHAR (256);

DECLARE @checkname AS NVARCHAR (256);

DECLARE @is_not_trusted AS INT;

DECLARE @statement AS NVARCHAR (1024);

BEGIN TRY
    OPEN tableconstraintnames;
    FETCH tableconstraintnames INTO @schemaname, @tablename, @checkname, @is_not_trusted;
    WHILE @@fetch_status = 0
        BEGIN
            PRINT N'Checking constraint: ' + @checkname + N' [' + @schemaname + N'].[' + @tablename + N']';
            SET @statement = N'ALTER TABLE [' + @schemaname + N'].[' + @tablename + N'] WITH ' + CASE @is_not_trusted WHEN 0 THEN N'CHECK' ELSE N'NOCHECK' END + N' CHECK CONSTRAINT [' + @checkname + N']';
            BEGIN TRY
                EXECUTE [sp_executesql] @statement;
            END TRY
            BEGIN CATCH
                INSERT  [#__checkStatus] ([Schema], [Table], [Constraint])
                VALUES                  (@schemaname, @tablename, @checkname);
            END CATCH
            FETCH tableconstraintnames INTO @schemaname, @tablename, @checkname, @is_not_trusted;
        END
END TRY
BEGIN CATCH
    PRINT ERROR_MESSAGE();
END CATCH

IF CURSOR_STATUS(N'LOCAL', N'tableconstraintnames') >= 0
    CLOSE tableconstraintnames;

IF CURSOR_STATUS(N'LOCAL', N'tableconstraintnames') = -1
    DEALLOCATE tableconstraintnames;

SELECT N'Constraint verification failed:' + [Schema] + N'.' + [Table] + N',' + [Constraint]
FROM   [#__checkStatus];

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occurred while verifying constraints', 16, 127);
    END

SET NOCOUNT OFF;

DROP TABLE [#__checkStatus];


GO
PRINT N'Update complete.';


GO
