USE [B2BSolution]
GO

/****** Object:  Table [dbo].[TB_TIPO_VENDEDORES]    Script Date: 11/12/2015 18:00:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TB_TIPO_VENDEDORES]') AND type in (N'U'))
DROP TABLE [dbo].[TB_TIPO_VENDEDORES]
GO

USE [B2BSolution]
GO

/****** Object:  Table [dbo].[TB_TIPO_VENDEDORES]    Script Date: 11/12/2015 18:00:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_TIPO_VENDEDORES](
	[ID_TIPO_VENDEDOR] [int] IDENTITY(1,1) NOT NULL,
	[DS_VENDEDOR] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TIPO_VENDEDOR] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


INSERT INTO TB_TIPO_VENDEDORES (DS_VENDEDOR) VALUES ('VENDEDOR')
INSERT INTO TB_TIPO_VENDEDORES (DS_VENDEDOR) VALUES ('CANAL')