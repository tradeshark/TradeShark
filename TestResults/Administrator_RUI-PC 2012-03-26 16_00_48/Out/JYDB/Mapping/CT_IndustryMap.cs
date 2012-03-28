using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_IndustryMap : EntityTypeConfiguration<CT_Industry>
	{
		public CT_IndustryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.IndustryNum, t.IndustryName, t.IndustryCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.IndustryNum)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IndustryName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.IndustryCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.IndustryPlate)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("CT_Industry");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.IndustryNum).HasColumnName("IndustryNum");
			this.Property(t => t.IndustryName).HasColumnName("IndustryName");
			this.Property(t => t.IndustryCode).HasColumnName("IndustryCode");
			this.Property(t => t.IndustryPlate).HasColumnName("IndustryPlate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

