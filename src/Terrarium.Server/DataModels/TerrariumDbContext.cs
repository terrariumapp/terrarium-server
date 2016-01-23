using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class TerrariumDbContext : DbContext, ITerrariumDbContext
    {
        public TerrariumDbContext() : base("TerrariumDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TerrariumDbContext>());
//            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TerrariumDbContext, Configuration>());
        }

        public DbSet<Watson> Errors { get; set; }

        public DbSet<RandomTip> Tips { get; set; }

        public DbSet<Usage> Usages { get; set; }

        public DbSet<UserRegister> Users { get; set; }

        IQueryable<UserRegister> ITerrariumDbContext.Users
        {
            get { return Users; }
        }

        IQueryable<Watson> ITerrariumDbContext.Errors
        {
            get { return Errors; }
        }

        IQueryable<RandomTip> ITerrariumDbContext.Tips
        {
            get { return Tips; }
        }

        IQueryable<Usage> ITerrariumDbContext.Usages
        {
            get { return Usages; }
        }

        public void AddError(Watson data)
        {
            Errors.Add(data);
            SaveChanges();
        }

        public void AddUsage(Usage data)
        {
            if (Usages.Any(x => x.Alias == data.Alias))
            {
                var record = Usages.Where(x => x.Alias == data.Alias).OrderByDescending(x => x.TickTime).First();
                var lastTickTime = record == null ? DateTime.MinValue : record.TickTime;
                var currentTickTime = DateTime.Now;
                var diff = currentTickTime.Subtract(lastTickTime);
                if (!(diff.TotalMinutes >= 60)) return;
                Usages.Add(data);
            }
            else
            {
                Usages.Add(data);
            }
            SaveChanges();
        }

        public void AddUser(UserRegister data)
        {
            if (Users.Any(x => x.IPAddress == data.IPAddress))
            {
                var user = Users.First(x => x.IPAddress == data.IPAddress);
                user.Email = data.Email;
            }
            else
            {
                Users.Add(data);
            }
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var configurationInstance in typesToRegister.Select(Activator.CreateInstance))
            {
                modelBuilder.Configurations.Add((dynamic) configurationInstance);
            }
        }
    }
}