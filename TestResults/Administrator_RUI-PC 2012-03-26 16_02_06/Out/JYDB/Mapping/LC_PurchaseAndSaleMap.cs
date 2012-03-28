using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PurchaseAndSaleMap : EntityTypeConfiguration<LC_PurchaseAndSale>
	{
		public LC_PurchaseAndSaleMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Company)
				.HasMaxLength(100);
				
			this.Property(t => t.Note)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_PurchaseAndSale");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.PurchaseType).HasColumnName("PurchaseType");
			this.Property(t => t.Company).HasColumnName("Company");
			this.Property(t => t.SN).HasColumnName("SN");
			this.Property(t => t.TradeSum).HasColumnName("TradeSum");
			this.Property(t => t.RatioInTotal).HasColumnName("RatioInTotal");
			this.Property(t => t.RatioInMainIncome).HasColumnName("RatioInMainIncome");
			this.Property(t => t.RatioInMainCost).HasColumnName("RatioInMainCost");
			this.Property(t => t.Note).HasColumnName("Note");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

