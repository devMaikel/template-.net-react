# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
# WORKDIR /app
# COPY *.csproj ./
# RUN dotnet restore
# COPY . ./
# RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/aspnet:6.0
# WORKDIR /app
# COPY --from=build-env /app/out .
# ENTRYPOINT ["dotnet", "backend.dll"]


# watch / hot reload

FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
EXPOSE 5000 5002
COPY . . 
RUN dotnet restore
ENTRYPOINT ["dotnet", "watch", "run", "--urls=http://0.0.0.0:5000"]
