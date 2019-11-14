# Samples (C# / .Net Core)

Provides samples for using the Bridge API with .Net Core & C#.

### Usage / Requirements

##### Access to a FORCAM Force Bridge API System

Please add your URL, user and password to your Bridge API instance to the variables below (contained by all samples).
```csharp

urlForTokenGeneration = ""; // YOUR URL (e.g. https://virtualfactory.force.eco:24443/ffwebservices/)
user = ""; // YOUR USER (e.g. GitHub)
password = ""; // YOUR PASSWORD (e.g. GitHub)

```

### Description of the sample applications:

# Authentication

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API and prints out the token information.

Folder: "authentication".

# Available workplaces

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API, determine all available workplaces and prints them out.

Folder: "getavailableworkplaces".