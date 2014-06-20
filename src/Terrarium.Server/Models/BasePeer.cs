using System;

namespace Terrarium.Server.Models
{
    public class BasePeer
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Channel { get; set; }
        public string IPAddress { get; set; }
        public string Version { get; set; }
        public DateTime FirstContact { get; set; }
    }
}