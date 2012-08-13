using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_MainSHListMap : EntityTypeConfiguration<LC_MainSHList>
	{
		public LC_MainSHListMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.SHList, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.SHList)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.PFStatement)
				.HasMaxLength(200);
				
			this.Property(t => t.ConnectionRelation)
				.HasMaxLength(20);
				
			this.Property(t => t.ConnectionStatement)
				.HasMaxLength(200);
				
			this.Property(t => t.ActInConcertStatement)
				.HasMaxLength(200);
				
			this.Property(t => t.Notes)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_MainSHList");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.InfoType).HasColumnName("InfoType");
			this.Property(t => t.SHNo).HasColumnName("SHNo");
			this.Property(t => t.SHList).HasColumnName("SHList");
			this.Property(t => t.SHKind).HasColumnName("SHKind");
			this.Property(t => t.SecuCoBelongedCode).HasColumnName("SecuCoBelongedCode");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.HoldSum).HasColumnName("HoldSum");
			this.Property(t => t.PCTOfTotalShares).HasColumnName("PCTOfTotalShares");
			this.Property(t => t.ShareCharacter).HasColumnName("ShareCharacter");
			this.Property(t => t.PledgeInvolvedSum).HasColumnName("PledgeInvolvedSum");
			this.Property(t => t.FreezeInvolvedSum).HasColumnName("FreezeInvolvedSum");
			this.Property(t => t.PFStatement).HasColumnName("PFStatement");
			this.Property(t => t.ConnectionRelation).HasColumnName("ConnectionRelation");
			this.Property(t => t.ConnectionStatement).HasColumnName("ConnectionStatement");
			this.Property(t => t.ActInConcertStatement).HasColumnName("ActInConcertStatement");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.SHType).HasColumnName("SHType");
			this.Property(t => t.RestrainedTShare).HasColumnName("RestrainedTShare");
			this.Property(t => t.UnstintedTShare).HasColumnName("UnstintedTShare");
			this.Property(t => t.FloatSHNo).HasColumnName("FloatSHNo");
			this.Property(t => t.FrontSHNo).HasColumnName("FrontSHNo");
		}
	}
}

