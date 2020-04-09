from IRegistroDAO import IRegistroDAO
from ConnectionFactory import ConnectionFactory
import psycopg2

class RegistroDAO(IRegistroDAO):

    def cadastrar(self, hidrometro) -> None:
        #insert = "INSERT INTO REGISTRO (VALOR, DATA, HIDROMETROFK) VALUES (%s,%s,$s)"
        insert = "INSERT INTO REGISTRO (VALOR, DATA, HIDROMETROFK) VALUES {}"

        conn = ConnectionFactory()
        try:
            connection = conn.getConnection()
            cursor = connection.cursor()

            print("REGISTRO DAO")
            print("valor : " , round(hidrometro.registro.valor,3))
            print("data: " + str(hidrometro.registro.data))
            print("hidrometro: " + str(hidrometro.id))

            # record_to_insert = (round(hidrometro.registro.valor,3),
            #                         str(hidrometro.registro.data),
            #                         hidrometro.id)
            #cursor.execute(insert.format(record_to_insert))

            cursor.callproc('inserirRegistro',[
                round(hidrometro.registro.valor,3),
                str(hidrometro.registro.data),
                hidrometro.id])

            connection.commit()
            #count = cursor.rowcount
            #return (count, "Record inserted successfully into mobile table")
        except (Exception, psycopg2.Error) as error:
            if (connection):
                print("SQL Error:", error)
        finally:
            # closing database connection.
            if (connection):
                cursor.close()
                connection.close()