using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HY_HYCWSJMap : EntityTypeConfiguration<VIEW_HY_HYCWSJ>
	{
		public VIEW_HY_HYCWSJMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.XGRQ });

			// Properties
			this.Property(t => t.N_Period)
				.HasMaxLength(300);
				
			this.Property(t => t.N_AreaAndMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_State)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_EnterpriseType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndustryType)
				.HasMaxLength(50);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.IndustryName)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HY_HYCWSJ");
			this.Property(t => t.N_Period).HasColumnName("N_Period");
			this.Property(t => t.N_AreaAndMethod).HasColumnName("N_AreaAndMethod");
			this.Property(t => t.N_State).HasColumnName("N_State");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_EnterpriseType).HasColumnName("N_EnterpriseType");
			this.Property(t => t.N_IndustryType).HasColumnName("N_IndustryType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Period).HasColumnName("Period");
			this.Property(t => t.AreaAndMethod).HasColumnName("AreaAndMethod");
			this.Property(t => t.State).HasColumnName("State");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.EnterpriseType).HasColumnName("EnterpriseType");
			this.Property(t => t.IndustryType).HasColumnName("IndustryType");
			this.Property(t => t.IndustryName).HasColumnName("IndustryName");
			this.Property(t => t.NumOfEnterprise).HasColumnName("NumOfEnterprise");
			this.Property(t => t.NumOfLossMakings).HasColumnName("NumOfLossMakings");
			this.Property(t => t.GrossOutputValueCP).HasColumnName("GrossOutputValueCP");
			this.Property(t => t.GrossOutputValueFP).HasColumnName("GrossOutputValueFP");
			this.Property(t => t.SalesValueCP).HasColumnName("SalesValueCP");
			this.Property(t => t.DeliveryValueExports).HasColumnName("DeliveryValueExports");
			this.Property(t => t.TotalLossOfLossMakings).HasColumnName("TotalLossOfLossMakings");
			this.Property(t => t.NetAccountReceivable).HasColumnName("NetAccountReceivable");
			this.Property(t => t.FinishedGoodsValue).HasColumnName("FinishedGoodsValue");
			this.Property(t => t.AvgBalCurrentAssets).HasColumnName("AvgBalCurrentAssets");
			this.Property(t => t.AvgBalNetFixedAssets).HasColumnName("AvgBalNetFixedAssets");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.SalesIncome).HasColumnName("SalesIncome");
			this.Property(t => t.SalesCost).HasColumnName("SalesCost");
			this.Property(t => t.OtherFeeForSales).HasColumnName("OtherFeeForSales");
			this.Property(t => t.SalesTaxesAndExtras).HasColumnName("SalesTaxesAndExtras");
			this.Property(t => t.ManagementFee).HasColumnName("ManagementFee");
			this.Property(t => t.FinancialFee).HasColumnName("FinancialFee");
			this.Property(t => t.InterestPaid).HasColumnName("InterestPaid");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.TotalTaxes).HasColumnName("TotalTaxes");
			this.Property(t => t.ValueAddedTaxPayable).HasColumnName("ValueAddedTaxPayable");
			this.Property(t => t.Ex_FactoryPriceIndices).HasColumnName("Ex_FactoryPriceIndices");
			this.Property(t => t.AvgNumOfStaffs).HasColumnName("AvgNumOfStaffs");
			this.Property(t => t.RateOfCapitalMA).HasColumnName("RateOfCapitalMA");
			this.Property(t => t.LiabilityAssetRatio).HasColumnName("LiabilityAssetRatio");
			this.Property(t => t.RatioPretaxProfitsOutput).HasColumnName("RatioPretaxProfitsOutput");
			this.Property(t => t.RatioOfProfitToCapital).HasColumnName("RatioOfProfitToCapital");
			this.Property(t => t.TurnoversOfCurrentCap).HasColumnName("TurnoversOfCurrentCap");
			this.Property(t => t.RatioOfProfitToCost).HasColumnName("RatioOfProfitToCost");
			this.Property(t => t.SalesValuePerWorker).HasColumnName("SalesValuePerWorker");
			this.Property(t => t.RatioOfFinishedGoods).HasColumnName("RatioOfFinishedGoods");
			this.Property(t => t.NumOfEnterpriseYOY).HasColumnName("NumOfEnterpriseYOY");
			this.Property(t => t.NumOfLossMakingsYOY).HasColumnName("NumOfLossMakingsYOY");
			this.Property(t => t.GrossOutputValueYOYCP).HasColumnName("GrossOutputValueYOYCP");
			this.Property(t => t.GrossOutputValueYOYFP).HasColumnName("GrossOutputValueYOYFP");
			this.Property(t => t.SalesValueYOYCP).HasColumnName("SalesValueYOYCP");
			this.Property(t => t.DeliveryValueExportsYOY).HasColumnName("DeliveryValueExportsYOY");
			this.Property(t => t.TotalLossOfLossMakingsYOY).HasColumnName("TotalLossOfLossMakingsYOY");
			this.Property(t => t.NetAccountReceivableYOY).HasColumnName("NetAccountReceivableYOY");
			this.Property(t => t.FinishedGoodsValueYOY).HasColumnName("FinishedGoodsValueYOY");
			this.Property(t => t.AvgBalCurrentAssetsYOY).HasColumnName("AvgBalCurrentAssetsYOY");
			this.Property(t => t.AvgBalNetFixedAssetsYOY).HasColumnName("AvgBalNetFixedAssetsYOY");
			this.Property(t => t.TotalAssetYOY).HasColumnName("TotalAssetYOY");
			this.Property(t => t.TotalLiabilityYOY).HasColumnName("TotalLiabilityYOY");
			this.Property(t => t.SalesIncomeYOY).HasColumnName("SalesIncomeYOY");
			this.Property(t => t.SalesCostYOY).HasColumnName("SalesCostYOY");
			this.Property(t => t.OtherFeeForSalesYOY).HasColumnName("OtherFeeForSalesYOY");
			this.Property(t => t.SalesTaxesAndExtrasYOY).HasColumnName("SalesTaxesAndExtrasYOY");
			this.Property(t => t.ManagementFeeYOY).HasColumnName("ManagementFeeYOY");
			this.Property(t => t.FinancialFeeYOY).HasColumnName("FinancialFeeYOY");
			this.Property(t => t.InterestPaidYOY).HasColumnName("InterestPaidYOY");
			this.Property(t => t.TotalProfitYOY).HasColumnName("TotalProfitYOY");
			this.Property(t => t.TotalTaxesYOY).HasColumnName("TotalTaxesYOY");
			this.Property(t => t.ValueAddedTaxPayableYOY).HasColumnName("ValueAddedTaxPayableYOY");
			this.Property(t => t.AvgNumOfStaffsYOY).HasColumnName("AvgNumOfStaffsYOY");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

