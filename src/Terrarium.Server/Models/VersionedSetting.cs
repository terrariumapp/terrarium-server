namespace Terrarium.Server.Models
{
    public class VersionedSetting
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public int Disabled { get; set; }
        public string Message { get; set; }
    }
}