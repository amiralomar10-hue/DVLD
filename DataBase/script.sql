USE [DVLD]
GO
/****** Object:  Table [dbo].[Applications]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Applications](
  [ApplicationID] [int] IDENTITY(1,1) NOT NULL,
  [ApplicantPersonID] [int] NOT NULL,
  [ApplicationDate] [datetime] NOT NULL,
  [ApplicationTypeID] [int] NOT NULL,
  [ApplicationStatus] [tinyint] NOT NULL,
  [LastStatusDate] [datetime] NOT NULL,
  [PaidFees] [smallmoney] NOT NULL,
  [CreatedByUserID] [int] NOT NULL,
 CONSTRAINT [PK_Applications] PRIMARY KEY CLUSTERED 
(
  [ApplicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationTypes]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationTypes](
  [ApplicationTypeID] [int] IDENTITY(1,1) NOT NULL,
  [ApplicationTypeTitle] [nvarchar](150) NOT NULL,
  [ApplicationFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_ApplicationTypes] PRIMARY KEY CLUSTERED 
(
  [ApplicationTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
  [CountryID] [int] IDENTITY(1,1) NOT NULL,
  [CountryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Countrie__10D160BFDBD6933F] PRIMARY KEY CLUSTERED 
(
  [CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetainedLicenses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetainedLicenses](
  [DetainID] [int] IDENTITY(1,1) NOT NULL,
  [LicenseID] [int] NOT NULL,
  [DetainDate] [smalldatetime] NOT NULL,
  [FineFees] [smallmoney] NOT NULL,
  [CreatedByUserID] [int] NOT NULL,
  [IsReleased] [bit] NOT NULL,
  [ReleaseDate] [smalldatetime] NULL,
  [ReleasedByUserID] [int] NULL,
  [ReleaseApplicationID] [int] NULL,
 CONSTRAINT [PK_DetainedLicenses] PRIMARY KEY CLUSTERED 
(
  [DetainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
  [DriverID] [int] IDENTITY(1,1) NOT NULL,
  [PersonID] [int] NOT NULL,
  [CreatedByUserID] [int] NOT NULL,
  [CreatedDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Drivers_1] PRIMARY KEY CLUSTERED 
(
  [DriverID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[InternationalLicenses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InternationalLicenses](
  [InternationalLicenseID] [int] IDENTITY(1,1) NOT NULL,
  [ApplicationID] [int] NOT NULL,
  [DriverID] [int] NOT NULL,
  [IssuedUsingLocalLicenseID] [int] NOT NULL,
  [IssueDate] [smalldatetime] NOT NULL,
  [ExpirationDate] [smalldatetime] NOT NULL,
  [IsActive] [bit] NOT NULL,
  [CreatedByUserID] [int] NOT NULL,
 CONSTRAINT [PK_InternationalLicenses] PRIMARY KEY CLUSTERED 
(
  [InternationalLicenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LicenseClasses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LicenseClasses](
  [LicenseClassID] [int] IDENTITY(1,1) NOT NULL,
  [ClassName] [nvarchar](50) NOT NULL,
  [ClassDescription] [nvarchar](500) NOT NULL,
  [MinimumAllowedAge] [tinyint] NOT NULL,
  [DefaultValidityLength] [tinyint] NOT NULL,
  [ClassFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_LicenseClasses] PRIMARY KEY CLUSTERED 
(
  [LicenseClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Licenses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Licenses](
  [LicenseID] [int] IDENTITY(1,1) NOT NULL,
  [ApplicationID] [int] NOT NULL,
  [DriverID] [int] NOT NULL,
  [LicenseClassID] [int] NOT NULL,
  [IssueDate] [datetime] NOT NULL,
  [ExpirationDate] [datetime] NOT NULL,
  [Notes] [nvarchar](500) NULL,
  [PaidFees] [smallmoney] NOT NULL,
  [IsActive] [bit] NOT NULL,
  [IssueReason] [tinyint] NOT NULL,
  [CreatedByUserID] [int] NOT NULL,
 CONSTRAINT [PK_Licenses] PRIMARY KEY CLUSTERED 
(
  [LicenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocalDrivingLicenseApplications]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocalDrivingLicenseApplications](
  [LocalDrivingLicenseApplicationID] [int] IDENTITY(1,1) NOT NULL,
  [ApplicationID] [int] NOT NULL,
  [LicenseClassID] [int] NOT NULL,
 CONSTRAINT [PK_DrivingLicsenseApplications] PRIMARY KEY CLUSTERED 
(
  [LocalDrivingLicenseApplicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
  [PersonID] [int] IDENTITY(1,1) NOT NULL,
  [NationalNo] [nvarchar](20) NOT NULL,
  [FirstName] [nvarchar](20) NOT NULL,
  [SecondName] [nvarchar](20) NOT NULL,
  [ThirdName] [nvarchar](20) NULL,
  [LastName] [nvarchar](20) NOT NULL,
  [DateOfBirth] [datetime] NOT NULL,
  [Gendor] [tinyint] NOT NULL,
  [Address] [nvarchar](500) NOT NULL,
  [Phone] [nvarchar](20) NOT NULL,
  [Email] [nvarchar](50) NULL,
  [NationalityCountryID] [int] NOT NULL,
  [ImagePath] [nvarchar](250) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
  [PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestAppointments]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestAppointments](
  [TestAppointmentID] [int] IDENTITY(1,1) NOT NULL,

[TestTypeID] [int] NOT NULL,
  [LocalDrivingLicenseApplicationID] [int] NOT NULL,
  [AppointmentDate] [smalldatetime] NOT NULL,
  [PaidFees] [smallmoney] NOT NULL,
  [CreatedByUserID] [int] NOT NULL,
  [IsLocked] [bit] NOT NULL,
  [RetakeTestApplicationID] [int] NULL,
 CONSTRAINT [PK_TestAppointments] PRIMARY KEY CLUSTERED 
(
  [TestAppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Tests]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
  [TestID] [int] IDENTITY(1,1) NOT NULL,
  [TestAppointmentID] [int] NOT NULL,
  [TestResult] [bit] NOT NULL,
  [Notes] [nvarchar](500) NULL,
  [CreatedByUserID] [int] NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
  [TestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestTypes]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTypes](
  [TestTypeID] [int] IDENTITY(1,1) NOT NULL,
  [TestTypeTitle] [nvarchar](100) NOT NULL,
  [TestTypeDescription] [nvarchar](500) NOT NULL,
  [TestTypeFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_TestTypes] PRIMARY KEY CLUSTERED 
(
  [TestTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
  [UserID] [int] IDENTITY(1,1) NOT NULL,
  [PersonID] [int] NOT NULL,
  [UserName] [nvarchar](20) NOT NULL,
  [Password] [nvarchar](64) NOT NULL,
  [IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
  [UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Applications] ADD  CONSTRAINT [DF_Applications_ApplicationStatus]  DEFAULT ((1)) FOR [ApplicationStatus]
GO
ALTER TABLE [dbo].[ApplicationTypes] ADD  CONSTRAINT [DF_ApplicationTypes_Fees]  DEFAULT ((0)) FOR [ApplicationFees]
GO
ALTER TABLE [dbo].[DetainedLicenses] ADD  CONSTRAINT [DF_DetainedLicenses_IsReleased]  DEFAULT ((0)) FOR [IsReleased]
GO
ALTER TABLE [dbo].[LicenseClasses] ADD  CONSTRAINT [DF_LicenseClasses_Age]  DEFAULT ((18)) FOR [MinimumAllowedAge]
GO
ALTER TABLE [dbo].[LicenseClasses] ADD  CONSTRAINT [DF_LicenseClasses_DefaultPeriodLength]  DEFAULT ((1)) FOR [DefaultValidityLength]
GO
ALTER TABLE [dbo].[LicenseClasses] ADD  CONSTRAINT [DF_LicenseClasses_ClassFees]  DEFAULT ((0)) FOR [ClassFees]
GO
ALTER TABLE [dbo].[Licenses] ADD  CONSTRAINT [DF_Licenses_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Licenses] ADD  CONSTRAINT [DF_Licenses_IssueReason]  DEFAULT ((1)) FOR [IssueReason]
GO
ALTER TABLE [dbo].[People] ADD  CONSTRAINT [DF_People_Gendor]  DEFAULT ((0)) FOR [Gendor]
GO
ALTER TABLE [dbo].[TestAppointments] ADD  CONSTRAINT [DF_TestAppointments_AppointmentLocked]  DEFAULT ((0)) FOR [IsLocked]
GO
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_Applications_ApplicationTypes] FOREIGN KEY([ApplicationTypeID])
REFERENCES [dbo].[ApplicationTypes] ([ApplicationTypeID])
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_Applications_ApplicationTypes]
GO
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_Applications_People] FOREIGN KEY([ApplicantPersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_Applications_People]
GO
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_Applications_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_Applications_Users]
GO
ALTER TABLE [dbo].[DetainedLicenses]  WITH CHECK ADD  CONSTRAINT [FK_DetainedLicenses_Applications] FOREIGN KEY([ReleaseApplicationID])
REFERENCES [dbo].[Applications] ([ApplicationID])
GO
ALTER TABLE [dbo].[DetainedLicenses] CHECK CONSTRAINT [FK_DetainedLicenses_Applications]
GO
ALTER TABLE [dbo].[DetainedLicenses]  WITH CHECK ADD  CONSTRAINT [FK_DetainedLicenses_Licenses] FOREIGN KEY([LicenseID])

REFERENCES [dbo].[Licenses] ([LicenseID])
GO
ALTER TABLE [dbo].[DetainedLicenses] CHECK CONSTRAINT [FK_DetainedLicenses_Licenses]
GO
ALTER TABLE [dbo].[DetainedLicenses]  WITH CHECK ADD  CONSTRAINT [FK_DetainedLicenses_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[DetainedLicenses] CHECK CONSTRAINT [FK_DetainedLicenses_Users]
GO
ALTER TABLE [dbo].[DetainedLicenses]  WITH CHECK ADD  CONSTRAINT [FK_DetainedLicenses_Users1] FOREIGN KEY([ReleasedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[DetainedLicenses] CHECK CONSTRAINT [FK_DetainedLicenses_Users1]
GO
ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Drivers] CHECK CONSTRAINT [FK_Drivers_People]
GO
ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Drivers] CHECK CONSTRAINT [FK_Drivers_Users]
GO
ALTER TABLE [dbo].[InternationalLicenses]  WITH CHECK ADD  CONSTRAINT [FK_InternationalLicenses_Applications] FOREIGN KEY([ApplicationID])
REFERENCES [dbo].[Applications] ([ApplicationID])
GO
ALTER TABLE [dbo].[InternationalLicenses] CHECK CONSTRAINT [FK_InternationalLicenses_Applications]
GO
ALTER TABLE [dbo].[InternationalLicenses]  WITH CHECK ADD  CONSTRAINT [FK_InternationalLicenses_Drivers] FOREIGN KEY([DriverID])
REFERENCES [dbo].[Drivers] ([DriverID])
GO
ALTER TABLE [dbo].[InternationalLicenses] CHECK CONSTRAINT [FK_InternationalLicenses_Drivers]
GO
ALTER TABLE [dbo].[InternationalLicenses]  WITH CHECK ADD  CONSTRAINT [FK_InternationalLicenses_Licenses] FOREIGN KEY([IssuedUsingLocalLicenseID])
REFERENCES [dbo].[Licenses] ([LicenseID])
GO
ALTER TABLE [dbo].[InternationalLicenses] CHECK CONSTRAINT [FK_InternationalLicenses_Licenses]
GO
ALTER TABLE [dbo].[InternationalLicenses]  WITH CHECK ADD  CONSTRAINT [FK_InternationalLicenses_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[InternationalLicenses] CHECK CONSTRAINT [FK_InternationalLicenses_Users]
GO
ALTER TABLE [dbo].[Licenses]  WITH CHECK ADD  CONSTRAINT [FK_Licenses_Applications] FOREIGN KEY([ApplicationID])
REFERENCES [dbo].[Applications] ([ApplicationID])
GO
ALTER TABLE [dbo].[Licenses] CHECK CONSTRAINT [FK_Licenses_Applications]
GO
ALTER TABLE [dbo].[Licenses]  WITH CHECK ADD  CONSTRAINT [FK_Licenses_Drivers] FOREIGN KEY([DriverID])
REFERENCES [dbo].[Drivers] ([DriverID])
GO
ALTER TABLE [dbo].[Licenses] CHECK CONSTRAINT [FK_Licenses_Drivers]
GO
ALTER TABLE [dbo].[Licenses]  WITH CHECK ADD  CONSTRAINT [FK_Licenses_LicenseClasses] FOREIGN KEY([LicenseClassID])
REFERENCES [dbo].[LicenseClasses] ([LicenseClassID])
GO
ALTER TABLE [dbo].[Licenses] CHECK CONSTRAINT [FK_Licenses_LicenseClasses]
GO
ALTER TABLE [dbo].[Licenses]  WITH CHECK ADD  CONSTRAINT [FK_Licenses_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Licenses] CHECK CONSTRAINT [FK_Licenses_Users]
GO
ALTER TABLE [dbo].[LocalDrivingLicenseApplications]  WITH CHECK ADD  CONSTRAINT [FK_DrivingLicsenseApplications_Applications] FOREIGN KEY([ApplicationID])
REFERENCES [dbo].[Applications] ([ApplicationID])
GO
ALTER TABLE [dbo].[LocalDrivingLicenseApplications] CHECK CONSTRAINT [FK_DrivingLicsenseApplications_Applications]
GO
ALTER TABLE [dbo].[LocalDrivingLicenseApplications]  WITH CHECK ADD  CONSTRAINT [FK_DrivingLicsenseApplications_LicenseClasses] FOREIGN KEY([LicenseClassID])
REFERENCES [dbo].[LicenseClasses] ([LicenseClassID])
GO
ALTER TABLE [dbo].[LocalDrivingLicenseApplications] CHECK CONSTRAINT [FK_DrivingLicsenseApplications_LicenseClasses]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Countries1] FOREIGN KEY([NationalityCountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Countries1]
GO

ALTER TABLE [dbo].[TestAppointments]  WITH CHECK ADD  CONSTRAINT [FK_TestAppointments_Applications] FOREIGN KEY([RetakeTestApplicationID])
REFERENCES [dbo].[Applications] ([ApplicationID])
GO
ALTER TABLE [dbo].[TestAppointments] CHECK CONSTRAINT [FK_TestAppointments_Applications]
GO
ALTER TABLE [dbo].[TestAppointments]  WITH CHECK ADD  CONSTRAINT [FK_TestAppointments_LocalDrivingLicenseApplications] FOREIGN KEY([LocalDrivingLicenseApplicationID])
REFERENCES [dbo].[LocalDrivingLicenseApplications] ([LocalDrivingLicenseApplicationID])
GO
ALTER TABLE [dbo].[TestAppointments] CHECK CONSTRAINT [FK_TestAppointments_LocalDrivingLicenseApplications]
GO
ALTER TABLE [dbo].[TestAppointments]  WITH CHECK ADD  CONSTRAINT [FK_TestAppointments_TestTypes] FOREIGN KEY([TestTypeID])
REFERENCES [dbo].[TestTypes] ([TestTypeID])
GO
ALTER TABLE [dbo].[TestAppointments] CHECK CONSTRAINT [FK_TestAppointments_TestTypes]
GO
ALTER TABLE [dbo].[TestAppointments]  WITH CHECK ADD  CONSTRAINT [FK_TestAppointments_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[TestAppointments] CHECK CONSTRAINT [FK_TestAppointments_Users]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_TestAppointments] FOREIGN KEY([TestAppointmentID])
REFERENCES [dbo].[TestAppointments] ([TestAppointmentID])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_TestAppointments]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_People]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewApplication]    Script Date: 30/10/2026 03:43:19 م ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewApplication]
@ApplicantPersonID INT ,
@ApplicationDate DATETIME ,
@ApplicationTypeID INT ,
@ApplicationStatus TINYINT ,
@LastStatusDate DATETIME ,
@PaidFees SMALLMONEY ,
@CreatedByUserID INT
AS
BEGIN
INSERT INTO Applications 
                                (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                                VALUES 
                                (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                                SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewDetainedLicense]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewDetainedLicense]
@LicenseID INT,
@DetainDate DATETIME,
@FineFees SMALLMONEY,
@CreatedByUserID INT
AS
BEGIN
INSERT INTO DetainedLicenses 
                                (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                                VALUES 
                                (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0, NULL, NULL, NULL);
                                SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewDriver]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewDriver]
@PersonID INT,
@CreatedDate DATETIME,
@CreatedByUserID INT
AS
BEGIN
INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                                 VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                                 SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewInternationalLicense]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_AddNewInternationalLicense]
@ApplicationID INT,
@DriverID INT,
@IssuedUsingLocalLicenseID INT,
@IssueDate DATETIME,
@ExpirationDate DATETIME,
@IsActive BIT,
@CreatedByUserID INT
AS
BEGIN
INSERT INTO InternationalLicenses
                                (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                                VALUES
                                (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID)
                                SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewLicense]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AddNewLicense]
@ApplicationID INT,
@DriverID INT,
@LicenseClassID INT,
@IssueDate DATETIME,
@ExpirationDate DATETIME,
@Notes NVARCHAR(500),
@PaidFees SMALLMONEY,
@IsActive BIT,
@IssueReason TINYINT,
@CreatedByUserID INT
AS
BEGIN
INSERT INTO Licenses (ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                             VALUES (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewLicenseClass]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AddNewLicenseClass]
@ClassName NVARCHAR(50),
@ClassDescription NVARCHAR(500),
@MinimumAllowedAge TINYINT,
@DefaultValidityLength TINYINT,
@ClassFees SMALLMONEY
AS
BEGIN
INSERT INTO LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                             VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);
                             SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewLocalDrivingLicenseApplication]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_AddNewLocalDrivingLicenseApplication]
@ApplicationID INT,
@LicenseClassID INT
AS
BEGIN
INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                             VALUES (@ApplicationID, @LicenseClassID);
                             SELECT SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewPeople]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewPeople]
    @NationalNo nvarchar(20),
    @FirstName nvarchar(20),
    @SecondName nvarchar(20),
    @ThirdName nvarchar(20),
    @LastName nvarchar(20),
    @DateOfBirth datetime,
    @Gendor tinyint,
    @Address nvarchar(500),
    @Phone nvarchar(20),
    @Email nvarchar(50),
    @NationalityCountryID int,
    @ImagePath nvarchar(250)
    -- تم حذف @NewPersonID OUTPUT
AS
BEGIN
    INSERT INTO People(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
    VALUES(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath); 
    
    -- إرجاع الـ ID الجديد مباشرة كسطر نتيجة (سيعمل مع ExecuteScalar)
    SELECT SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewTest]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewTest]
@TestAppointmentID INT,
@TestResult bit,
@Notes nvarchar(500), 
@CreatedByUserID INT
AS
BEGIN
   INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                 VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewTestAppointment]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddNewTestAppointment]
@TestTypeID INT ,
@LocalDrivingLicenseApplicationID INT,
@AppointmentDate DATETIME ,
@PaidFees SMALLMONEY ,
@CreatedByUserID INT ,
@IsLocked BIT ,
@RetakeTestApplicationID INT
AS
BEGIN
INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                                 VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID)
                                 SELECT SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewUser]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_AddNewUser]
     @PersonID INT,
   @UserName nvarchar(20),
   @Password nvarchar(64),
   @IsActive bit
  AS

  BEGIN

      INSERT INTO Users (PersonID, UserName, Password, IsActive)
                             VALUES (@PersonID, @UserName, @Password, @IsActive);
                             SELECT SCOPE_IDENTITY();
      END

GO
/****** Object:  StoredProcedure [dbo].[SP_ChanageApplicationStatusToCancel]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ChanageApplicationStatusToCancel]
@ApplicationID INT 
AS 
BEGIN
UPDATE Applications
                                SET 
                                    ApplicationStatus = 2
                                WHERE ApplicationID = @ApplicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChanageApplicationStatusToComplete]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ChanageApplicationStatusToComplete]
@ApplicationID INT 
AS 
BEGIN
UPDATE Applications
                                SET 
                                    ApplicationStatus = 3
                                WHERE ApplicationID = @ApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ChangeISLook]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ChangeISLook]
@TestAppointmentID INT
AS
BEGIN
UPDATE TestAppointments 
                                 SET IsLocked = 1
                                 WHERE TestAppointmentID = @TestAppointmentID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeactivateLicense]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeactivateLicense]
@LicenseID INT
AS
BEGIN
UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteApplication]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteApplication]
@ApplicationID INT 
AS 
BEGIN
DELETE FROM Applications WHERE ApplicationID = @ApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteLocalDrivingLicenseApplication]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteLocalDrivingLicenseApplication]
@LocalDrivingLicenseApplicationID INT
AS
BEGIN
DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeletePerson]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeletePerson]
  @personID INT
  AS

  BEGIN
         DELETE FROM People      WHERE PersonID = @personID
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteTest]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteTest]
@TestID INT
AS
BEGIN
DELETE FROM Tests WHERE TestID = @TestID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteTestAppointment]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteTestAppointment]
@TestAppointmentID INT 
AS
BEGIN
DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteUser]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteUser]
     @UserID int
     
  AS

  BEGIN

    DELETE FROM Users WHERE UserID = @UserID
      END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetActiveLicenseIDByPersonID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SP_GetActiveLicenseIDByPersonID]
@PersonID INT,
@LicenseClassID INT
AS
BEGIN
SELECT Licenses.LicenseID 
                                 FROM Licenses 
                                 INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                                 WHERE Drivers.PersonID = @PersonID 
                                   AND Licenses.LicenseClassID = @LicenseClassID 
                                   AND Licenses.IsActive = 1;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllApplications]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_GetAllApplications]
AS 
BEGIN
SELECT ApplicationID , ApplicantPersonID ,ApplicationDate ,ApplicationTypeID , 
CASE   WHEN Applications.ApplicationStatus = 1 THEN 'NEW'   WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'   ELSE 'Completed'   END as ApplicationStatus ,
LastStatusDate ,PaidFees ,CreatedByUserID  FROM Applications 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllApplicationTypes]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllApplicationTypes]
AS 
BEGIN
SELECT * FROM ApplicationTypes 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllCountries]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllCountries]
AS
BEGIN
SELECT * FROM Countries
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllDetainedLicenses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllDetainedLicenses]
AS
BEGIN
SELECT 
    DetainedLicenses.DetainID AS [D.ID],
    DetainedLicenses.LicenseID AS [L.ID],
    DetainedLicenses.DetainDate AS [D Date],
    DetainedLicenses.FineFees AS [Fine Fees],
    People.NationalNo AS [N.No],
    ISNULL(People.FirstName, '') + ' ' + 
    ISNULL(People.SecondName, '') + ' ' + 
    ISNULL(People.ThirdName, '') + ' ' + 
    ISNULL(People.LastName, '') AS [Full Name], 
  DetainedLicenses.IsReleased AS [Is Released],
    DetainedLicenses.ReleaseDate AS [Release Date],
    DetainedLicenses.ReleaseApplicationID AS [Release App ID]
FROM DetainedLicenses 
INNER JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID
INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
INNER JOIN People ON Drivers.PersonID = People.PersonID
LEFT JOIN Applications ON DetainedLicenses.ReleaseApplicationID = Applications.ApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllDrivers]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetAllDrivers]
AS
BEGIN
SELECT 
                            Drivers.DriverID AS [Driver ID], 
                            Drivers.PersonID AS [Person ID], 
                            People.NationalNo AS [National No],
                            People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName AS [Full Name], 
                            Drivers.CreatedDate AS [Date],
                            (SELECT COUNT(*) FROM Licenses WHERE Licenses.DriverID = Drivers.DriverID AND Licenses.IsActive = 1) AS [Active Licenses]
                         FROM Drivers 
                         INNER JOIN People ON Drivers.PersonID = People.PersonID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllInternationalLicenses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllInternationalLicenses]
AS
BEGIN
SELECT InternationalLicenseID AS [Int.License ID], ApplicationID, DriverID AS [Driver ID],
                                 IssuedUsingLocalLicenseID AS [L.License ID], IssueDate AS [Issue Date], ExpirationDate AS [Expiration Date], IsActive AS [Is Active]
                                 FROM InternationalLicenses
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllLicenseClasses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllLicenseClasses]
AS
BEGIN
SELECT * FROM LicenseClasses
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllLicenses]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllLicenses]
AS
BEGIN
SELECT * FROM Licenses 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPeople]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllPeople]
AS
BEGIN
SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth ,
CASE       WHEN People.Gendor = 0 THEN 'Male'     ELSE 'Femail' END AS Gendor , 
People.Address, People.Phone, People.Email, Countries.CountryName,          
People.ImagePath FROM     People INNER JOIN                Countries ON People.NationalityCountryID = Countries.CountryID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllTestAppointments]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllTestAppointments]

AS
BEGIN
SELECT TestAppointmentID AS [Appointment ID] , AppointmentDate AS [Appointment Date] , PaidFees As [Paid Fees] , IsLocked FROM TestAppointments
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllTestAppointmentsByIDAndTestTypeID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllTestAppointmentsByIDAndTestTypeID]
@LocalDrivingLicenseApplicationID INT ,
@TestTypeID INT
AS
BEGIN
SELECT TestAppointmentID AS [Appointment ID] , AppointmentDate AS [Appointment Date] , PaidFees As [Paid Fees] , IsLocked FROM TestAppointments Where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID And TestTypeID = @TestTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllTests]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllTests]
AS
BEGIN
SELECT * FROM Tests
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllTestTypes]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllTestTypes]
AS
BEGIN
      SELECT * FROM TestTypes
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllUsers]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetAllUsers]
     
  AS

  BEGIN

      SELECT Users.UserID,
      Users.PersonID, People.FirstName + ' ' + People.SecondName + ' '  + People.ThirdName + ' ' + People.LastName AS [Full Name], Users.UserName, Users.Password, 
      CASE 
      WHEN IsActive = 1 THEN 'Yes'
      ELSE 'No'
      End AS [Is Active] 
      FROM     Users INNER JOIN People ON Users.PersonID = People.PersonID
      END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllUsersIsActive]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SP_GetAllUsersIsActive]
   
  AS

  BEGIN

SELECT Users.UserID, Users.PersonID, 
      People.FirstName + ' ' + People.SecondName + ' '  + People.ThirdName + ' ' + People.LastName AS [Full Name], 
      Users.UserName, Users.Password,
      CASE
      WHEN IsActive = 1 THEN 'Yes' 
      ELSE 'No'
      End AS [Is Active]  
      FROM     Users INNER JOIN People ON Users.PersonID = People.PersonID where IsActive = 1
      END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllUsersIsNotActive]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SP_GetAllUsersIsNotActive]
      
  AS

  BEGIN

      SELECT Users.UserID, Users.PersonID, 
      People.FirstName + ' ' + People.SecondName + ' '  + People.ThirdName + ' ' + People.LastName AS [Full Name], 
      Users.UserName, Users.Password,
      CASE
      WHEN IsActive = 1 THEN 'Yes' 
      ELSE 'No'
      End AS [Is Active]  
      FROM     Users INNER JOIN People ON Users.PersonID = People.PersonID where IsActive = 0
      END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetApplicationInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetApplicationInfoByID]
@ApplicationID INT
AS
BEGIN
SELECT * FROM Applications WHERE ApplicationID = @ApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetApplicationTypesByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetApplicationTypesByID]
@ApplicationTypeID INT
AS
BEGIN
 SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID

END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetCountryNameByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetCountryNameByID]
@CountryID INT
AS
BEGIN
SELECT * FROM Countries WHERE CountryID = @CountryID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDetainedLicenseInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDetainedLicenseInfoByID]
@DetainID INT
AS
BEGIN
SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetDetainedLicenseInfoByLicenseID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetDetainedLicenseInfoByLicenseID]
@LicenseID INT
AS
BEGIN
SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID ORDER BY DetainID DESC
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetDriverInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDriverInfoByID]
@DriverID INT
AS
BEGIN
SELECT * FROM Drivers WHERE DriverID = @DriverID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetDriverInfoByPersonID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetDriverInfoByPersonID]
@PersonID INT
AS
BEGIN
SELECT * FROM Drivers WHERE PersonID = @PersonID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetFailedTestByLDLAppID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetFailedTestByLDLAppID]
@LocalDrivingLicenseApplicationID INT,
@TestTypeID INT
AS
BEGIN
SELECT COUNT(Tests.TestID) AS [Failed Tests] FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID   AND Tests.TestResult = 0 And TestTypeID = @TestTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetInternationalLicenseInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetInternationalLicenseInfoByID]
@InternationalLicenseID INT
AS
BEGIN
SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetInternationalLicenseInfoByLocalLicenseID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetInternationalLicenseInfoByLocalLicenseID]
@IssuedUsingLocalLicenseID INT
AS
BEGIN
SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetInternationalLicensesInfoByPersonID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SP_GetInternationalLicensesInfoByPersonID]
@PersonID INT
AS
BEGIN
SELECT InternationalLicenses.InternationalLicenseID AS [Int.License ID], InternationalLicenses.ApplicationID AS [Application ID], InternationalLicenses.IssuedUsingLocalLicenseID AS [L.License ID],    
InternationalLicenses.IssueDate AS [Issue Date], InternationalLicenses.ExpirationDate AS [Expiration Date], InternationalLicenses.IsActive AS [Is Active] 
FROM     InternationalLicenses INNER JOIN                  Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID INNER JOIN 
People ON Applications.ApplicantPersonID = People.PersonID 
WHERE    People.PersonID = @PersonID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLicenseByAppIDAndLicenseClassID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetLicenseByAppIDAndLicenseClassID]
@ApplicationID INT ,
@LicenseClassID INT
AS
BEGIN
SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID AND LicenseClassID = @LicenseClassID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetLicenseClassInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetLicenseClassInfoByID]
@LicenseClassID INT
AS
BEGIN
SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLicenseClassInfoClassName]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetLicenseClassInfoClassName]
@ClassName INT
AS
BEGIN
SELECT * FROM LicenseClasses WHERE ClassName = @ClassName
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLicenseInfoByAppID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetLicenseInfoByAppID]
@ApplicationID INT
AS
BEGIN
SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLicenseInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetLicenseInfoByID]
@LicenseID INT
AS
BEGIN
SELECT * FROM  Licenses WHERE LicenseID = @LicenseID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLicenseInfoByPersonID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetLicenseInfoByPersonID]
@PersonID INT
AS
BEGIN
SELECT Licenses.LicenseID, Licenses.ApplicationID, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM Licenses INNER JOIN            
                             Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN            
                             People ON Drivers.PersonID = People.PersonID 
                             WHERE Drivers.PersonID = @PersonID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLocalDrivingLicenseApplicationInfoByApplicationID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetLocalDrivingLicenseApplicationInfoByApplicationID]
@ApplicationID INT
AS
BEGIN
SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetLocalDrivingLicenseApplicationInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetLocalDrivingLicenseApplicationInfoByID]
@LocalDrivingLicenseApplicationID INT
AS
BEGIN
SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetPassedTestByLDLAppID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetPassedTestByLDLAppID]
@LocalDrivingLicenseApplicationID INT
AS
BEGIN
SELECT COUNT(Tests.TestID) AS [Passed Tests] FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID   AND Tests.TestResult = 1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetPersonByNationalNo]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetPersonByNationalNo]
    @NationalNo nvarchar(20)
  AS

  BEGIN
  SELECT * FROM People WHERE NationalNo = @NationalNo
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetPersonByPersonID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetPersonByPersonID]
    @person int
  AS

  BEGIN
  SELECT * FROM People where PersonID = @person
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetTestAppointmentInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetTestAppointmentInfoByID]
@TestAppointmentID INT
AS
BEGIN
SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetTestInfoByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetTestInfoByID]
@TestID INT
AS
BEGIN
     SELECT * FROM Tests WHERE TestID = @TestID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetTestTypeByID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetTestTypeByID]
@TestTypeID INT
AS
BEGIN
       SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUserInfoByUserID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetUserInfoByUserID]
    @UserID int
    
  AS

  BEGIN
  SELECT * FROM Users WHERE UserID = @UserID
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUserInfoByUserNameAndPassword]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_GetUserInfoByUserNameAndPassword]
      @UserName nvarchar(20),
      @Password nvarchar(64)
  AS

BEGIN
  SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_IsApplicationExist]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IsApplicationExist]
@ApplicationID INT
AS 
BEGIN
SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IsExistLocalDrivingLicenseApplication]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_IsExistLocalDrivingLicenseApplication]
@LicenseID INT
AS
BEGIN
SELECT Found = 1 FROM Licenses WHERE LicenseID = @LicenseID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_IsExistPerson]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IsExistPerson]
  @PersonID INT
  AS

  BEGIN
     SELECT Found = 1  FROM People WHERE PersonID = @PersonID
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_IsExistPersonByNo]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IsExistPersonByNo]
  @NationalNo nvarchar(20)
  AS

  BEGIN
     SELECT Found = 1  FROM People WHERE NationalNo = @NationalNo
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_IsLicenseDetained]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_IsLicenseDetained]
@LicenseID INT
AS
BEGIN
SELECT IsDetained = 1 FROM DetainedLicenses 
                                WHERE LicenseID = @LicenseID AND IsReleased = 0
END

GO
/****** Object:  StoredProcedure [dbo].[SP_IsLicenseExpired]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_IsLicenseExpired]
@LicenseID INT
AS
BEGIN
SELECT Found = 1 FROM Licenses WHERE LicenseID = @LicenseID AND ExpirationDate < GETDATE()
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ISlicenseExsitByAppIDAndLicenseClassID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ISlicenseExsitByAppIDAndLicenseClassID]
@ApplicationID INT ,
@LicenseClassID INT
AS
BEGIN
SELECT Found = 1 FROM Licenses WHERE ApplicationID = @ApplicationID AND LicenseClassID = @LicenseClassID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ISlicenseExsitByLicenseID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ISlicenseExsitByLicenseID]
@LicenseID INT
AS
BEGIN
SELECT Found = 1 FROM Licenses WHERE LicenseID = @LicenseID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_IsLocalDrivingLicenseExist]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IsLocalDrivingLicenseExist]
@LocalDrivingLicenseID INT
AS
BEGIN
   SELECT Found =1  FROM TestAppointments Where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID  And IsLocked = 0

END
GO
/****** Object:  StoredProcedure [dbo].[SP_IsUserExistForPersonID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_IsUserExistForPersonID]
     @PersonID int
     
  AS

  BEGIN

        SELECT Found = 1 FROM Users WHERE PersonID = @PersonID
    END

GO
/****** Object:  StoredProcedure [dbo].[SP_IsUserExistForUserID]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_IsUserExistForUserID]
     @UserID int
     
  AS

  BEGIN

        SELECT Found = 1 FROM Users WHERE UserID = @UserID
    END

GO
/****** Object:  StoredProcedure [dbo].[SP_IsUserExistForUserNameAndPassWord]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_IsUserExistForUserNameAndPassWord]
     @UserName nvarchar(20),
     @PassWord nvarchar(64)
  AS

  BEGIN

        SELECT Found =1  FROM Users WHERE UserName = @UserName AND Password = @PassWord AND IsActive = 1
    END

GO
/****** Object:  StoredProcedure [dbo].[SP_ListALLLocalDrivingLicenseAppLications]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListALLLocalDrivingLicenseAppLications]
AS
BEGIN
SELECT 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.L.AppID],
    LicenseClasses.ClassName AS [Driving Class],
    People.NationalNo AS [National No],
    People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName AS [Full Name],
    Applications.ApplicationDate AS [Application Date],
    (
        SELECT COUNT(TestAppointments.TestTypeID)
        FROM TestAppointments 
        INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
        WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
          AND Tests.TestResult = 1
    ) AS [Passed Tests],
    CASE 
        WHEN Applications.ApplicationStatus = 1 THEN 'New'
        WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
        ELSE 'Unknown'
    END AS [Status]
FROM LocalDrivingLicenseApplications
INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReleaseDetainedLicense]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReleaseDetainedLicense]
@ReleaseDate DATETIME,
@ReleaseApplicationID INT,
@ReleasedByUserID INT,
@DetainID INT
AS
BEGIN
UPDATE DetainedLicenses
                                SET IsReleased = 1,
                                    ReleaseDate = @ReleaseDate,
                                    ReleasedByUserID = @ReleasedByUserID,
                                    ReleaseApplicationID = @ReleaseApplicationID
                                WHERE DetainID = @DetainID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateApplication]    Script Date: 30/10/2026 03:43:19 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_UpdateApplication]
@ApplicationID INT ,
@ApplicantPersonID INT ,
@ApplicationDate DATETIME ,
@ApplicationTypeID INT ,
@ApplicationStatus TINYINT ,
@LastStatusDate DATETIME ,
@PaidFees SMALLMONEY ,
@CreatedByUserID INT
AS 
BEGIN
UPDATE Applications
                                SET ApplicantPersonID = @ApplicantPersonID,
                                    ApplicationDate = @ApplicationDate,
                                    ApplicationTypeID = @ApplicationTypeID,
                                    ApplicationStatus = @ApplicationStatus,
                                    LastStatusDate = @LastStatusDate,
                                    PaidFees = @PaidFees,
                                    CreatedByUserID = @CreatedByUserID
                                WHERE ApplicationID = @ApplicationID
END

GO