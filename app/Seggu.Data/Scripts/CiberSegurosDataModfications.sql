﻿USE CiberSeguros
GO

IF NOT EXISTS (SELECT * FROM CiberSeguros.dbo.COMPAÑIAS where CODIGO = 0)
BEGIN
	INSERT INTO CiberSeguros.dbo.COMPAÑIAS (ACTIVA, AGENTE, CODIGO, ELIMINADA, LIQ_BANCARIA, LIQ_PORDISK, NOMBRE, TELEFONO1, MAILEJ)
	VALUES (1, 1, 0, 0, 0, 0, 'DUMMY', '', '')
END
GO

SELECT cr.COD_CIA, cr.COD_RIES, cr.NOM_ENCIA, cr.NOM_PLAN, cr.NOM_RIES, cr.Refacturacion, cr.TXT_LINEA1, cr.TXT_LINEA2
INTO #ExistingCiaRiesgos
FROM CIA_RIESGO cr

DELETE FROM CIA_RIESGO
GO

INSERT INTO CIA_RIESGO (CODIGO, COD_CIA, COD_RIES, NOM_ENCIA, NOM_PLAN, NOM_RIES, Refacturacion, TXT_LINEA1, TXT_LINEA2)
SELECT 
	ROW_NUMBER() OVER (ORDER BY R.CODIGO, C.CODIGO) CODIGO, 
	C.CODIGO COD_CIA, 
	R.CODIGO COD_RIES, 
	ISNULL(T.NOM_ENCIA, R.NOMBRE) NOM_ENCIA, 
	ISNULL(T.NOM_PLAN, R.NOMBRE) NOM_PLAN, 
	ISNULL(T.NOM_RIES, R.NOMBRE) NOM_RIES, 
	ISNULL(T.Refacturacion, 0) Refacturacion, 
	ISNULL(T.TXT_LINEA1, '') TXT_LINEA1, 
	ISNULL(T.TXT_LINEA2, '') TXT_LINEA2
FROM RIESGO R
CROSS JOIN COMPAÑIAS C
LEFT JOIN #ExistingCiaRiesgos T ON R.codigo = T.COD_RIES AND C.CODIGO = T.COD_CIA