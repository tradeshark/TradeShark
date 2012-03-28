using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ExchangeRateRMBtoUSDMap : EntityTypeConfiguration<ED_ExchangeRateRMBtoUSD>
	{
		public ED_ExchangeRateRMBtoUSDMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.DataReportPeriod, t.Currency, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			this.Property(t => t.DataReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Currency)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_ExchangeRateRMBtoUSD");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.DataReportPeriod).HasColumnName("DataReportPeriod");
			this.Property(t => t.Currency).HasColumnName("Currency");
			this.Property(t => t.ExchangeRatetoUSDollar).HasColumnName("ExchangeRatetoUSDollar");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

