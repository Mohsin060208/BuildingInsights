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

Date: 2019-07-14 12:59:53
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
[Type] int NOT NULL ,
[Cost] bigint NULL ,
[Failure] bigint NULL ,
[Year] smallint NOT NULL ,
[IsActive] bit NOT NULL ,
[CreatedOn] datetime NOT NULL ,
[UpdatedOn] datetime NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Mechanics]', RESEED, 2025)
GO

-- ----------------------------
-- Records of Mechanics
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Mechanics] ON
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1002', N'1', N'0', N'5000', N'65', N'2017', N'1', N'1900-01-01 00:00:00.000', N'2019-07-12 15:11:01.083')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1003', N'1', N'0', N'4000', N'25', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-14 12:45:35.780')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1005', N'1', N'0', N'5100', N'70', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-10 18:25:40.527')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1007', N'1', N'3', N'2000', null, N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:36:39.667')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1008', N'1', N'3', N'5000', null, N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-06-28 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1009', N'1', N'3', N'2000', null, N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:39:17.287')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1010', N'1', N'4', N'17000000000', null, N'2017', N'1', N'2019-06-26 00:00:00.000', N'1900-01-01 00:00:00.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1011', N'1', N'4', N'15000000000', null, N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-10 17:35:41.200')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1012', N'1', N'4', N'5000000000', null, N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-10 17:36:05.267')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1013', N'1', N'1', N'219', N'1900', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:10:58.787')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1014', N'1', N'1', N'220', N'1900', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 15:42:53.353')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1015', N'1', N'2', N'2018000', N'2019', N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-07-04 16:32:42.503')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1016', N'1', N'2', N'2017000', N'2018', N'2018', N'1', N'2019-06-26 00:00:00.000', N'2019-07-14 11:54:42.513')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1017', N'1', N'2', N'2000000', N'2017', N'2019', N'1', N'2019-06-26 00:00:00.000', N'2019-07-14 11:54:51.663')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1018', N'1', N'1', N'221', N'200', N'2017', N'1', N'2019-06-26 00:00:00.000', N'2019-07-14 11:43:03.157')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1019', N'1', N'5', N'1350', null, N'2018', N'1', N'2019-07-12 15:52:07.000', N'2019-07-12 15:52:10.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1024', N'1', N'6', N'123', null, N'2018', N'1', N'2019-07-12 15:59:08.000', N'2019-07-12 15:59:10.000')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1026', N'1', N'5', N'450', null, N'2017', N'1', N'2019-07-12 18:39:16.553', N'2019-07-12 18:51:49.597')
GO
GO
INSERT INTO [dbo].[Mechanics] ([Id], [BuildingId], [Type], [Cost], [Failure], [Year], [IsActive], [CreatedOn], [UpdatedOn]) VALUES (N'1027', N'1', N'6', N'4500', null, N'2019', N'1', N'2019-07-12 18:52:13.427', N'2019-07-12 18:52:13.427')
GO
GO
SET IDENTITY_INSERT [dbo].[Mechanics] OFF
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
-- Procedure structure for stp_GetTotalCost
-- ----------------------------
DROP PROCEDURE [dbo].[stp_GetTotalCost]
GO

CREATE PROCEDURE [dbo].[stp_GetTotalCost]
	@Year SMALLINT,@BuildingId INT
AS
BEGIN
SELECT Type, ISNULL(Cost, 0) Cost, Year FROM Mechanics WHERE [Year] = @Year AND BuildingId = @BuildingId AND Type = 5
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
SELECT Type, ISNULL(Cost, 0) Cost, Year FROM Mechanics WHERE [Year] = @Year AND BuildingId = @BuildingId AND Type = 6
END


GO

-- ----------------------------
-- Procedure structure for stp_SaveTotalCost
-- ----------------------------
DROP PROCEDURE [dbo].[stp_SaveTotalCost]
GO

CREATE PROCEDURE [dbo].[stp_SaveTotalCost]
	@Year SMALLINT, @Cost bigint, @BuildingId INTEGER, @IsActive BIT, @CreatedOn DATE, @UpdatedOn DATE
AS
BEGIN
IF EXISTS (SELECT * FROM Mechanics WHERE BuildingId = @BuildingId AND [YEAR] = @Year AND Type = 5)

        UPDATE YearlyRecordBook
        SET   Cost = @Cost,
							UpdatedOn = @UpdatedOn,
							IsActive = @IsActive


WHERE BuildingId = @BuildingId AND [YEAR] = @Year

ELSE
INSERT INTO Mechanics (YEAR, Cost, BuildingId, IsActive, CreatedOn, UpdatedOn) VALUES (@Year, @Cost, @BuildingId, @IsActive, @CreatedOn, @UpdatedOn)
END


GO

-- ----------------------------
-- Procedure structure for stp_SaveTotalSaving
-- ----------------------------
DROP PROCEDURE [dbo].[stp_SaveTotalSaving]
GO

CREATE PROCEDURE [dbo].[stp_SaveTotalSaving]
	@Year SMALLINT, @Cost bigint, @BuildingId INTEGER, @IsActive BIT, @CreatedOn DATE, @UpdatedOn DATE
AS
BEGIN
IF EXISTS (SELECT * FROM Mechanics WHERE BuildingId = @BuildingId AND [YEAR] = @Year AND Type = 6)

        UPDATE YearlyRecordBook
        SET   Cost = @Cost,
							UpdatedOn = @UpdatedOn,
							IsActive = @IsActive


WHERE BuildingId = @BuildingId AND [YEAR] = @Year

ELSE
INSERT INTO Mechanics (YEAR, Cost, BuildingId, IsActive, CreatedOn, UpdatedOn) VALUES (@Year, @Cost, @BuildingId, @IsActive, @CreatedOn, @UpdatedOn)
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
-- Foreign Key structure for table [dbo].[Mechanics]
-- ----------------------------
ALTER TABLE [dbo].[Mechanics] ADD FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
GO
