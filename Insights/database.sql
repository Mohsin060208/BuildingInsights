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

Date: 2019-06-28 14:36:15
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
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1002', N'1', N'Elevator', N'6100', N'65', N'2017', N'1', N'1900-01-01 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1003', N'1', N'Elevator', N'5300', N'5', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1005', N'1', N'Elevator', N'5600', N'60', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1007', N'1', N'Plumbing', N'2000', null, N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1008', N'1', N'Plumbing', N'5000', null, N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1009', N'1', N'Plumbing', N'2000', null, N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1010', N'1', N'Operational Plumbing', N'17000000000', null, N'2017', N'1', N'2019-06-26 00:00:00.000', N'1900-01-01 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1011', N'1', N'Operational Plumbing', N'19000000000', null, N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1012', N'1', N'Operational Plumbing', N'5000000000', null, N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1013', N'1', N'Boiler', N'3550', N'3999', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1014', N'1', N'Boiler', N'3500', N'3998', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1015', N'1', N'Chiller', N'6700', N'4800', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-27 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1016', N'1', N'Chiller', N'6000', N'4900', N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-06-27 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1017', N'1', N'Chiller', N'7000', N'5000', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-06-27 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1018', N'1', N'Boiler', N'3500', N'4000', N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-06-27 00:00:00.000')
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
DBCC CHECKIDENT(N'[dbo].[YearlyRecordBook]', RESEED, 9)
GO

-- ----------------------------
-- Records of YearlyRecordBook
-- ----------------------------
SET IDENTITY_INSERT [dbo].[YearlyRecordBook] ON
GO
INSERT INTO [dbo].[YearlyRecordBook] ([Id], [BuildingId], [TotalCost], [TotalSaving], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1', N'1', N'1280', N'123', N'2018', N'1', N'2019-06-27 11:52:57.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[YearlyRecordBook] ([Id], [BuildingId], [TotalCost], [TotalSaving], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'2', N'1', N'1500', N'350', N'2017', N'1', N'2019-06-27 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[YearlyRecordBook] ([Id], [BuildingId], [TotalCost], [TotalSaving], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'9', N'1', N'2000', N'350', N'2019', N'1', N'2019-06-27 00:00:00.000', N'2019-06-28 00:00:00.000')
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
-- Procedure structure for stp_GetMechanicsCostByType
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetMechanicsCostByType]
GO
CREATE PROCEDURE [dbo].[stp_GetMechanicsCostByType]
	@Type varchar(255)
AS
BEGIN
	SELECT Cost, [Year] FROM Mechanics WHERE Type = @Type ORDER BY [YEAR] ASC
END

GO

-- ----------------------------
-- Procedure structure for stp_GetMechanicsFailureByType
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetMechanicsFailureByType]
GO
CREATE PROCEDURE [dbo].[stp_GetMechanicsFailureByType]
	@Type varchar(255)
AS
BEGIN
	SELECT Failure, [Year] FROM Mechanics WHERE Type = @Type ORDER BY [Year] ASC
END

GO

-- ----------------------------
-- Procedure structure for stp_GetTotalCost
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetTotalCost]
GO
CREATE PROCEDURE [dbo].[stp_GetTotalCost]
	@Year SMALLINT,@BuildingId INTEGER
AS
BEGIN
SELECT ISNULL(TotalCost, 0) TotalCost FROM YearlyRecordBook WHERE [Year] = @Year AND BuildingId = @BuildingId
END

GO

-- ----------------------------
-- Procedure structure for stp_GetTotalSaving
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetTotalSaving]
GO
CREATE PROCEDURE [dbo].[stp_GetTotalSaving]
	@Year SMALLINT,@BuildingId INTEGER
AS
BEGIN
SELECT ISNULL(TotalSaving, 0) TotalSaving FROM YearlyRecordBook WHERE [Year] = @Year AND BuildingId = @BuildingId
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
