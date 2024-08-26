using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.OpenApiModels
{
    public class Car
    {
        public int brake { get; set; }
        public DateTime date { get; set; }
        public int drs { get; set; }
        public int n_gear { get; set; }
        public int rpm { get; set; }
        public int speed { get; set; }
        public int throttle { get; set; }
        public int session_key { get; set; }
        public int meeting_key { get; set; }
        public int driver_number { get; set; }
    }
}
