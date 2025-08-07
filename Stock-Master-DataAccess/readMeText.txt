
+++ Code help +++


+++ Install this NuGet package +++

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Relational
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools


+++ Install this CLI
.Net CLI install command (https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
PM> dotnet tool install --global dotnet-ef

+++ Check Installation
Check PM> dotnet ef



// Create migrations
PM> 
dotnet ef migrations add MIGRATIONNAMEHERE --project .\Stock-Master-DataAccess

//Commit migrations to DB
PM> 
dotnet ef database update --project .\Stock-Master-DataAccess


//You can remove migrations
PM> 
dotnet ef migrations remove --project .\Stock-Master-DataAccess

