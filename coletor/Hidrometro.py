from Registro import Registro

class Hidrometro:
    def __init__(self):
        self.id = 0
        self.chave = ""
        self.modelo = ""
        self.ativo = True
        #registro = Registro()
        self.registro = Registro()
        #self.registros.append(registro)



    def setId(self,id):
        self.id = id

    def getId(self):
        return self.id

    def setChave(self, chave):
        self.chave = chave

    def getChave(self):
        return self.chave

    def setModelo(self, modelo):
        self.modelo = modelo

    def getModelo(self):
        return self.modelo

    def setAtivo(self, ativo):
        self.ativo = ativo

    def getAtivo(self):
        return self.ativo

    def setRegistro(self, registro):
        self.registro = registro

    def getRegistro(self):
        return self.registro