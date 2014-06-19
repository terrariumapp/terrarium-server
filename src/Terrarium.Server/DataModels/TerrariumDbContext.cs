using System.Data.Entity;
using System.Linq;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class TerrariumDbContext : DbContext, ITerrariumDbContext
    {
        public TerrariumDbContext() : base("TerrariumDb")
        {
        }

        public DbSet<RandomTip> Tips { get; set; }

        public DbSet<Usage> Usages { get; set; }

        IQueryable<RandomTip> ITerrariumDbContext.Tips
        {
            get { return Tips; }
        }

        IQueryable<Usage> ITerrariumDbContext.Usages
        {
            get { return Usages; }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RandomTipDataModel());
            modelBuilder.Configurations.Add(new UsageDataModel());
        }
    }
}