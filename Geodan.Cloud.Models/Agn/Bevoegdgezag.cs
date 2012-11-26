using System.Globalization;

namespace Geodan.Cloud.Models.Agn
{
    public class Bevoegdgezag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Wkt { set; get; }
        public string Theme { get; set; }


        public Link Link
        {
            get { return new Link() { href = @"/" + Theme + @"/" + Id.ToString(CultureInfo.InvariantCulture), rel = Theme }; }
            set { }
        }

    }
}
