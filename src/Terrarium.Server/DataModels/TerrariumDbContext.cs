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

        IQueryable<RandomTip> ITerrariumDbContext.Tips
        {
            get { return Tips; }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RandomTipDataModel());
        }
    }
}