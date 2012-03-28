using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_SmallSumFCInterestRateMap : EntityTypeConfiguration<ED_SmallSumFCInterestRate>
	{
		public ED_SmallSumFCInterestRateMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_SmallSumFCInterestRate");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.AdjustDate).HasColumnName("AdjustDate");
			this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
			this.Property(t => t.SR_DemandDeposit).HasColumnName("SR_DemandDeposit");
			this.Property(t => t.SR_7daysNotice).HasColumnName("SR_7daysNotice");
			this.Property(t => t.SR_1month).HasColumnName("SR_1month");
			this.Property(t => t.SR_3months).HasColumnName("SR_3months");
			this.Property(t => t.SR_6months).HasColumnName("SR_6months");
			this.Property(t => t.SR_1year).HasColumnName("SR_1year");
			this.Property(t => t.SR_2years).HasColumnName("SR_2years");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

