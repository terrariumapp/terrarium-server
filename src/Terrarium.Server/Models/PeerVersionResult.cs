namespace Terrarium.Server.Models
{
    public class PeerVersionResult
    {
        /// <summary>
        /// True if the version is enabled, false otherwise
        /// </summary>
        public bool Result { get; set; }
        /// <summary>
        /// This is an admin message that the client will display if the version is disabled
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}