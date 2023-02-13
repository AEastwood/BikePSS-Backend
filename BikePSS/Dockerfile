FROM mcr.microsoft.com/dotnet/runtime:7.0 AS build-env
WORKDIR /App

COPY bin/Release/net7.0/publish .

ENTRYPOINT ["dotnet", "BikePSS.dll"]