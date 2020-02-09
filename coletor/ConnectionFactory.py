import psycopg2

class ConnectionFactory :

    def getConnection(self):
        try:
            connection = psycopg2.connect(user="sys",
                                          password="sys",
                                          host="127.0.0.1",
                                          port="5432",
                                          database="memch")

            cursor = connection.cursor()
            # Print PostgreSQL Connection properties
            #print(connection.get_dsn_parameters(), "\n")

            return connection
        except (Exception, psycopg2.Error) as error:
            print("Error while connecting to PostgreSQL", error)
        #finally:
        #    # closing database connection.
        #    if (connection):
        #        cursor.close()
        #        connection.close()
        #        print("PostgreSQL connection is closed")