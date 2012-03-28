using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_UsualIndexMap : EntityTypeConfiguration<BD_UsualIndex>
	{
		public BD_UsualIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("BD_UsualIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.ClosePriceDt).HasColumnName("ClosePriceDt");
			this.Property(t => t.AccruedInterest).HasColumnName("AccruedInterest");
			this.Property(t => t.YTM).HasColumnName("YTM");
			this.Property(t => t.Duration).HasColumnName("Duration");
			this.Property(t => t.Duration2).HasColumnName("Duration2");
			this.Property(t => t.Convexity).HasColumnName("Convexity");
			this.Property(t => t.RemainPaymentNum).HasColumnName("RemainPaymentNum");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

