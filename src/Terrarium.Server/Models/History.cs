using System;

namespace Terrarium.Server.Models
{
    public class History
    {
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public int TickNumber { get; set; }
        public string SpeciesName { get; set; }
        public DateTime ContactTime { get; set; }
        public DateTime ClientTime { get; set; }
        public int CorrectTime { get; set; }
        public int Population { get; set; }
        public int BirthCount { get; set; }
        public int TeleportedToCount { get; set; }
        public int StarvedCount { get; set; }
        public int KilledCount { get; set; }
        public int TeleportedFromCount { get; set; }
        public int ErrorCount { get; set; }
        public int TimeoutCount { get; set; }
        public int SickCount { get; set; }
        public int OldAgeCount { get; set; }
        public int SecurityViolationCount { get; set; }
    }
}