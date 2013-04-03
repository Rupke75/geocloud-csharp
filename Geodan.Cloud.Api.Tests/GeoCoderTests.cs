using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Location;
using Xunit;

namespace Geodan.Cloud.Api.Tests
{
    public class GeoCoderTests
    {
        [Fact]
        public void GetSuggestionsBySearchText()
        {
            var api = new GeoCoderApi();
            var result = api.GetSuggestions("parnassia");
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetLocationsById(string id)
        {
            var api = new GeoCoderApi();
            var result = api.GetLocations(id);
            Assert.True(result.Count > 0);
        }
    }
}
