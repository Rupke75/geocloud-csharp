using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Location;
using Xunit;

namespace Geodan.Cloud.Api.Tests
{
    public class LocationsTests
    {
        [Fact]
        public void GetLocationsByUser()
        {
            var locationApi = new LocationsApi();
            locationApi.BaseUrl = "http://wingis.geodan.nl/location/api/";
            var result = locationApi.GetLocations("bert");
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void GetTrackeeTrail()
        {
            //http://wingis/location/api/trail?username=NS&trackeename=2143&starttime=2013-03-11T09%3A43%3A29&endTime=2013-03-11T10%3A13%3A29
            var locationApi = new LocationsApi();
            locationApi.BaseUrl = "http://wingis.geodan.nl/location/api/";
            var result = locationApi.GetTrail("NS", "2143", new DateTime(2013, 3, 11,9,0,0), new DateTime(2013, 3, 12,9,30,0));
            Assert.True(result.Count > 0);
        }
    }
}
