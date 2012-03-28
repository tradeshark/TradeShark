using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_MacroData
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int ReportArea { get; set; }
		public Nullable<int> Country { get; set; }
		public Nullable<int> Province { get; set; }
		public System.DateTime EndDate { get; set; }
		public int ReportPeriod { get; set; }
		public Nullable<decimal> GNP { get; set; }
		public Nullable<decimal> GDP { get; set; }
		public Nullable<decimal> GrowthGDP { get; set; }
		public Nullable<decimal> PrimaryIndustry { get; set; }
		public Nullable<decimal> GrowthRateP { get; set; }
		public Nullable<decimal> SecondIndustry { get; set; }
		public Nullable<decimal> GrowthRateS { get; set; }
		public Nullable<decimal> ThirdIndustry { get; set; }
		public Nullable<decimal> GrowthRateT { get; set; }
		public Nullable<decimal> PerCapitaGDP { get; set; }
		public Nullable<decimal> UrbanResidentDI { get; set; }
		public Nullable<decimal> RuralResidentDCI { get; set; }
		public Nullable<decimal> IndustrialValueAdded { get; set; }
		public Nullable<decimal> GrowthIVA { get; set; }
		public Nullable<decimal> LIVA { get; set; }
		public Nullable<decimal> HIVA { get; set; }
		public Nullable<decimal> StateOwnedControlledCom { get; set; }
		public Nullable<decimal> CollectiveCom { get; set; }
		public Nullable<decimal> StockCooperativeCom { get; set; }
		public Nullable<decimal> JointStockCom { get; set; }
		public Nullable<decimal> ForeignHKMacauTaiwanInv { get; set; }
		public Nullable<decimal> GIP90ConstantValue { get; set; }
		public Nullable<decimal> GrowthGIP90ConstantValue { get; set; }
		public Nullable<decimal> ProductionSalesRatio { get; set; }
		public Nullable<decimal> GrowthPSR { get; set; }
		public Nullable<decimal> FixedAssetInv { get; set; }
		public Nullable<decimal> InfrastructureInv { get; set; }
		public Nullable<decimal> RenovationInv { get; set; }
		public Nullable<decimal> RealEstateInv { get; set; }
		public Nullable<decimal> PrimaryIndustryInv { get; set; }
		public Nullable<decimal> SecondIndustryInv { get; set; }
		public Nullable<decimal> ThirdIndustryInv { get; set; }
		public Nullable<decimal> EasternRegionInv { get; set; }
		public Nullable<decimal> CentralRegionInv { get; set; }
		public Nullable<decimal> WesternRegionInv { get; set; }
		public Nullable<decimal> FinancialRE { get; set; }
		public Nullable<decimal> FinancialR { get; set; }
		public Nullable<decimal> FinancialE { get; set; }
		public Nullable<decimal> TaxRevenues { get; set; }
		public Nullable<decimal> InfrastructureE { get; set; }
		public Nullable<decimal> RetailValueSC { get; set; }
		public Nullable<decimal> ImportExportValueOfGoods { get; set; }
		public Nullable<decimal> ExportValueOfGoods { get; set; }
		public Nullable<decimal> ImportValueOfGoods { get; set; }
		public Nullable<decimal> ApprovedContractualFInv { get; set; }
		public Nullable<decimal> ActualFInv { get; set; }
		public Nullable<decimal> BroadMoney { get; set; }
		public Nullable<decimal> NarrowMoney { get; set; }
		public Nullable<decimal> CashCirculation { get; set; }
		public Nullable<decimal> NetAmountCash { get; set; }
		public Nullable<decimal> FISavings { get; set; }
		public Nullable<decimal> CorporateSavings { get; set; }
		public Nullable<decimal> ResidentSavings { get; set; }
		public Nullable<decimal> FILoans { get; set; }
		public Nullable<decimal> ShortTermLoans { get; set; }
		public Nullable<decimal> MediumLongTermLoans { get; set; }
		public Nullable<decimal> StateBankSavings { get; set; }
		public Nullable<decimal> CorporateSavingsSB { get; set; }
		public Nullable<decimal> ResidentSavingsSB { get; set; }
		public Nullable<decimal> StateBankLoans { get; set; }
		public Nullable<decimal> ShortTermLoansSB { get; set; }
		public Nullable<decimal> ICLoansSB { get; set; }
		public Nullable<decimal> MediumLongTermLoansSB { get; set; }
		public Nullable<decimal> ForeignReserves { get; set; }
		public Nullable<decimal> GoldReserves { get; set; }
		public Nullable<decimal> NationalRCPI { get; set; }
		public Nullable<decimal> UrbanRCPI { get; set; }
		public Nullable<decimal> RuralRCPI { get; set; }
		public Nullable<decimal> NationalCRPI { get; set; }
		public Nullable<decimal> UrbanCRPI { get; set; }
		public Nullable<decimal> RuralCRPI { get; set; }
		public Nullable<decimal> GeneralPGPI { get; set; }
		public Nullable<decimal> AgriculturePGPI { get; set; }
		public Nullable<decimal> InflationRate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

