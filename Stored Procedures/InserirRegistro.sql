CREATE OR REPLACE FUNCTION inserirRegistro(COLETA numeric(8,3), DATACOLETA DATE, HIDROMETROCOLETA INTEGER)
RETURNS VOID AS
$$
DECLARE
	VALORPERIODO NUMERIC;
	VALORINICIOPERIODO NUMERIC;
	VALORFIMPERIODO NUMERIC;
	DESCRICAOREGRA VARCHAR(100);

	TuplaRegra RECORD;
	cursorRegra cursor(hidrometroid integer) 
		 for select ID, PERIODO, VALOR, dt_inicio_periodo
		 from REGRA
		 where HIDROMETROFK = hidrometroid;
BEGIN
	IF ((SELECT ATIVO FROM HIDROMETRO WHERE ID = HIDROMETROCOLETA) = 1) THEN
	
		INSERT INTO REGISTRO (VALOR, DATA, HIDROMETROFK)
		VALUES (COLETA, DATACOLETA, HIDROMETROCOLETA);

		IF (SELECT COUNT(ID) FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA AND ATIVO = 1) > 0 THEN --EXISTEM REGRAS ATIVAS

			OPEN cursorRegra(HIDROMETROCOLETA);

			LOOP
				FETCH cursorRegra INTO TuplaRegra;

				exit when not found;

				--Caso o periodo tenha passado, considerar o novo periodo de acordo com a regra;
				IF ((TuplaRegra.dt_inicio_periodo + TuplaRegra.PERIODO) <  NOW()) THEN
					UPDATE REGRA SET dt_inicio_periodo = now() WHERE HIDROMETROFK = HIDROMETROCOLETA AND TuplaRegra.ID = ID;
					TuplaRegra.dt_inicio_periodo := NOW();
				END IF;

				VALORINICIOPERIODO := (SELECT MIN(VALOR) FROM REGISTRO WHERE DATA BETWEEN TuplaRegra.dt_inicio_periodo AND (TuplaRegra.dt_inicio_periodo + TuplaRegra.PERIODO));
				VALORFIMPERIODO := (SELECT MAX(VALOR) FROM REGISTRO WHERE DATA BETWEEN TuplaRegra.dt_inicio_periodo AND (TuplaRegra.dt_inicio_periodo + TuplaRegra.PERIODO));
				--raise notice 'Valor total do periodo informado - % em % dias',VALORPERIODO,TuplaRegra.PERIODO;

				VALORPERIODO := VALORFIMPERIODO - VALORINICIOPERIODO;

				IF(VALORPERIODO > TuplaRegra.Valor) THEN
					IF(SELECT REGRATIPOFK FROM REGRA WHERE HIDROMETROFK = HIDROMETROCOLETA LIMIT 1) = 2 THEN -- REGRA DE CONSUMO
						DESCRICAOREGRA := CONCAT('Valor gasto no periodo: ',VALORPERIODO);
						INSERT INTO ALERTA (DESCRICAO, DATA, HIDROMETROFK, REGRAFK, REGRA)
						VALUES (DESCRICAOREGRA,DATACOLETA,HIDROMETROCOLETA,TuplaRegra.ID, CONCAT('Consumo (',TuplaRegra.PERIODO,' dias) - Valor Maximo: ',cast(TuplaRegra.Valor as varchar(100))));
					ELSE
						DESCRICAOREGRA := CONCAT('O registro apresentou um consumo fora do comum estipulado.');
						INSERT INTO ALERTA (DESCRICAO, DATA, HIDROMETROFK, REGRAFK, REGRA)
						VALUES (DESCRICAOREGRA,DATACOLETA,HIDROMETROCOLETA,TuplaRegra.ID, CONCAT('Surto (',TuplaRegra.PERIODO,' dias) - Valor Maximo: ',cast(TuplaRegra.Valor as varchar(100))));
					END IF;
				END IF;
				
			END LOOP;
		END IF;
	END IF;
END;   
$$
language 'plpgsql';