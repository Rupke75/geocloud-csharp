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
            RegiosApi.GetBevoegdgezag(4.9128153,52.3423183,callback);
        }

        [Fact]
        public void GetBevoegdgezagByRd()
        {
            RegiosApi.GetBevoegdgezag("POINT(208501.1 603036.6)", callback);
        }

        private static void callback(List<Bevoegdgezag> bevoegdgezagen)
        {
            Assert.True(bevoegdgezagen.Count > 0);
        }
    }
}
