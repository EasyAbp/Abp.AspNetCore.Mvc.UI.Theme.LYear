#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["samples/LYearUiSample.Web/LYearUiSample.Web.csproj", "samples/LYearUiSample.Web/"]
COPY ["samples/LYearUiSample.HttpApi/LYearUiSample.HttpApi.csproj", "samples/LYearUiSample.HttpApi/"]
COPY ["samples/LYearUiSample.Application.Contracts/LYearUiSample.Application.Contracts.csproj", "samples/LYearUiSample.Application.Contracts/"]
COPY ["samples/LYearUiSample.Domain.Shared/LYearUiSample.Domain.Shared.csproj", "samples/LYearUiSample.Domain.Shared/"]
COPY ["samples/LYearUiSample.EntityFrameworkCore/LYearUiSample.EntityFrameworkCore.csproj", "samples/LYearUiSample.EntityFrameworkCore/"]
COPY ["samples/LYearUiSample.Domain/LYearUiSample.Domain.csproj", "samples/LYearUiSample.Domain/"]
COPY ["src/EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.csproj", "src/"]
COPY ["samples/LYearUiSample.Application/LYearUiSample.Application.csproj", "samples/LYearUiSample.Application/"]
COPY Directory.Build.props .
RUN dotnet restore "samples/LYearUiSample.Web/LYearUiSample.Web.csproj"
COPY . .
WORKDIR "/src/samples/LYearUiSample.Web"
RUN dotnet build "LYearUiSample.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LYearUiSample.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LYearUiSample.Web.dll"]
