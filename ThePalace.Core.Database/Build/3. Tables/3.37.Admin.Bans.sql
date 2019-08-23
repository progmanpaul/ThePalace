IF NOT EXISTS(SELECT TOP 1 1 FROM SYS.TABLES WHERE OBJECT_ID = OBJECT_ID('[Admin].[Bans]')) BEGIN
	CREATE TABLE [Admin].[Bans](
		[BanID] [int] IDENTITY(1,1) NOT NULL,
		[UntilDate] [datetime] NULL,
		[IPAddress] [nvarchar](50) NOT NULL,
		[RegCtr] [int] NOT NULL,
		[RegCrc] [int] NOT NULL,
		[PUIDCtr] [int] NOT NULL,
		[PUIDCrc] [int] NOT NULL,
		[Note] [NVARCHAR](max) NULL,
	 CONSTRAINT [PK_Bans] PRIMARY KEY CLUSTERED 
	(
		[BanID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	PRINT 'CREATED [Admin].[Bans]'
END ELSE BEGIN
	PRINT 'ALREADY EXISTS [Admin].[Bans]'
END
GO