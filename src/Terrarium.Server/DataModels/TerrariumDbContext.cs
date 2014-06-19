using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Terrarium.Server.Models;

namespace Terrarium.Server.DataModels
{
    public class TerrariumDbContext : DbContext, ITerrariumDbContext
    {
        public TerrariumDbContext() : base("TerrariumDb")
        {
            Trace.Write(Database.Connection.ConnectionString);
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