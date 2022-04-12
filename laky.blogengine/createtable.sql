CREATE TABLE [dbo].[blogentry](
	[blogid] [int] IDENTITY(1,1) NOT NULL,
	[created] [datetime] NOT NULL,
	[title] [nvarchar](200) NOT NULL,
	[content] [text] NULL,
	[slug] [varchar](200) NULL,
	[tags] [nvarchar](200) NULL,
	[lang] [nvarchar](10) NULL,
	[metadescription] [nvarchar](200) NULL,
 CONSTRAINT [PK_blogentry] PRIMARY KEY CLUSTERED 
(
	[blogid] ASC
)
)

GO

CREATE TABLE [dbo].[blogpicture](
	[picture_id] [int] IDENTITY(1,1) NOT NULL,
	[created] [smalldatetime] NOT NULL,
	[tags] [nvarchar](200) NULL,
	[filename] [nvarchar](200) NULL,
	[path] [nvarchar](200) NULL,
	[imagedata] [image] NULL,
 CONSTRAINT [PK_blogpicture] PRIMARY KEY CLUSTERED 
(
	[picture_id] ASC
))
GO

