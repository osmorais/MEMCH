from SensorFluxo import SensorFluxo

class Registro:

    def __init__(self):
        self.id = ""
        self.valor = 0
        self.data = ""
        self.sensor = SensorFluxo()

    def setId(self, id):
        self.id = id

    def getId(self):
        return self.id

    def setValor(self, valor):
        self.valor = valor

    def getValor(self):
        return self.valor

    def setData(self, data):
        self.data = data

    def getData(self):
        return self.data

    def registrarSensor(self):
        self.valor = self.sensor.registrar()