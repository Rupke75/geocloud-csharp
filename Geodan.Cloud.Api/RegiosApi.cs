using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Agn;
using RestSharp;

namespace Geodan.Cloud.Api
{
    public class RegiosApi
    {
        public static string BaseUrl = "http://wingis/regios/api";
        public static string UserId = string.Empty;

        static readonly RestClient Client = new RestClient(BaseUrl);

        public static void GetBevoegdgezag(double lon, double lat, Action<List<Bevoegdgezag>> callback)
        {
            var request = new RestRequest("bevoegdgezag");
            request.AddParameter("lon", lon);
            request.AddParameter("lat", lat);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId); 
            Client.ExecuteAsync<List<Bevoegdgezag>>(request, response => callback(response.Data));
        }

        public static void GetBevoegdgezag(string wktRd, Action<List<Bevoegdgezag>> callback)
        {
            var request = new RestRequest("bevoegdgezag");
            request.AddParameter("wkt", wktRd);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId); 
            Client.ExecuteAsync<List<Bevoegdgezag>>(request, response => callback(response.Data));
        }




    }
}
