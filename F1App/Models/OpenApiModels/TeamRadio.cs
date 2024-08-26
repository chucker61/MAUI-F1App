using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.OpenApiModels
{
    public class TeamRadio
    {
        public DateTime date { get; set; }
        public string recording_url { get; set; }
        public int meeting_key { get; set; }
        public int driver_number { get; set; }
        public int session_key { get; set; }
    }
}
