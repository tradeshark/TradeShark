using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_IndustryPlateMap : EntityTypeConfiguration<CT_IndustryPlate>
	{
		public CT_IndustryPlateMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.IndustryCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.IndustryName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.IndustryPlateCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.IndustryPlateName)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("CT_IndustryPlate");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TypeCode).HasColumnName("TypeCode");
			this.Property(t => t.IndustryNum).HasColumnName("IndustryNum");
			this.Property(t => t.IndustryCode).HasColumnName("IndustryCode");
			this.Property(t => t.IndustryName).HasColumnName("IndustryName");
			this.Property(t => t.IndustryPlateNum).HasColumnName("IndustryPlateNum");
			this.Property(t => t.IndustryPlateCode).HasColumnName("IndustryPlateCode");
			this.Property(t => t.IndustryPlateName).HasColumnName("IndustryPlateName");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

