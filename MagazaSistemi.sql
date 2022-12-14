USE [Magaza]
GO
/****** Object:  Table [dbo].[Magaza]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Magaza](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MagazaAd] [nvarchar](20) NULL,
	[AktifMi] [bit] NULL,
 CONSTRAINT [PK_Magaza] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](20) NULL,
	[MusteriSoyad] [nvarchar](20) NULL,
	[Aktifmi] [bit] NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAd] [nvarchar](20) NULL,
	[PersonelSoyad] [nvarchar](20) NULL,
	[MagazaId] [int] NULL,
	[Aktifmi] [bit] NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MusteriId] [int] NULL,
	[PersonelId] [int] NULL,
	[UrunId] [int] NULL,
 CONSTRAINT [PK_Satis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UrunAd] [nvarchar](20) NULL,
	[UrunFiyat] [money] NULL,
	[Aktifmi] [bit] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Magaza] ON 

INSERT [dbo].[Magaza] ([Id], [MagazaAd], [AktifMi]) VALUES (1, N'koton', 0)
INSERT [dbo].[Magaza] ([Id], [MagazaAd], [AktifMi]) VALUES (2, N'Leyligül', 0)
INSERT [dbo].[Magaza] ([Id], [MagazaAd], [AktifMi]) VALUES (3, N'KOTON', 1)
INSERT [dbo].[Magaza] ([Id], [MagazaAd], [AktifMi]) VALUES (4, N'BERSHKA', 1)
INSERT [dbo].[Magaza] ([Id], [MagazaAd], [AktifMi]) VALUES (5, N'MAVİ', 1)
INSERT [dbo].[Magaza] ([Id], [MagazaAd], [AktifMi]) VALUES (6, N'ACER', 0)
SET IDENTITY_INSERT [dbo].[Magaza] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (7, N'Selami', N'Durmuş', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (8, N'Hasan', N'Mübarek', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (9, N'Elif', N'Karakelle', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (10, N'Tuğçe ', N'Çakar', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (11, N'Mustafa', N'Gedik', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (13, N'Şeyda', N'Kafaoğlu', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (16, N'Büyük Özgün', N'Erbudak', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (17, N'Behzat', N'Ç', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (18, N'Ercüment', N'Çözer', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (19, N'Zaza ', N'Dayı', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (20, N'Memati', N'Baş', NULL)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (24, N'Elif', N'Sivrikaya', 0)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (25, N'Nihal', N'Mercan', 0)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (26, N'Osman', N'Sivrikaya', 0)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (27, N'ELİF', N'CANER', 0)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (28, N'OĞUZHAN', N'ESEN', 1)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (29, N'NİHAL', N'MERCAN', 1)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (30, N'MELİKE', N'GÜNERİ', 1)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (31, N'SONER', N'GÜNERİ', 1)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (32, N'ŞEYMANUR', N'KESİK', 1)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (33, N'ÖMER ASAF', N'SİVRİ', 1)
INSERT [dbo].[Musteri] ([Id], [MusteriAd], [MusteriSoyad], [Aktifmi]) VALUES (34, N'MUSTAFA ', N'GEDİK', 1)
SET IDENTITY_INSERT [dbo].[Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([Id], [PersonelAd], [PersonelSoyad], [MagazaId], [Aktifmi]) VALUES (1, N'Emir', N'Kuyu', 2, 0)
INSERT [dbo].[Personeller] ([Id], [PersonelAd], [PersonelSoyad], [MagazaId], [Aktifmi]) VALUES (2, N'GÜL', N'MERCAN', 5, NULL)
INSERT [dbo].[Personeller] ([Id], [PersonelAd], [PersonelSoyad], [MagazaId], [Aktifmi]) VALUES (3, N'OSMAN', N'SİVRİKAYA', 4, 1)
SET IDENTITY_INSERT [dbo].[Personeller] OFF
GO
SET IDENTITY_INSERT [dbo].[Satis] ON 

INSERT [dbo].[Satis] ([Id], [MusteriId], [PersonelId], [UrunId]) VALUES (1, 7, 1, 1)
SET IDENTITY_INSERT [dbo].[Satis] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (1, N'etek', 330.0000, NULL)
INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (6, N'osman', 0.0000, NULL)
INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (7, N'Pantolon', 250.0000, NULL)
INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (8, N'Tişört', 200.0000, NULL)
INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (11, N'Pantolon', 100.0000, 0)
INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (12, N'PANTOLON', 100.0000, 0)
INSERT [dbo].[Urunler] ([Id], [UrunAd], [UrunFiyat], [Aktifmi]) VALUES (13, N'PANTOLON', 100.0000, 1)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_MagazaEkle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MagazaEkle]
(
@Id int null,
@MagazaAd nvarchar(20),
@AktifMi bit null
)
as
begin
 insert into Magaza (MagazaAd, AktifMi) values (@MagazaAd,1)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_MagazaGuncelle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MagazaGuncelle]
(
@Id int null,
@MagazaAd nvarchar(20),
@AktifMi bit
)
as
begin
update Magaza set  MagazaAd=@MagazaAd, Aktifmi = 1 where Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_MagazaSil]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_MagazaSil]
(
@Id int null,
@AktifMi bit
)
as
begin
update Magaza set  AktifMi=0 where Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_MusteriEkle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MusteriEkle]
(
@Id int null,
@MusteriAd nvarchar(20),
@MusteriSoyad nvarchar(20),
@Aktifmi bit
)
as
begin
insert into Musteri (MusteriAd,MusteriSoyad,Aktifmi) values (@MusteriAd,@MusteriSoyad,1)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_MusteriGuncelle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MusteriGuncelle]
(
@Id int null,
@MusteriAd nvarchar(20),
@MusteriSoyad nvarchar(20),
@Aktifmi bit
)
as 
begin 
update Musteri set MusteriAd =@MusteriAd , MusteriSoyad = @MusteriSoyad, Aktifmi = 1  where Id = @Id 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_PersonellerEkle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PersonellerEkle](

@Id int null,
@PersonelAd nvarchar(20),
@PersonelSoyad nvarchar(20),
@MagazaId int,
@Aktifmi bit

)
as
begin
insert into Personeller(PersonelAd,PersonelSoyad,MagazaId,Aktifmi) values (@PersonelAd,@PersonelSoyad,@MagazaId,1)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_PersonellerGuncelle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PersonellerGuncelle](

@Id int null,
@PersonelAd nvarchar(20),
@PersonelSoyad nvarchar(20),
@MagazaId int,
@Aktifmi bit
)
as
begin
update Personeller set PersonelAd=@PersonelAd,PersonelSoyad=@PersonelSoyad ,MagazaId = @MagazaId , Aktifmi = 1 where Id= @Id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SatisEkle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SatisEkle] 
(
@Id int null,
@MusteriId int ,
@UrunId int,
@PersonelId int
)
as
begin 
insert into Satis (MusteriId,UrunId,PersonelId) values (@MusteriId, @UrunId,@PersonelId)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UrunlerEkle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UrunlerEkle](

@Id int null,
@UrunAd nvarchar(20),
@UrunFiyat money,
@Aktifmi bit
)
as
begin
insert into Urunler (UrunAd,UrunFiyat,Aktifmi) values (@UrunAd,@UrunFiyat,1)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UrunlerGuncelle]    Script Date: 5.08.2022 17:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UrunlerGuncelle](

@Id int null,
@UrunAd nvarchar(20),
@UrunFiyat money,
@Aktifmi bit null
)
as
begin
update Urunler set UrunAd = @UrunAd,UrunFiyat = @UrunFiyat, Aktifmi=1 where Id= @Id
end
GO
