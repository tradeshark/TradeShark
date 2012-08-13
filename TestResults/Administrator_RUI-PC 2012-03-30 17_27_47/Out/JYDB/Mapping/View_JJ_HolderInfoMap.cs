using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_HolderInfoMap : EntityTypeConfiguration<View_JJ_HolderInfo>
	{
		public View_JJ_HolderInfoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(300);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_HolderInfo");
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
		}
	}
}

