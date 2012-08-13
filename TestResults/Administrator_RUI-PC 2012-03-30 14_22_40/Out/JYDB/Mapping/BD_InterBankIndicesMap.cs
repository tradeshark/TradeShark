using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_InterBankIndicesMap : EntityTypeConfiguration<BD_InterBankIndices>
	{
		public BD_InterBankIndicesMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("BD_InterBankIndices");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.IndexValue).HasColumnName("IndexValue");
			this.Property(t => t.Duration1).HasColumnName("Duration1");
			this.Property(t => t.Duration2).HasColumnName("Duration2");
			this.Property(t => t.Convexity1).HasColumnName("Convexity1");
			this.Property(t => t.Convexity2).HasColumnName("Convexity2");
			this.Property(t => t.YTM).HasColumnName("YTM");
			this.Property(t => t.TTM).HasColumnName("TTM");
			this.Property(t => t.InterestPaymentRate).HasColumnName("InterestPaymentRate");
			this.Property(t => t.TotalMarketValue).HasColumnName("TotalMarketValue");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

