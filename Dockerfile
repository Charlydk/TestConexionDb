# Imagen base
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar todo y restaurar dependencias
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Imagen final
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

# Comando al ejecutar
ENTRYPOINT ["dotnet", "TestConexionDb.dll"]
