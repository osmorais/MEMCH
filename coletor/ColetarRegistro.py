from Hidrometro import Hidrometro
from datetime import date
from HidrometroDAO import HidrometroDAO
import time, datetime

from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText
import smtplib

def sendMail(content):
    msg = MIMEMultipart()
    
    msg.attach(MIMEText(content, 'plain'))
        
    server = smtplib.SMTP('smtp.gmail.com: 587')
    server.starttls()

    password = "68433212tenaz"
    msg['From'] = "osmorais5@gmail.com"
    msg['To'] = "osmorais5@gmail.com"
    msg['Subject'] = "ALERTA! - MEMCH - Monitoramento de estado de metragem cubica de hidrometro"

    server.login(msg['From'], password)
    server.sendmail(msg['From'], msg['To'], msg.as_string())
    server.quit()

hidrometroDAO = HidrometroDAO()
hidrometro = Hidrometro()

hidrometroDAO.consultar(hidrometro)

inicioTimer = time.time()

while True :
    hidrometro.registro.registrarSensor()
    hidrometro.registro.setData(date.today())

    if time.time() - inicioTimer > 10:
        print("\n\n...[INFO] processando...\n\n")
        inicioTimer = time.time()
        hidrometroDAO.cadastrarRegistro(hidrometro)

        if hidrometro.existeAlertas == 1:
            print ("[INFO] Foi encontrado um alerta de acordo com o limite estabelecido..")
            print ("[INFO] Enviando e-mail de notificação..")
            # subject= "Seu gasto de agua ultrapassou o valor delimitado: " + str(hidrometro.registro.valor)


            message= "\n\nOlá, tudo bem? Esperamos que sim =)\n"
            message = message + "\nConforme o monitoramento do seu gasto de agua, " 
            message = message + "indentificamos um consumo além do limite "
            message = message + "estipulado em umas das regras configuradas,\n"
            message = message + "\nSegue algumas informações sobre esse registro:\n"
            message = message + "\n     Data do registro: " + str(hidrometro.registro.data)
            message = message + "\n     Valor gasto: " + str(hidrometro.registro.valor)
            message = message + "\n     Hidrometro: " + str(hidrometro.identificador)
            message = message + "\n\nPara mais informações, por gentileza acesse seu painel de controle MEMCH e entre na opção Alertas...\n"
            message = message + "\nAtenciosamente,\nSeu medidor de gasto de Agua..."
            message = message + "\n\nMEMCH - Monitoramento de Estado de Metragem Cúbica\n"
            message = message + "UMC - Universidade de Mogi das Cruzes\n"
            message = message + "Projeto de Final de Curso - 2020"
            sendMail(message)