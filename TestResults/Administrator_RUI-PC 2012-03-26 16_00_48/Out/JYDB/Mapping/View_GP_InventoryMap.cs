using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_InventoryMap : EntityTypeConfiguration<View_GP_Inventory>
	{
		public View_GP_InventoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.DataType, t.IfAdjusted, t.IfMerged, t.XGRQ });

			// Properties
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfAdjusted)
				.HasMaxLength(300);
				
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
			this.ToTable("View_GP_Inventory");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
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
			this.Property(t => t.RawMaterial_DJZB).HasColumnName("RawMaterial_DJZB");
			this.Property(t => t.InventoryInTransit_DJZB).HasColumnName("InventoryInTransit_DJZB");
			this.Property(t => t.DeveProduct_DJZB).HasColumnName("DeveProduct_DJZB");
			this.Property(t => t.ConstructingDeveProduct_DJZB).HasColumnName("ConstructingDeveProduct_DJZB");
			this.Property(t => t.LeasingDeveProduct_DJZB).HasColumnName("LeasingDeveProduct_DJZB");
			this.Property(t => t.DeveCost_DJZB).HasColumnName("DeveCost_DJZB");
			this.Property(t => t.UndeveLand_DJZB).HasColumnName("UndeveLand_DJZB");
			this.Property(t => t.ConstructionProject_DJZB).HasColumnName("ConstructionProject_DJZB");
			this.Property(t => t.InventoryProducts_DJZB).HasColumnName("InventoryProducts_DJZB");
			this.Property(t => t.SemiFinishedGoods_DJZB).HasColumnName("SemiFinishedGoods_DJZB");
			this.Property(t => t.WorkInProcessGoods_DJZB).HasColumnName("WorkInProcessGoods_DJZB");
			this.Property(t => t.FinishedGoods_DJZB).HasColumnName("FinishedGoods_DJZB");
			this.Property(t => t.LowCostAndShortLivedArticles_DJZB).HasColumnName("LowCostAndShortLivedArticles_DJZB");
			this.Property(t => t.GoodsOnInstallmentSales_DJZB).HasColumnName("GoodsOnInstallmentSales_DJZB");
			this.Property(t => t.GoodsInConsignors_DJZB).HasColumnName("GoodsInConsignors_DJZB");
			this.Property(t => t.GoodsPurchased_DJZB).HasColumnName("GoodsPurchased_DJZB");
			this.Property(t => t.Fuel_DJZB).HasColumnName("Fuel_DJZB");
			this.Property(t => t.Containers_DJZB).HasColumnName("Containers_DJZB");
			this.Property(t => t.MaterialsInConsignors_DJZB).HasColumnName("MaterialsInConsignors_DJZB");
			this.Property(t => t.MaterialsPurchased_DJZB).HasColumnName("MaterialsPurchased_DJZB");
			this.Property(t => t.CostVariancesOfMaterials_DJZB).HasColumnName("CostVariancesOfMaterials_DJZB");
			this.Property(t => t.SpareParts_DJZB).HasColumnName("SpareParts_DJZB");
			this.Property(t => t.FlightSpareParts_DJZB).HasColumnName("FlightSpareParts_DJZB");
			this.Property(t => t.ExpensiveTurnoverParts_DJZB).HasColumnName("ExpensiveTurnoverParts_DJZB");
			this.Property(t => t.CommonEquipment_DJZB).HasColumnName("CommonEquipment_DJZB");
			this.Property(t => t.OtherInventory_DJZB).HasColumnName("OtherInventory_DJZB");
			this.Property(t => t.Total_DJZB).HasColumnName("Total_DJZB");
			this.Property(t => t.JTBL).HasColumnName("JTBL");
		}
	}
}

