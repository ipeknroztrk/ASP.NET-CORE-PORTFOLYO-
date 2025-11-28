FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PortfolyoCore/PortfolyoCore.csproj", "PortfolyoCore/"]
RUN dotnet restore "PortfolyoCore/PortfolyoCore.csproj"
COPY . .
WORKDIR "/src/PortfolyoCore"
RUN dotnet build "PortfolyoCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PortfolyoCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortfolyoCore.dll"]
