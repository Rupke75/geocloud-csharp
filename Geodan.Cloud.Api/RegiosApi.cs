using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Agn;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Globalization;

namespace Geodan.Cloud.Api
{
    public class RegiosApi
    {
        public string BaseUrl = "http://wingis/regios/api";
        public string UserId = string.Empty;

        public List<Bevoegdgezag> GetBevoegdgezag(double lon, double lat)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format(CultureInfo.InvariantCulture, "bevoegdgezag?lon={0}&lat={1}",lon,lat);
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var bevoegdgezagStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Bevoegdgezag>));
            var bevoegdgezag = (List<Bevoegdgezag>)serializer.ReadObject(bevoegdgezagStream);
            return bevoegdgezag;
        }

        public List<Bevoegdgezag> GetBevoegdgezag(string wktRd)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = "bevoegdgezag?wkt=" + wktRd ;
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var bevoegdgezagStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Bevoegdgezag>));
            var bevoegdgezag = (List<Bevoegdgezag>)serializer.ReadObject(bevoegdgezagStream);
            return bevoegdgezag;
        }
    }
}
