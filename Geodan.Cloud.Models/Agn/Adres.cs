using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geodan.Cloud.Models.Agn
{
    public class Adres
    {
        public string AdresBagId { get; set; }
        public string Nraandid { get; set; }
        public string Oruimteid { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Huisletter { get; set; }
        public string Huisnrtoev { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }
        public string Wnpcode { get; set; }
        public string Gemeente { get; set; }
        public string Gemcode { get; set; }
        public string Provincie { get; set; }
        public string Provcode { get; set; }
        public string Adres_Type { get; set; }
        public string Status { get; set; }
        public int Oppvlakte { get; set; }
        public decimal X_rd { get; set; }
        public decimal Y_rd { get; set; }
        public string GeometrieRD { get; set; }
        public string GebwBagID { get; set; }
        public string DataExtractDate { get; set; }
        public Link Gebouw { get; set; }
    }
}
