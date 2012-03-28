using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class IN_IndustryFinaDataStat
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> Period { get; set; }
		public Nullable<int> AreaAndMethod { get; set; }
		public Nullable<int> State { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<int> EnterpriseType { get; set; }
		public Nullable<int> IndustryType { get; set; }
		public string IndustryName { get; set; }
		public Nullable<int> NumOfEnterprise { get; set; }
		public Nullable<int> NumOfLossMakings { get; set; }
		public Nullable<decimal> GrossOutputValueCP { get; set; }
		public Nullable<decimal> GrossOutputValueFP { get; set; }
		public Nullable<decimal> SalesValueCP { get; set; }
		public Nullable<decimal> DeliveryValueExports { get; set; }
		public Nullable<decimal> TotalLossOfLossMakings { get; set; }
		public Nullable<decimal> NetAccountReceivable { get; set; }
		public Nullable<decimal> FinishedGoodsValue { get; set; }
		public Nullable<decimal> AvgBalCurrentAssets { get; set; }
		public Nullable<decimal> AvgBalNetFixedAssets { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> SalesIncome { get; set; }
		public Nullable<decimal> SalesCost { get; set; }
		public Nullable<decimal> OtherFeeForSales { get; set; }
		public Nullable<decimal> SalesTaxesAndExtras { get; set; }
		public Nullable<decimal> ManagementFee { get; set; }
		public Nullable<decimal> FinancialFee { get; set; }
		public Nullable<decimal> InterestPaid { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public Nullable<decimal> TotalTaxes { get; set; }
		public Nullable<decimal> ValueAddedTaxPayable { get; set; }
		public Nullable<decimal> Ex_FactoryPriceIndices { get; set; }
		public Nullable<decimal> AvgNumOfStaffs { get; set; }
		public Nullable<decimal> RateOfCapitalMA { get; set; }
		public Nullable<decimal> LiabilityAssetRatio { get; set; }
		public Nullable<decimal> RatioPretaxProfitsOutput { get; set; }
		public Nullable<decimal> RatioOfProfitToCapital { get; set; }
		public Nullable<decimal> TurnoversOfCurrentCap { get; set; }
		public Nullable<decimal> RatioOfProfitToCost { get; set; }
		public Nullable<decimal> SalesValuePerWorker { get; set; }
		public Nullable<decimal> RatioOfFinishedGoods { get; set; }
		public Nullable<decimal> NumOfEnterpriseYOY { get; set; }
		public Nullable<decimal> NumOfLossMakingsYOY { get; set; }
		public Nullable<decimal> GrossOutputValueYOYCP { get; set; }
		public Nullable<decimal> GrossOutputValueYOYFP { get; set; }
		public Nullable<decimal> SalesValueYOYCP { get; set; }
		public Nullable<decimal> DeliveryValueExportsYOY { get; set; }
		public Nullable<decimal> TotalLossOfLossMakingsYOY { get; set; }
		public Nullable<decimal> NetAccountReceivableYOY { get; set; }
		public Nullable<decimal> FinishedGoodsValueYOY { get; set; }
		public Nullable<decimal> AvgBalCurrentAssetsYOY { get; set; }
		public Nullable<decimal> AvgBalNetFixedAssetsYOY { get; set; }
		public Nullable<decimal> TotalAssetYOY { get; set; }
		public Nullable<decimal> TotalLiabilityYOY { get; set; }
		public Nullable<decimal> SalesIncomeYOY { get; set; }
		public Nullable<decimal> SalesCostYOY { get; set; }
		public Nullable<decimal> OtherFeeForSalesYOY { get; set; }
		public Nullable<decimal> SalesTaxesAndExtrasYOY { get; set; }
		public Nullable<decimal> ManagementFeeYOY { get; set; }
		public Nullable<decimal> FinancialFeeYOY { get; set; }
		public Nullable<decimal> InterestPaidYOY { get; set; }
		public Nullable<decimal> TotalProfitYOY { get; set; }
		public Nullable<decimal> TotalTaxesYOY { get; set; }
		public Nullable<decimal> ValueAddedTaxPayableYOY { get; set; }
		public Nullable<decimal> AvgNumOfStaffsYOY { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

