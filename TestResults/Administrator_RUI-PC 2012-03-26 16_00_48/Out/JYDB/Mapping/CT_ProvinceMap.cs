using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_ProvinceMap : EntityTypeConfiguration<CT_Province>
	{
		public CT_ProvinceMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.ProvinceName, t.ProvinceCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.ProvinceName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.ProvinceCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("CT_Province");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.ProvinceName).HasColumnName("ProvinceName");
			this.Property(t => t.ProvinceCode).HasColumnName("ProvinceCode");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

