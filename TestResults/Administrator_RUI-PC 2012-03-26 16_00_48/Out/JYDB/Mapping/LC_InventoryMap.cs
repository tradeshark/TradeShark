using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_InventoryMap : EntityTypeConfiguration<LC_Inventory>
	{
		public LC_InventoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.DataType, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.DataType)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_Inventory");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.RawMaterial).HasColumnName("RawMaterial");
			this.Property(t => t.InventoryInTransit).HasColumnName("InventoryInTransit");
			this.Property(t => t.DeveProduct).HasColumnName("DeveProduct");
			this.Property(t => t.ConstructingDeveProduct).HasColumnName("ConstructingDeveProduct");
			this.Property(t => t.LeasingDeveProduct).HasColumnName("LeasingDeveProduct");
			this.Property(t => t.DeveCost).HasColumnName("DeveCost");
			this.Property(t => t.UndeveLand).HasColumnName("UndeveLand");
			this.Property(t => t.ConstructionProject).HasColumnName("ConstructionProject");
			this.Property(t => t.InventoryProducts).HasColumnName("InventoryProducts");
			this.Property(t => t.SemiFinishedGoods).HasColumnName("SemiFinishedGoods");
			this.Property(t => t.WorkInProcessGoods).HasColumnName("WorkInProcessGoods");
			this.Property(t => t.FinishedGoods).HasColumnName("FinishedGoods");
			this.Property(t => t.LowCostAndShortLivedArticles).HasColumnName("LowCostAndShortLivedArticles");
			this.Property(t => t.GoodsOnInstallmentSales).HasColumnName("GoodsOnInstallmentSales");
			this.Property(t => t.GoodsInConsignors).HasColumnName("GoodsInConsignors");
			this.Property(t => t.GoodsPurchased).HasColumnName("GoodsPurchased");
			this.Property(t => t.Fuel).HasColumnName("Fuel");
			this.Property(t => t.Containers).HasColumnName("Containers");
			this.Property(t => t.MaterialsInConsignors).HasColumnName("MaterialsInConsignors");
			this.Property(t => t.MaterialsPurchased).HasColumnName("MaterialsPurchased");
			this.Property(t => t.CostVariancesOfMaterials).HasColumnName("CostVariancesOfMaterials");
			this.Property(t => t.SpareParts).HasColumnName("SpareParts");
			this.Property(t => t.FlightSpareParts).HasColumnName("FlightSpareParts");
			this.Property(t => t.ExpensiveTurnoverParts).HasColumnName("ExpensiveTurnoverParts");
			this.Property(t => t.CommonEquipment).HasColumnName("CommonEquipment");
			this.Property(t => t.OtherInventory).HasColumnName("OtherInventory");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

