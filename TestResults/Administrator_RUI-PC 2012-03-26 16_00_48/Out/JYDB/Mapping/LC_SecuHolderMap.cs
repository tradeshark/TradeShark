using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SecuHolderMap : EntityTypeConfiguration<LC_SecuHolder>
	{
		public LC_SecuHolderMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.HolderName)
				.HasMaxLength(200);
				
			this.Property(t => t.Notes)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("LC_SecuHolder");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SecuVolume).HasColumnName("SecuVolume");
			this.Property(t => t.HolderNum).HasColumnName("HolderNum");
			this.Property(t => t.HolderNo).HasColumnName("HolderNo");
			this.Property(t => t.HolderName).HasColumnName("HolderName");
			this.Property(t => t.HolderNature).HasColumnName("HolderNature");
			this.Property(t => t.HolderCode).HasColumnName("HolderCode");
			this.Property(t => t.BelongedCompanyCode).HasColumnName("BelongedCompanyCode");
			this.Property(t => t.HoldVolume).HasColumnName("HoldVolume");
			this.Property(t => t.HoldRatio).HasColumnName("HoldRatio");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoType).HasColumnName("InfoType");
		}
	}
}

