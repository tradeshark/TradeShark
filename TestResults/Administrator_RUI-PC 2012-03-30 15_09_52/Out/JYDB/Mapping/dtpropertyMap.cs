using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class dtpropertyMap : EntityTypeConfiguration<dtproperty>
	{
		public dtpropertyMap()
		{
			// Primary Key
			this.HasKey(t => new { t.id, t.property, t.version });

			// Properties
			this.Property(t => t.id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
				
			this.Property(t => t.property)
				.IsRequired()
				.HasMaxLength(64);
				
			this.Property(t => t.value)
				.HasMaxLength(255);
				
			this.Property(t => t.uvalue)
				.HasMaxLength(255);
				
			this.Property(t => t.version)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("dtproperties");
			this.Property(t => t.id).HasColumnName("id");
			this.Property(t => t.objectid).HasColumnName("objectid");
			this.Property(t => t.property).HasColumnName("property");
			this.Property(t => t.value).HasColumnName("value");
			this.Property(t => t.uvalue).HasColumnName("uvalue");
			this.Property(t => t.lvalue).HasColumnName("lvalue");
			this.Property(t => t.version).HasColumnName("version");
		}
	}
}

