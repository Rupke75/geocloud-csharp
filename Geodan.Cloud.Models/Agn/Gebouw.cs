using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geodan.Cloud.Models.Agn
{
    public class Gebouw
    {
        public string GebwBagID { get; set; }
        public string Pc4Code { get; set; }
        public string Woonplaats { get; set; }
        public string WnpCode { get; set; }
        public string Gemeente { get; set; }
        public string GemCode { get; set; }
        public string Provincie { get; set; }
        public int ProvincieCode { get; set; }
        public int Bouwjaar { get; set; }
        public string Gebw_Type { get; set; }
        public string Status { get; set; }
        public int Oppvlakte { get; set; }
        public string GeometrieRD { get; set; }
        public List<Adres> Adressen { get; set; }
        public string DataExtractDate { get; set; }
    }
}
