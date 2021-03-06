USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_ENDERECO_ALTERAR]    Script Date: 11/12/2015 17:55:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_ENDERECO_ALTERAR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_ENDERECO_ALTERAR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_ENDERECO_ALTERAR]    Script Date: 11/12/2015 17:55:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SPR_ENDERECO_ALTERAR]
(
	@ID_ENDERECO	INT,
	@RUA			VARCHAR(200),
	@NUMERO			VARCHAR(6),
	@COMPLEMENTO	VARCHAR(50) = NULL,
	@CEP			VARCHAR(8),
	@BAIRRO			VARCHAR(100),
	@CIDADE			VARCHAR(50),
	@ESTADO			VARCHAR(2)
)
AS
BEGIN

	UPDATE TB_ENDERECO
	   SET RUA = @RUA,
		   NUMERO = @NUMERO,
		   COMPLEMENTO = @COMPLEMENTO,
		   CEP = @CEP,
		   BAIRRO = @BAIRRO,
		   CIDADE = @CIDADE,
		   ESTADO = @ESTADO
	 WHERE ID_ENDERECO = @ID_ENDERECO
	 
END
GO


