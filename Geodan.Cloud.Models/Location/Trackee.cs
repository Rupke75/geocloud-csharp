using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geodan.Cloud.Models.Location
{
    public class Trackee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrgId { get; set; }
        public Position ActualPosition { get; set; }
        public string Organisation { get; set; }

    }
}
