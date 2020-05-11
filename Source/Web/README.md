# Tailwind Point Of Sale

This is the Point Of Sale App modernized by Mobilize all the way from VB6 to .NET Core so it can run on Linux, Mac, Windows or Docker.

# Build BackEnd 

```
dotnet build TailwindPOS.sln
```

# Build FrontEnd
```
cd tailwindpos-angular
yarn
ng build
```

# Setting up the Database

There is a docker file to run the database

## Building the docker image

```
cd DockerDB
docker build -t orellabac:POSDB .
```

## Running the database

```
docker run -p 1433:1433 orellabac:POSDB
```

# Run the Tailwind POS

```
dotnet run
```