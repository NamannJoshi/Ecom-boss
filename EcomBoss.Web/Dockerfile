# =========================
# Build
# =========================
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# Copy project files first
COPY ["EcomBoss.Web/EcomBoss.Web.csproj", "EcomBoss.Web/"]
COPY ["EcomBoss.Application/EcomBoss.Application.csproj", "EcomBoss.Application/"]
COPY ["EcomBoss.Domain/EcomBoss.Domain.csproj", "EcomBoss.Domain/"]
COPY ["EcomBoss.Infrastructure/EcomBoss.Infrastructure.csproj", "EcomBoss.Infrastructure/"]

# Restore
RUN dotnet restore "EcomBoss.Web/EcomBoss.Web.csproj"

# Copy remaining source
COPY . .

WORKDIR /src/EcomBoss.Web

# Publish
RUN dotnet publish "EcomBoss.Web.csproj" \
    -c Release \
    -o /app/publish


# =========================
# Runtime
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

EXPOSE 8080

ENV ASPNETCORE_HTTP_PORTS=8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "EcomBoss.Web.dll"]