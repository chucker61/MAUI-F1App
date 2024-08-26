using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.OpenApiModels
{
    public class RaceControl
    {
        public string category { get; set; }
        public DateTime date { get; set; }
        public string flag { get; set; }
        public int lap_number { get; set; }
        public string message { get; set; }
        public string scope { get; set; }
        public object sector { get; set; }
        public int meeting_key { get; set; }
        public int session_key { get; set; }
        public int driver_number { get; set; }
    }
}
