# .NET Core SDK
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.402-alpine3.12


COPY . /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 44375

WORKDIR /bin/debug/netcoreapp3.1/
ENTRYPOINT ["dotnet","TestMappingEfCore.dll"]