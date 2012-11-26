using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geodan.Cloud.Models.Location
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("id: {0}, name: {1}", Id, Name);
        }
    }
}
