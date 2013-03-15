using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Location;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Geodan.Cloud.Api
{
    public class LocationsApi
    {
        public string BaseUrl = "http://wingis/location/api";
        public string UserId = string.Empty;

        public List<Position> GetLocations(string username)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = "positions?username=" + username;
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var positionString = response.Content.ReadAsStringAsync().Result;
            var positions = JsonConvert.DeserializeObject<List<Position>>(positionString);
            return positions;
        }

        public List<Position> GetTrail(string username, string trackeename, DateTime startTime, DateTime endTime)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format("trail?username={0}&trackeeName={1}&startTime={2}&endTime={3}",username,trackeename, startTime,endTime);
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var positionString = response.Content.ReadAsStringAsync().Result;
            var positions = JsonConvert.DeserializeObject<List<Position>>(positionString);
            return positions;
        }
    }
}
