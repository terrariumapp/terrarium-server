using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class DailyPopulationDataModel : EntityTypeConfiguration<DailyPopulation>
    {
        public DailyPopulationDataModel()
        {
            ToTable("DailyPopulation");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SampleDateTime).IsRequired();
            Property(x => x.SpeciesName).IsRequired().HasMaxLength(255);
            Property(x => x.Population).IsRequired();
            Property(x => x.BirthCount).IsRequired();
            Property(x => x.StarvedCount).IsRequired();
            Property(x => x.KilledCount).IsRequired();
            Property(x => x.ErrorCount).IsRequired();
            Property(x => x.TimeoutCount).IsRequired();
            Property(x => x.SickCount).IsRequired();
            Property(x => x.OldAgeCount).IsRequired();
            Property(x => x.SecurityViolationCount).IsRequired();
        }
    }
}