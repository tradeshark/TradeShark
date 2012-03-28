using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_ExchangFundHolderInfoMap : EntityTypeConfiguration<MF_ExchangFundHolderInfo>
	{
		public MF_ExchangFundHolderInfoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("MF_ExchangFundHolderInfo");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.HolderAccountNumber).HasColumnName("HolderAccountNumber");
			this.Property(t => t.AverageVolumePerAccount).HasColumnName("AverageVolumePerAccount");
			this.Property(t => t.InstitutionHoldVolume).HasColumnName("InstitutionHoldVolume");
			this.Property(t => t.InstitutionHoldRatio).HasColumnName("InstitutionHoldRatio");
			this.Property(t => t.IndividualHoldVolume).HasColumnName("IndividualHoldVolume");
			this.Property(t => t.IndividualHoldRatio).HasColumnName("IndividualHoldRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

