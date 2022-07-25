#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["adventureworks2.api/adventureworks2.api.csproj", "adventureworks2.api/"]
RUN dotnet restore "adventureworks2.api/adventureworks2.api.csproj"
COPY . .
WORKDIR "/src/adventureworks2.api"
RUN dotnet build "adventureworks2.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "adventureworks2.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "adventureworks2.api.dll"]