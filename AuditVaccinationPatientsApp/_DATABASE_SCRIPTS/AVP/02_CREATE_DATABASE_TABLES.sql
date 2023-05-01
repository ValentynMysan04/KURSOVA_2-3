
/****** Object: Table [dbo].[Doctors]   Script Date: 4/30/2023 3:05:22 PM ******/
USE [AVP];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Doctors]') AND type in (N'U'))
BEGIN
DROP TABLE [dbo].[Doctors];
END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Doctors]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Doctors] (
[DoctorID] int IDENTITY(1, 1) NOT NULL,
[LastName] nvarchar(20) NOT NULL,
[FirstName] nvarchar(20) NOT NULL,
[MiddleName] nvarchar(20) NOT NULL,
[PhoneNumber] nvarchar(20) NULL,
[Address] nvarchar(200) NULL,
CONSTRAINT [PK_Doctors]
PRIMARY KEY CLUSTERED ([DoctorID] ASC)
WITH ( PAD_INDEX = OFF,
FILLFACTOR = 100,
IGNORE_DUP_KEY = OFF,
STATISTICS_NORECOMPUTE = OFF,
ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON,
DATA_COMPRESSION = NONE )
 ON [PRIMARY]
)
ON [PRIMARY];
END;
GO
ALTER TABLE [dbo].[Doctors] SET (LOCK_ESCALATION = TABLE);
GO

/****** Object: Table [dbo].[Patients]   Script Date: 4/30/2023 3:04:41 PM ******/
USE [AVP];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patients]') AND type in (N'U'))
BEGIN
DROP TABLE [dbo].[Patients];
END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patients]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Patients] (
[PatientID] int IDENTITY(1, 1) NOT NULL,
[LastName] nvarchar(20) NOT NULL,
[FirstName] nvarchar(20) NOT NULL,
[MiddleName] nvarchar(20) NOT NULL,
[Gender] nvarchar(1) NOT NULL,
[DateOfBirth] date NOT NULL,
[SSN] nvarchar(10) NOT NULL,
[PhoneNumber] nvarchar(20) NULL,
[Address] nvarchar(200) NULL,
CONSTRAINT [PK_Patients]
PRIMARY KEY CLUSTERED ([PatientID] ASC)
WITH ( PAD_INDEX = OFF,
FILLFACTOR = 100,
IGNORE_DUP_KEY = OFF,
STATISTICS_NORECOMPUTE = OFF,
ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON,
DATA_COMPRESSION = NONE )
 ON [PRIMARY]
)
ON [PRIMARY];
END;
GO
ALTER TABLE [dbo].[Patients] SET (LOCK_ESCALATION = TABLE);
GO

/****** Object: Table [dbo].[PatientVactinations]   Script Date: 4/30/2023 3:05:35 PM ******/
USE [AVP];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientVactinations]') AND type in (N'U'))
BEGIN
DROP TABLE [dbo].[PatientVactinations];
END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientVactinations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PatientVactinations] (
[PatientVactinationsID] int IDENTITY(1, 1) NOT NULL,
[PatientID] int NOT NULL,
[VaccineID] int NOT NULL,
[DateOfVaccination] date NOT NULL,
[DoctorID] int NULL,
[NurseID] int NULL,
CONSTRAINT [PK_PatientVactinations]
PRIMARY KEY CLUSTERED ([PatientVactinationsID] ASC)
WITH ( PAD_INDEX = OFF,
FILLFACTOR = 100,
IGNORE_DUP_KEY = OFF,
STATISTICS_NORECOMPUTE = OFF,
ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON,
DATA_COMPRESSION = NONE )
 ON [PRIMARY]
)
ON [PRIMARY];
END;
GO
ALTER TABLE [dbo].[PatientVactinations] SET (LOCK_ESCALATION = TABLE);
GO

/****** Object: Table [dbo].[Vaccines]   Script Date: 4/30/2023 3:06:28 PM ******/
USE [AVP];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vaccines]') AND type in (N'U'))
BEGIN
DROP TABLE [dbo].[Vaccines];
END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vaccines]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Vaccines] (
[VaccineID] int IDENTITY(1, 1) NOT NULL,
[Mandatory] int NOT NULL,
[AgeInDays] int NOT NULL,
[Age] nvarchar(13) NOT NULL,
[VaccineName] nvarchar(84) NOT NULL)
ON [PRIMARY]
WITH (DATA_COMPRESSION = NONE);
END;
GO
ALTER TABLE [dbo].[Vaccines] SET (LOCK_ESCALATION = TABLE);
GO

