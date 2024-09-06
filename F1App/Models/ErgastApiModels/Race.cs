namespace F1App.Models.ErgastApiModels
{
    public class Race
    {
        public string Season { get; set; }
        public string Round { get; set; }
        public string Url { get; set; }
        public string RaceName { get; set; }
        public Circuit Circuit { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool IsLive { get; set; }
        public FirstPractice FirstPractice { get; set; }
        public SecondPractice SecondPractice { get; set; }
        public ThirdPractice ThirdPractice { get; set; }
        public Qualifying Qualifying { get; set; }
        public SprintQualifying SprintQualifying { get; set; }
        public Sprint Sprint { get; set; }  
        public List<Result> Results { get; set; }
        public List<QualifyingResult> QualifyingResults { get; set; }
        public List<SprintResult> SprintResults { get; set; }
    }
}
