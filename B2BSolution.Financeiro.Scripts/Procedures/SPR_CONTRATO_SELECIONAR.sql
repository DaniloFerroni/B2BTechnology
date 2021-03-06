USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_CONTRATO_SELECIONAR]    Script Date: 11/12/2015 17:55:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SPR_CONTRATO_SELECIONAR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SPR_CONTRATO_SELECIONAR]
GO

USE [B2BSolution]
GO

/****** Object:  StoredProcedure [dbo].[SPR_CONTRATO_SELECIONAR]    Script Date: 11/12/2015 17:55:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SPR_CONTRATO_SELECIONAR]
(
	@DOCUMENTO		VARCHAR(14)  = NULL,
	@NOME			VARCHAR(500) = NULL
)
AS
BEGIN

if(@DOCUMENTO is not null)
	set @NOME = null

	 SELECT CONTRATO.ID_CONTRATO,
			CONTRATO.VL_TARIFA_LOCAL,
			CONTRATO.VL_TARIFA_LDN,
			CONTRATO.VL_TARIFA_VC1,
			CONTRATO.VL_TARIFA_VC2,
			CONTRATO.VL_TARIFA_VC3,
			CONTRATO.VL_CONSUMO_MINIMO,
			CONTRATO.DS_CADENCIA_FIXA,
			CONTRATO.DS_CADENCIA_MOVEL,
			CONTRATO.DT_CONTRATO,
			CONTRATO.DIA_VENCIMENTO,
			CONTRATO.VL_INSTALACAO,
			CONTRATO.ID_PRAZO_CONTRATUAL,
			CONTRATO.ID_VENDEDOR,
			CONTRATO.VL_MENSALIDADE,
			
			CLIENTE.ID_CLIENTE,
			CLIENTE.DOCUMENTO,
			CLIENTE.NOME,
			CLIENTE.TP_PESSOA,
			CLIENTE.ID_ENDERECO,
			CLIENTE.ID_CONTATO,
			CLIENTE.FL_ATIVO,
			
			EQUIPAMENTO.ID_EQUIPAMENTO,
			EQUIPAMENTO.MARCA,
			EQUIPAMENTO.MODELO,
			EQUIPAMENTO.NUMERO_SERIE,
			
			E.ID_ENDERECO,
			E.RUA,
			E.NUMERO,
			E.COMPLEMENTO,
			E.CEP,
			E.BAIRRO,
			E.CIDADE,
			E.ESTADO,
	
			CO.ID_CONTATO,
			CO.NOME NOME_CONTATO,
			CO.EMAIL,
			CO.TELEFONE,
			CO.CELULAR,
			
			V.ID_VENDEDOR AS ID_VENDEDOR_V,
			V.ID_ENDERECO AS ID_ENDERECO_VENDENDOR,
			V.ID_CONTATO AS ID_CONTATO_VENDEDOR,
			V.DOCUMENTO AS DOCUMENTO_VENDEDOR,
			V.COMISSAO AS COMISSAO_VENDEDOR,
			V.TP_VENDEDOR ,
			V.FL_ATIVO AS FL_ATIVO_VENDEDOR,
			V.NOME AS NOME_VENDEDOR,
			V.ID_SUPERIOR
	   FROM TB_CONTRATO CONTRATO
			INNER JOIN TB_CLIENTE CLIENTE ON
					   CONTRATO.ID_CLIENTE = CLIENTE.ID_CLIENTE
			LEFT JOIN TB_EQUIPAMENTOS EQUIPAMENTO ON
					   CONTRATO.ID_EQUIPAMENTO = EQUIPAMENTO.ID_EQUIPAMENTO
		    INNER JOIN TB_ENDERECO E ON
					   CLIENTE.ID_ENDERECO = E.ID_ENDERECO
		    INNER JOIN TB_CONTATO CO ON
					   CLIENTE.ID_CONTATO = CO.ID_CONTATO
		     LEFT JOIN TB_VENDEDORES V ON
					   CONTRATO.ID_VENDEDOR = V.ID_VENDEDOR
	  WHERE (
				(CLIENTE.DOCUMENTO = ISNULL(@DOCUMENTO, CLIENTE.DOCUMENTO)) 
				AND (@NOME IS NULL OR (CLIENTE.NOME LIKE '%' + @NOME + '%'))
			)

END
GO


