-- ======================================================================================
-- Create SQL Login template for Azure SQL Database and Azure SQL Data Warehouse Database
-- ======================================================================================

CREATE LOGIN mvclogin
	WITH PASSWORD = 'T0do1234!@#$asdrinvlk' 
GO

USE SportSport;  
CREATE USER mvclogin FOR LOGIN mvclogin
    WITH DEFAULT_SCHEMA = dbo;  
GO 


EXEC sp_addrolemember 'public', 'mvclogin';
