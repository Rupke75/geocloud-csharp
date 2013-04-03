using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geodan.Cloud.Models.Geocoder
{
    public class Location
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string StreetNumberRange { get; set; }
        public string Postcode { get; set; }
        public string Town { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Locality { get; set; }
        public string Srs { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
    }
}
