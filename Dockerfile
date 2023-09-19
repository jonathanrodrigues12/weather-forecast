# Use a imagem base do SDK para construir o aplicativo
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Copie o código-fonte para o contêiner
WORKDIR /App
COPY . .

# Restaurar as dependências e construir o aplicativo
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Imagem de estágio de execução
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /App
COPY --from=build /App/out ./

# Expor a porta 80
EXPOSE 80

# Iniciar o aplicativo
ENTRYPOINT ["dotnet", "App.dll"]