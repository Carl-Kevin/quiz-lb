-----------------------------Delete database if exists----------------------------
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'QuizBee')
BEGIN 
	--Take database offline ignoring any connection made
	ALTER DATABASE [QuizBee] SET OFFLINE WITH ROLLBACK IMMEDIATE;

	--Bring online before delete 
	ALTER DATABASE [QuizBee] SET ONLINE;

	DROP DATABASE [QuizBee]; 

END 

-----------------------------Create database----------------------------------------

CREATE DATABASE [QuizBee];
USE [QuizBee]
GO
-----------------------------Create the Quiz Table----------------------------------
CREATE TABLE [dbo].[Quiz](
	[QuestionNumber] [int] NOT NULL,
	[Questions] [varchar](max) NOT NULL,
	[Option1] [varchar](max) NOT NULL,
	[Option2] [varchar](max) NOT NULL,
	[Option3] [varchar](max) NOT NULL,
	[Option4] [varchar](max) NOT NULL,
	[TimeFrame] [int] NOT NULL,
	[AnswerKey] [varchar](255) NOT NULL,
	[DifficultyLevel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------Create the Contestant Score Table-------------------------
CREATE TABLE [dbo].[ContestantScore](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContestantName] [nvarchar](50) NULL,
	[Score] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



-----------------------------Prepare Sample Data---------------------------------- 
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (1, N'Question 1', N'Q1A', N'Q1B', N'Q1C', N'Q1D', 5, N'Q1A', 1)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (2, N'Question 2', N'Q2A', N'Q2B', N'Q2C', N'Q2D', 10, N'Q2B', 1)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (3, N'Question 3', N'Q3A', N'Q3B', N'Q3C', N'Q3D', 15, N'Q3D', 2)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (4, N'Question 4', N'Q4A', N'Q4B', N'Q4C', N'Q4D', 20, N'Q4C', 2)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (5, N'Question 5', N'Q5A', N'Q5B', N'Q5C', N'Q5D', 25, N'Q5A', 3)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (6, N'Question 6', N'Q6A', N'Q6B', N'Q6C', N'Q6D', 30, N'Q6B', 3)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (7, N'Question 7', N'Q7A', N'Q7B', N'Q7C', N'Q7D', 25, N'Q7A', 3)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (8, N'Question 8', N'Q8A', N'Q8B', N'Q8C', N'Q8D', 30, N'Q8C', 1)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (9, N'Question 9', N'Q9A', N'Q9B', N'Q9C', N'Q9D', 20, N'Q9A', 2)
INSERT [dbo].[Quiz] ([QuestionNumber], [Questions], [Option1], [Option2], [Option3], [Option4], [TimeFrame], [AnswerKey], [DifficultyLevel]) VALUES (10, N'Question 10', N'Q10A', N'Q10B', N'Q10C', N'Q10D', 25, N'Q10B', 3)
