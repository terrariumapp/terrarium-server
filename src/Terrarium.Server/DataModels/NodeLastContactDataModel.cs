using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class NodeLastContactDataModel : EntityTypeConfiguration<NodeLastContact>
    {
        public NodeLastContactDataModel()
        {
            ToTable("NodeLastContact");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GUID).IsRequired();
            Property(x => x.LastTick).IsRequired();
            Property(x => x.LastContact).IsRequired();
        }
    }
}