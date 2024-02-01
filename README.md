USE [DotNetCore]
GO
/****** Object:  Table [dbo].[Tbl_Product]    Script Date: 01-Feb-24 4:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tbl_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ShoppingCart]    Script Date: 01-Feb-24 4:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ShoppingCart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_ShoppingCart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Product] ON 

INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (1, N'LD01 LOUNGE CHAIR', 200, N'1.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (2, N'LD02 LOUNGE CHAIR', 290, N'2.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (3, N'LD03 LOUNGE CHAIR', 300, N'3.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (4, N'LD04 LOUNGE CHAIR', 350, N'4.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (5, N'LD05 LOUNGE CHAIR', 250, N'5.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (6, N'LD06 LOUNGE CHAIR', 250, N'6.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (7, N'LD07 LOUNGE CHAIR', 400, N'7.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (8, N'LD08 LOUNGE CHAIR', 200, N'8.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (9, N'LD09 LOUNGE CHAIR', 240, N'3.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (10, N'LD10 LOUNGE CHAIR', 390, N'6.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (11, N'LD11 LOUNGE CHAIR', 300, N'4.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
INSERT [dbo].[Tbl_Product] ([Id], [ProductName], [Price], [Image], [Description]) VALUES (12, N'LD12 LOUNGE CHAIR', 450, N'1.png', N'Expertly rendered by Carl Hansen & Søn, the lounge chair—first introduced in 1951 and enduring ever since—is available in oak or as a combination of oak and walnut, sourced from sustainable forestry. Choose from seat and back upholstery in a selection of leather options or in a custom fabric.')
SET IDENTITY_INSERT [dbo].[Tbl_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_ShoppingCart] ON 

INSERT [dbo].[Tbl_ShoppingCart] ([Id], [ProductId], [Price], [Quantity]) VALUES (2, 2, 290, 3)
INSERT [dbo].[Tbl_ShoppingCart] ([Id], [ProductId], [Price], [Quantity]) VALUES (4, 4, 350, 1)
SET IDENTITY_INSERT [dbo].[Tbl_ShoppingCart] OFF
GO
ALTER TABLE [dbo].[Tbl_ShoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_ShoppingCart_Tbl_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Tbl_Product] ([Id])
GO
ALTER TABLE [dbo].[Tbl_ShoppingCart] CHECK CONSTRAINT [FK_Tbl_ShoppingCart_Tbl_Product]
GO
