# create 
dotnet new webapi -n UserRegistrationSystem
cd UserRegistrationSystem

##
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet ef --version

##
dotnet add package Swashbuckle.AspNetCore
dotnet add package Microsoft.Data.SqlClient
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.IdentityModel.Tokens

##
dotnet ef migrations add InitialCreate
dotnet ef database update

## 
