using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_AccruedExpenseMap : EntityTypeConfiguration<LC_AccruedExpense>
	{
		public LC_AccruedExpenseMap()
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
			this.ToTable("LC_AccruedExpense");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AccruedInterest).HasColumnName("AccruedInterest");
			this.Property(t => t.AccruedLeaseFee).HasColumnName("AccruedLeaseFee");
			this.Property(t => t.AccruedPowerFee).HasColumnName("AccruedPowerFee");
			this.Property(t => t.AccruedRepairmentFee).HasColumnName("AccruedRepairmentFee");
			this.Property(t => t.AccruedAdFee).HasColumnName("AccruedAdFee");
			this.Property(t => t.AccruedTLSFee).HasColumnName("AccruedTLSFee");
			this.Property(t => t.AccruedProcessFee).HasColumnName("AccruedProcessFee");
			this.Property(t => t.AccruedResearchFee).HasColumnName("AccruedResearchFee");
			this.Property(t => t.AccruedOtherFees).HasColumnName("AccruedOtherFees");
			this.Property(t => t.WageWelfare).HasColumnName("WageWelfare");
			this.Property(t => t.InsuranceAndPension).HasColumnName("InsuranceAndPension");
			this.Property(t => t.GovernmentTaxAndFee).HasColumnName("GovernmentTaxAndFee");
			this.Property(t => t.AgentFee).HasColumnName("AgentFee");
			this.Property(t => t.SaleFee).HasColumnName("SaleFee");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

