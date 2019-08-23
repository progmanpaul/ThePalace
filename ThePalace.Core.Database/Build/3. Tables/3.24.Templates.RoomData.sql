IF NOT EXISTS(SELECT TOP 1 1 FROM SYS.TABLES WHERE OBJECT_ID = OBJECT_ID('[Templates].[RoomData]')) BEGIN
	CREATE TABLE [Templates].[RoomData](
		[TemplateID] [int] NOT NULL,
		[FacesID] [int] NOT NULL,
		[PictureName] [nvarchar](1024) NULL,
		[ArtistName] [nvarchar](1024) NULL,
		[Password] [nvarchar](1024) NULL,
	 CONSTRAINT [PK_RoomData] PRIMARY KEY CLUSTERED 
	(
		[TemplateID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	PRINT 'CREATED [Templates].[RoomData]'
END ELSE BEGIN
	PRINT 'ALREADY EXISTS [Templates].[RoomData]'
END
GO
