using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_WarrentCreationChangeMap : EntityTypeConfiguration<LC_WarrentCreationChange>
	{
		public LC_WarrentCreationChangeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Issuer)
				.HasMaxLength(200);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_WarrentCreationChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.WarrantCategory).HasColumnName("WarrantCategory");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.Issuer).HasColumnName("Issuer");
			this.Property(t => t.IssuerSN).HasColumnName("IssuerSN");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
			this.Property(t => t.Circulation).HasColumnName("Circulation");
			this.Property(t => t.ChangeSize).HasColumnName("ChangeSize");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

