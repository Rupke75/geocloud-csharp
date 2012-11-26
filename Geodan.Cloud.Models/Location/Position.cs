using System;

namespace Geodan.Cloud.Models.Location
{
    public class Position
    {
        public DateTime DateGps { get; set; }
        public DateTime DateReceived { get; set; }
        public int EventCode { get; set; }
        public string EventName { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Track { get; set; } // direction
        public int Speed { get; set; }
        public int Dop { get; set; }
        public string Trackee { get; set; }
        public string Bps { get; set; }
        public string Organisation { get; set; }

        public override string ToString()
        {
            return String.Format("Longitude: {0}, Latitude: {1}, DatumGps: {2}, Bps: {3}", Longitude, Latitude, DateGps, Bps);
        }
    }
}
