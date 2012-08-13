using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class tb_system_constMap : EntityTypeConfiguration<tb_system_const>
	{
		public tb_system_constMap()
		{
			// Primary Key
			this.HasKey(t => t.id);

			// Properties
			this.Property(t => t.lbmc)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.ms)
				.HasMaxLength(300);
				
			this.Property(t => t.cvalue)
				.HasMaxLength(2000);
				
			// Table & Column Mappings
			this.ToTable("tb_system_const");
			this.Property(t => t.id).HasColumnName("id");
			this.Property(t => t.lb).HasColumnName("lb");
			this.Property(t => t.lbmc).HasColumnName("lbmc");
			this.Property(t => t.ms).HasColumnName("ms");
			this.Property(t => t.dm).HasColumnName("dm");
			this.Property(t => t.xgrq).HasColumnName("xgrq");
			this.Property(t => t.fvalue).HasColumnName("fvalue");
			this.Property(t => t.ivalue).HasColumnName("ivalue");
			this.Property(t => t.dvalue).HasColumnName("dvalue");
			this.Property(t => t.cvalue).HasColumnName("cvalue");
		}
	}
}

