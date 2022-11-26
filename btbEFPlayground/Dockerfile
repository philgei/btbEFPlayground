FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["btbEFPlayground/btbEFPlayground.csproj", "btbEFPlayground/"]
RUN dotnet restore "btbEFPlayground/btbEFPlayground.csproj"
COPY . .
WORKDIR "/src/btbEFPlayground"
RUN dotnet build "btbEFPlayground.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "btbEFPlayground.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "btbEFPlayground.dll"]
