using System.Data.Entity;
using System.Linq;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class TerrariumDbContext : DbContext
    {
//        public DbSet<Watson> WatsonDbSet { get; set; }
        public DbSet<RandomTip> RandomTips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
//            modelBuilder.Configurations.Add(new WatsonDataModel());
            modelBuilder.Configurations.Add(new RandomTipDataModel());
        }
    }
}