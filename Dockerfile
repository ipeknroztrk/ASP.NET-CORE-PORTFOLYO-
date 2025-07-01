# Temel imaj (.NET 6 kullanıyorsan)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Build imajı
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Proje dosyasını kopyala
COPY ["MyPortfolioUdemy.csproj", "./"]

# Bağımlılıkları yükle
RUN dotnet restore "MyPortfolioUdemy.csproj"

# Tüm projeyi kopyala ve derle
COPY . .
RUN dotnet build "MyPortfolioUdemy.csproj" -c Release -o /app/build

# Yayın için publish et
FROM build AS publish
RUN dotnet publish "MyPortfolioUdemy.csproj" -c Release -o /app/publish

# Uygulamayı çalıştıracak katman
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyPortfolioUdemy.dll"]
