from IRegistroDAO import IRegistroDAO
from ConnectionFactory import ConnectionFactory
import psycopg2

class RegistroDAO(IRegistroDAO):

    def cadastrar(self, hidrometro) -> None:
        #insert = "INSERT INTO REGISTRO (VALOR, DATA, HIDROMETROFK) VALUES {}"

        conn = ConnectionFactory()
        try:
            connection = conn.getConnection()
            cursor = connection.cursor()

            print("[INFO] Registrando estado do hidrometro...")
            print("[INFO]     Valor : " , round(hidrometro.registro.valor,3))
            print("[INFO]      Data : " + str(hidrometro.registro.data))
            print("[INFO] Hidrometro: " + str(hidrometro.id))

            # record_to_insert = (round(hidrometro.registro.valor,3),
            #                         str(hidrometro.registro.data),
            #                         hidrometro.id)
            #cursor.execute(insert.format(record_to_insert))

            cursor.callproc('inserirRegistro',[
                round(hidrometro.registro.valor,3),
                str(hidrometro.registro.data),
                hidrometro.id])

            connection.commit()
            existeAlertas = cursor.fetchone()
            hidrometro.setExisteAlertas(existeAlertas[0])

        except (Exception, psycopg2.Error) as error:
            if (connection):
                print("SQL Error:", error)
        finally:
            # closing database connection.
            if (connection):
                cursor.close()
                connection.close()