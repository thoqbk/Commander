# Commander

Course reference [.NET Core 3.1 MVC REST API - Full Course](https://www.youtube.com/watch?v=fmvcAzHpsk8)

## Get started

### Pull image and start SQL Server container

1. Pull SQL server docker image
```sh
docker pull mcr.microsoft.com/mssql/server:2019-latest
```
2. Start SQL Server container
```sh
docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 mcr.microsoft.com/mssql/server
```
3. Install `Azure Data Studio` and connect to Db instance
4. Create new database via `Azure Data Studio`
5. Create `Commands` table
```sql
CREATE TABLE [dbo].[Commands](
	[Id] [int] NOT NULL,
	[HowTo] [varchar](250) NULL,
	[Line] [varchar](250) NULL,
	[Platform] [varchar](255) NULL
) ON [PRIMARY]
```
6. Insert sample data to `Commands` table

### Update configuration and start API server

1. Update `appsettings.json` accordingly
2. Start server `dotnet run`
3. Test APIs
```sh
curl https://localhost:5001/commands
curl https://localhost:5001/commands/{id}
```
