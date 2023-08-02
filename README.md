# Criando-projetos-.NET-Core-segundo-a-Clean-Architecture

Criando projetos .NET Core segundo a Clean Architecture

# Add-Migration and Update-Database with Identity

EntityFrameworkCore\Add-Migration
EntityFrameworkCore\Update-Database
Com Identity não funciona sem a referencia EntityFrameworkCore\

# Create Database from MainApp (Web), C# Project with DBContext and C# Project for Models.

dotnet ef database update -s MainApp -p ProjectHavingDbContext
dotnet ef database update -s .\CleanArcMvc.API\CleanArcMvc.API.csproj -p .\CleanArcMvc.Infra.Data\CleanArcMvc.Infra.Data.csproj

# Install pgAdminm4 Web Linux
$ sudo mkdir /var/lib/pgadmin
$ sudo mkdir /var/log/pgadmin
$ sudo chown $USER /var/lib/pgadmin
$ sudo chown $USER /var/log/pgadmin

# Create virtual environment
$ python3 -m venv pgadmin4
$ source pgadmin4/bin/activate

# Install pgadmin4
(pgadmin4) $ pip install pgadmin4

# Start pgadmin4
(pgadmin4) $ pgadmin4
