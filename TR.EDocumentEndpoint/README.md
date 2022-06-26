![icon](Images/icon.png)

# TR.EDocumentEndpoint

[![TR.EDocumentEndpoint NuGet Package](https://img.shields.io/nuget/v/TR.EDocumentEndpoint.svg)](https://www.nuget.org/packages/TR.EDocumentEndpoint/) [![TR.EDocumentEndpoint NuGet Package Downloads](https://img.shields.io/nuget/dt/TR.EDocumentEndpoint)](https://www.nuget.org/packages/TR.EDocumentEndpoint) [![GitHub Actions Status](https://github.com/wiyyyy/TR.EDocumentEndpoint/workflows/Build/badge.svg?branch=main)](https://github.com/wiyyyy/TR.EDocumentEndpoint/actions)

[![GitHub Actions Build History](https://buildstats.info/github/chart/wiyyyy/TR.EDocumentEndpoint?branch=main&includeBuildsFromPullRequest=false)](https://github.com/wiyyyy/TR.EDocumentEndpoint/actions)


## E-Document Endpoint Builder for TR Government

This package is created for e-transformation regulatory in Turkiye. TRA (Turkiye Revenue Administration) is wanting you to expose a SOAP API that implements their WSDL spec. This package provide an easy way to expose and implement their behavior specialized for your system. 

## Supported Version

- .NET 6+

## Basic Usage

You need to create a class that implements ``IEDocumentEndpoint`` interface or if you want to create another SOAP Actions beside TRA needs you can create custom interface that inherit ``IEDocumentEndpoint`` .
````csharp
    [ServiceContract]
    public interface IEDocumentService : IEDocumentEndpoint
    {
    }

    internal class EDocumentService : IEDocumentService
    {
        public getApplicationResponseResponse getApplicationResponse(getApplicationResponse request)
        {
            return new getApplicationResponseResponse();
        }

        public sendDocumentResponse sendDocument(sendDocument request)
        {
            return new sendDocumentResponse();
        }
    }

````
After creating and implementing this interface you need to add ``Program.cs`` like below.   

````csharp
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddEdocumentEndpoint();
    builder.Services.AddSingleton<IEDocumentService, EDocumentService>();

    var app = builder.Build();

    app.UseEdocumentEndpoint<IEDocumentService, EDocumentService>();

    app.Run();
````

When you run your application, you can send SOAP requests to this default endpoint http://localhost:5000/efatura .

## Customizing endpoint path

You can customize default endpoint like below.

````csharp
    app.UseEdocumentEndpoint<IEDocumentService, EDocumentService>("/mycustompath");
````

# Thanks
[CoreWcf](https://github.com/CoreWCF/CoreWCF) team and all of its contributors.