using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_IndexComponentMap : EntityTypeConfiguration<LC_IndexComponent>
	{
		public LC_IndexComponentMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.IndexInnerCode, t.SecuInnerCode, t.Flag, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.IndexInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SecuInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Flag)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_IndexComponent");
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

