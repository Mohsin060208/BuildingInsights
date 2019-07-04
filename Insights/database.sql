/*
Navicat SQL Server Data Transfer

Source Server         : SQLSERVER
Source Server Version : 110000
Source Host           : DESKTOP-S6AR8GG\SQLEXPRESS:1433
Source Database       : InsightsDB
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2019-07-04 16:46:08
*/


-- ----------------------------
-- Table structure for Building
-- ----------------------------
DROP TABLE [dbo].[Building]
GO
CREATE TABLE [dbo].[Building] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] varchar(255) NOT NULL ,
[isActive] bit NOT NULL ,
[CreatedOn] datetime NOT NULL ,
[UpdatedOn] datetime NOT NULL 
)


GO

-- ----------------------------
-- Records of Building
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Building] ON
GO
INSERT INTO [dbo].[Building] ([Id], [Name], [isActive], [CreatedOn], [UpdatedOn]) VALUES (N'1', N'Eruditech', N'1', N'2019-06-24 13:52:53.000', N'2019-06-24 13:52:55.000')
GO
GO
SET IDENTITY_INSERT [dbo].[Building] OFF
GO

-- ----------------------------
-- Table structure for Mechanics
-- ----------------------------
DROP TABLE [dbo].[Mechanics]
GO
CREATE TABLE [dbo].[Mechanics] (
[Id] int NOT NULL IDENTITY(1,1) ,
[BuildingId] int NOT NULL ,
[Type] varchar(255) NOT NULL ,
[Cost] bigint NULL ,
[Failure] bigint NULL ,
[Year] smallint NOT NULL ,
[IsActive] bit NOT NULL ,
[CreatedOn] datetime NOT NULL ,
[UpdatedOn] datetime NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Mechanics]', RESEED, 1018)
GO

-- ----------------------------
-- Records of Mechanics
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Mechanics] ON
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1002', N'1', N'Elevator', N'6500', N'65', N'2017', N'1', N'1900-01-01 00:00:00.000', N'2019-07-04 15:38:18.747')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1003', N'1', N'Elevator', N'4500', N'25', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:38:05.277')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1005', N'1', N'Elevator', N'5100', N'60', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:38:43.997')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1007', N'1', N'Plumbing', N'2000', null, N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:36:39.667')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1008', N'1', N'Plumbing', N'5000', null, N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1009', N'1', N'Plumbing', N'2000', null, N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:39:17.287')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1010', N'1', N'Operational Plumbing', N'17000000000', null, N'2017', N'1', N'2019-06-26 00:00:00.000', N'1900-01-01 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1011', N'1', N'Operational Plumbing', N'19500000000', null, N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:40:57.893')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1012', N'1', N'Operational Plumbing', N'5000000000', null, N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:40:06.490')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1013', N'1', N'Boiler', N'219', N'1900', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:10:58.787')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1014', N'1', N'Boiler', N'220', N'1900', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:42:53.353')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1015', N'1', N'Chiller', N'2018000', N'2019', N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:32:42.503')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1016', N'1', N'Chiller', N'2017000', N'2018', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:32:30.763')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1017', N'1', N'Chiller', N'2000000', N'2000', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:32:58.927')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1018', N'1', N'Boiler', N'221', N'150', N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:42:30.447')
GO
GO
SET IDENTITY_INSERT [dbo].[Mechanics] OFF
GO

