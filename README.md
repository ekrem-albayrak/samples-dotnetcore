# Samples (C# / .NET Core)

Provides samples for using the FORCAM FORCE Bridge API with .NET Core & C#.

### Usage / Requirements

###### Further Bridge API information

* Website: https://www.forcebridge.io/
* Documentation: https://docs.forcebridge.io/
* ReDoc documentation: https://docs.forcebridge.io/api/
* Swagger documentation: https://forcebridgepublish.force.eco:24443/ffwebservices/swagger/index.html
* Virtual Factory: https://edu.forcebridge.io/

###### Access to a FORCAM FORCE Bridge API System

_If you need access to a demo system please contact forcebridge@forcam.com._

Please add your URL, user and password of your Bridge API instance to the variables below (contained by all samples).

```csharp

urlForTokenGeneration = ""; // YOUR URL (e.g. https://virtualfactory.force.eco:24443/ffwebservices/)
user = ""; // YOUR USER (e.g. GitHub)
password = ""; // YOUR PASSWORD (e.g. GitHub)

```

### Description of the sample applications:

# Authentication

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API and prints out the token information.

Folder: "authentication".

# Get all available workplaces

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API, determine all available workplaces and prints them out.

Folder: "getavailableworkplaces".

# Get current operating state of a workplace

A small .net core cosnsole application wich authenticates to a FORCAM FORCE Bridge API, determine the operating state of an workplace and print it.

Folder: "getoperatingstateofworkplace".

