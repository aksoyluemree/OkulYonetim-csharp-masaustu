USE [UniSistem]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 17.01.2023 21:04:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Kredi] [int] NULL,
	[OkulYonetimId] [int] NULL,
	[DersRenk] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 17.01.2023 21:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](100) NULL,
	[KayitTarih] [datetime2](7) NULL,
	[OgrenciNo] [varchar](50) NULL,
	[DTarih] [datetime2](7) NULL,
	[Bolum] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDers]    Script Date: 17.01.2023 21:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DersId] [int] NULL,
	[OgrenciId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 17.01.2023 21:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](100) NULL,
	[Gorevi] [varchar](150) NULL,
	[YonetimTip] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ders] ON 

INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (1, N'Tarih', 3, 1, N'Blue')
INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (2, N'Web Tasarim-3', 2, 5, N'Gray')
INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (11, N'Isletme', 6, 3, N'Bisque')
INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (4, N'Programlamaya Giris', 5, 2, N'Violet')
INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (5, N'Veritabani Yönetimi -2', 2, 4, N'Green')
INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (6, N'Mobil Programlama', 6, 3, N'Goldenrod')
INSERT [dbo].[Ders] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (12, N'Yönetim Teknikleri', 2, 3, N'Chocolate')
SET IDENTITY_INSERT [dbo].[Ders] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (1, N'Haluk Levent', CAST(N'2022-05-09T00:00:00.0000000' AS DateTime2), N'000154', CAST(N'1970-02-18T00:00:00.0000000' AS DateTime2), N'Tarih')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (2, N'Mine Tugay', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'0009871', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Yönetim Bilisim Sistemleri')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (9, N'Ceza', CAST(N'2023-01-17T20:27:12.2248725' AS DateTime2), N'Sagopa', CAST(N'1993-06-11T20:26:50.0000000' AS DateTime2), N'Müzik')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (4, N'Elçin Sangu', CAST(N'2022-05-11T22:25:48.0000000' AS DateTime2), N'0005481', CAST(N'2022-12-02T22:25:37.0000000' AS DateTime2), N'Moda Tasarim')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (8, N'Gizem Kaya', CAST(N'2023-01-10T01:03:31.9500000' AS DateTime2), N'65994', CAST(N'1995-08-15T01:03:08.0000000' AS DateTime2), N'Isletme')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (7, N'Elif Nur Korkut', CAST(N'2022-12-08T00:00:00.0000000' AS DateTime2), N'1111', CAST(N'2000-06-15T23:32:08.0000000' AS DateTime2), N'bilgisayar müh')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciDers] ON 

INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (1, 2, 1)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (2, 1, 4)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (3, 4, 4)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (4, 5, 2)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (5, 2, 2)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (6, 3, 2)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (7, 3, 3)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (8, 6, 4)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (9, 4, 6)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (10, 7, 7)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (11, 3, 7)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (12, 8, 3)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (13, 4, 7)
SET IDENTITY_INSERT [dbo].[OgrenciDers] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (1, N'Ali Veli', N'Belgeleri düzenler', N'Ögrenci Isleri')
INSERT [dbo].[Personel] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (2, N'Canan Kara', N'Matematik ögretmeni', N'Idare')
INSERT [dbo].[Personel] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (3, N'Cüneyt Ergün', N'Bilgisayar mühendisi', N'Ögretmen')
INSERT [dbo].[Personel] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (9, N'Yusuf Can', N'isletme bölüm baskani', N'Ögretmen')
INSERT [dbo].[Personel] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (7, N'Murat Han', N'Dekan', N'Idare')
INSERT [dbo].[Personel] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (8, N'Elif Nur Korkut', N'Ögrenci topluluk baskan yardimcisi', N'Ögrenci Isleri')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
