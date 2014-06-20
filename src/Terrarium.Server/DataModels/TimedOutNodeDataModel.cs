using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class TimedOutNodeDataModel : EntityTypeConfiguration<TimedOutNode>
    {
        public TimedOutNodeDataModel()
        {
            ToTable("TimedOutNodes");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GUID).IsRequired();
            Property(x => x.TimeoutDate).IsRequired();
        }
    }
}