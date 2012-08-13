using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FinancialEngineering.Data.Database.JYDB.Entities;
using FinancialEngineering.Data.Database.JYDB.Mapping;

namespace FinancialEngineering.Data.Database.JYDB
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
			System.Data.Entity.Database.SetInitializer<JYDBContext>(null);
		}

		
		public DbSet<QT_DailyQuote> QT_DailyQuote { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new QT_DailyQuoteMap());
            base.OnModelCreating(modelBuilder);
        }
	}
}

