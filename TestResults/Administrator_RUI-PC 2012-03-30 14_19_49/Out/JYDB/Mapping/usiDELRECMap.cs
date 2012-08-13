using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class usiDELRECMap : EntityTypeConfiguration<usiDELREC>
	{
		public usiDELRECMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TABLENAME, t.RECID, t.XGRQ, t.XGRY, t.JSID });

			// Properties
			this.Property(t => t.TABLENAME)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.XGRY)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("usiDELREC");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TABLENAME).HasColumnName("TABLENAME");
			this.Property(t => t.RECID).HasColumnName("RECID");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.XGRY).HasColumnName("XGRY");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

