USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_CLIENTE_ALTERAR]    Script Date: 11/12/2015 17:52:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_CLIENTE_ALTERAR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_CLIENTE_ALTERAR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_CLIENTE_ALTERAR]    Script Date: 11/12/2015 17:52:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SPR_CLIENTE_ALTERAR]
(
	@ID_CLIENTE		INT,
	@NOME			VARCHAR	(500),
	@TP_PESSOA		VARCHAR	(2),
	@ID_ENDERECO	INT,
	@ID_CONTATO		INT,
	@FL_ATIVO		BIT
)
AS
BEGIN

	UPDATE TB_CLIENTE
	   SET NOME = @NOME,
		   TP_PESSOA = @TP_PESSOA,
		   ID_ENDERECO = @ID_ENDERECO,
		   ID_CONTATO = @ID_CONTATO,
		   FL_ATIVO = @FL_ATIVO	   
	 WHERE ID_CLIENTE = @ID_CLIENTE
	 
END

GO


