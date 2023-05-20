#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Service/Interviews/Interviews.API/Interviews.API.csproj", "Service/Interviews/Interviews.API/"]
COPY ["Service/Interviews/ApplicationCore/ApplicationCore.csproj", "Service/Interviews/ApplicationCore/"]
COPY ["Service/Interviews/Infrastructure/Infrastructure.csproj", "Service/Interviews/Infrastructure/"]
RUN dotnet restore "Service/Interviews/Interviews.API/Interviews.API.csproj"
COPY . .
WORKDIR "/src/Service/Interviews/Interviews.API"
RUN dotnet build "Interviews.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Interviews.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Interviews.API.dll"]