using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pinecone.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PineconeOpenApiClientTests : HostedUnitTest
{
    public PineconeOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
