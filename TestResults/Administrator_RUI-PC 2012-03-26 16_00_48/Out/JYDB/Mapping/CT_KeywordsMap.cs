using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_KeywordsMap : EntityTypeConfiguration<CT_Keywords>
	{
		public CT_KeywordsMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Content)
				.HasMaxLength(50);
				
			this.Property(t => t.Keyword)
				.HasMaxLength(50);
				
			this.Property(t => t.ChiSpelling)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("CT_Keywords");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.Type).HasColumnName("Type");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.Keyword).HasColumnName("Keyword");
			this.Property(t => t.Code).HasColumnName("Code");
			this.Property(t => t.ChiSpelling).HasColumnName("ChiSpelling");
			this.Property(t => t.InfoLevel).HasColumnName("InfoLevel");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

