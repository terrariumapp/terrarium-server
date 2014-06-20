using System;

namespace Terrarium.Server.Models
{
    public class ShutdownPeer : BasePeer
    {
        public DateTime LastContact { get; set; }
        public bool UnRegister { get; set; }
    }
}