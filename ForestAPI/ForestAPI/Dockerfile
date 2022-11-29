#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ForestAPI/ForestAPI.csproj", "ForestAPI/"]
RUN dotnet restore "ForestAPI/ForestAPI.csproj"
COPY . .
WORKDIR "/src/ForestAPI"
RUN dotnet build "ForestAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ForestAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ForestAPI.dll"]