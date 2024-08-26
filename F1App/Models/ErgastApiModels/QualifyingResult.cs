using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.ErgastApiModels
{
    public class QualifyingResult
    {
        public string number { get; set; }
        public string position { get; set; }
        public Driver Driver { get; set; }
        public Constructor Constructor { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
    }
}
