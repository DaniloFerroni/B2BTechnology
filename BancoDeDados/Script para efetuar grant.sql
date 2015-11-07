USE B2BSolution
GO

SELECT 'GRANT EXECUTE ON ' + NAME + ' TO b2bsolution' + CHAR(13) + CHAR(10) + 'GO' + CHAR(13) + CHAR(10) + CHAR(13) + CHAR(10)
  FROM SYS.objects 
 WHERE TYPE = 'P' AND 
	   name LIKE '%SPR%'