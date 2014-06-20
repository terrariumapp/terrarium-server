using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class UsageDataModel : EntityTypeConfiguration<Usage>
    {
        public UsageDataModel()
        {
            ToTable("Usage");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Alias).IsRequired().HasMaxLength(255);
            Property(x => x.Domain).IsRequired().HasMaxLength(255);
            Property(x => x.TickTime).IsRequired();
            Property(x => x.UsageMinutes).IsRequired();
            Property(x => x.IPAddress).IsRequired().HasMaxLength(25);
            Property(x => x.GameVersion).IsRequired().HasMaxLength(255);
            Property(x => x.PeerChannel).IsRequired().HasMaxLength(255);
            Property(x => x.PeerCount).IsRequired();
            Property(x => x.AnimalCount).IsRequired();
            Property(x => x.MaxAnimalCount).IsRequired();
            Property(x => x.WorldHeight).IsRequired();
            Property(x => x.WorldWidth).IsRequired();
            Property(x => x.MachineName).IsRequired().HasMaxLength(255);
            Property(x => x.OSVersion).IsRequired().HasMaxLength(255);
            Property(x => x.ProcessorCount).IsRequired();
            Property(x => x.ClrVersion).IsRequired().HasMaxLength(255);
            Property(x => x.WorkingSet).IsRequired();
            Property(x => x.MinWorkingSet).IsRequired();
            Property(x => x.MaxWorkingSet).IsRequired();
            Property(x => x.ProcessorTime).IsRequired();
            Property(x => x.ProcessStarTime).IsRequired();
        }
    }
}