FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy project file and restore dependencies
COPY ["WebWomen/WebWomen.csproj", "WebWomen/"]
RUN dotnet restore "WebWomen/WebWomen.csproj"

# Copy remaining files and publish specific project
COPY . .
WORKDIR "/src/WebWomen"
RUN dotnet publish "WebWomen.csproj" -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "WebWomen.dll"]