using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Octothorp.AspNetCore.Tests
{
    public class StatusTests
    {
        [Test]
        public async Task VersionRoute_ReturnsAssemblyVersion()
        {
            HttpClient httpClient = new StatusApiApplication().CreateClient();

            string version = await httpClient.GetStringAsync("/status/version");

            version.Should().NotBe("Unknown");

            Assert.Pass();
        }
    }
}