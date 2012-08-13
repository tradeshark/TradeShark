using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_AccruedBondInterestMap : EntityTypeConfiguration<BD_AccruedBondInterest>
	{
		public BD_AccruedBondInterestMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.TradingDay, t.DateOfCouponPayment, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("BD_AccruedBondInterest");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.StartDateOfThisCoupon).HasColumnName("StartDateOfThisCoupon");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.DateOfCouponPayment).HasColumnName("DateOfCouponPayment");
			this.Property(t => t.AccruedInterest).HasColumnName("AccruedInterest");
			this.Property(t => t.AccruedDays).HasColumnName("AccruedDays");
			this.Property(t => t.DaysToNextCoupon).HasColumnName("DaysToNextCoupon");
			this.Property(t => t.CouponRate).HasColumnName("CouponRate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

