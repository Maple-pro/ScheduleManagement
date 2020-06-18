IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resources]') AND type in (N'U'))

BEGIN

CREATE TABLE [dbo].[Resources](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [IdSort] [int] NULL,
        [ParentId] [int] NULL,
        [Description] [nvarchar](max) NULL,
CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED 
(
        [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

GO

SET IDENTITY_INSERT [dbo].[Resources] ON
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (1, 10, NULL, N'Project Deployment')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (2, 20, 1, N'Specifications')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (3, 30, 1, N'Spike Solution')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (4, 40, 1, N'Deployment')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (5, 50, 1, N'Performance')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (6, 60, NULL, N'Demos and Docs')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (7, 70, 6, N'Demos')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (8, 80, 6, N'Docs')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (9, 90, 1, N'Testing')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (10, 100, 5, N'Code Refactoring')
INSERT [dbo].[Resources] ([Id], [IdSort], [ParentId], [Description]) VALUES (11, 110, 5, N'Optimization')
SET IDENTITY_INSERT [dbo].[Resources] OFF
