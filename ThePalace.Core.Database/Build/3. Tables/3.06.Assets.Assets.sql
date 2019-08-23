IF NOT EXISTS(SELECT TOP 1 1 FROM SYS.TABLES WHERE OBJECT_ID = OBJECT_ID('[Assets].[Assets]')) BEGIN
	CREATE TABLE [Assets].[Assets](
		[AssetID] [int] NOT NULL,
		[AssetCrc] [int] NOT NULL,
		[Name] [nvarchar](1024) NOT NULL,
		[Flags] [int] NOT NULL,
		[LastUsed] [datetime] NOT NULL,
		[Data] [varbinary](max) NULL,
	 CONSTRAINT [PK_Assets_Assets] PRIMARY KEY CLUSTERED 
	(
		[AssetID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

	PRINT 'CREATED [Assets].[Assets]'
END ELSE BEGIN
	PRINT 'ALREADY EXISTS [Assets].[Assets]'
END
GO
