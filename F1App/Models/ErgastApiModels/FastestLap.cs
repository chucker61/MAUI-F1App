namespace F1App.Models.ErgastApiModels
{
    public class FastestLap
    {
        public string rank { get; set; }
        public string lap { get; set; }
        public Time Time { get; set; }
        public AverageSpeed AverageSpeed { get; set; }
    }


}
