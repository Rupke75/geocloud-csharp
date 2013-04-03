using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Geocoder;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Geodan.Cloud.Api
{
    public class GeoCoderApi
    {
        public string BaseUrl = "http://geoserver.nl/geocoder/";
        public string UserId = string.Empty;

        public List<GeoSuggestion> GetSuggestions(string searchText)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = "geosuggest.aspx?format=json&search=" + searchText;
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var suggestionString = response.Content.ReadAsStringAsync().Result;
            var suggestions = JsonConvert.DeserializeObject<List<GeoSuggestion>>(suggestionString);
            return suggestions;
        }

        public List<Location> GetLocations(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = "nladdressll.aspx?format=json&request=idlookup&id=" + id;
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var locationString = response.Content.ReadAsStringAsync().Result;
            var locations = JsonConvert.DeserializeObject<List<Location>>(locationString);
            return locations;
        }

    }
}
