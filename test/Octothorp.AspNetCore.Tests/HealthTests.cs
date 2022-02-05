using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Octothorp.AspNetCore.Tests
{
    public class HealthTests
    {
        [Test]
        public async Task VersionRoute_ReturnsAssemblyVersion()
        {
            HttpClient httpClient = new HealthApiApplication().CreateClient();

            string version = await httpClient.GetStringAsync("/health/version");

            version.Should().NotBe("Unknown");

            Assert.Pass();
        }
    }
}