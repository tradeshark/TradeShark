using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_HolderInfoMap : EntityTypeConfiguration<MF_HolderInfo>
	{
		public MF_HolderInfoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("MF_HolderInfo");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.HolderAccountNumber).HasColumnName("HolderAccountNumber");
			this.Property(t => t.AverageHoldShares).HasColumnName("AverageHoldShares");
			this.Property(t => t.InstitutionHoldShares).HasColumnName("InstitutionHoldShares");
			this.Property(t => t.InstitutionHoldRatio).HasColumnName("InstitutionHoldRatio");
			this.Property(t => t.IndividualHoldshares).HasColumnName("IndividualHoldshares");
			this.Property(t => t.IndividualHoldRatio).HasColumnName("IndividualHoldRatio");
			this.Property(t => t.UndefinedHoldShares).HasColumnName("UndefinedHoldShares");
			this.Property(t => t.UndefinedHoldRatio).HasColumnName("UndefinedHoldRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.Top10HolderAmount).HasColumnName("Top10HolderAmount");
			this.Property(t => t.Top10HoldersProportion).HasColumnName("Top10HoldersProportion");
			this.Property(t => t.ProfessionalHoldShares).HasColumnName("ProfessionalHoldShares");
			this.Property(t => t.ProfessionalHoldRatio).HasColumnName("ProfessionalHoldRatio");
		}
	}
}

