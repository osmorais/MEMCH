from Hidrometro import Hidrometro
from datetime import date
from HidrometroDAO import HidrometroDAO
import time, datetime
from smtplib import SMTP_SSL as SMTP
from email.MIMEText import MIMEText

SMTPserver    = 'smtp-mail.outlook.com'

sender        = 'osmardemoraisjunior@hotmail.com'
destination   = ['osmorais5@gmail.com']
USERNAME      = "osmardemoraisjunior@hotmail.com"
PASSWORD      = "68433212tenaz"
subject       = "ALERTA! - MEMCH - Monitoramento de estado de metragem cubica de hidrometro"

hidrometroDAO = HidrometroDAO()
hidrometro = Hidrometro()

hidrometroDAO.consultar(hidrometro)

inicioTimer = time.time()

while True :
    hidrometro.registro.registrarSensor()
    hidrometro.registro.setData(date.today())

    if time.time() - inicioTimer > 10:
        print("\n\n...[INFO] Reiniciando o processo...\n\n")
        inicioTimer = time.time()
        hidrometroDAO.cadastrarRegistro(hidrometro)

        if(hidrometro.existeAlertas == 1)
            print "[INFO] Foi encontrado um alerta de acordo com o limite estabelecido.."
            print "[INFO] Enviando e-mail de notificação.."
            # subject= "Seu gasto de agua ultrapassou o valor delimitado: " + str(hidrometro.registro.valor)


            message= "\n\nOlá, tudo bem? Esperamos que sim =)\n"
            message = message + "\nConforme o monitoramento do seu gasto de agua, 
            message = message + "indentificamos um consumo além do limite "
            message = message + "estipulado em umas das regras configuradas,\n"
            message = message + "\nSegue algumas informações sobre esse registro abaixo:\n"
            message = message + "\n     Data do registro: " + hidrometro.registro.data
            message = message + "\n     Valor gasto: " + hidrometro.registro.valor
            message = message + "\n     Hidrometro: " + hidrometro.identificador
            message = message + "\n\nPara mais informações, por gentileza acesse seu painel de controle MEMCH e entre na opção Alertas...\n"
            message = message + "\nAtenciosamente,\nSeu medidor de gasto de Agua..."
            message = message + "\n\n\n\n\n\nMEMCH - Monitoramento de Estado de Metragem Cúbica\n"
            message = message + "UMC - Universidade de Mogi das Cruzes\n"
            message = message + "Projeto de Final de Curso - 2020"
            sendMail(message)



def sendMail(content):
    try:
        msg = MIMEText(content, text_subtype)
        msg['Subject']= subject
        msg['From']   = sender 

        conn = SMTP(SMTPserver)
        conn.set_debuglevel(False)
        conn.login(USERNAME, PASSWORD)
        try:
            conn.sendmail(sender, destination, msg.as_string())
        finally:
            conn.close()

    except Exception:
        sys.exit( "mail failed; %s" % str(exc) ) # give a error message