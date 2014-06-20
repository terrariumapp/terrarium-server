using System;

namespace Terrarium.Server.Models
{
    public class TimedOutNode
    {
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public DateTime TimeoutDate { get; set; }
    }
}