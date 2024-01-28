#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Web/ChefRecipes.Api.Web/ChefRecipes.Api.Web.csproj", "Web/ChefRecipes.Api.Web/"]
COPY ["ChefRecipes.Api.Common/ChefRecipes.Api.Common.csproj", "ChefRecipes.Api.Common/"]
COPY ["Data/ChefRecipes.Api.Data.Models/ChefRecipes.Api.Data.Models.csproj", "Data/ChefRecipes.Api.Data.Models/"]
COPY ["Data/ChefRecipes.Api.Data.Common/ChefRecipes.Api.Data.Common.csproj", "Data/ChefRecipes.Api.Data.Common/"]
COPY ["Data/ChefRecipes.Api.Data/ChefRecipes.Api.Data.csproj", "Data/ChefRecipes.Api.Data/"]
COPY ["Services/ChefRecipes.Api.Services.Data/ChefRecipes.Api.Services.Data.csproj", "Services/ChefRecipes.Api.Services.Data/"]
COPY ["Services/ChefRecipes.Api.Services.Mapping/ChefRecipes.Api.Services.Mapping.csproj", "Services/ChefRecipes.Api.Services.Mapping/"]
COPY ["Services/ChefRecipes.Api.Services.Messaging/ChefRecipes.Api.Services.Messaging.csproj", "Services/ChefRecipes.Api.Services.Messaging/"]
COPY ["Services/ChefRecipes.Api.Services/ChefRecipes.Api.Services.csproj", "Services/ChefRecipes.Api.Services/"]
COPY ["Web/ChefRecipes.Api.Web.Infrastructure/ChefRecipes.Api.Web.Infrastructure.csproj", "Web/ChefRecipes.Api.Web.Infrastructure/"]
COPY ["Web/ChefRecipes.Api.Web.ViewModels/ChefRecipes.Api.Web.ViewModels.csproj", "Web/ChefRecipes.Api.Web.ViewModels/"]
RUN dotnet restore "./Web/ChefRecipes.Api.Web/./ChefRecipes.Api.Web.csproj"
COPY . .
WORKDIR "/src/Web/ChefRecipes.Api.Web"
RUN dotnet build "./ChefRecipes.Api.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ChefRecipes.Api.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChefRecipes.Api.Web.dll"]