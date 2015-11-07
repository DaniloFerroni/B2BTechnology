USE B2BSOLUTION
GO

IF EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'SPR_CONTRATO_INSERIR')
	DROP PROC DBO.SPR_CONTRATO_INSERIR
GO

CREATE PROC DBO.SPR_CONTRATO_INSERIR
(
	@ID_CLIENTE			int,
	@ID_EQUIPAMENTO		int = NULL,
	@VL_TARIFA_LOCAL	DECIMAL(18,2),
	@VL_TARIFA_LDN		DECIMAL(18,2),
	@VL_TARIFA_VC1		DECIMAL(18,2),
	@VL_TARIFA_VC2		DECIMAL(18,2),
	@VL_TARIFA_VC3		DECIMAL(18,2),
	@VL_CONSUMO_MINIMO	decimal(18,2),
	@DS_CADENCIA_FIXA	VARCHAR(6),
	@DS_CADENCIA_MOVEL	VARCHAR(6),
	@DT_CONTRATO		datetime,
	@DIA_VENCIMENTO		int,
	@VL_INSTALACAO		decimal(18,2)  = NULL,
	@ID_PRAZO_CONTRATUAL INT,
	@ID_VENDEDOR		 INT
)
AS
BEGIN

	INSERT INTO TB_CONTRATO
	(ID_CLIENTE, ID_EQUIPAMENTO, VL_TARIFA_LOCAL, VL_TARIFA_LDN, VL_TARIFA_VC1, VL_TARIFA_VC2, VL_TARIFA_VC3, VL_CONSUMO_MINIMO, DS_CADENCIA_FIXA, DS_CADENCIA_MOVEL, DT_CONTRATO, DIA_VENCIMENTO, VL_INSTALACAO, ID_PRAZO_CONTRATUAL, ID_VENDEDOR)
	VALUES
	(@ID_CLIENTE, @ID_EQUIPAMENTO, @VL_TARIFA_LOCAL, @VL_TARIFA_LDN, @VL_TARIFA_VC1, @VL_TARIFA_VC2, @VL_TARIFA_VC3, @VL_CONSUMO_MINIMO, @DS_CADENCIA_FIXA, @DS_CADENCIA_MOVEL, @DT_CONTRATO, @DIA_VENCIMENTO, @VL_INSTALACAO, @ID_PRAZO_CONTRATUAL, @ID_VENDEDOR)
	
	SELECT @@IDENTITY	 

END
GO