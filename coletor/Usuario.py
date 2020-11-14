class Usuario:
    def __init__(self):
        self.id = 0
        self.login = ""
        self.senha = ""
        self.email = ""

    def setId(self,id):
        self.id = id

    def getId(self,id):
        self.id = id
    
    def setLogin(self,login):
        self.login = login

    def getLogin(self,login):
        self.login = login

    def setSenha(self,senha):
        self.senha = senha

    def getSenha(self,senha):
        self.senha = senha
    
    def setEmail(self,email):
        self.email = email

    def getEmail(self,email):
        self.email = email