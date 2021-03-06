USE [STUDENTLIST]
GO
/****** Object:  Table [dbo].[tblStudentInfo]    Script Date: 03/19/2014 17:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStudentInfo](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NULL,
	[RollNo] [int] NULL,
	[RegNo] [int] NULL,
	[Age] [int] NULL,
	[Id] [int] NULL,
 CONSTRAINT [PK_tblStudentInfo] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblStudentInfo] ON
INSERT [dbo].[tblStudentInfo] ([StudentId], [StudentName], [RollNo], [RegNo], [Age], [Id]) VALUES (1, N'Jahangir Alam', 718021, 1207, 24, NULL)
INSERT [dbo].[tblStudentInfo] ([StudentId], [StudentName], [RollNo], [RegNo], [Age], [Id]) VALUES (2, N'Jahangir Alam', 718021, 1207, 24, NULL)
INSERT [dbo].[tblStudentInfo] ([StudentId], [StudentName], [RollNo], [RegNo], [Age], [Id]) VALUES (4, N'Mamun', 22, 14, 35, 1)
INSERT [dbo].[tblStudentInfo] ([StudentId], [StudentName], [RollNo], [RegNo], [Age], [Id]) VALUES (5, N'Sohel', 24, 22, 25, 1)
SET IDENTITY_INSERT [dbo].[tblStudentInfo] OFF
/****** Object:  Table [dbo].[tblDept]    Script Date: 03/19/2014 17:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDept](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [varchar](50) NULL,
 CONSTRAINT [PK_tblDetp] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblDept] ON
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (1, N'ICE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (2, N'CSE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (3, N'CSE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (4, N'APECE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (5, N'APE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (6, N'APECE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (7, N'APECE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (8, N'BTGE')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (9, N'MATH')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (10, N'MATH')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (11, N'Stat')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (12, N'YYY')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (13, N'YYY')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (14, N'YYY')
INSERT [dbo].[tblDept] ([DeptId], [DeptName]) VALUES (15, N'sdwe')
SET IDENTITY_INSERT [dbo].[tblDept] OFF