-- ----------------------------
-- Table structure for YearlyRecordBook
-- ----------------------------
DROP TABLE [dbo].[YearlyRecordBook]
GO
CREATE TABLE [dbo].[YearlyRecordBook] (
[Id] int NOT NULL IDENTITY(1,1) ,
[BuildingId] int NOT NULL ,
[TotalCost] bigint NULL ,
[TotalSaving] bigint NULL ,
[Year] smallint NOT NULL ,
[IsActive] bit NOT NULL ,
[CreatedOn] datetime NOT NULL ,
[UpdatedOn] datetime NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[YearlyRecordBook]', RESEED, 14)
GO

-- ----------------------------
-- Records of YearlyRecordBook
-- ----------------------------
SET IDENTITY_INSERT [dbo].[YearlyRecordBook] ON
GO
INSERT INTO [dbo].[YearlyRecordBook] ([Id], [BuildingId], [TotalCost], [TotalSaving], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'10', N'1', N'1350', N'125', N'2017', N'1', N'2019-07-03 18:55:32.000', N'2019-07-04 14:45:13.467')
GO
GO
INSERT INTO [dbo].[YearlyRecordBook] ([Id], [BuildingId], [TotalCost], [TotalSaving], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'13', N'1', null, N'123', N'2018', N'1', N'2019-07-04 12:54:58.343', N'2019-07-04 14:43:55.110')
GO
GO
INSERT INTO [dbo].[YearlyRecordBook] ([Id], [BuildingId], [TotalCost], [TotalSaving], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'14', N'1', N'500', null, N'2019', N'1', N'2019-07-04 12:58:01.327', N'2019-07-04 14:42:45.020')
GO
GO
SET IDENTITY_INSERT [dbo].[YearlyRecordBook] OFF
GO

-- ----------------------------
-- Procedure structure for stp_CreateUpdateMechanicsCostByType
-- ----------------------------
DROP PROCEDURE [dbo].[stp_CreateUpdateMechanicsCostByType]
GO

CREATE PROCEDURE [dbo].[stp_CreateUpdateMechanicsCostByType]
	 @Year SMALLINT, @Type VARCHAR(255), @Cost bigint, @BuildingId INTEGER, @IsActive BIT, @CreatedOn DATE, @UpdatedOn DATE
AS
BEGIN

IF EXISTS (SELECT * FROM Mechanics WHERE Type = @Type AND BuildingId = @BuildingId AND [YEAR] = @Year)


        UPDATE Mechanics
        SET    Cost = @Cost,
							UpdatedOn = @UpdatedOn,
							IsActive = @IsActive
WHERE Type = @Type AND BuildingId = @BuildingId AND [YEAR] = @Year

      ELSE

        INSERT INTO Mechanics ( BuildingId, Type, Cost, [Year], IsActive, CreatedOn, UpdatedOn)
        VALUES      (@BuildingId, @Type, @Cost, @Year, @IsActive, @CreatedOn, @UpdatedOn)
END


GO

-- ----------------------------
-- Procedure structure for stp_CreateUpdateMechanicsFailureByType
-- ----------------------------
DROP PROCEDURE [dbo].[stp_CreateUpdateMechanicsFailureByType]
GO

CREATE PROCEDURE [dbo].[stp_CreateUpdateMechanicsFailureByType]
	 @Year SMALLINT, @Type VARCHAR(255), @Failure bigint, @BuildingId INTEGER, @IsActive BIT, @CreatedOn DATE, @UpdatedOn DATE
AS
BEGIN

IF EXISTS (SELECT * FROM Mechanics WHERE Type = @Type AND BuildingId = @BuildingId AND [YEAR] = @Year)


        UPDATE Mechanics
        SET    Failure = @Failure,
							UpdatedOn = @UpdatedOn,
							IsActive = @IsActive
WHERE Type = @Type AND BuildingId = @BuildingId AND [YEAR] = @Year

      ELSE

        INSERT INTO Mechanics ( BuildingId, Type, Failure, [Year], IsActive, CreatedOn, UpdatedOn)
        VALUES      (@BuildingId, @Type, @Failure, @Year, @IsActive, @CreatedOn, @UpdatedOn)
END


GO

-- ----------------------------
-- Procedure structure for stp_GetAllMechanics
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetAllMechanics]
GO
CREATE PROCEDURE [dbo].[stp_GetAllMechanics]
@BuildingId INT
AS
BEGIN
SELECT Type,ISNULL(Cost, 0) Cost, ISNULL(Failure, 0) Failure,[Year],BuildingId,IsActive,CreatedOn,UpdatedOn FROM Mechanics WHERE BuildingId = @BuildingId ORDER BY [YEAR]
END

GO

-- ----------------------------
-- Procedure structure for stp_GetMechanicsCostByType
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetMechanicsCostByType]
GO

CREATE PROCEDURE [dbo].[stp_GetMechanicsCostByType]
	@Type varchar(255), @BuildingId int
AS
BEGIN
	SELECT Type, Cost, [Year] FROM Mechanics WHERE Type = @Type AND BuildingId = @BuildingId ORDER BY [YEAR] ASC
END


GO

-- ----------------------------
-- Procedure structure for stp_GetMechanicsFailureByType
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetMechanicsFailureByType]
GO

CREATE PROCEDURE [dbo].[stp_GetMechanicsFailureByType]
	@Type varchar(255), @BuildingId INT
AS
BEGIN
	SELECT Type, ISNULL(Failure, 0)Failure, [Year] FROM Mechanics WHERE Type = @Type AND BuildingId = @BuildingId ORDER BY [Year] ASC
END


GO

