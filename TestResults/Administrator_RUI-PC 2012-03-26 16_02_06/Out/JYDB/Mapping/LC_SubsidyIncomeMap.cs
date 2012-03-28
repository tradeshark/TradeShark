using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SubsidyIncomeMap : EntityTypeConfiguration<LC_SubsidyIncome>
	{
		public LC_SubsidyIncomeMap()
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
			this.ToTable("LC_SubsidyIncome");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.TaxReduExemRefund).HasColumnName("TaxReduExemRefund");
			this.Property(t => t.TaxReduExemRefund_VAT).HasColumnName("TaxReduExemRefund_VAT");
			this.Property(t => t.TaxReduExemRefund_IT).HasColumnName("TaxReduExemRefund_IT");
			this.Property(t => t.TaxReduExemRefund_BT).HasColumnName("TaxReduExemRefund_BT");
			this.Property(t => t.FiscalInterestSubsidy).HasColumnName("FiscalInterestSubsidy");
			this.Property(t => t.ExportSubsidy).HasColumnName("ExportSubsidy");
			this.Property(t => t.ExportRebate).HasColumnName("ExportRebate");
			this.Property(t => t.ExportInterestSubsidy).HasColumnName("ExportInterestSubsidy");
			this.Property(t => t.Compensation).HasColumnName("Compensation");
			this.Property(t => t.TechSubsidyAndSupportFund).HasColumnName("TechSubsidyAndSupportFund");
			this.Property(t => t.SurpportFund).HasColumnName("SurpportFund");
			this.Property(t => t.TechSubsidy).HasColumnName("TechSubsidy");
			this.Property(t => t.FiscalSubsidy).HasColumnName("FiscalSubsidy");
			this.Property(t => t.OtherSubsidy).HasColumnName("OtherSubsidy");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

