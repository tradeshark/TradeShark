using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_NonOperatingExpenseMap : EntityTypeConfiguration<LC_NonOperatingExpense>
	{
		public LC_NonOperatingExpenseMap()
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
			this.ToTable("LC_NonOperatingExpense");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AmercementExpense).HasColumnName("AmercementExpense");
			this.Property(t => t.SubSidyExpense).HasColumnName("SubSidyExpense");
			this.Property(t => t.AssetDealLoss).HasColumnName("AssetDealLoss");
			this.Property(t => t.CurrentAssetDealLoss).HasColumnName("CurrentAssetDealLoss");
			this.Property(t => t.FixedAssetDealLoss).HasColumnName("FixedAssetDealLoss");
			this.Property(t => t.IntangibleAssetDealLoss).HasColumnName("IntangibleAssetDealLoss");
			this.Property(t => t.AssetDevalueReserve).HasColumnName("AssetDevalueReserve");
			this.Property(t => t.FixedAssetReserve).HasColumnName("FixedAssetReserve");
			this.Property(t => t.ConstruInProcessReserve).HasColumnName("ConstruInProcessReserve");
			this.Property(t => t.IntangibleAssetReserve).HasColumnName("IntangibleAssetReserve");
			this.Property(t => t.AccruedDebtAndSecuredLoss).HasColumnName("AccruedDebtAndSecuredLoss");
			this.Property(t => t.AccruedLiability).HasColumnName("AccruedLiability");
			this.Property(t => t.SecurityLoss).HasColumnName("SecurityLoss");
			this.Property(t => t.TaxAndFeeExpense).HasColumnName("TaxAndFeeExpense");
			this.Property(t => t.VATExpense).HasColumnName("VATExpense");
			this.Property(t => t.DonationExpense).HasColumnName("DonationExpense");
			this.Property(t => t.OtherNonOperatingExpense).HasColumnName("OtherNonOperatingExpense");
			this.Property(t => t.DebtRearrangementLoss).HasColumnName("DebtRearrangementLoss");
			this.Property(t => t.ExtraordinaryLoss).HasColumnName("ExtraordinaryLoss");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

