namespace F1App.Models.ErgastApiModels
{
    public class RaceTable
    {
        public string season { get; set; }
        public string round { get; set; }
        public List<Race> Races { get; set; }
    }


}
