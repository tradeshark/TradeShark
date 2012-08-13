using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SMTVotingMap : EntityTypeConfiguration<LC_SMTVoting>
	{
		public LC_SMTVotingMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Title)
				.HasMaxLength(200);
				
			this.Property(t => t.Subtitle)
				.HasMaxLength(200);
				
			this.Property(t => t.SHName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_SMTVoting");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.TitleSN).HasColumnName("TitleSN");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.SubtitleSN).HasColumnName("SubtitleSN");
			this.Property(t => t.Subtitle).HasColumnName("Subtitle");
			this.Property(t => t.SHNumber).HasColumnName("SHNumber");
			this.Property(t => t.SHName).HasColumnName("SHName");
			this.Property(t => t.SHKind).HasColumnName("SHKind");
			this.Property(t => t.SHCorporationSN).HasColumnName("SHCorporationSN");
			this.Property(t => t.ShareCharacter).HasColumnName("ShareCharacter");
			this.Property(t => t.HoldSum).HasColumnName("HoldSum");
			this.Property(t => t.PCTOfTotalShares).HasColumnName("PCTOfTotalShares");
			this.Property(t => t.Opinion).HasColumnName("Opinion");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

