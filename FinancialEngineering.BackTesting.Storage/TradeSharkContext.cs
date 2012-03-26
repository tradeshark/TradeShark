using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using FinancialEngineering.BackTesting.Model;
using System.ComponentModel.DataAnnotations;

namespace FinancialEngineering.BackTesting.Storage
{

    //Enable-Migrations -EnableAutomaticMigrations

    public class TradeSharkContext : DbContext
    {
        public TradeSharkContext(string connectionStringOrName) : base(connectionStringOrName)
        {

        }
        static  TradeSharkContext()
        {
            Database.SetInitializer<TradeSharkContext>(null);
        }
        public DbSet<MyPortfolio> MyPortfolios { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<StrategyPortfolio> StrategyPortfolios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Strategy>()
                .Property(s => s.Description)
                .HasMaxLength(1000);
            modelBuilder.Entity<Strategy>().Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<MyPortfolio>().Property(s => s.Id)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<StrategyPortfolio>().Property(s => s.Id)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            base.OnModelCreating(modelBuilder);
        }
    }
}
