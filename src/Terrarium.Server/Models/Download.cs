using System;

namespace Terrarium.Server.Models
{
    public class Download
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public int DownloadCount { get; set; }
        public DateTime LastDownloadDate { get; set; }
    }
}