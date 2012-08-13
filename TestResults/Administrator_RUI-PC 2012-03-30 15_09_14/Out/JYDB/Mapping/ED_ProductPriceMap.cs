using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ProductPriceMap : EntityTypeConfiguration<ED_ProductPrice>
	{
		public ED_ProductPriceMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.AreaName)
				.HasMaxLength(100);
				
			this.Property(t => t.ProductName)
				.HasMaxLength(100);
				
			this.Property(t => t.Standard)
				.HasMaxLength(100);
				
			this.Property(t => t.Place)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			this.Property(t => t.ObjectName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("ED_ProductPrice");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.AreaName).HasColumnName("AreaName");
			this.Property(t => t.Market).HasColumnName("Market");
			this.Property(t => t.Product).HasColumnName("Product");
			this.Property(t => t.ProductName).HasColumnName("ProductName");
			this.Property(t => t.Standard).HasColumnName("Standard");
			this.Property(t => t.PriceType).HasColumnName("PriceType");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.Category).HasColumnName("Category");
			this.Property(t => t.Price).HasColumnName("Price");
			this.Property(t => t.PriceGYOY).HasColumnName("PriceGYOY");
			this.Property(t => t.PriceLinkRatio).HasColumnName("PriceLinkRatio");
			this.Property(t => t.PriceRatioToYB).HasColumnName("PriceRatioToYB");
			this.Property(t => t.Place).HasColumnName("Place");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoSourceCode).HasColumnName("InfoSourceCode");
			this.Property(t => t.ObjectName).HasColumnName("ObjectName");
		}
	}
}

