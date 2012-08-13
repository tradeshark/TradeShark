using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SMVotingMap : EntityTypeConfiguration<LC_SMVoting>
	{
		public LC_SMVotingMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Title)
				.HasMaxLength(200);
				
			this.Property(t => t.Subtitle)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_SMVoting");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.TitleSN).HasColumnName("TitleSN");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.SubtitleSN).HasColumnName("SubtitleSN");
			this.Property(t => t.Subtitle).HasColumnName("Subtitle");
			this.Property(t => t.IfConnectedTransaction).HasColumnName("IfConnectedTransaction");
			this.Property(t => t.ProposalType).HasColumnName("ProposalType");
			this.Property(t => t.IfPassed).HasColumnName("IfPassed");
			this.Property(t => t.SharesAvoiding).HasColumnName("SharesAvoiding");
			this.Property(t => t.SharesApprovedASH).HasColumnName("SharesApprovedASH");
			this.Property(t => t.RatioApprovedASH).HasColumnName("RatioApprovedASH");
			this.Property(t => t.SharesOpposedASH).HasColumnName("SharesOpposedASH");
			this.Property(t => t.RatioOpposedASH).HasColumnName("RatioOpposedASH");
			this.Property(t => t.SharesDisclaimedASH).HasColumnName("SharesDisclaimedASH");
			this.Property(t => t.RatioDisclaimedASH).HasColumnName("RatioDisclaimedASH");
			this.Property(t => t.SharesApprovedNTSH).HasColumnName("SharesApprovedNTSH");
			this.Property(t => t.RatioApprovedNTSH).HasColumnName("RatioApprovedNTSH");
			this.Property(t => t.SharesOpposedNTSH).HasColumnName("SharesOpposedNTSH");
			this.Property(t => t.RatioOpposedNTSH).HasColumnName("RatioOpposedNTSH");
			this.Property(t => t.SharesDisclaimedNTSH).HasColumnName("SharesDisclaimedNTSH");
			this.Property(t => t.RatioDisclaimedNTSH).HasColumnName("RatioDisclaimedNTSH");
			this.Property(t => t.SharesApprovedTSH).HasColumnName("SharesApprovedTSH");
			this.Property(t => t.RatioApprovedTSH).HasColumnName("RatioApprovedTSH");
			this.Property(t => t.ASharesApprovedTSH).HasColumnName("ASharesApprovedTSH");
			this.Property(t => t.BSharesApprovedTSH).HasColumnName("BSharesApprovedTSH");
			this.Property(t => t.HSharesApprovedTSH).HasColumnName("HSharesApprovedTSH");
			this.Property(t => t.OSharesApprovedTSH).HasColumnName("OSharesApprovedTSH");
			this.Property(t => t.SharesOpposedTSH).HasColumnName("SharesOpposedTSH");
			this.Property(t => t.RatioOpposedTSH).HasColumnName("RatioOpposedTSH");
			this.Property(t => t.ASharesOpposedTSH).HasColumnName("ASharesOpposedTSH");
			this.Property(t => t.BSharesOpposedTSH).HasColumnName("BSharesOpposedTSH");
			this.Property(t => t.HSharesOpposedTSH).HasColumnName("HSharesOpposedTSH");
			this.Property(t => t.OSharesOpposedTSH).HasColumnName("OSharesOpposedTSH");
			this.Property(t => t.SharesDisclaimedTSH).HasColumnName("SharesDisclaimedTSH");
			this.Property(t => t.RatioDisclaimedTSH).HasColumnName("RatioDisclaimedTSH");
			this.Property(t => t.ASharesDisclaimedTSH).HasColumnName("ASharesDisclaimedTSH");
			this.Property(t => t.BSharesDisclaimedTSH).HasColumnName("BSharesDisclaimedTSH");
			this.Property(t => t.HSharesDisclaimedTSH).HasColumnName("HSharesDisclaimedTSH");
			this.Property(t => t.OSharesDisclaimedTSH).HasColumnName("OSharesDisclaimedTSH");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

