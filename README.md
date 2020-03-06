# PaycomputeProject

#### Persistence Layer Add Packages 

Microsoft.AspNetCore.Identity.EntityFrameworkCore<br>
Microsoft.EntityFrameworkCore.SqlServer<br>
Microsoft.EntityFrameworkCore.Tools

#### Db Migration 

```
Configuration Paycompute -> AppSetting.json -> ConnectionString -> ServerName  
Package Manager Console -> Select Paycompute.Persistence Layer -> Add this command 
 Add-Migration "Initial Migration" 
 Update-database 
 ```
