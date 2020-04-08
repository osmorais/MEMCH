from Hidrometro import Hidrometro
from datetime import date
from HidrometroDAO import HidrometroDAO
import time

hidrometroDAO = HidrometroDAO()
hidrometro = Hidrometro()

hidrometroDAO.consultar(hidrometro)

inicioTimer = time.time()

while True :
    hidrometro.registro.registrarSensor()
    hidrometro.registro.setData(date.today())

    if time.time() - inicioTimer > 30:
        print("30 sec")
        inicioTimer = time.time()
        hidrometroDAO.cadastrarRegistro(hidrometro)


