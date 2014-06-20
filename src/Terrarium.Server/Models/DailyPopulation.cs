using System;

namespace Terrarium.Server.Models
{
    public class DailyPopulation
    {
        public int Id { get; set; }
        public DateTime SampleDateTime { get; set; }
        public string SpeciesName { get; set; }
        public int Population { get; set; }
        public int BirthCount { get; set; }
        public int StarvedCount { get; set; }
        public int KilledCount { get; set; }
        public int ErrorCount { get; set; }
        public int TimeoutCount { get; set; }
        public int SickCount { get; set; }
        public int OldAgeCount { get; set; }
        public int SecurityViolationCount { get; set; }
    }
}