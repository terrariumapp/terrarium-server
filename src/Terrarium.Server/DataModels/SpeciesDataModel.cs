using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class SpeciesDataModel : EntityTypeConfiguration<Species>
    {
        public SpeciesDataModel()
        {
            ToTable("Species");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Type).IsRequired().HasMaxLength(50);
            Property(x => x.Author).IsRequired().HasMaxLength(255);
            Property(x => x.AuthorEmail).IsRequired().HasMaxLength(255);
            Property(x => x.DateAdded).IsRequired();
            Property(x => x.AssemblyFullName).IsRequired();
            Property(x => x.Extinct).IsRequired();
            Property(x => x.Version).IsRequired().HasMaxLength(255);
            Property(x => x.BlackListed).IsRequired();
        }
    }
}