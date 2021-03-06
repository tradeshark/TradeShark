using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_ZQ_InterestRateMap : EntityTypeConfiguration<VIEW_ZQ_InterestRate>
	{
		public VIEW_ZQ_InterestRateMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.Number, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_FRNRefRateText)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Number)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_ZQ_InterestRate");
			this.Property(t => t.N_FRNRefRateText).HasColumnName("N_FRNRefRateText");
			this.Property(t => t.N_FRNRefRatePer).HasColumnName("N_FRNRefRatePer");
			this.Property(t => t.N_CouponRatePer).HasColumnName("N_CouponRatePer");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.FRNRefRateText).HasColumnName("FRNRefRateText");
			this.Property(t => t.FRNRefRatePer).HasColumnName("FRNRefRatePer");
			this.Property(t => t.Number).HasColumnName("Number");
			this.Property(t => t.ValueDatePer).HasColumnName("ValueDatePer");
			this.Property(t => t.LastDatePer).HasColumnName("LastDatePer");
			this.Property(t => t.CouponRatePer).HasColumnName("CouponRatePer");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

