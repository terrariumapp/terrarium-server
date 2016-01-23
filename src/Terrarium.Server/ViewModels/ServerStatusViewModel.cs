namespace Terrarium.Server.ViewModels
{
    public class ServerStatusViewModel
    {
        public bool IsDatabaseUp { get; set; } 

        public bool IsServicesUp { get; set; }

        public int PeerCount { get; set; }
    }
}