
FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /Dot


FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /Dot
COPY DevOpsSolution.sln ./
COPY DevOpsSolution/DevOpsSolution.csproj DevOpsSolution/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /Dot/DevOpsSolution
RUN dotnet build -c Release -o /app
