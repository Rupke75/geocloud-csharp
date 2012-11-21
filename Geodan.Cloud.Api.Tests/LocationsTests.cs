using System;
using System.Collections.Generic;
using Geodan.Cloud.Api.Models;
using Xunit;

namespace Geodan.Cloud.Api.Tests
{
    public class LocationsTests
    {
        [Fact]
        public void GetLocationsByUser()
        {
            LocationsApi.GetLocations("bert", callback);
        }

        [Fact]
        public void GetTrackeeTrail()
        {
            LocationsApi.GetTrail("pieter","GE-PK-01", new DateTime(2012,5,11), new DateTime(2012,5,12), callback);
        }

        private static void callback(List<Position> positions)
        {
            Assert.True(positions.Count > 0);
        }



    }
}
