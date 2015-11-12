USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_VENDEDORES_INSERIR]    Script Date: 11/12/2015 17:57:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_VENDEDORES_INSERIR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_VENDEDORES_INSERIR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_VENDEDORES_INSERIR]    Script Date: 11/12/2015 17:57:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SPR_VENDEDORES_INSERIR]
(
	@ID_ENDERECO	INT,
	@ID_CONTATO		INT,
	@DOCUMENTO		VARCHAR(14),
	@COMISSAO		DECIMAL(4,2),
	@TP_VENDEDOR	INT,
	@FL_ATIVO		BIT,
	@NOME			VARCHAR(500),
	@ID_SUPERIOR	INT
)
AS
BEGIN

	INSERT INTO TB_VENDEDORES
	(ID_ENDERECO, ID_CONTATO, DOCUMENTO, COMISSAO, TP_VENDEDOR, FL_ATIVO, NOME, ID_SUPERIOR)
	VALUES
	(@ID_ENDERECO, @ID_CONTATO, @DOCUMENTO, @COMISSAO, @TP_VENDEDOR, @FL_ATIVO, @NOME, @ID_SUPERIOR)
	
	SELECT @@IDENTITY	 

END

GO


