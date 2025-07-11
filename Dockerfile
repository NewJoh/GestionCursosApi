# Etapa 1: compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar todo y restaurar dependencias
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Iniciar la API
ENTRYPOINT ["dotnet", "GestionCursosApi.dll"]
