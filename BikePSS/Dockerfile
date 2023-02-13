FROM mcr.microsoft.com/dotnet/runtime:7.0 AS build-env
WORKDIR /App

COPY bin/Debug/net7.0/ .

ENTRYPOINT ["dotnet", "BikePSS.dll"]