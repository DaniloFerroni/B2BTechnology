USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_EQUIPAMENTOS_SELECIONAR]    Script Date: 11/12/2015 17:56:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_EQUIPAMENTOS_SELECIONAR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_EQUIPAMENTOS_SELECIONAR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_EQUIPAMENTOS_SELECIONAR]    Script Date: 11/12/2015 17:56:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SPR_EQUIPAMENTOS_SELECIONAR]
AS
BEGIN

	 SELECT ID_EQUIPAMENTO,
			MARCA,
			MODELO,
			NUMERO_SERIE
	   FROM TB_EQUIPAMENTOS

END
GO


