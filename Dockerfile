FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY CSharp-React-Twitter/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY CSharp-React-Twitter/. ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "CSharp-React-Twitter.dll"]