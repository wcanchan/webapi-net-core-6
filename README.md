# webapi-net-core-6
Servicio Api Rest en C# con Net Core 6 

ubicarte en el proyecto

## instalar

Microsoft.EntityFrameworkCore.SqlServer

## PowerShell
abrir powershell y ubicarse en el proyecto ClaseAcceso y luego ejcutar los siguientes comandos

- dotnet tool install --global dotnet-ef
- dotnet ef dbcontext scaffold "Server={SERVER};Initial Catalog={Bd};User ID={USER};Password={PASS};" Microsoft.EntityFrameworkCore.SqlServer  --context "DbContext" --force
