FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FrameWork.Host/FrameWork.Host.csproj", "FrameWork.Host/"]
COPY ["FrameWork.Application/FrameWork.Application.csproj", "FrameWork.Application/"]
COPY ["FrameWork.Domain/FrameWork.Domain.csproj", "FrameWork.Domain/"]
COPY ["FrameWork.Persistence/FrameWork.Persistence.csproj", "FrameWork.Persistence/"]
RUN dotnet restore "FrameWork.Host/FrameWork.Host.csproj"
COPY . .
WORKDIR "/src/FrameWork.Host"
RUN dotnet build "FrameWork.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FrameWork.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrameWork.Host.dll"]
