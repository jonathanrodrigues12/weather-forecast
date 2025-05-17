# 🌦️ Previsão do Tempo - Aplicativo .NET

**Autor:** Jonathan Rodrigues

## 📘 Visão Geral

Este aplicativo em .NET permite consultar a previsão do tempo para uma cidade ou aeroporto específicos. Ele utiliza APIs externas para obter dados meteorológicos atualizados e apresenta essas informações de forma clara e acessível.

## 🚀 Funcionalidades

- Consulta de previsão do tempo por cidade ou código de aeroporto.
- Interface amigável para exibição das informações meteorológicas.
- Integração com APIs confiáveis para obtenção de dados atualizados.

## 🛠️ Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado na máquina.
- Docker e Docker Compose (opcional, para execução via containers).
- Chave de API válida para o serviço de previsão do tempo utilizado.

## 📦 Instalação

1. **Clone o repositório:**

```bash
git clone https://github.com/jonathanrodrigues12/weather-forecast.git
```

2. **Configure as variáveis de ambiente:**

Crie um arquivo `.env` na raiz do projeto com a seguinte variável:

```env
API_KEY=SuaChaveDeAPI
```

3. **Execute o aplicativo:**

- Via Docker:

```bash
docker-compose up --build
```

- Ou diretamente com o .NET CLI:

```bash
dotnet run --project App
```

## 🧪 Uso

Após iniciar o aplicativo, acesse `http://localhost:5000` em seu navegador. Utilize a interface para inserir o nome de uma cidade ou o código de um aeroporto e visualizar a previsão do tempo correspondente.

## 📝 Observações

- Certifique-se de que a chave de API fornecida seja válida e tenha permissões adequadas para acessar os dados meteorológicos.
- O aplicativo está configurado para rodar na porta 5000 por padrão. Caso essa porta esteja em uso, ajuste as configurações conforme necessário.

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias e correções.

## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
