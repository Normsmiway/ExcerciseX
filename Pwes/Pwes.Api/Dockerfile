#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pwes.Api/Pwes.Api.csproj", "Pwes.Api/"]
RUN dotnet restore "Pwes.Api/Pwes.Api.csproj"
COPY . .
WORKDIR "/src/Pwes.Api"
RUN dotnet build "Pwes.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pwes.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pwes.Api.dll"]