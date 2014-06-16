using System;

namespace Terrarium.Server.Models
{
    public class Watson
    {
        public int Id { get; set; }
        public string LogType { get; set; }
        public string MachineName { get; set; }
        public string OSVersion { get; set; }
        public string GameVersion { get; set; }
        public string CLRVersion { get; set; }
        public string ErrorLog { get; set; }
        public string UserEmail { get; set; }
        public string UserComment { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}