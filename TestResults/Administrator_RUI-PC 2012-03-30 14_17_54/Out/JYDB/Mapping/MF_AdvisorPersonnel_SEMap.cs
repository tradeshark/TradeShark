using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_AdvisorPersonnel_SEMap : EntityTypeConfiguration<MF_AdvisorPersonnel_SE>
	{
		public MF_AdvisorPersonnel_SEMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TypeCode, t.Code });

			// Properties
			this.Property(t => t.TypeCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Code)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_AdvisorPersonnel_SE");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TypeCode).HasColumnName("TypeCode");
			this.Property(t => t.Code).HasColumnName("Code");
		}
	}
}

