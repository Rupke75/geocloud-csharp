using System;
using System.Collections.Generic;
using Geodan.Cloud.Api.Models;
using RestSharp;

namespace Geodan.Cloud.Api
{
    public class LocationsApi
    {
        public static string BaseUrl = "http://wingis/location/api";
        public static string UserId = string.Empty;

        static readonly RestClient Client = new RestClient(BaseUrl);

        public static void GetLocations(string username, Action<List<Position>> callback)
        {
            var request = new RestRequest("positions");
            request.AddParameter("username", username);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId);
            Client.ExecuteAsync<List<Position>>(request, response => callback(response.Data));
        }

        public static void GetTrail(string username, string trackeename, DateTime startTime, DateTime endTime, Action<List<Position>> callback)
        {
            var request = new RestRequest("trail");
            request.AddParameter("username", username);
            request.AddParameter("trackeename", trackeename);
            request.AddParameter("starttime", startTime);
            request.AddParameter("endTime", endTime);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId);
            Client.ExecuteAsync<List<Position>>(request, response => callback(response.Data));
        }


    }
}
