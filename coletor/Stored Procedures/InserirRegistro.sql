
CREATE OR REPLACE FUNCTION inserirRegistro(coleta numeric(8,3), datacoleta DATE, hidrometrocoleta INTEGER)
RETURNS VOID AS
$$
DECLARE 
REGRAID INTEGER,
REGRAPERIODO INTEGER, 
VALORPERIODO NUMERIC,
REGRAVALOR NUMERIC;
	BEGIN
		INSERT INTO REGISTRO (VALOR, DATA, HIDROMETROFK) 
		VALUES (coleta, datacoleta, hidrometrocoleta);

		IF (SELECT REGRATIPOFK FROM REGRA WHERE HIDROMETROFK = hidrometrocoleta) <> 3 THEN --REGRA DE CONSUMO OU DE SURTO
				REGRAPERIODO := (SELECT PERIODO FROM REGRA WHERE HIDROMETROFK = hidrometrocoleta); -- PERIODO valor em meses
				REGRAVALOR := (SELECT VALOR FROM REGRA WHERE HIDROMETROFK = hidrometrocoleta);-- VALOR LIMITE
				REGRAID := (SELECT ID FROM REGRA WHERE HIDROMETROFK = hidrometrocoleta); 
				VALORPERIODO : (SELECT SUM(VALOR) FROM REGISTRO WHERE DATA >= CURRENT_DATE - (REGRAPERIODO * 30));

				IF(VALORPERIODO > REGRAVALOR) THEN
					IF(SELECT REGRATIPOFK FROM REGRA WHERE HIDROMETROFK = hidrometrocoleta) = 2 THEN -- REGRA DE CONSUMO
						INSERT INTO ALERTA 
						(DESCRICAO, 
						DATA, HIDROMETROFK, REGRAFK)
						VALUES
						(CONCAT('ALERTA DE CONSUMO - O registro do dia ',datacoleta,' ultrapassou o limite de coleta em ',(coleta)-COLETAVALOR,'.')
						,datacoleta,hidrometrocoleta,REGRAID);
					ELSE -- ALERTA DE SURTO
						INSERT INTO ALERTA 
						(DESCRICAO, 
						DATA, HIDROMETROFK, REGRAFK)
						VALUES
						(CONCAT('ALERTA DE SURTO - O registro do dia ',datacoleta,' apresentou um consumo fora do comum estipulado.')
						,datacoleta,hidrometrocoleta,REGRAID);
					END IF;
				END IF;
			END IF;
        END IF;
     END;
$$
language 'plpgsql';