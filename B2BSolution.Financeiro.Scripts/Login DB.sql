
use B2BSolution
go

CREATE LOGIN b2btecnology
    WITH PASSWORD = '#b2b2015financeiro';
GO

CREATE USER b2btecnology FOR LOGIN b2btecnology;
GO