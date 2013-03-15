using System.Collections.Generic;
using Geodan.Cloud.Models.Agn;
using Xunit;

namespace Geodan.Cloud.Api.Tests
{
    public class AgnTests
    {
        [Fact]
        public void GetAdresById()
        {
            var agnApi = new AgnApi();
            agnApi.BaseUrl = "http://wingis.geodan.nl/agn/api/";
            var result = agnApi.GetAdres("0003010000125985");
            Assert.True(result != null);
        }

        [Fact]
        public void GetGebouwenByPostcode()
        {
            var agnApi = new AgnApi();
            agnApi.BaseUrl = "http://wingis.geodan.nl/agn/api/";
            var result = agnApi.GetGebouwenByPc6("3583es");
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetGebouwenByStraatGemeente()
        {
            var agnApi = new AgnApi();
            agnApi.BaseUrl = "http://wingis.geodan.nl/agn/api/";
            var result = agnApi.GetGebouwen("Parkstraat", "Utrecht");
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetAdressenByStraatGemeente()
        {
            var agnApi = new AgnApi();
            agnApi.BaseUrl = "http://wingis.geodan.nl/agn/api/";
            var result = agnApi.GetAdressen("Parkstraat", "Utrecht");
            Assert.True(result.Count > 0);
        }
    }
}
