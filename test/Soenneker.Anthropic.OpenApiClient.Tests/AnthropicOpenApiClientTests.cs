using Soenneker.Tests.HostedUnit;

namespace Soenneker.Anthropic.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class AnthropicOpenApiClientTests : HostedUnitTest
{
    public AnthropicOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
