using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class HistoryDataModel : EntityTypeConfiguration<History>
    {
        public HistoryDataModel()
        {
            ToTable("History");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GUID).IsRequired();
            Property(x => x.TickNumber).IsRequired();
            Property(x => x.SpeciesName).IsRequired().HasMaxLength(255);
            Property(x => x.ContactTime).IsRequired();
            Property(x => x.ClientTime).IsRequired();
            Property(x => x.CorrectTime).IsRequired();
            Property(x => x.Population).IsRequired();
            Property(x => x.BirthCount).IsRequired();
            Property(x => x.TeleportedToCount).IsRequired();
            Property(x => x.StarvedCount).IsRequired();
            Property(x => x.KilledCount).IsRequired();
            Property(x => x.TeleportedFromCount).IsRequired();
            Property(x => x.ErrorCount).IsRequired();
            Property(x => x.TimeoutCount).IsRequired();
            Property(x => x.SickCount).IsRequired();
            Property(x => x.OldAgeCount).IsRequired();
            Property(x => x.SecurityViolationCount).IsRequired();
        }
    }
}