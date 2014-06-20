using System;

namespace Terrarium.Server.Models
{
    public class Usage
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Domain { get; set; }
        public DateTime TickTime { get; set; }
        public int UsageMinutes { get; set; }
        public string IPAddress { get; set; }
        public string GameVersion { get; set; }
        public string PeerChannel { get; set; }
        public int PeerCount { get; set; }
        public int AnimalCount { get; set; }
        public int MaxAnimalCount { get; set; }
        public int WorldHeight { get; set; }
        public int WorldWidth { get; set; }
        public string MachineName { get; set; }
        public string OSVersion { get; set; }
        public int ProcessorCount { get; set; }
        public string ClrVersion { get; set; }
        public int WorkingSet { get; set; }
        public int MaxWorkingSet { get; set; }
        public int MinWorkingSet { get; set; }
        public int ProcessorTime { get; set; }
        public DateTime ProcessStarTime { get; set; }
    }
}