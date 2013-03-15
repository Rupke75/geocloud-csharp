using System.Collections.Generic;
using Geodan.Cloud.Models.Agn;
using Xunit;

namespace Geodan.Cloud.Api.Tests
{
    public class Tests
    {
        [Fact]
        public void GetBevoegdgezagByLatLon()
        {
            var regioApi = new RegiosApi();
            regioApi.BaseUrl = "http://wingis.geodan.nl/regios/api/";
            var result = regioApi.GetBevoegdgezag(4.9128153, 52.3423183);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetBevoegdgezagByRd()
        {
            var regioApi = new RegiosApi();
            regioApi.BaseUrl = "http://wingis.geodan.nl/regios/api/";
            var result = regioApi.GetBevoegdgezag("POINT(208501.1 603036.6)");
            Assert.True(result.Count > 0);
        }
    }
}
