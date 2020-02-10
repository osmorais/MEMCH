Monitoramento de Estado de Metragem C�bica de Hidrometro

Este projeto tem como intuito monitorar em tempo real o valor de gasto de agua, trazendo a facilidade de gerenciar e analisar esses dados via cliente Desktop.

A arquitetura � separada entre cliente, servidor e coletor, respectivamente, nas linguagens, C#, Java e Python.

O codigo do coletor foi feito para rodar continuamente, incluindo no banco de dados o registro do valor atual de tempos em tempos de acordo com o configurado, o cliente envia a solicita��o para o servidor que recupera os valores do banco de dados e retorna para o cliente, fazendo poss�vel assim a tratativas dos dados e um melhor acompanhamento dos gastos.

O projeto est� em andamento e � pretendido incluir funcionalidades como emiss�o de relat�rio de acordo com o periodo desejado, configura��o de novos "hidrometros"(pontos onde sensores est�o alocados) na mesma rede para gerenciamento, emiss�o de alerta de surto (poss�vel problema de encanamento) e de gasto excessivo.