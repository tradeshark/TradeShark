using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_NonOperatingIncomeMap : EntityTypeConfiguration<LC_NonOperatingIncome>
	{
		public LC_NonOperatingIncomeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_NonOperatingIncome");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AmercementIncome).HasColumnName("AmercementIncome");
			this.Property(t => t.CompensationIncome).HasColumnName("CompensationIncome");
			this.Property(t => t.AssetDealIncome).HasColumnName("AssetDealIncome");
			this.Property(t => t.CurrentAsset).HasColumnName("CurrentAsset");
			this.Property(t => t.FixedAsset).HasColumnName("FixedAsset");
			this.Property(t => t.IntangibleAsset).HasColumnName("IntangibleAsset");
			this.Property(t => t.NonPerformingAsset).HasColumnName("NonPerformingAsset");
			this.Property(t => t.LossSwitchBack).HasColumnName("LossSwitchBack");
			this.Property(t => t.debtUnneededPay).HasColumnName("debtUnneededPay");
			this.Property(t => t.InterestofFreezeCapital).HasColumnName("InterestofFreezeCapital");
			this.Property(t => t.TaxAndFeeRefund).HasColumnName("TaxAndFeeRefund");
			this.Property(t => t.VATIncome).HasColumnName("VATIncome");
			this.Property(t => t.OtherNonOperatingIncome).HasColumnName("OtherNonOperatingIncome");
			this.Property(t => t.DebtRearrangementIncom).HasColumnName("DebtRearrangementIncom");
			this.Property(t => t.SubsidyIncome).HasColumnName("SubsidyIncome");
			this.Property(t => t.AwardIncome).HasColumnName("AwardIncome");
			this.Property(t => t.CommissionIncome).HasColumnName("CommissionIncome");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

