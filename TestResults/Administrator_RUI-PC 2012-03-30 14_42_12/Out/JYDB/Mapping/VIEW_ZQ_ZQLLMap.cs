using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_ZQ_ZQLLMap : EntityTypeConfiguration<VIEW_ZQ_ZQLL>
	{
		public VIEW_ZQ_ZQLLMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.Number, t.XGRQ });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.FRNRefRateText)
				.HasMaxLength(300);
				
			this.Property(t => t.Number)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_ZQ_ZQLL");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.FRNRefRateText).HasColumnName("FRNRefRateText");
			this.Property(t => t.FRNRefRatePer).HasColumnName("FRNRefRatePer");
			this.Property(t => t.Number).HasColumnName("Number");
			this.Property(t => t.ValueDatePer).HasColumnName("ValueDatePer");
			this.Property(t => t.LastDatePer).HasColumnName("LastDatePer");
			this.Property(t => t.CouponRatePer).HasColumnName("CouponRatePer");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

