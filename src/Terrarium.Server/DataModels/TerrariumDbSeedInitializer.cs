using System.Data.Entity;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class TerrariumDbSeedInitializer : DropCreateDatabaseAlways<TerrariumDbContext>
    {
        protected override void Seed(TerrariumDbContext context)
        {
            context.Tips.Add(new RandomTip { Tip = "You can use Alt-Enter to enter a true Full-Screen view." });
            context.SaveChanges();
        }
    }
}