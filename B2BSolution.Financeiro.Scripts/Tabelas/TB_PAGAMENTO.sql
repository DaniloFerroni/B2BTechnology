USE [B2BSolution]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PAGAMENTO_CONTRATO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TB_PAGAMENTO]'))
ALTER TABLE [dbo].[TB_PAGAMENTO] DROP CONSTRAINT [FK_PAGAMENTO_CONTRATO]
GO

USE [B2BSolution]
GO

/****** Object:  Table [dbo].[TB_PAGAMENTO]    Script Date: 11/12/2015 18:00:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TB_PAGAMENTO]') AND type in (N'U'))
DROP TABLE [dbo].[TB_PAGAMENTO]
GO

USE [B2BSolution]
GO

/****** Object:  Table [dbo].[TB_PAGAMENTO]    Script Date: 11/12/2015 18:00:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_PAGAMENTO](
	[ID_PAGAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[DT_PAGAMENTO] [datetime] NULL,
	[VL_GASTO] [decimal](18, 2) NULL,
	[VL_PAGO] [decimal](18, 2) NULL,
	[ID_CONTRATO] [int] NULL,
	[FL_PAGO] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PAGAMENTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[TB_PAGAMENTO]  WITH CHECK ADD  CONSTRAINT [FK_PAGAMENTO_CONTRATO] FOREIGN KEY([ID_CONTRATO])
REFERENCES [dbo].[TB_CONTRATO] ([ID_CONTRATO])
GO

ALTER TABLE [dbo].[TB_PAGAMENTO] CHECK CONSTRAINT [FK_PAGAMENTO_CONTRATO]
GO


