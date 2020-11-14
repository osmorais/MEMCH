from IUsuarioDAO import IUsuarioDAO
from ConnectionFactory import ConnectionFactory
import psycopg2

class UsuarioDAO(IUsuarioDAO):

    def consultar(self, hidrometro, usuario) -> None:
        select = "SELECT usuario.id, usuario.Login, usuario.Senha, usuario.Email FROM USUARIO "
        select = select + "INNER JOIN CONEXAO conexao on conexao.usuariofk = usuario.id "
        select = select + "INNER JOIN HIDROMETRO hidrometro on hidrometro.id = conexao.hidrometrofk "
        select = select + "WHERE hidrometro.id = " + str(hidrometro.getId()) + " LIMIT 1"

        conn = ConnectionFactory()
        try:
            connection = conn.getConnection()
            cursor = connection.cursor()

            print("[INFO] Resgatando email do usuario...")
            cursor.execute(select)

            reg = cursor.fetchall()
            for row in reg:
                usuario.setId(row[0])
                usuario.setLogin(row[1])
                usuario.setSenha(row[2])
                usuario.setEmail(row[3])
                print("[INFO] Enviando alerta para: " + str(row[3]))

        except (Exception, psycopg2.Error) as error:
            if (connection):
                print("Falha ao recuperar registro.", error)

        finally:
            # closing database connection.
            if (connection):
                cursor.close()
                connection.close()