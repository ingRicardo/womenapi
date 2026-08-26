FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj directly from root
COPY ["WebWomen.csproj", "./"]
RUN dotnet restore "WebWomen.csproj"

# Copy all source files and publish
COPY . .
RUN dotnet publish "WebWomen.csproj" -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "WebWomen.dll"]