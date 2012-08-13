using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_AssetDevalProviMap : EntityTypeConfiguration<View_GP_AssetDevalProvi>
	{
		public View_GP_AssetDevalProviMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfMerged, t.DataType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_DataType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.DataType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_GP_AssetDevalProvi");
			this.Property(t => t.N_DataType).HasColumnName("N_DataType");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.BadAssetsProvi).HasColumnName("BadAssetsProvi");
			this.Property(t => t.AccountReceivable).HasColumnName("AccountReceivable");
			this.Property(t => t.OtherReceivables).HasColumnName("OtherReceivables");
			this.Property(t => t.AdvancePayment).HasColumnName("AdvancePayment");
			this.Property(t => t.InterestReceivable).HasColumnName("InterestReceivable");
			this.Property(t => t.RentalReceivable).HasColumnName("RentalReceivable");
			this.Property(t => t.DepositInInterbank).HasColumnName("DepositInInterbank");
			this.Property(t => t.LendToInterbank).HasColumnName("LendToInterbank");
			this.Property(t => t.LendToFinanceCo).HasColumnName("LendToFinanceCo");
			this.Property(t => t.BoughtSellbackSecu).HasColumnName("BoughtSellbackSecu");
			this.Property(t => t.LendCapital).HasColumnName("LendCapital");
			this.Property(t => t.SubIssueSecu).HasColumnName("SubIssueSecu");
			this.Property(t => t.SubHonorBond).HasColumnName("SubHonorBond");
			this.Property(t => t.IssueExpenseToTransfer).HasColumnName("IssueExpenseToTransfer");
			this.Property(t => t.OtherBadAssetProvi).HasColumnName("OtherBadAssetProvi");
			this.Property(t => t.STermInvestDevalProvi).HasColumnName("STermInvestDevalProvi");
			this.Property(t => t.StockInvest).HasColumnName("StockInvest");
			this.Property(t => t.ListedStockInvest).HasColumnName("ListedStockInvest");
			this.Property(t => t.BondInvest).HasColumnName("BondInvest");
			this.Property(t => t.MFundInvest).HasColumnName("MFundInvest");
			this.Property(t => t.TrustInvest).HasColumnName("TrustInvest");
			this.Property(t => t.OtherSTermInvestProvi).HasColumnName("OtherSTermInvestProvi");
			this.Property(t => t.InventoryDevalProvi).HasColumnName("InventoryDevalProvi");
			this.Property(t => t.StorageGoods).HasColumnName("StorageGoods");
			this.Property(t => t.RawMaterials).HasColumnName("RawMaterials");
			this.Property(t => t.CargoAfloat).HasColumnName("CargoAfloat");
			this.Property(t => t.DevelopProducts).HasColumnName("DevelopProducts");
			this.Property(t => t.DevelopCost).HasColumnName("DevelopCost");
			this.Property(t => t.ProductInBuildDevelop).HasColumnName("ProductInBuildDevelop");
			this.Property(t => t.LandToExploit).HasColumnName("LandToExploit");
			this.Property(t => t.LowValueEasyDamaged).HasColumnName("LowValueEasyDamaged");
			this.Property(t => t.HalfFinished).HasColumnName("HalfFinished");
			this.Property(t => t.ProductInProcess).HasColumnName("ProductInProcess");
			this.Property(t => t.FinishedProduct).HasColumnName("FinishedProduct");
			this.Property(t => t.MaterialPurchase).HasColumnName("MaterialPurchase");
			this.Property(t => t.GoodsOnInstalmentSales).HasColumnName("GoodsOnInstalmentSales");
			this.Property(t => t.ConstructionProject).HasColumnName("ConstructionProject");
			this.Property(t => t.TrustProcessMaterial).HasColumnName("TrustProcessMaterial");
			this.Property(t => t.Packages).HasColumnName("Packages");
			this.Property(t => t.EstimatedContractLoss).HasColumnName("EstimatedContractLoss");
			this.Property(t => t.Materials).HasColumnName("Materials");
			this.Property(t => t.AuxiliaryMaterials).HasColumnName("AuxiliaryMaterials");
			this.Property(t => t.SpareParts).HasColumnName("SpareParts");
			this.Property(t => t.ProxyGoods).HasColumnName("ProxyGoods");
			this.Property(t => t.OtherInventoryDevalProvi).HasColumnName("OtherInventoryDevalProvi");
			this.Property(t => t.LTermInvestDevalProvi).HasColumnName("LTermInvestDevalProvi");
			this.Property(t => t.LTermEquityInvest).HasColumnName("LTermEquityInvest");
			this.Property(t => t.LTermDebtInvest).HasColumnName("LTermDebtInvest");
			this.Property(t => t.OtherLTermInvest).HasColumnName("OtherLTermInvest");
			this.Property(t => t.FixedAssetsDevalProvi).HasColumnName("FixedAssetsDevalProvi");
			this.Property(t => t.Buildings).HasColumnName("Buildings");
			this.Property(t => t.Machines).HasColumnName("Machines");
			this.Property(t => t.TrafficTools).HasColumnName("TrafficTools");
			this.Property(t => t.Electronics).HasColumnName("Electronics");
			this.Property(t => t.MiniPC).HasColumnName("MiniPC");
			this.Property(t => t.CommunicationDevice).HasColumnName("CommunicationDevice");
			this.Property(t => t.OfficeEquip).HasColumnName("OfficeEquip");
			this.Property(t => t.OperLeaseOutEquip).HasColumnName("OperLeaseOutEquip");
			this.Property(t => t.FinanceLeaseInAsset).HasColumnName("FinanceLeaseInAsset");
			this.Property(t => t.GeneralEquip).HasColumnName("GeneralEquip");
			this.Property(t => t.SpecialEquip).HasColumnName("SpecialEquip");
			this.Property(t => t.OtherEquip).HasColumnName("OtherEquip");
			this.Property(t => t.MainRoadBridge).HasColumnName("MainRoadBridge");
			this.Property(t => t.OtherFixedAssetDevalProvi).HasColumnName("OtherFixedAssetDevalProvi");
			this.Property(t => t.IntangiAssetDevalProvi).HasColumnName("IntangiAssetDevalProvi");
			this.Property(t => t.Patents).HasColumnName("Patents");
			this.Property(t => t.TrademarkRight).HasColumnName("TrademarkRight");
			this.Property(t => t.LandUseRight).HasColumnName("LandUseRight");
			this.Property(t => t.ProprietaryTechnology).HasColumnName("ProprietaryTechnology");
			this.Property(t => t.Software).HasColumnName("Software");
			this.Property(t => t.WaterSurfaceUseRight).HasColumnName("WaterSurfaceUseRight");
			this.Property(t => t.HouseUseRight).HasColumnName("HouseUseRight");
			this.Property(t => t.MiningRight).HasColumnName("MiningRight");
			this.Property(t => t.Goodwill).HasColumnName("Goodwill");
			this.Property(t => t.OtherIntangiProvi).HasColumnName("OtherIntangiProvi");
			this.Property(t => t.ConstruInProcessDevalProvi).HasColumnName("ConstruInProcessDevalProvi");
			this.Property(t => t.LoanDevalProvi).HasColumnName("LoanDevalProvi");
			this.Property(t => t.STermLoan).HasColumnName("STermLoan");
			this.Property(t => t.MLTermLoan).HasColumnName("MLTermLoan");
			this.Property(t => t.OverrideLoan).HasColumnName("OverrideLoan");
			this.Property(t => t.OtherLoanDevalProvi).HasColumnName("OtherLoanDevalProvi");
			this.Property(t => t.SelfSecuDevalProvi).HasColumnName("SelfSecuDevalProvi");
			this.Property(t => t.OtherAssetDevalProvi).HasColumnName("OtherAssetDevalProvi");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

