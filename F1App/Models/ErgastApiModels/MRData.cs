﻿namespace F1App.Models.ErgastApiModels
{
    public class MRData
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public RaceTable RaceTable { get; set; }
        public StandingsTable StandingsTable { get; set; }
    }


}
