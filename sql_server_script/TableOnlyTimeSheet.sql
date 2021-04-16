USE [dbTimeSheet]
GO
/****** Object:  Table [dbo].[timeSheet]    Script Date: 16/04/2021 01:09:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[timeSheet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](150) NULL,
	[Date] [date] NULL,
	[Hours] [time](7) NULL,
	[Narration] [nvarchar](500) NULL,
	[Customer] [nvarchar](250) NULL,
	[HorlyRate] [decimal](18, 0) NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_timeSheet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
