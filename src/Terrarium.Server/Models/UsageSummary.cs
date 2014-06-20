using System;

namespace Terrarium.Server.Models
{
    public class UsageSummary
    {
        public int Id { get; set; }
        public int Peers { get; set; }
        public DateTime SummaryDateTime { get; set; }
    }
}