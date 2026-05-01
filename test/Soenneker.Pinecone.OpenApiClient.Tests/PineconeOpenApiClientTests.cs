using Soenneker.TestHosts.Unit;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pinecone.OpenApiClient.Tests;

[ClassDataSource<UnitTestHost>(Shared = SharedType.PerTestSession)]
public sealed class PineconeOpenApiClientTests : HostedUnitTest
{
    public PineconeOpenApiClientTests(UnitTestHost host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
