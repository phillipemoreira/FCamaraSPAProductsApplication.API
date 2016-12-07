# SimpleProductsAppWithOauth.API
Simple WebApi for a products application that requires OAtuth Authentication.

This project demonstrated how to use ASP.NET web API token based authentication to access content that require authorization.

## It was developed using
  - Visual Studio 2015 Community Edition / ASPNET Web application
  - Installed packages (nuget)
    - Microsoft.AspNet.WebApi.Owin
    - Microsoft.Owin.Host.SystemWeb
    - Microsoft.AspNet.Identity.Owin
    - Microsoft.AspNet.Identity.EntityFramework
    - Microsoft.Owin.Security.Oauth
    - Microsoft.Owin.Cors
		
## Dependencies/Prereqs
  - Visual Studio
  - SQL Express

## Instructions
  - Open the API solution
  - Compile the project
  - Run in Package Manager Console: Update-Database
  - Run the project

##Project URL
http://localhost:8090/
		
### Endpoints
  - GET
    - http://localhost:8090/api/products
  - POST
    - http://localhost:8090/api/account/register
    - http://localhost:8090/token
