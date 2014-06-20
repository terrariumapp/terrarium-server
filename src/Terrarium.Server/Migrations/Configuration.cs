using System.Data.Entity.Migrations;
using System.Linq;
using Terrarium.Server.DataModels;
using Terrarium.Server.Models;

namespace Terrarium.Server.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TerrariumDbContext>
    {
        private readonly bool _pendingMigrations;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Terrarium.Server.DataModels.TerrariumDbContext";
            var migrator = new DbMigrator(this);
            _pendingMigrations = migrator.GetPendingMigrations().Any();
        }

        protected override void Seed(TerrariumDbContext context)
        {
            if (!_pendingMigrations) return;
            context.Tips.AddOrUpdate(new RandomTip { Tip = "You can use Alt-Enter to enter a true Full-Screen view." });
//            context.VersionedSettings.AddOrUpdate(new VersionedSetting {Version = "Default", Disabled = 0, Message = ""});
        }
    }
}