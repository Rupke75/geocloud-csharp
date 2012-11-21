using System;
using System.Collections.Generic;
using Geodan.Cloud.Api.Models;
using RestSharp;

namespace Geodan.Cloud.Api
{
    public class AgnApi
    {
        public static string BaseUrl = "http://wingis/agn/api";
        public static string UserId = string.Empty;

        static readonly RestClient Client = new RestClient(BaseUrl);

        public static void GetGebouwen(string wkt, Action<List<Gebouw>> callback)
        {
            var request = new RestRequest("gebouwen");
            request.AddParameter("wkt", wkt);
            Client.ExecuteAsync<List<Gebouw>>(request, response => callback(response.Data));
        }


        public static void GetGebouw(string id, Action<Gebouw> callback)
        {
            var request = new RestRequest("gebouwen");
            request.AddParameter(id, ParameterType.UrlSegment);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId);
            Client.ExecuteAsync<Gebouw>(request, response => callback(response.Data));
        }


        public static void GetGebouwen(string pc6, Action<List<Gebouw>> callback, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "")
        {
            var request = new RestRequest("gebouwen");
            request.AddParameter("postcode", pc6);
            if (huisnummer != string.Empty) request.AddParameter("huisnummer", huisnummer);
            if (huisletter != string.Empty) request.AddParameter("huisletter", huisletter);
            if (huisnummerToevoeging != string.Empty) request.AddParameter("huisnrtoev", huisnummerToevoeging);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId);
            Client.ExecuteAsync<List<Gebouw>>(request, response => callback(response.Data));
        }


        public static void GetAdres(string id, Action<Adres> callback)
        {
            var request = new RestRequest("adressen");
            request.AddParameter(id, ParameterType.UrlSegment);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId);
            Client.ExecuteAsync<Adres>(request, response => callback(response.Data));
        }


        public static void GetAdressen(string pc6, Action<List<Adres>> callback, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "")
        {
            var request = new RestRequest("adressen");
            request.AddParameter("postcode", pc6);
            if (huisnummer != string.Empty) request.AddParameter("huisnummer", huisnummer);
            if (huisletter != string.Empty) request.AddParameter("huisletter", huisletter);
            if (huisnummerToevoeging != string.Empty) request.AddParameter("huisnrtoev", huisnummerToevoeging);
            if (!string.IsNullOrEmpty(UserId)) request.AddParameter("uid", UserId);
            Client.ExecuteAsync<List<Adres>>(request, response => callback(response.Data));
        }

    }
}
