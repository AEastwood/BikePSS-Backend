FROM mcr.microsoft.com/dotnet/runtime:7.0 AS build-env
WORKDIR /App

RUN dotnet build BikePSS

COPY ./bin/Debug/net7.0 .

ENTRYPOINT ["dotnet", "BikePSS.dll"]