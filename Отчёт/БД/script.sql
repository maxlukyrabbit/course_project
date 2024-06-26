
CREATE DATABASE [course_project]
 GO
 

USE [course_project]
GO
/****** Object:  Table [dbo].[access]    Script Date: 16.04.2024 20:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[access](
	[id_level] [int] IDENTITY(1,1) NOT NULL,
	[name_level] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_access] PRIMARY KEY CLUSTERED 
(
	[id_level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[logs]    Script Date: 16.04.2024 20:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logs](
	[logs_id] [int] IDENTITY(1,1) NOT NULL,
	[id_panel] [nvarchar](10) NOT NULL,
	[user_id] [int] NOT NULL,
	[initial_stage] [nvarchar](50) NOT NULL,
	[final_stage] [nvarchar](50) NOT NULL,
	[date] [datetime] NOT NULL,
	[result] [bit] NOT NULL,
	[reason] [nchar](100) NULL,
 CONSTRAINT [PK_logs] PRIMARY KEY CLUSTERED 
(
	[logs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stage_deal]    Script Date: 16.04.2024 20:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stage_deal](
	[id_deal] [nvarchar](50) NOT NULL,
	[name_stage] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_stage_deal] PRIMARY KEY CLUSTERED 
(
	[id_deal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 16.04.2024 20:45:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](100) NOT NULL,
	[name] [nvarchar](75) NOT NULL,
	[patronymic] [nvarchar](100) NOT NULL,
	[access_level] [int] NOT NULL,
	[token] [nvarchar](100) NOT NULL,
	[post] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[access] ON 

INSERT [dbo].[access] ([id_level], [name_level]) VALUES (1, N'Низкий')
INSERT [dbo].[access] ([id_level], [name_level]) VALUES (2, N'Средний')
INSERT [dbo].[access] ([id_level], [name_level]) VALUES (3, N'')
SET IDENTITY_INSERT [dbo].[access] OFF
GO
SET IDENTITY_INSERT [dbo].[logs] ON 

INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (1, N'1944102691', 1, N'C25:2', N'C25:2', CAST(N'2024-03-26T00:00:00.000' AS DateTime), 1, NULL)
INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (2, N'1944102691', 1, N'C25:2', N'C25:EXECUTING', CAST(N'2024-03-26T20:17:40.697' AS DateTime), 0, NULL)
INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (3, N'1944102691', 1, N'C25:PREPARATION', N'C25:EXECUTING', CAST(N'2024-03-28T19:52:19.137' AS DateTime), 1, NULL)
INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (5, N'1944102691', 1, N'C25:EXECUTING', N'C25:EXECUTING', CAST(N'2024-03-28T20:03:17.773' AS DateTime), 0, N'Панель находится в неподходящей стадии                                                              ')
INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (6, N'1944102691', 1, N'C25:EXECUTING', N'C25:2', CAST(N'2024-03-28T20:03:43.683' AS DateTime), 1, N'                                                                                                    ')
INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (7, N'1111111111', 1, N'C25:APOLOGY', N'C25:EXECUTING', CAST(N'2024-03-28T20:05:03.180' AS DateTime), 0, N'Панель находится в неподходящей стадии                                                              ')
INSERT [dbo].[logs] ([logs_id], [id_panel], [user_id], [initial_stage], [final_stage], [date], [result], [reason]) VALUES (8, N'1944102691', 2, N'C25:2', N'C25:EXECUTING', CAST(N'2024-03-30T16:26:03.980' AS DateTime), 0, N'Панель находится в неподходящей стадии                                                              ')
SET IDENTITY_INSERT [dbo].[logs] OFF
GO
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:1', N'Отложено')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:2', N'В ремонте')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:7', N'Готово к отправке')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:APOLOGY', N'Ошибка заведения')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:EXECUTING', N'Принята на склад')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:FINAL_INVOICE', N'Выходной контроль')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:LOSE', N'Заявка отменена')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:NEW', N'Новая заявка')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:PREPARATION', N'Проверка заявки')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:PREPAYMENT_INVOIC', N'Заявка готова к отправке')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:UC_DMZGI5', N'Паркинг')
INSERT [dbo].[stage_deal] ([id_deal], [name_stage]) VALUES (N'C25:WON', N'Заявка завершена')
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id_user], [firstname], [name], [patronymic], [access_level], [token], [post]) VALUES (1, N'Случаев', N'Максим', N'Константинович', 3, N'ылдфроапоырфвпароывраплрфыпвроаплрофыпвафыроваплрофыц', N'Мастер')
INSERT [dbo].[user] ([id_user], [firstname], [name], [patronymic], [access_level], [token], [post]) VALUES (2, N'Спиридонов', N'Евгений', N'Андреевич', 3, N'выаплоыврапошлщрываолдпролд', N'Мастер')
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[logs]  WITH CHECK ADD  CONSTRAINT [FK_logs_stage_deal] FOREIGN KEY([initial_stage])
REFERENCES [dbo].[stage_deal] ([id_deal])
GO
ALTER TABLE [dbo].[logs] CHECK CONSTRAINT [FK_logs_stage_deal]
GO
ALTER TABLE [dbo].[logs]  WITH CHECK ADD  CONSTRAINT [FK_logs_stage_deal1] FOREIGN KEY([final_stage])
REFERENCES [dbo].[stage_deal] ([id_deal])
GO
ALTER TABLE [dbo].[logs] CHECK CONSTRAINT [FK_logs_stage_deal1]
GO
ALTER TABLE [dbo].[logs]  WITH CHECK ADD  CONSTRAINT [FK_logs_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id_user])
GO
ALTER TABLE [dbo].[logs] CHECK CONSTRAINT [FK_logs_user]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_access] FOREIGN KEY([access_level])
REFERENCES [dbo].[access] ([id_level])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_access]
GO
USE [master]
GO
ALTER DATABASE course_project SET  READ_WRITE 
GO
 
