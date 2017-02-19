USE [LOTTODB]

SET IDENTITY_INSERT [dbo].[Configuration] ON 


INSERT [dbo].[Configuration] ([Id], [KeyName], [KeyValue]) VALUES (1, N'Factor1', N'1')

INSERT [dbo].[Configuration] ([Id], [KeyName], [KeyValue]) VALUES (2, N'Factor2', N'1')

INSERT [dbo].[Configuration] ([Id], [KeyName], [KeyValue]) VALUES (3, N'MissingUrl', N'https://www.lotto-hessen.de/pfe/controller/DrawingStatisticsController/showLottoTrends?gbn=5&loc=de&jdn=5')

INSERT [dbo].[Configuration] ([Id], [KeyName], [KeyValue]) VALUES (4, N'OccurenciesUrl', N'https://www.lotto-hessen.de/pfe/controller/DrawingStatisticsController/showLottoGameCycles?gbn=5&loc=de&jdn=5 ')

INSERT [dbo].[Configuration] ([Id], [KeyName], [KeyValue]) VALUES (5, N'MissingRegex', N'<span>(\d+)</span></div>.+?<span class="amount.+?">(.+?)</span>')

INSERT [dbo].[Configuration] ([Id], [KeyName], [KeyValue]) VALUES (6, N'OccurenciesRegex', N'<span>(\d+)</span></div>.+?<span class="amount">(\d+) x</span>')

SET IDENTITY_INSERT [dbo].[Configuration] OFF

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (1, 1, NULL, 7, 677)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (2, 2, NULL, 4, 684)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (3, 3, NULL, 2, 708)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (4, 4, NULL, 10, 682)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (5, 5, NULL, 8, 666)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (6, 6, NULL, 6, 735)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (7, 7, NULL, 1, 685)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (8, 8, NULL, 32, 646)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (9, 9, NULL, 6, 689)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (10, 10, NULL, 9, 671)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (11, 11, NULL, 8, 693)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (12, 12, NULL, 2, 660)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (13, 13, NULL, 1, 619)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (14, 14, NULL, 3, 673)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (15, 15, NULL, 6, 650)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (16, 16, NULL, 4, 690)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (17, 17, NULL, 0, 680)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (18, 18, NULL, 1, 677)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (19, 19, NULL, 5, 672)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (20, 20, NULL, 0, 644)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (21, 21, NULL, 5, 644)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (22, 22, NULL, 2, 699)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (23, 23, NULL, 10, 669)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (24, 24, NULL, 0, 677)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (25, 25, NULL, 0, 706)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (26, 26, NULL, 8, 737)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (27, 27, NULL, 0, 699)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (28, 28, NULL, 3, 648)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (29, 29, NULL, 11, 661)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (30, 30, NULL, 3, 672)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (31, 31, NULL, 25, 717)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (32, 32, NULL, 2, 693)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (33, 33, NULL, 1, 707)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (34, 34, NULL, 11, 673)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (35, 35, NULL, 18, 675)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (36, 36, NULL, 1, 678)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (37, 37, NULL, 4, 670)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (38, 38, NULL, 6, 732)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (39, 39, NULL, 1, 689)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (40, 40, NULL, 9, 669)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (41, 41, NULL, 0, 709)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (42, 42, NULL, 5, 691)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (43, 43, NULL, 19, 736)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (44, 44, NULL, 19, 677)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (45, 45, NULL, 2, 620)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (46, 46, NULL, 2, 655)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (47, 47, NULL, 14, 681)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (48, 48, NULL, 13, 678)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (49, 49, NULL, 4, 709)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (101, 1, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (102, 2, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (103, 3, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (104, 4, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (105, 5, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (106, 6, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (107, 7, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (108, 8, NULL, NULL, NULL)

INSERT [dbo].[Number] ([Id], [Number], [IsSpecial], [NotSeen], [Occurencies]) VALUES (109, 9, NULL, NULL, NULL)

