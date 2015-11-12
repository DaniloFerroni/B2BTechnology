USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_EQUIPES_INSERIR]    Script Date: 11/12/2015 17:56:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_EQUIPES_INSERIR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_EQUIPES_INSERIR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_EQUIPES_INSERIR]    Script Date: 11/12/2015 17:56:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SPR_EQUIPES_INSERIR]
(
	@ID_VENDEDOR	INT,
	@ID_CANAL		INT
)
AS
BEGIN

	INSERT INTO TB_EQUIPES
	(ID_VENDEDOR, ID_CANAL)
	VALUES
	(@ID_VENDEDOR, @ID_CANAL)
	
	SELECT @@IDENTITY	 

END

GO


