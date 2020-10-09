# .NET Core SDK
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
RUN file="$(ls)" && echo $file
COPY . /app
WORKDIR /app
RUN file="$(ls)" && echo $file
RUN ["dotnet", "restore"]
RUN dotnet build -o out
ENV ASPNETCORE_URLS=http://127.0.0.1:3500
EXPOSE 3500
RUN file="$(ls)" && echo $file
WORKDIR /app/out/
RUN file="$(ls)" && echo $file
ENTRYPOINT ["dotnet","TestMappingEfCore.dll"]