using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_InterestPaymentMap : EntityTypeConfiguration<BD_InterestPayment>
	{
		public BD_InterestPaymentMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.FullName, t.ValueDatePer, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.FullName)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.PaymentYear)
				.IsFixedLength()
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("BD_InterestPayment");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.FullName).HasColumnName("FullName");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PaymentYear).HasColumnName("PaymentYear");
			this.Property(t => t.Number).HasColumnName("Number");
			this.Property(t => t.BaseSize).HasColumnName("BaseSize");
			this.Property(t => t.ValueDatePer).HasColumnName("ValueDatePer");
			this.Property(t => t.ValueDateNextPer).HasColumnName("ValueDateNextPer");
			this.Property(t => t.CouponRatePer).HasColumnName("CouponRatePer");
			this.Property(t => t.FRNRefRatePer).HasColumnName("FRNRefRatePer");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.RegDate).HasColumnName("RegDate");
			this.Property(t => t.ExDividendDate).HasColumnName("ExDividendDate");
			this.Property(t => t.PaymentDate).HasColumnName("PaymentDate");
			this.Property(t => t.Interest).HasColumnName("Interest");
			this.Property(t => t.InterestDeductedTax).HasColumnName("InterestDeductedTax");
			this.Property(t => t.InterestTaxRate).HasColumnName("InterestTaxRate");
			this.Property(t => t.CouponRateNextPer).HasColumnName("CouponRateNextPer");
			this.Property(t => t.FRNRefRateNextPer).HasColumnName("FRNRefRateNextPer");
			this.Property(t => t.AccumulatedPaymentNum).HasColumnName("AccumulatedPaymentNum");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

