using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class PeerDataModel : EntityTypeConfiguration<Peer>
    {
        public PeerDataModel()
        {
            ToTable("Peers");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Channel).IsRequired().HasMaxLength(32);
            Property(x => x.IPAddress).IsRequired().HasMaxLength(16);
            Property(x => x.Lease).IsRequired();
            Property(x => x.Version).IsRequired().HasMaxLength(16);
            Property(x => x.FirstContact).IsRequired();
        }
    }
}