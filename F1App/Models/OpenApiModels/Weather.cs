using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.OpenApiModels
{
    public class Weather
    {
        public double air_temperature { get; set; }
        public DateTime date { get; set; }
        public int humidity { get; set; }
        public double pressure { get; set; }
        public int rainfall { get; set; }
        public double track_temperature { get; set; }
        public int wind_direction { get; set; }
        public double wind_speed { get; set; }
        public int session_key { get; set; }
        public int meeting_key { get; set; }
    }
}
