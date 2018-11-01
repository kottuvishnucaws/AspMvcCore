FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 64776
EXPOSE 44382

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["AspMvcCore/AspMvcCore.csproj", "AspMvcCore/"]
RUN dotnet restore "AspMvcCore/AspMvcCore.csproj"
COPY . .
WORKDIR "/src/AspMvcCore"
RUN dotnet build "AspMvcCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AspMvcCore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspMvcCore.dll"]