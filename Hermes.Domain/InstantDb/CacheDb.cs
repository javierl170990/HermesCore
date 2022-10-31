using Hermes.Domain.Entities;

using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain.InstantDb
{
    public class CacheDb : DbContext
    {
        public CacheDb() { }

        public DbSet<UserMessage> Messages { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // To remove the requests to the Migration History table
            Database.SetInitializer<CacheDb>(null);
            // To remove the plural names   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
    