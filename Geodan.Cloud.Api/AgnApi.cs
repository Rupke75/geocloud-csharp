using System;
using System.Collections.Generic;
using Geodan.Cloud.Models.Agn;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;

namespace Geodan.Cloud.Api
{
    public class AgnApi
    {
        public string BaseUrl = "http://wingis.geodan.nl/agn/api/";
        public string UserId = string.Empty;

        public List<Gebouw> GetGebouwenByWkt(string wkt)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var response = client.GetAsync("gebouwen?wkt=" + wkt).Result;
            var gebouwenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Gebouw>));
            var gebouwen = (List<Gebouw>)serializer.ReadObject(gebouwenStream);
            return gebouwen;
        }

        public Gebouw GetGebouw(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = "gebouwen/" + id;
            if (!string.IsNullOrEmpty(UserId)) url += "?uid" + UserId;
            var response = client.GetAsync(url).Result;
            var gebouwenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(Gebouw));
            var gebouw = (Gebouw)serializer.ReadObject(gebouwenStream);
            return gebouw;
        }

        public List<Gebouw> GetGebouwenByPc6(string pc6, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format("gebouwen?postcode={0}", pc6);
            url = AddOptionalParameters(url, huisnummer, huisletter, huisnummerToevoeging, UserId);

            var response = client.GetAsync(url).Result;
            var gebouwenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Gebouw>));
            var gebouwen = (List<Gebouw>)serializer.ReadObject(gebouwenStream);
            return gebouwen;
        }

        public List<Gebouw> GetGebouwen(string straat, string woonplaats, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format("gebouwen?straat={0}&woonplaats={1}", straat, woonplaats);
            url = AddOptionalParameters(url, huisnummer, huisletter, huisnummerToevoeging, UserId);

            var response = client.GetAsync(url).Result;
            var gebouwenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Gebouw>));
            var gebouwen = (List<Gebouw>)serializer.ReadObject(gebouwenStream);
            return gebouwen;
        }

        public Adres GetAdres(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format("adressen/{0}", id);
            if (!string.IsNullOrEmpty(UserId)) url += "&uid" + UserId;

            var response = client.GetAsync(url).Result;
            var adressenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(Adres));
            var adres = (Adres)serializer.ReadObject(adressenStream);
            return adres;
        }

        public List<Adres> GetAdressenByPc6(string pc6, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format("adressen?postcode={0}", pc6);
            url = AddOptionalParameters(url, huisnummer, huisletter, huisnummerToevoeging, UserId);

            var response = client.GetAsync(url).Result;
            var adressenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Adres>));
            var adressen = (List<Adres>)serializer.ReadObject(adressenStream);
            return adressen;
        }

        public List<Adres> GetAdressen(string straat, string woonplaats, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "")
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var url = String.Format("adressen?straat={0}&woonplaats={1}", straat, woonplaats);
            url = AddOptionalParameters(url, huisnummer, huisletter, huisnummerToevoeging, UserId);
            var response = client.GetAsync(url).Result;
            var adressenStream = response.Content.ReadAsStreamAsync().Result;
            var serializer = new DataContractJsonSerializer(typeof(List<Adres>));
            var adressen = (List<Adres>)serializer.ReadObject(adressenStream);
            return adressen;
        }

        private string AddOptionalParameters(string Url, string huisnummer = "", string huisletter = "", string huisnummerToevoeging = "", string UserId = "")
        {
            if (huisnummer != string.Empty) Url += "&huisnummer=" + huisnummer;
            if (huisletter != string.Empty) Url += "&huisletter=" + huisletter;
            if (huisnummerToevoeging != string.Empty) Url += "&huisnrtoev=" + huisnummerToevoeging;
            if (!string.IsNullOrEmpty(UserId)) Url += "&uid" + UserId;
            return Url;
        }
    }
}
