using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HY_HYCL_LJMap : EntityTypeConfiguration<VIEW_HY_HYCL_LJ>
	{
		public VIEW_HY_HYCL_LJMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.XGRQ });

			// Properties
			this.Property(t => t.N_Period)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Unit)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ProductName)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HY_HYCL_LJ");
			this.Property(t => t.N_Period).HasColumnName("N_Period");
			this.Property(t => t.N_Unit).HasColumnName("N_Unit");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPubDate).HasColumnName("InfoPubDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Period).HasColumnName("Period");
			this.Property(t => t.ProductCode).HasColumnName("ProductCode");
			this.Property(t => t.ProductName).HasColumnName("ProductName");
			this.Property(t => t.Unit).HasColumnName("Unit");
			this.Property(t => t.OutputQuantity).HasColumnName("OutputQuantity");
			this.Property(t => t.IncreaseOrDecreaseYOY).HasColumnName("IncreaseOrDecreaseYOY");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

