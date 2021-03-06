using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_ShareStruMap : EntityTypeConfiguration<View_GP_ShareStru>
	{
		public View_GP_ShareStruMap()
		{
			// Primary Key
			this.HasKey(t => new { t.变动日, t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_ChangeType)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("View_GP_ShareStru");
			this.Property(t => t.N_ChangeType).HasColumnName("N_ChangeType");
			this.Property(t => t.变动日).HasColumnName("变动日");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
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
		}
	}
}

