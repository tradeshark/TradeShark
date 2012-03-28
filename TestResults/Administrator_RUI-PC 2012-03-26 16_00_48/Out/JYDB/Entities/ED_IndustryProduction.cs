using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_IndustryProduction
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public int AdjustMark { get; set; }
		public int ReportArea { get; set; }
		public int ReportPeriod { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<int> Industry { get; set; }
		public Nullable<int> StatStandard { get; set; }
		public Nullable<decimal> IndustrialValueAdded { get; set; }
		public Nullable<decimal> LIValueAdded { get; set; }
		public Nullable<decimal> HIValueAdded { get; set; }
		public Nullable<decimal> StateOwnedControlledCom { get; set; }
		public Nullable<decimal> CollectiveCom { get; set; }
		public Nullable<decimal> PrivateEnterprise { get; set; }
		public Nullable<decimal> StockCooperativeCom { get; set; }
		public Nullable<decimal> JointStockCom { get; set; }
		public Nullable<decimal> ForeignHKMacauTaiwanInv { get; set; }
		public Nullable<decimal> ForeignInv { get; set; }
		public Nullable<decimal> HKMacauTaiwanInv { get; set; }
		public Nullable<decimal> LargeCom { get; set; }
		public Nullable<decimal> MediumCom { get; set; }
		public Nullable<decimal> MinitypeCom { get; set; }
		public Nullable<decimal> IndustrialOutputValueAP { get; set; }
		public Nullable<decimal> LIValueAP { get; set; }
		public Nullable<decimal> HIValueAP { get; set; }
		public Nullable<decimal> StateOwnedControlledComAP { get; set; }
		public Nullable<decimal> CollectiveComAP { get; set; }
		public Nullable<decimal> PrivateEnterpriseAP { get; set; }
		public Nullable<decimal> StockCooperativeComAP { get; set; }
		public Nullable<decimal> JointStockComAP { get; set; }
		public Nullable<decimal> ForeignHKMacauTaiwanInvAP { get; set; }
		public Nullable<decimal> ForeignInvAP { get; set; }
		public Nullable<decimal> HKMacauTaiwanInvAP { get; set; }
		public Nullable<decimal> LargeComAP { get; set; }
		public Nullable<decimal> MediumComAP { get; set; }
		public Nullable<decimal> MinitypeComAP { get; set; }
		public Nullable<decimal> IndustrialOutputValueFP { get; set; }
		public Nullable<decimal> LIValueFP { get; set; }
		public Nullable<decimal> HIValueFP { get; set; }
		public Nullable<decimal> StateOwnedControlledComFP { get; set; }
		public Nullable<decimal> CollectiveComFP { get; set; }
		public Nullable<decimal> PrivateEnterpriseFP { get; set; }
		public Nullable<decimal> StockCooperativeComFP { get; set; }
		public Nullable<decimal> JointStockComFP { get; set; }
		public Nullable<decimal> ForeignHKMacauTaiwanInvFP { get; set; }
		public Nullable<decimal> ForeignInvFP { get; set; }
		public Nullable<decimal> HKMacauTaiwanInvFP { get; set; }
		public Nullable<decimal> LargeComFP { get; set; }
		public Nullable<decimal> MediumComFP { get; set; }
		public Nullable<decimal> MinitypeComFP { get; set; }
		public Nullable<decimal> ProductionSalesRatio { get; set; }
		public Nullable<decimal> GrowthIValueAdded { get; set; }
		public Nullable<decimal> GrowthLIValueAdded { get; set; }
		public Nullable<decimal> GrowthHIValueAdded { get; set; }
		public Nullable<decimal> GrowthSOwnedControlledCom { get; set; }
		public Nullable<decimal> GrowthCollectiveCom { get; set; }
		public Nullable<decimal> GrowthPrivateEnterprise { get; set; }
		public Nullable<decimal> GrowthStockCooperativeCom { get; set; }
		public Nullable<decimal> GrowthJointStockCom { get; set; }
		public Nullable<decimal> GrowthFHKMTInv { get; set; }
		public Nullable<decimal> GrowthForeignInv { get; set; }
		public Nullable<decimal> GrowthHKMacauTaiwanInv { get; set; }
		public Nullable<decimal> GrowthLargeCom { get; set; }
		public Nullable<decimal> GrowthMediumCom { get; set; }
		public Nullable<decimal> GrowthMinitypeCom { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

