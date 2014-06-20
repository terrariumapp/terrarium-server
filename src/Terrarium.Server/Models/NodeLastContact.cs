using System;

namespace Terrarium.Server.Models
{
    public class NodeLastContact
    {
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public int LastTick { get; set; }
        public DateTime LastContact { get; set; }
    }
}