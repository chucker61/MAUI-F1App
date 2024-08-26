﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.OpenApiModels
{
    public class Position
    {
        public DateTime date { get; set; }
        public int position { get; set; }
        public int driver_number { get; set; }
        public int session_key { get; set; }
        public int meeting_key { get; set; }
    }
}
