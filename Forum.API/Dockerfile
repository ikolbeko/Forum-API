#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Forum.API/Forum.API.csproj", "Forum.API/"]
COPY ["Forum.Models/Forum.Core.csproj", "Forum.Models/"]
COPY ["Forum.Repository/Forum.Repository.csproj", "Forum.Repository/"]
RUN dotnet restore "Forum.API/Forum.API.csproj"
COPY . .
WORKDIR "/src/Forum.API"
RUN dotnet build "Forum.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Forum.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Forum.API.dll"]