using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class usiLOCASYSTEMMap : EntityTypeConfiguration<usiLOCASYSTEM>
	{
		public usiLOCASYSTEMMap()
		{
			// Primary Key
			this.HasKey(t => t.BH);

			// Properties
			this.Property(t => t.BH)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.MS)
				.HasMaxLength(200);
				
			this.Property(t => t.CVALUE)
				.HasMaxLength(4000);
				
			// Table & Column Mappings
			this.ToTable("usiLOCASYSTEM");
			this.Property(t => t.BH).HasColumnName("BH");
			this.Property(t => t.MS).HasColumnName("MS");
			this.Property(t => t.IVALUE).HasColumnName("IVALUE");
			this.Property(t => t.FVALUE).HasColumnName("FVALUE");
			this.Property(t => t.DVALUE).HasColumnName("DVALUE");
			this.Property(t => t.CVALUE).HasColumnName("CVALUE");
			this.Property(t => t.I64VALUE).HasColumnName("I64VALUE");
		}
	}
}

