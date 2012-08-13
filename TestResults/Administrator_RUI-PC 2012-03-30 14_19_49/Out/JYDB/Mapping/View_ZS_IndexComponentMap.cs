using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_ZS_IndexComponentMap : EntityTypeConfiguration<View_ZS_IndexComponent>
	{
		public View_ZS_IndexComponentMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.IndexInnerCode, t.SecuInnerCode, t.Flag, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_PubOrgCode)
				.HasMaxLength(100);
				
			this.Property(t => t.IndexId)
				.HasMaxLength(10);
				
			this.Property(t => t.IndexName)
				.HasMaxLength(20);
				
			this.Property(t => t.SecuCode)
				.HasMaxLength(10);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.N_SecuCategory)
				.HasMaxLength(300);
				
			this.Property(t => t.IndexInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SecuInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Flag)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_ZS_IndexComponent");
			this.Property(t => t.N_PubOrgCode).HasColumnName("N_PubOrgCode");
			this.Property(t => t.IndexId).HasColumnName("IndexId");
			this.Property(t => t.IndexName).HasColumnName("IndexName");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.N_SecuCategory).HasColumnName("N_SecuCategory");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.IndexInnerCode).HasColumnName("IndexInnerCode");
			this.Property(t => t.SecuInnerCode).HasColumnName("SecuInnerCode");
			this.Property(t => t.InDate).HasColumnName("InDate");
			this.Property(t => t.OutDate).HasColumnName("OutDate");
			this.Property(t => t.Flag).HasColumnName("Flag");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

