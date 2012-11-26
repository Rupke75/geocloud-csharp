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
            AgnApi.GetAdres("0003010000125985", callback);
        }

        [Fact]
        public void GetGebouwenByPostcode()
        {
            AgnApi.GetGebouwen("3583", callback);
        }

        private static void callback(Adres adres)
        {
            Assert.True(adres != null);
        }

        private static void callback(List<Gebouw> gebouwen)
        {
            Assert.True(gebouwen.Count >0 );
        }
    }
}
