using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.DataSets.Entities;
using System.Web.DataSets.Mapping;

namespace System.Web.DataSets
{
	public class JYDBContext : DbContext
	{
        public JYDBContext()
        {

        }
        public JYDBContext(string connectionNameOrString): base(connectionNameOrString)
        {

        }
		static JYDBContext()
		{ 
			Database.SetInitializer<JYDBContext>(null);
		}

		
		public DbSet<QT_DailyQuote> QT_DailyQuote { get; set; }
        public DbSet<SecuMain> SecuMain { get; set; }
        public DbSet<QT_AdjustingFactor> QT_AdjustingFactor { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Configurations.Add(new QT_DailyQuoteMap());
            modelBuilder.Configurations.Add(new SecuMainMap());
            modelBuilder.Configurations.Add(new QT_AdjustingFactorMap());
            base.OnModelCreating(modelBuilder);
        }
	}
}

