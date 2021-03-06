USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_CLIENTE_INSERIR]    Script Date: 11/12/2015 17:53:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_CLIENTE_INSERIR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_CLIENTE_INSERIR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_CLIENTE_INSERIR]    Script Date: 11/12/2015 17:53:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SPR_CLIENTE_INSERIR]
(
	@NOME			VARCHAR	(500),
	@TP_PESSOA		VARCHAR	(2),
	@ID_ENDERECO	INT,
	@ID_CONTATO		INT,
	@FL_ATIVO		BIT,
	@DOCUMENTO		VARCHAR(14)
)
AS
BEGIN

	INSERT INTO TB_CLIENTE
	(NOME, TP_PESSOA, ID_ENDERECO, ID_CONTATO, FL_ATIVO, DOCUMENTO)
	VALUES
	(@NOME, @TP_PESSOA, @ID_ENDERECO, @ID_CONTATO, @FL_ATIVO, @DOCUMENTO)
	
	SELECT @@IDENTITY	 

END

GO


