using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_QZ_CreationChangeMap : EntityTypeConfiguration<View_QZ_CreationChange>
	{
		public View_QZ_CreationChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.WarrantCategory, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.SecuCode)
				.HasMaxLength(13);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.N_WarrantCategory)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ChangeType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IssuerSN)
				.HasMaxLength(100);
				
			this.Property(t => t.WarrantCategory)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Issuer)
				.HasMaxLength(200);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("View_QZ_CreationChange");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.N_WarrantCategory).HasColumnName("N_WarrantCategory");
			this.Property(t => t.N_ChangeType).HasColumnName("N_ChangeType");
			this.Property(t => t.N_IssuerSN).HasColumnName("N_IssuerSN");
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

