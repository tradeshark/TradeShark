using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class usiYHXXMap : EntityTypeConfiguration<usiYHXX>
	{
		public usiYHXXMap()
		{
			// Primary Key
			this.HasKey(t => t.JSID);

			// Properties
			this.Property(t => t.YHBH)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(32);
				
			this.Property(t => t.YHJQM)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(32);
				
			this.Property(t => t.YHMM)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(32);
				
			this.Property(t => t.HJSJ)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(16);
				
			this.Property(t => t.YHSX)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(16);
				
			this.Property(t => t.YHMC)
				.IsRequired()
				.HasMaxLength(300);
				
			this.Property(t => t.YHBM)
				.HasMaxLength(300);
				
			this.Property(t => t.TSXX)
				.HasMaxLength(1900);
				
			this.Property(t => t.YHSQ)
				.IsRequired();
				
			this.Property(t => t.ZDYHS)
				.IsFixedLength()
				.HasMaxLength(16);
				
			this.Property(t => t.ZDWWIP)
				.IsFixedLength()
				.HasMaxLength(16);
				
			this.Property(t => t.ZDNWIP)
				.IsFixedLength()
				.HasMaxLength(16);
				
			this.Property(t => t.ZDJJM)
				.IsFixedLength()
				.HasMaxLength(16);
				
			// Table & Column Mappings
			this.ToTable("usiYHXX");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.YHID).HasColumnName("YHID");
			this.Property(t => t.YHBH).HasColumnName("YHBH");
			this.Property(t => t.YHJQM).HasColumnName("YHJQM");
			this.Property(t => t.YHMM).HasColumnName("YHMM");
			this.Property(t => t.HJSJ).HasColumnName("HJSJ");
			this.Property(t => t.YHSX).HasColumnName("YHSX");
			this.Property(t => t.YHMC).HasColumnName("YHMC");
			this.Property(t => t.YHBM).HasColumnName("YHBM");
			this.Property(t => t.TSXX).HasColumnName("TSXX");
			this.Property(t => t.YHSQ).HasColumnName("YHSQ");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ZDYHS).HasColumnName("ZDYHS");
			this.Property(t => t.ZDWWIP).HasColumnName("ZDWWIP");
			this.Property(t => t.ZDNWIP).HasColumnName("ZDNWIP");
			this.Property(t => t.ZDJJM).HasColumnName("ZDJJM");
			this.Property(t => t.YHJBXX).HasColumnName("YHJBXX");
		}
	}
}

