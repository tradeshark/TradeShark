using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class tb_stock_perf_bakMap : EntityTypeConfiguration<tb_stock_perf_bak>
	{
		public tb_stock_perf_bakMap()
		{
			// Primary Key
			this.HasKey(t => new { t.id, t.innercode, t.tradingday, t.adjustprice, t.referday, t.referprice, t.standard, t.industry });

			// Properties
			this.Property(t => t.innercode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.secucode)
				.HasMaxLength(50);
				
			this.Property(t => t.adjustprice)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.referprice)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.standard)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.industry)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("tb_stock_perf_bak");
			this.Property(t => t.id).HasColumnName("id");
			this.Property(t => t.innercode).HasColumnName("innercode");
			this.Property(t => t.secucode).HasColumnName("secucode");
			this.Property(t => t.tradingday).HasColumnName("tradingday");
			this.Property(t => t.adjustprice).HasColumnName("adjustprice");
			this.Property(t => t.referday).HasColumnName("referday");
			this.Property(t => t.referprice).HasColumnName("referprice");
			this.Property(t => t.standard).HasColumnName("standard");
			this.Property(t => t.industry).HasColumnName("industry");
			this.Property(t => t.yield).HasColumnName("yield");
			this.Property(t => t.yieldrank).HasColumnName("yieldrank");
			this.Property(t => t.risk).HasColumnName("risk");
			this.Property(t => t.riskrank).HasColumnName("riskrank");
			this.Property(t => t.yrvalue).HasColumnName("yrvalue");
			this.Property(t => t.yrrank).HasColumnName("yrrank");
			this.Property(t => t.stocknum).HasColumnName("stocknum");
		}
	}
}

