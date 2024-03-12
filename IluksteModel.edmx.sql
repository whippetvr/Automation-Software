
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2021 14:34:41
-- Generated from EDMX file: c:\Work\Temp\Lrt\Lrt_Ilukste\IluksteModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ilukste];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Events_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Events_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_OperData_OperReg]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperationData] DROP CONSTRAINT [FK_OperData_OperReg];
GO
IF OBJECT_ID(N'[dbo].[FK_OperData_OperState]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperationData] DROP CONSTRAINT [FK_OperData_OperState];
GO
IF OBJECT_ID(N'[dbo].[FK_OperReg_OperName]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperationRegister] DROP CONSTRAINT [FK_OperReg_OperName];
GO
IF OBJECT_ID(N'[dbo].[FK_OperReg_Persons]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperationRegister] DROP CONSTRAINT [FK_OperReg_Persons];
GO
IF OBJECT_ID(N'[dbo].[FK_OperReg_Persons1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OperationRegister] DROP CONSTRAINT [FK_OperReg_Persons1];
GO
IF OBJECT_ID(N'[dbo].[FK_Persons_Partners]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persons] DROP CONSTRAINT [FK_Persons_Partners];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CoefDensity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoefDensity];
GO
IF OBJECT_ID(N'[dbo].[CoefTank]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoefTank];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[OperationData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperationData];
GO
IF OBJECT_ID(N'[dbo].[OperationName]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperationName];
GO
IF OBJECT_ID(N'[dbo].[OperationRegister]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperationRegister];
GO
IF OBJECT_ID(N'[dbo].[OperationState]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperationState];
GO
IF OBJECT_ID(N'[dbo].[Partners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Partners];
GO
IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO
IF OBJECT_ID(N'[dbo].[SaabCalculations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SaabCalculations];
GO
IF OBJECT_ID(N'[dbo].[SaabData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SaabData];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Tanks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tanks];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[ZoneTank]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZoneTank];
GO
IF OBJECT_ID(N'[dbo].[Params]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Params];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CoefDensity'
CREATE TABLE [dbo].[CoefDensity] (
    [CoefDensityID] int IDENTITY(1,1) NOT NULL,
    [p_min] real  NULL,
    [p_max] real  NULL,
    [b] float  NULL
);
GO

-- Creating table 'CoefTank'
CREATE TABLE [dbo].[CoefTank] (
    [CoefTankID] int IDENTITY(1,1) NOT NULL,
    [TankID] smallint  NULL,
    [Zone] smallint  NULL,
    [H_Level] float  NULL,
    [V_Base] float  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [EventID] int IDENTITY(1,1) NOT NULL,
    [DataTime] datetime  NULL,
    [UserID] int  NULL,
    [Message] nvarchar(250)  NULL
);
GO

-- Creating table 'OperationData'
CREATE TABLE [dbo].[OperationData] (
    [OperDataID] int IDENTITY(1,1) NOT NULL,
    [RegID] int  NULL,
    [StateID] smallint  NULL,
    [DataTime] datetime  NULL,
    [TankLevel] real  NULL,
    [TankAvgTemp] real  NULL,
    [TankDensity] real  NULL,
    [TankTgrad] real  NULL,
    [AirTemp] real  NULL,
    [CalcVolume] real  NULL,
    [CalcDensity20] real  NULL,
    [CalcVolume20] real  NULL,
    [CalcMassa] real  NULL,
    [LabDensity] real  NULL,
    [LabVolume] real  NULL,
    [LabDensity20] real  NULL,
    [LabVolume20] real  NULL,
    [LabMassa] real  NULL,
    [MeasureType] tinyint  NULL
);
GO

-- Creating table 'OperationName'
CREATE TABLE [dbo].[OperationName] (
    [OperID] int IDENTITY(1,1) NOT NULL,
    [OperName] nvarchar(50)  NULL
);
GO

-- Creating table 'OperationRegister'
CREATE TABLE [dbo].[OperationRegister] (
    [RegID] int IDENTITY(1,1) NOT NULL,
    [StartDataTime] datetime  NULL,
    [EndDataTime] datetime  NULL,
    [OperID] int  NULL,
    [ProvID] int  NULL,
    [TankID] int  NULL,
    [CustID] int  NULL,
    [ActN] int  NULL,
    [CreateDataTime] datetime  NULL,
    [FullReport] bit  NULL,
    [TanksTankID] int  NOT NULL
);
GO

-- Creating table 'OperationState'
CREATE TABLE [dbo].[OperationState] (
    [StateID] smallint  NOT NULL,
    [StateName] nvarchar(50)  NULL
);
GO

-- Creating table 'Partners'
CREATE TABLE [dbo].[Partners] (
    [PartID] int IDENTITY(1,1) NOT NULL,
    [PartName] nvarchar(50)  NULL
);
GO

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [PersID] int IDENTITY(1,1) NOT NULL,
    [PersSurn] nvarchar(30)  NULL,
    [PersName] nvarchar(30)  NULL,
    [PartID] int  NULL
);
GO

-- Creating table 'SaabCalculations'
CREATE TABLE [dbo].[SaabCalculations] (
    [SaabCalcID] int IDENTITY(1,1) NOT NULL,
    [SaabID] int  NULL,
    [AirTemp] real  NULL,
    [CalcVolume] real  NULL,
    [CalcDensity20] real  NULL,
    [CalcVolume20] real  NULL,
    [CalcMassa] real  NULL
);
GO

-- Creating table 'SaabData'
CREATE TABLE [dbo].[SaabData] (
    [SaabID] int  NOT NULL,
    [DataTime] datetime  NULL,
    [TankID] int  NULL,
    [TankLevel] real  NULL,
    [TankAvgTemp] real  NULL,
    [TankDensity] real  NULL,
    [TankTgrad] real  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Tanks'
CREATE TABLE [dbo].[Tanks] (
    [TankID] int  NOT NULL,
    [TankName] nvarchar(50)  NULL,
    [TankTgrad] real  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [UserPWD] nvarchar(50)  NULL,
    [AccessLevel] smallint  NULL
);
GO

-- Creating table 'ZoneTank'
CREATE TABLE [dbo].[ZoneTank] (
    [ZoneTankID] int IDENTITY(1,1) NOT NULL,
    [TankID] tinyint  NULL,
    [Zone] tinyint  NULL,
    [HA_Level] smallint  NULL,
    [VA_Base] float  NULL
);
GO

-- Creating table 'Params'
CREATE TABLE [dbo].[Params] (
    [ParamID] int IDENTITY(1,1) NOT NULL,
    [AirTemp] real  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CoefDensityID] in table 'CoefDensity'
ALTER TABLE [dbo].[CoefDensity]
ADD CONSTRAINT [PK_CoefDensity]
    PRIMARY KEY CLUSTERED ([CoefDensityID] ASC);
GO

-- Creating primary key on [CoefTankID] in table 'CoefTank'
ALTER TABLE [dbo].[CoefTank]
ADD CONSTRAINT [PK_CoefTank]
    PRIMARY KEY CLUSTERED ([CoefTankID] ASC);
GO

-- Creating primary key on [EventID] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([EventID] ASC);
GO

-- Creating primary key on [OperDataID] in table 'OperationData'
ALTER TABLE [dbo].[OperationData]
ADD CONSTRAINT [PK_OperationData]
    PRIMARY KEY CLUSTERED ([OperDataID] ASC);
GO

-- Creating primary key on [OperID] in table 'OperationName'
ALTER TABLE [dbo].[OperationName]
ADD CONSTRAINT [PK_OperationName]
    PRIMARY KEY CLUSTERED ([OperID] ASC);
GO

-- Creating primary key on [RegID] in table 'OperationRegister'
ALTER TABLE [dbo].[OperationRegister]
ADD CONSTRAINT [PK_OperationRegister]
    PRIMARY KEY CLUSTERED ([RegID] ASC);
GO

-- Creating primary key on [StateID] in table 'OperationState'
ALTER TABLE [dbo].[OperationState]
ADD CONSTRAINT [PK_OperationState]
    PRIMARY KEY CLUSTERED ([StateID] ASC);
GO

-- Creating primary key on [PartID] in table 'Partners'
ALTER TABLE [dbo].[Partners]
ADD CONSTRAINT [PK_Partners]
    PRIMARY KEY CLUSTERED ([PartID] ASC);
GO

-- Creating primary key on [PersID] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([PersID] ASC);
GO

-- Creating primary key on [SaabCalcID] in table 'SaabCalculations'
ALTER TABLE [dbo].[SaabCalculations]
ADD CONSTRAINT [PK_SaabCalculations]
    PRIMARY KEY CLUSTERED ([SaabCalcID] ASC);
GO

-- Creating primary key on [SaabID] in table 'SaabData'
ALTER TABLE [dbo].[SaabData]
ADD CONSTRAINT [PK_SaabData]
    PRIMARY KEY CLUSTERED ([SaabID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [TankID] in table 'Tanks'
ALTER TABLE [dbo].[Tanks]
ADD CONSTRAINT [PK_Tanks]
    PRIMARY KEY CLUSTERED ([TankID] ASC);
GO

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [ZoneTankID] in table 'ZoneTank'
ALTER TABLE [dbo].[ZoneTank]
ADD CONSTRAINT [PK_ZoneTank]
    PRIMARY KEY CLUSTERED ([ZoneTankID] ASC);
GO

-- Creating primary key on [ParamID] in table 'Params'
ALTER TABLE [dbo].[Params]
ADD CONSTRAINT [PK_Params]
    PRIMARY KEY CLUSTERED ([ParamID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserID] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Events_Users]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Events_Users'
CREATE INDEX [IX_FK_Events_Users]
ON [dbo].[Events]
    ([UserID]);
GO

-- Creating foreign key on [StateID] in table 'OperationData'
ALTER TABLE [dbo].[OperationData]
ADD CONSTRAINT [FK_OperData_OperState]
    FOREIGN KEY ([StateID])
    REFERENCES [dbo].[OperationState]
        ([StateID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperData_OperState'
CREATE INDEX [IX_FK_OperData_OperState]
ON [dbo].[OperationData]
    ([StateID]);
GO

-- Creating foreign key on [OperID] in table 'OperationRegister'
ALTER TABLE [dbo].[OperationRegister]
ADD CONSTRAINT [FK_OperReg_OperName]
    FOREIGN KEY ([OperID])
    REFERENCES [dbo].[OperationName]
        ([OperID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperReg_OperName'
CREATE INDEX [IX_FK_OperReg_OperName]
ON [dbo].[OperationRegister]
    ([OperID]);
GO

-- Creating foreign key on [CustID] in table 'OperationRegister'
ALTER TABLE [dbo].[OperationRegister]
ADD CONSTRAINT [FK_OperReg_Persons]
    FOREIGN KEY ([CustID])
    REFERENCES [dbo].[Persons]
        ([PersID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperReg_Persons'
CREATE INDEX [IX_FK_OperReg_Persons]
ON [dbo].[OperationRegister]
    ([CustID]);
GO

-- Creating foreign key on [ProvID] in table 'OperationRegister'
ALTER TABLE [dbo].[OperationRegister]
ADD CONSTRAINT [FK_OperReg_Persons1]
    FOREIGN KEY ([ProvID])
    REFERENCES [dbo].[Persons]
        ([PersID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperReg_Persons1'
CREATE INDEX [IX_FK_OperReg_Persons1]
ON [dbo].[OperationRegister]
    ([ProvID]);
GO

-- Creating foreign key on [PartID] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [FK_Persons_Partners]
    FOREIGN KEY ([PartID])
    REFERENCES [dbo].[Partners]
        ([PartID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Persons_Partners'
CREATE INDEX [IX_FK_Persons_Partners]
ON [dbo].[Persons]
    ([PartID]);
GO

-- Creating foreign key on [RegID] in table 'OperationData'
ALTER TABLE [dbo].[OperationData]
ADD CONSTRAINT [FK_OperationRegisterOperationData]
    FOREIGN KEY ([RegID])
    REFERENCES [dbo].[OperationRegister]
        ([RegID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperationRegisterOperationData'
CREATE INDEX [IX_FK_OperationRegisterOperationData]
ON [dbo].[OperationData]
    ([RegID]);
GO

-- Creating foreign key on [TanksTankID] in table 'OperationRegister'
ALTER TABLE [dbo].[OperationRegister]
ADD CONSTRAINT [FK_TanksOperationRegister]
    FOREIGN KEY ([TanksTankID])
    REFERENCES [dbo].[Tanks]
        ([TankID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TanksOperationRegister'
CREATE INDEX [IX_FK_TanksOperationRegister]
ON [dbo].[OperationRegister]
    ([TanksTankID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------