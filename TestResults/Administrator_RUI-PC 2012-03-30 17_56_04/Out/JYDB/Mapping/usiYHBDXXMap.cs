using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class usiYHBDXXMap : EntityTypeConfiguration<usiYHBDXX>
	{
		public usiYHBDXXMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.YHID, t.SJLX, t.JSID });

			// Properties
			this.Property(t => t.YHID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SJLX)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.XDJJM)
				.IsFixedLength()
				.HasMaxLength(32);
				
			// Table & Column Mappings
			this.ToTable("usiYHBDXX");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.YHID).HasColumnName("YHID");
			this.Property(t => t.SJLX).HasColumnName("SJLX");
			this.Property(t => t.QSIP).HasColumnName("QSIP");
			this.Property(t => t.JZIP).HasColumnName("JZIP");
			this.Property(t => t.XDJJM).HasColumnName("XDJJM");
			this.Property(t => t.XGSJ).HasColumnName("XGSJ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

