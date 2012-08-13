using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_BOCForexQuoteMap : EntityTypeConfiguration<ED_BOCForexQuote>
	{
		public ED_BOCForexQuoteMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ED_BOCForexQuote");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.StatPeriodCode).HasColumnName("StatPeriodCode");
			this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
			this.Property(t => t.BidPriceSpot).HasColumnName("BidPriceSpot");
			this.Property(t => t.BidPriceCurrency).HasColumnName("BidPriceCurrency");
			this.Property(t => t.AskedPriceSpot).HasColumnName("AskedPriceSpot");
			this.Property(t => t.BenchMarkPrice).HasColumnName("BenchMarkPrice");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

