using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class DownloadDataModel : EntityTypeConfiguration<Download>
    {
        public DownloadDataModel()
        {
            ToTable("Downloads");
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Filename).IsRequired().HasMaxLength(255);
            Property(x => x.DownloadCount).IsRequired();
            Property(x => x.LastDownloadDate).IsRequired();
        }
    }
}