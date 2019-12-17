# Samples (C# / .NET Core)

Provides samples for using the FORCAM FORCE Bridge API with .NET Core & C#.

### Usage / Requirements

###### Further Bridge API information

* Website: https://www.forcebridge.io/
* Documentation: https://docs.forcebridge.io/
* ReDoc documentation: https://docs.forcebridge.io/api/
* Swagger documentation: https://forcebridgepublish.force.eco:24443/ffwebservices/swagger/index.html
* Virtual Factory: https://edu.forcebridge.io/
* Company: https://www.forcam.com/

###### Access to a FORCAM FORCE Bridge API System

_If you need access to a demo system please contact forcebridge@forcam.com._

Please add your URL, user and password of your Bridge API instance to the variables below (contained by all samples).

```csharp

urlForTokenGeneration = ""; // YOUR URL (e.g. https://virtualfactory.force.eco:24443/ffwebservices/)
user = ""; // YOUR USER (e.g. GitHub)
password = ""; // YOUR PASSWORD (e.g. GitHub)

```

###### Framework & Tools

* .NET Core 2.2 runtime (https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Created with Microsoft Visual Studio 2019 (https://visualstudio.microsoft.com/de/vs/)

### Description of the sample applications:

# Authentication

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API and prints out the token information.

Folder: "Authentication".

# Get all available workplaces

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API, determine all available workplaces and prints them out.

Folder: "GetAvailableWorkplaces".

# Get current operating state of a workplace

A small .net core cosnsole application wich authenticates to a FORCAM FORCE Bridge API, determine the operating state of an workplace and print it.

Folder: "GetOperatingStateOfWorkplace".

# Get all operating states

A small .net core console application wich authenticates to a FORCAM FORCE Bridge API, determine all operating states and prints them out.

Folder: "GetOperatingStates".

# Alerting on workplace operating state change (based on cyclic api requests)

A easy .net core console application which "alerts" if state of given workplace changed to undefined stoppage (Code 999).

Functionality:

1.) Reads first console argument (Cycle-Time) / Default 60 seconds
2.) LOOP (Cycle Time)
2.1) Detect current operating state of the workplace
2.2) If OperatingState is "999" (Undefined Stoppage)
2.2.1) Create a console message

_This procedure is not the "best" way to create a alarming/alerting functionality._
_It is better to use the Bridge API callback functionality (PUSH not PULL)._
_See the following callback examples_

Folder: "AlertingOnWPLOperatingStateChangesBasedOnCyclicRequests"

# Alerting on workplace operating state change (based on mqtt callbacks)

A .net core console application wich listen to machine state changes event over an MQTT Broker and prints out a alarting message if a specific workplace operating state occures.

Attention: Requires a MQTT-Broker (TCP)

```csharp

string MQTTTCPUrl = "mqtt://test.mosquitto.org"; // Your broker address
string PORT = "1883";
string MQTTTopicName = "external/statechange"; // "external/" is mandatory

```

Folder: "AlertingOnWPLOperatingStateChangesBasedOnMQTTCallbacks"