# MEMCH
Monitoramento de Estado de Metragem Cúbica de Hidrometro

Este projeto tem como intuito monitorar em tempo real o valor de gasto de agua, trazendo a facilidade de gerenciar e analisar esses dados via cliente Desktop.

A arquitetura é separada entre cliente, servidor e coletor, respectivamente, nas linguagens, C#, Java e Python. A comunicação entre Cliente e Servidor é feita via RESTful, ultiliza-se um sensor de fluxo de agua (modelo yf‑s201) e seus pulsos são reconhecidos, convertidos e inseridos no banco de dados via Python, configuramos o servidor Java e o coletor Python em um Raspberry 3b+, o cliente foi projetado para acessa-los via rede com o apontamento do IP pelo usuário.

O codigo do coletor foi feito para rodar continuamente, incluindo no banco de dados o registro do valor atual de tempos em tempos de acordo com o configurado, o cliente envia a solicitação para o servidor que recupera os valores do banco de dados e retorna para o cliente, fazendo possível assim a tratativas dos dados e um melhor acompanhamento dos gastos.

O projeto está em andamento e é pretendido incluir funcionalidades como emissão de relatório de acordo com o periodo desejado, configuração de novos "hidrometros"(pontos onde sensores estão alocados) na mesma rede para gerenciamento, emissão de alerta de surto (possível problema de encanamento) e de gasto excessivo.
