using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_ShareReformMap : EntityTypeConfiguration<View_GP_ShareReform>
	{
		public View_GP_ShareReformMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InitialInfoPublDate });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Program)
				.HasMaxLength(500);
				
			this.Property(t => t.Notes)
				.HasMaxLength(500);
				
			this.Property(t => t.GainerShareKind)
				.HasMaxLength(300);
				
			// Table & Column Mappings
			this.ToTable("View_GP_ShareReform");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.LatestInfoPublDate).HasColumnName("LatestInfoPublDate");
			this.Property(t => t.DMDate).HasColumnName("DMDate");
			this.Property(t => t.DMDAnnounceDate).HasColumnName("DMDAnnounceDate");
			this.Property(t => t.SMRecordDate).HasColumnName("SMRecordDate");
			this.Property(t => t.OnlineVotingStartDate).HasColumnName("OnlineVotingStartDate");
			this.Property(t => t.OnlineVotingEndDate).HasColumnName("OnlineVotingEndDate");
			this.Property(t => t.SMDate).HasColumnName("SMDate");
			this.Property(t => t.IDCollectStartDate).HasColumnName("IDCollectStartDate");
			this.Property(t => t.IDCollectEndDate).HasColumnName("IDCollectEndDate");
			this.Property(t => t.SMDAnnounceDate).HasColumnName("SMDAnnounceDate");
			this.Property(t => t.ImplementionAnnouceDate).HasColumnName("ImplementionAnnouceDate");
			this.Property(t => t.ImplementionRecordDate).HasColumnName("ImplementionRecordDate");
			this.Property(t => t.SConsiderationPayDate).HasColumnName("SConsiderationPayDate");
			this.Property(t => t.SConsiderationListDate).HasColumnName("SConsiderationListDate");
			this.Property(t => t.CConsiderationPayDate).HasColumnName("CConsiderationPayDate");
			this.Property(t => t.WarrantIssueDate).HasColumnName("WarrantIssueDate");
			this.Property(t => t.SuspendDate).HasColumnName("SuspendDate");
			this.Property(t => t.RecoverTradinDate).HasColumnName("RecoverTradinDate");
			this.Property(t => t.BaseShareCapital).HasColumnName("BaseShareCapital");
			this.Property(t => t.CompanyGrantedShare).HasColumnName("CompanyGrantedShare");
			this.Property(t => t.NTSHTranPaid).HasColumnName("NTSHTranPaid");
			this.Property(t => t.CompanyTransformedShare).HasColumnName("CompanyTransformedShare");
			this.Property(t => t.NTSHTranPaidTShare).HasColumnName("NTSHTranPaidTShare");
			this.Property(t => t.CompanyPaidCashBT).HasColumnName("CompanyPaidCashBT");
			this.Property(t => t.NTSHTranPaidCash).HasColumnName("NTSHTranPaidCash");
			this.Property(t => t.CompanyPaidCashAT).HasColumnName("CompanyPaidCashAT");
			this.Property(t => t.CashATfromCompany).HasColumnName("CashATfromCompany");
			this.Property(t => t.CashConsiderationRateAT).HasColumnName("CashConsiderationRateAT");
			this.Property(t => t.CompanyWarrantRate).HasColumnName("CompanyWarrantRate");
			this.Property(t => t.NTSNTranWarrant).HasColumnName("NTSNTranWarrant");
			this.Property(t => t.WarrantConsiderationRate).HasColumnName("WarrantConsiderationRate");
			this.Property(t => t.CallWarrant).HasColumnName("CallWarrant");
			this.Property(t => t.PutWarrant).HasColumnName("PutWarrant");
			this.Property(t => t.TotalSharePaid).HasColumnName("TotalSharePaid");
			this.Property(t => t.TotalCashPaid).HasColumnName("TotalCashPaid");
			this.Property(t => t.TotalWarrant).HasColumnName("TotalWarrant");
			this.Property(t => t.ShareConsiderationRate).HasColumnName("ShareConsiderationRate");
			this.Property(t => t.CashConsiderationRateBT).HasColumnName("CashConsiderationRateBT");
			this.Property(t => t.ShareConsideration).HasColumnName("ShareConsideration");
			this.Property(t => t.CashConsiderationR).HasColumnName("CashConsiderationR");
			this.Property(t => t.WarrantConsideration).HasColumnName("WarrantConsideration");
			this.Property(t => t.RatioOfNTShareBCompressed).HasColumnName("RatioOfNTShareBCompressed");
			this.Property(t => t.RatioOfNTShareACompressed).HasColumnName("RatioOfNTShareACompressed");
			this.Property(t => t.ShareCompressedOfNTShare).HasColumnName("ShareCompressedOfNTShare");
			this.Property(t => t.Program).HasColumnName("Program");
			this.Property(t => t.PricingBasis).HasColumnName("PricingBasis");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.GainerShareKind).HasColumnName("GainerShareKind");
		}
	}
}

