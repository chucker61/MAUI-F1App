using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.OpenApiModels
{
    public class Location
    {
        public DateTime date { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int session_key { get; set; }
        public int meeting_key { get; set; }
        public int driver_number { get; set; }
    }
}
