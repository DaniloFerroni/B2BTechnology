use B2BSolution
go

CREATE TABLE DBO.TB_CONTATO
(
	ID_CONTATO		INT PRIMARY KEY IDENTITY,
	NOME			VARCHAR(100),
	EMAIL			VARCHAR(200),
	TELEFONE		VARCHAR(10),
	CELULAR			VARCHAR(11),
)
GO