-- ----------------------------
-- Procedure structure for stp_GetRecordsByYear
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetRecordsByYear]
GO
CREATE PROCEDURE [dbo].[stp_GetRecordsByYear]
	@Year SMALLINT,@BuildingId INTEGER
AS
BEGIN
SELECT ISNULL(TotalCost, 0) TotalCost, ISNULL(TotalSaving,0) TotalSaving, BuildingId, [Year], IsActive, CreatedOn, UpdatedOn FROM YearlyRecordBook WHERE [Year] = @Year AND BuildingId = @BuildingId
END

GO

-- ----------------------------
-- Procedure structure for stp_GetTotalCost
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetTotalCost]
GO

CREATE PROCEDURE [dbo].[stp_GetTotalCost]
	@Year SMALLINT,@BuildingId INT
AS
BEGIN
SELECT ISNULL(TotalCost, 0) TotalCost, BuildingId, Year FROM YearlyRecordBook WHERE [Year] = @Year AND BuildingId = @BuildingId
END


GO

-- ----------------------------
-- Procedure structure for stp_GetTotalSaving
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetTotalSaving]
GO

CREATE PROCEDURE [dbo].[stp_GetTotalSaving]
	@Year SMALLINT,@BuildingId INT
AS
BEGIN
SELECT ISNULL(TotalSaving, 0) TotalSaving, BuildingId, Year FROM YearlyRecordBook WHERE [Year] = @Year AND BuildingId = @BuildingId
END


GO

-- ----------------------------
-- Procedure structure for stp_SaveTotalCost
-- ----------------------------
DROP PROCEDURE [dbo].[stp_SaveTotalCost]
GO

CREATE PROCEDURE [dbo].[stp_SaveTotalCost]
	@Year SMALLINT, @TotalCost bigint, @BuildingId INTEGER, @IsActive BIT, @CreatedOn DATE, @UpdatedOn DATE
AS
BEGIN
IF EXISTS (SELECT * FROM YearlyRecordBook WHERE BuildingId = @BuildingId AND [YEAR] = @Year)

        UPDATE YearlyRecordBook
        SET   TotalCost = @TotalCost,
							UpdatedOn = @UpdatedOn,
							IsActive = @IsActive


WHERE BuildingId = @BuildingId AND [YEAR] = @Year

ELSE
INSERT INTO YearlyRecordBook (YEAR, TotalCost, BuildingId, IsActive, CreatedOn, UpdatedOn) VALUES (@Year, @TotalCost, @BuildingId, @IsActive, @CreatedOn, @UpdatedOn)
END


GO

-- ----------------------------
-- Procedure structure for stp_SaveTotalSaving
-- ----------------------------
DROP PROCEDURE [dbo].[stp_SaveTotalSaving]
GO

CREATE PROCEDURE [dbo].[stp_SaveTotalSaving]
	@Year SMALLINT, @TotalSaving bigint, @BuildingId INTEGER, @IsActive BIT, @CreatedOn DATE, @UpdatedOn DATE
AS
BEGIN
IF EXISTS (SELECT * FROM YearlyRecordBook WHERE BuildingId = @BuildingId AND [YEAR] = @Year)

        UPDATE YearlyRecordBook
        SET    TotalSaving = @TotalSaving,
UpdatedOn = @UpdatedOn,
							IsActive = @IsActive

WHERE BuildingId = @BuildingId AND [YEAR] = @Year

ELSE
INSERT INTO YearlyRecordBook (YEAR, TotalSaving, BuildingId, IsActive, CreatedOn, UpdatedOn) VALUES (@Year, @TotalSaving, @BuildingId, @IsActive, @CreatedOn, @UpdatedOn)
END


GO

-- ----------------------------
-- Indexes structure for table Building
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Building
-- ----------------------------
ALTER TABLE [dbo].[Building] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Mechanics
-- ----------------------------
CREATE INDEX [IX_Building_Mechanics] ON [dbo].[Mechanics]
([BuildingId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table Mechanics
-- ----------------------------
ALTER TABLE [dbo].[Mechanics] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table YearlyRecordBook
-- ----------------------------
CREATE INDEX [IX_YRB_Building] ON [dbo].[YearlyRecordBook]
([BuildingId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table YearlyRecordBook
-- ----------------------------
ALTER TABLE [dbo].[YearlyRecordBook] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Mechanics]
-- ----------------------------
ALTER TABLE [dbo].[Mechanics] ADD FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[YearlyRecordBook]
-- ----------------------------
ALTER TABLE [dbo].[YearlyRecordBook] ADD FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
