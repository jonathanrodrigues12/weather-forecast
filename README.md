# Teste AeC

Este App faz consulta de previsão do tempo de uma determinada cidade e aeroporto

## Índice

- [Instalação](#instalação)
- [Acesso](#Acesso)
- [Observações](#Observações)
- [Contato](#Contato)

## Instalação
1. Clone o Repositório:
`git clone https://github.com/seu-usuario/seu-projeto.git`

2. Altere as variaveis de ambiente
	2.1 [docker-compose.yml](docker-compose.yml)
		SA_PASSWORD #para uma senha de sua prefêrencia, essa tag é responsável por criar uma senha para seu banco de dados
		- DB_HOST=Your_Host   # nome do host atribuido para o container do SqlServer
		- DB_PORT=Your_Port #Porta TCP
		- DB_DATABASE=AeC #Nome da sua base dados
		- DB_USERNAME=sa #defina um usuário
		- DB_PASSWORD= #defina um usuário
	2.2 [App\appsettings.json](appsettings.json)
		Altere a string de conexão de acordo com os dados escolhidos no  [docker-compose.yml](docker-compose.yml)
3. Builde o container
`docker-compose up`

## Acesso 
Para Acessar a documentação Swagger 
[http://localhost:8090/swagger/index.html](http://localhost:8090/swagger/index.html "http://localhost:8090/swagger/index.html")

##Observações

A Brasil API não fornece uma lista dos Codigos ICAO (International Civil Aviation Organization), para que seja possivel a obtenção destes códigos, criei um seed no arquivo de contexto [Repo\ContextApp.cs](ContextApp.cs), e uma rota espessifica no Controller [App\Controllers\AirportController.cs](AirportController), onde lista esses códigos obtidos no site da ANAC (Agencia de Aviação Civil)
Outro sim, a Brasil API encontra-se com bug, visto que quando buscamos por uma localidade no endpoint [https://brasilapi.com.br/api/cptec/v1/cidade/{cityName}] Busca localidades, o inserir mais de 5 caracteres no campo cityName, a api retorna com o seguinte erro:


    {
        "message": "Erro ao buscar informações sobre cidade",
        "type": "city_error",
        "name": "CITY_INTERNAL"
    }

o mesmo se encontra gravando na tabela  de logs.
Não obtive tempo hábil necessário para implementar um teste unitários desejados no teste
Antemão eu já agradeço oportunidade e a atenção dispensada

##Contato
Jonathan Rodrigues
Desenvolvedor .NET Core
Tel.: +55(15) 99630-5590
WhatsApp.: +55(15) 99630-5590
Linkedin: [https://www.linkedin.com/in/jonathanrodrigues12/](jonathanrodrigues12)