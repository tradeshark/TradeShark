using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_ProductMap : EntityTypeConfiguration<CT_Product>
	{
		public CT_ProductMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.ProductCategory, t.ProductName, t.ProductCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.ProductCategory)
				.IsRequired()
				.HasMaxLength(30);
				
			this.Property(t => t.ProductName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.ProductCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.IndustryCode)
				.IsFixedLength()
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("CT_Product");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.ProductCategory).HasColumnName("ProductCategory");
			this.Property(t => t.ProductName).HasColumnName("ProductName");
			this.Property(t => t.ProductCode).HasColumnName("ProductCode");
			this.Property(t => t.IndustryCode).HasColumnName("IndustryCode");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

