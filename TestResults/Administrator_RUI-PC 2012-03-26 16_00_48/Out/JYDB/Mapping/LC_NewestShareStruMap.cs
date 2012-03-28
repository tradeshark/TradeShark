using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_NewestShareStruMap : EntityTypeConfiguration<LC_NewestShareStru>
	{
		public LC_NewestShareStruMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_NewestShareStru");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.NonListedShares).HasColumnName("NonListedShares");
			this.Property(t => t.PromoterShares).HasColumnName("PromoterShares");
			this.Property(t => t.StateShares).HasColumnName("StateShares");
			this.Property(t => t.DLegalPersonShares).HasColumnName("DLegalPersonShares");
			this.Property(t => t.FLegalPersonShares).HasColumnName("FLegalPersonShares");
			this.Property(t => t.OtherPromoterShares).HasColumnName("OtherPromoterShares");
			this.Property(t => t.RaisedLPShares).HasColumnName("RaisedLPShares");
			this.Property(t => t.NaturalPersonHoldLPShares).HasColumnName("NaturalPersonHoldLPShares");
			this.Property(t => t.StaffShares).HasColumnName("StaffShares");
			this.Property(t => t.RightsIssueTransferred).HasColumnName("RightsIssueTransferred");
			this.Property(t => t.PreferredAndOtherShares).HasColumnName("PreferredAndOtherShares");
			this.Property(t => t.PreferredShares).HasColumnName("PreferredShares");
			this.Property(t => t.FloatShare).HasColumnName("FloatShare");
			this.Property(t => t.AFloats).HasColumnName("AFloats");
			this.Property(t => t.AFloatListed).HasColumnName("AFloatListed");
			this.Property(t => t.ManagementShares).HasColumnName("ManagementShares");
			this.Property(t => t.StategicInvestorShares).HasColumnName("StategicInvestorShares");
			this.Property(t => t.CommonLPShares).HasColumnName("CommonLPShares");
			this.Property(t => t.MutualFundShares).HasColumnName("MutualFundShares");
			this.Property(t => t.AdditionalIssueUnlisted).HasColumnName("AdditionalIssueUnlisted");
			this.Property(t => t.RightsIssueUnlisted).HasColumnName("RightsIssueUnlisted");
			this.Property(t => t.Bshares).HasColumnName("Bshares");
			this.Property(t => t.Hshares).HasColumnName("Hshares");
			this.Property(t => t.Sshares).HasColumnName("Sshares");
			this.Property(t => t.Nshares).HasColumnName("Nshares");
			this.Property(t => t.OtherFloatShares).HasColumnName("OtherFloatShares");
			this.Property(t => t.TotalShares).HasColumnName("TotalShares");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.SLegalPersonShares).HasColumnName("SLegalPersonShares");
			this.Property(t => t.RaisedSLPShares).HasColumnName("RaisedSLPShares");
			this.Property(t => t.OtherAFloatShares).HasColumnName("OtherAFloatShares");
			this.Property(t => t.RestrictedAFloatShares).HasColumnName("RestrictedAFloatShares");
			this.Property(t => t.RestrinctStaffShares).HasColumnName("RestrinctStaffShares");
			this.Property(t => t.NonListedBShares).HasColumnName("NonListedBShares");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.RestrictedShares).HasColumnName("RestrictedShares");
			this.Property(t => t.StateHolding).HasColumnName("StateHolding");
			this.Property(t => t.SLegalPersonHolding).HasColumnName("SLegalPersonHolding");
			this.Property(t => t.OtherDCapitalHolding).HasColumnName("OtherDCapitalHolding");
			this.Property(t => t.DLegalPersonHolding).HasColumnName("DLegalPersonHolding");
			this.Property(t => t.DNaturalPersonHolding).HasColumnName("DNaturalPersonHolding");
			this.Property(t => t.ForeignHolding).HasColumnName("ForeignHolding");
			this.Property(t => t.FLegalPersonHolding).HasColumnName("FLegalPersonHolding");
			this.Property(t => t.FNaturalPersonHolding).HasColumnName("FNaturalPersonHolding");
			this.Property(t => t.OtherRestrictedShares).HasColumnName("OtherRestrictedShares");
			this.Property(t => t.RestrictedBFloatShares).HasColumnName("RestrictedBFloatShares");
			this.Property(t => t.PerValue).HasColumnName("PerValue");
			this.Property(t => t.Rpt_RestrictedShares).HasColumnName("Rpt_RestrictedShares");
			this.Property(t => t.Rpt_StateHolding).HasColumnName("Rpt_StateHolding");
			this.Property(t => t.Rpt_SLegalPersonHolding).HasColumnName("Rpt_SLegalPersonHolding");
			this.Property(t => t.Rpt_OtherDCapitalHolding).HasColumnName("Rpt_OtherDCapitalHolding");
			this.Property(t => t.Rpt_DLegalPersonHolding).HasColumnName("Rpt_DLegalPersonHolding");
			this.Property(t => t.Rpt_DNaturalPersonHolding).HasColumnName("Rpt_DNaturalPersonHolding");
			this.Property(t => t.Rpt_ForeignHolding).HasColumnName("Rpt_ForeignHolding");
			this.Property(t => t.Rpt_FLegalPersonHolding).HasColumnName("Rpt_FLegalPersonHolding");
			this.Property(t => t.Rpt_FNaturalPersonHolding).HasColumnName("Rpt_FNaturalPersonHolding");
			this.Property(t => t.Rpt_FloatListed).HasColumnName("Rpt_FloatListed");
			this.Property(t => t.Rpt_AFloatListed).HasColumnName("Rpt_AFloatListed");
			this.Property(t => t.Rpt_BFloatListed).HasColumnName("Rpt_BFloatListed");
			this.Property(t => t.Rpt_FFloatListed).HasColumnName("Rpt_FFloatListed");
			this.Property(t => t.Rpt_OtherFloatShares).HasColumnName("Rpt_OtherFloatShares");
			this.Property(t => t.Rpt_TotalShares).HasColumnName("Rpt_TotalShares");
			this.Property(t => t.Ashares).HasColumnName("Ashares");
			this.Property(t => t.NonRestrictedShares).HasColumnName("NonRestrictedShares");
			this.Property(t => t.BsharesTotal).HasColumnName("BsharesTotal");
			this.Property(t => t.ListedBShares).HasColumnName("ListedBShares");
			this.Property(t => t.NonListedRestrictedBShares).HasColumnName("NonListedRestrictedBShares");
			this.Property(t => t.ForeignHoldingAshares).HasColumnName("ForeignHoldingAshares");
			this.Property(t => t.RestrictedAShares).HasColumnName("RestrictedAShares");
			this.Property(t => t.Rpt_ManagementShares).HasColumnName("Rpt_ManagementShares");
		}
	}
}

