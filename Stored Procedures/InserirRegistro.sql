CREATE OR REPLACE FUNCTION inserirRegistro(COLETA numeric(8,3), DATACOLETA DATE, HIDROMETROCOLETA INTEGER)
RETURNS VOID AS
$$
DECLARE
	REGRAID INTEGER;
	REGRAPERIODO INTEGER;
	VALORPERIODO NUMERIC;
	REGRAVALOR NUMERIC;
	DESCRICAOREGRA VARCHAR(100);
BEGIN
	INSERT INTO REGISTRO (VALOR, DATA, HIDROMETROFK)
	VALUES (COLETA, DATACOLETA, HIDROMETROCOLETA);
	IF (SELECT COUNT(ID) FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA AND ATIVO = 1) > 0 THEN --EXISTEM REGRAS ATIVAS
		REGRAPERIODO := (SELECT PERIODO FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA);
		REGRAVALOR := (SELECT VALOR FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA);
		REGRAID := (SELECT ID FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA);
		VALORPERIODO := (SELECT SUM(VALOR) FROM REGISTRO WHERE DATA >= CURRENT_DATE - REGRAPERIODO);
		raise notice 'Valor total do periodo informado - % em % dias',VALORPERIODO,REGRAPERIODO;
		IF(VALORPERIODO > REGRAVALOR) THEN
			IF(SELECT REGRATIPOFK FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA) = 2 THEN -- REGRA DE CONSUMO
				DESCRICAOREGRA := CONCAT('ALERTA DE CONSUMO - Valor gasto no periodo: ',VALORPERIODO);
				INSERT INTO ALERTA (DESCRICAO, DATA, HIDROMETROFK, REGRAFK)
				VALUES (DESCRICAOREGRA,DATACOLETA,HIDROMETROCOLETA,REGRAID);
			ELSE
				DESCRICAOREGRA := CONCAT('ALERTA DE SURTO - O registro apresentou um consumo fora do comum estipulado.');
				INSERT INTO ALERTA (DESCRICAO, DATA, HIDROMETROFK, REGRAFK)
				VALUES (DESCRICAOREGRA,DATACOLETA,HIDROMETROCOLETA,REGRAID);
			END IF;
		END IF;
	END IF;
END;   
$$
language 'plpgsql';