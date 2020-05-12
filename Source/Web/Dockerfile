FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build
WORKDIR /app
# Add dotnet 2.2 for some dotnet tools
RUN wget -O dotnet22.tar.gz https://download.visualstudio.microsoft.com/download/pr/c72122bd-38f5-4c98-b585-b8aaf57ecc6e/c89d7774a430e163d801753654f33972/dotnet-sdk-2.2.207-linux-musl-x64.tar.gz \
    && aspnetcore_sha512='231118ba205b5d609263fc790851c65900aabf5830d492425849de89b7103f02012a302ce21960cb062426c5b8fd480e1316176a927bd287b08b7d19445f7224' \
    && echo "$aspnetcore_sha512  dotnet22.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet22.tar.gz -C /usr/share/dotnet \
    && rm dotnet22.tar.gz
# copy csproj and restore as distinct layers
COPY *.sln .
COPY nuget.config .
COPY *.csproj .
RUN dotnet restore

#copy everthing else and build
COPY . .
RUN dotnet publish -c Debug -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine as runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "TailwindPOS.dll"]