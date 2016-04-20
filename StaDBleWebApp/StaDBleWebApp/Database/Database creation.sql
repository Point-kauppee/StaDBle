﻿CREATE TABLE [dbo].[Horse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StableId] [int] NULL,
	[Identifier] [nvarchar](100) NULL,
	[Links] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Stable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [int] NULL,
	[Identifier] [nvarchar](100) NULL,
	[Links] [int] NULL,
	[Stalls] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
