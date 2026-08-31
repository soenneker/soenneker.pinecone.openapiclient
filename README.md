[![](https://img.shields.io/nuget/v/soenneker.pinecone.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.pinecone.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.pinecone.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.pinecone.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.pinecone.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.pinecone.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.pinecone.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.pinecone.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Pinecone.OpenApiClient

Generated request builders and models for the Pinecone Nexus API, including authentication, projects, contexts, connectors, queries, sessions, and tasks.

## Installation

```bash
dotnet add package Soenneker.Pinecone.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Pinecone.OpenApiClient;

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://your-nexus-host/api/")
};
httpClient.DefaultRequestHeaders.Add("X-Pinecone-Api-Key", "your-api-key");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = httpClient.BaseAddress.ToString().TrimEnd('/')
};

var client = new PineconeOpenApiClient(adapter);
var project = await client.Nexus.Project.GetAsync(
    cancellationToken: cancellationToken);
```

Set `BaseUrl` explicitly; the schema's placeholder host is not a callable endpoint. The generated `Nexus` segment reflects the source specification's namespace in the merged schema.
