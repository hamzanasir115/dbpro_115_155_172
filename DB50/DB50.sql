USE [DB50]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Disease]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disease](
	[DiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Detail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Disease] PRIMARY KEY CLUSTERED 
(
	[DiseaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiseaseCategory]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiseaseCategory](
	[DiseaseID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL
	PRIMARY KEY(DiseaseID, CategoryID)
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiseaseSymptom]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiseaseSymptom](
	[SymptomID] [int] NOT NULL,
	[DiseaseID] [int] NOT NULL
	PRIMARY KEY(SymptomID, DiseaseID)
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profile]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[ProfileID] [int] IDENTITY(1,1) NOT NULL,
	[ContactNumber] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[LicenseNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[ProfileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Symptom]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Symptom](
	[SymptomID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Detail] [nvarchar](50) NOT NULL,
	[Reason] [nvarchar](50) NULL,
 CONSTRAINT [PK_Symptom] PRIMARY KEY CLUSTERED 
(
	[SymptomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 4/13/2019 9:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[TreatmentID] [int] IDENTITY(1,1) NOT NULL,
	[DiseaseID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Detail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Treatment] PRIMARY KEY CLUSTERED 
(
	[TreatmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DiseaseCategory]  WITH CHECK ADD  CONSTRAINT [FK_DiseaseCategory_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[DiseaseCategory] CHECK CONSTRAINT [FK_DiseaseCategory_Category]
GO
ALTER TABLE [dbo].[DiseaseCategory]  WITH CHECK ADD  CONSTRAINT [FK_DiseaseCategory_Disease] FOREIGN KEY([DiseaseID])
REFERENCES [dbo].[Disease] ([DiseaseID])
GO
ALTER TABLE [dbo].[DiseaseCategory] CHECK CONSTRAINT [FK_DiseaseCategory_Disease]
GO
ALTER TABLE [dbo].[DiseaseSymptom]  WITH CHECK ADD  CONSTRAINT [FK_DiseaseSymptom_Disease] FOREIGN KEY([DiseaseID])
REFERENCES [dbo].[Disease] ([DiseaseID])
GO
ALTER TABLE [dbo].[DiseaseSymptom] CHECK CONSTRAINT [FK_DiseaseSymptom_Disease]
GO
ALTER TABLE [dbo].[DiseaseSymptom]  WITH CHECK ADD  CONSTRAINT [FK_DiseaseSymptom_Symptom] FOREIGN KEY([SymptomID])
REFERENCES [dbo].[Symptom] ([SymptomID])
GO
ALTER TABLE [dbo].[DiseaseSymptom] CHECK CONSTRAINT [FK_DiseaseSymptom_Symptom]
GO
ALTER TABLE [dbo].[Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Treatment_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Treatment] CHECK CONSTRAINT [FK_Treatment_Category]
GO
ALTER TABLE [dbo].[Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Treatment_Disease] FOREIGN KEY([DiseaseID])
REFERENCES [dbo].[Disease] ([DiseaseID])
GO
ALTER TABLE [dbo].[Treatment] CHECK CONSTRAINT [FK_Treatment_Disease]
GO
