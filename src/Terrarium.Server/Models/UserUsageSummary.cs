namespace Terrarium.Server.Models
{
    public class UserUsageSummary
    {
        public string Alias { get; set; }
        public UsagePeriod Period { get; set; }
        public int TotalHours { get; set; }
        public float AverageHours { get; set; }
    }
}