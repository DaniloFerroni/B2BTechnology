
use B2BSolution
go

CREATE LOGIN b2bsolution
    WITH PASSWORD = '#b2b2015financeiro';
GO

CREATE USER b2bsolution FOR LOGIN b2bsolution;
GO