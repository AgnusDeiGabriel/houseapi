# Etap 1: Build app
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out

# Etap 2: Run app
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

COPY --from=build /app/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "HouseApi.dll"]