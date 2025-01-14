FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "backend.dll"]

# # Usando a imagem oficial do .NET SDK
# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# # Criar o diretório de trabalho
# WORKDIR /app

# # Copiar os arquivos do projeto para o container
# COPY *.csproj ./
# RUN dotnet restore

# COPY . .

# # Build do projeto
# RUN dotnet publish -c Release -o out

# # Segunda etapa: usar a imagem do runtime do .NET
# FROM mcr.microsoft.com/dotnet/aspnet:6.0

# WORKDIR /app
# COPY --from=build /app/out .

# # Expor a porta
# EXPOSE 5000

# # Definir o comando de inicialização
# ENTRYPOINT ["dotnet", "backend.dll"]
