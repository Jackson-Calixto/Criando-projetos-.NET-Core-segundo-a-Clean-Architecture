# Criando-projetos-.NET-Core-segundo-a-Clean-Architecture

Criando projetos .NET Core segundo a Clean Architecture

# Add-Migration and Update-Database with Identity

EntityFrameworkCore\Add-Migration
EntityFrameworkCore\Update-Database
Com Identity não funciona sem a referencia EntityFrameworkCore\

# Create Database from MainApp (Web), C# Project with DBContext and C# Project for Models.

dotnet ef database update -s MainApp -p ProjectHavingDbContext
dotnet ef database update -s .\CleanArcMvc.API\CleanArcMvc.API.csproj -p .\CleanArcMvc.Infra.Data\CleanArcMvc.Infra.Data.csproj
