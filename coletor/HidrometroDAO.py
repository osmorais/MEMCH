IUsuarioDAOIUsuarioDAO
from ConnectionFactory import ConnectionFactory
import psycopg2
from RegistroDAO import RegistroDAO

class HidrometroDAO(IHidrometroDAO):

    def cadastrar(self,hidrometro) -> None:
        insert = "INSERT INTO HIDROMETRO (CHAVE, MODELO, ATIVO) " \
                 "VALUES (%s,%s,$s);"

        conn = ConnectionFactory();
        try:
            connection = conn.getConnection()
            cursor = connection.cursor()

            record_to_insert = (hidrometro.getChave(),hidrometro.getModelo(),
                                hidrometro.getAtivo())
            cursor.execute(insert, record_to_insert)

            connection.commit()
            #count = cursor.rowcount
            #print(count, "Record inserted successfully into mobile table")

        except (Exception, psycopg2.Error) as error:
            if (connection):
                print("Failed to insert record into mobile table", error)

        finally:
            # closing database connection.
            if (connection):
                cursor.close()
                connection.close()

    def consultar(self,hidrometro) -> None:
        select = "SELECT * FROM HIDROMETRO LIMIT 1"

        conn = ConnectionFactory();
        try:
            connection = conn.getConnection()
            cursor = connection.cursor()

            print("[INFO] Buscando no banco de dados as informacoes do hidrometro...")
            cursor.execute(select)

            reg = cursor.fetchall()
            for row in reg:
                hidrometro.setId(row[0])
                hidrometro.setIdentificador(row[1])
                hidrometro.setChave(row[2])
                hidrometro.setModelo(row[3])
                hidrometro.setAtivo(row[5])
                print("[INFO] Encontramos o cadastro do hidrometro: ")
                print("[INFO]     Id: ", row[0])
                print("[INFO]  descr: ", row[1])
                print("[INFO]  Chave: ", row[2])
                print("[INFO] Modelo: ", row[3])
                print("[INFO]  Ativo: ", row[5])

        except (Exception, psycopg2.Error) as error:
            if (connection):
                print("Falha ao recuperar registro.", error)

        finally:
            # closing database connection.
            if (connection):
                cursor.close()
                connection.close()


    def cadastrarRegistro(self,hidrometro) -> None:
        registroDAO = RegistroDAO()
        registroDAO.cadastrar(hidrometro)