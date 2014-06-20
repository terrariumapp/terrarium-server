using System;

namespace Terrarium.Server.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public DateTime DateAdded { get; set; }
        public string AssemblyFullName { get; set; }
        public int Extinct { get; set; }
        public DateTime LastReintroduction { get; set; }
        public Guid ReintroductionNode { get; set; }
        public string Version { get; set; }
        public bool BlackListed { get; set; }
        public DateTime ExtinctDate { get; set; }
    }
}