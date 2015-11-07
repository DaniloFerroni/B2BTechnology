CREATE TABLE DBO.TB_PRAZO_CONTRATUAL
(
	ID_PRAZO_CONTRATUAL		INT PRIMARY KEY IDENTITY,
	PERIODO					VARCHAR(100)
)

INSERT INTO TB_PRAZO_CONTRATUAL VALUES ('6 Meses')
INSERT INTO TB_PRAZO_CONTRATUAL VALUES ('12 Meses')
INSERT INTO TB_PRAZO_CONTRATUAL VALUES ('24 Meses')
INSERT INTO TB_PRAZO_CONTRATUAL VALUES ('Indetermidado')