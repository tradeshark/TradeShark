using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_ResidentIncome
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<int> NumberOfHouseholdSurveyed { get; set; }
		public Nullable<decimal> AvgFamilySize { get; set; }
		public Nullable<decimal> AvgFamilyLaborers { get; set; }
		public Nullable<decimal> PersonsSupportedPerLaborer { get; set; }
		public Nullable<decimal> TotalIncomePerCapita { get; set; }
		public Nullable<decimal> AvgDisposalIncomePerCapita { get; set; }
		public Nullable<decimal> TotalSalaryIncome { get; set; }
		public Nullable<decimal> HouseholdCultivationIncome { get; set; }
		public Nullable<decimal> TransferAndCatitalIncome { get; set; }
		public Nullable<decimal> TransferingIncome { get; set; }
		public Nullable<decimal> CatitalIncome { get; set; }
		public Nullable<decimal> OtherIncome { get; set; }
		public Nullable<decimal> PerCapitaCashIncome { get; set; }
		public Nullable<decimal> CashIncomeFromWages { get; set; }
		public Nullable<decimal> CashIcomeFromCultivation { get; set; }
		public Nullable<decimal> CashIncomeFromTranCapital { get; set; }
		public Nullable<decimal> CapitalCashIncome { get; set; }
		public Nullable<decimal> TransferingCashIncome { get; set; }
		public Nullable<decimal> CashIncomeSavingsLoans { get; set; }
		public Nullable<decimal> OtherCashIncome { get; set; }
		public Nullable<decimal> TotalExpenPerCapita { get; set; }
		public Nullable<decimal> TotalExpenFamilyCultivation { get; set; }
		public Nullable<decimal> TotalExpenProductiveFAssets { get; set; }
		public Nullable<decimal> TotalExpenTaxAndFees { get; set; }
		public Nullable<decimal> TotalExpenLivingConsumption { get; set; }
		public Nullable<decimal> TotalExpenFood { get; set; }
		public Nullable<decimal> TotalExpenGrains { get; set; }
		public Nullable<decimal> TotalExpenDress { get; set; }
		public Nullable<decimal> TotalExpenClothing { get; set; }
		public Nullable<decimal> TotalExpenFamilyEquipService { get; set; }
		public Nullable<decimal> TotalExpenDurables { get; set; }
		public Nullable<decimal> TotalExpenMedicare { get; set; }
		public Nullable<decimal> TotalExpenTrafficCommuni { get; set; }
		public Nullable<decimal> TotalExpenEntertainmentEdu { get; set; }
		public Nullable<decimal> TotalExpenDurablesForAE { get; set; }
		public Nullable<decimal> TotalExpenHabitation { get; set; }
		public Nullable<decimal> TotalExpenHousing { get; set; }
		public Nullable<decimal> TotalExpenOtherGoodsServices { get; set; }
		public Nullable<decimal> TotalExpenOtherConsumption { get; set; }
		public Nullable<decimal> TotalExpenTransferAndCapital { get; set; }
		public Nullable<decimal> TotalExpenCapital { get; set; }
		public Nullable<decimal> TotalExpenTransfering { get; set; }
		public Nullable<decimal> TotalExpenSavingsLoans { get; set; }
		public Nullable<decimal> TotalExpenOther { get; set; }
		public Nullable<decimal> CashExpenPerCapita { get; set; }
		public Nullable<decimal> CashExpenProductionCost { get; set; }
		public Nullable<decimal> CashExpenHouseholdCultivation { get; set; }
		public Nullable<decimal> CashExpenProductiveFAssets { get; set; }
		public Nullable<decimal> CashExpenTaxAndFee { get; set; }
		public Nullable<decimal> CashExpenLiving { get; set; }
		public Nullable<decimal> CashExpenFood { get; set; }
		public Nullable<decimal> CashExpenGrains { get; set; }
		public Nullable<decimal> CashExpenDress { get; set; }
		public Nullable<decimal> CashExpenClothing { get; set; }
		public Nullable<decimal> CashExpenFamilyEquipService { get; set; }
		public Nullable<decimal> CashExpenDurables { get; set; }
		public Nullable<decimal> CashExpenMedicare { get; set; }
		public Nullable<decimal> CashExpenTrafficCommuni { get; set; }
		public Nullable<decimal> CashExpenEntertainmentEdu { get; set; }
		public Nullable<decimal> CashExpenDurablesForAE { get; set; }
		public Nullable<decimal> CashExpenHabitation { get; set; }
		public Nullable<decimal> CashExpenHousing { get; set; }
		public Nullable<decimal> CashExpenOtherGoodsServices { get; set; }
		public Nullable<decimal> CashExpenOtherConsumption { get; set; }
		public Nullable<decimal> CashExpenTransferAndCapital { get; set; }
		public Nullable<decimal> CashExpenCapital { get; set; }
		public Nullable<decimal> CashExpenTransfering { get; set; }
		public Nullable<decimal> CashExpenSavingsLoans { get; set; }
		public Nullable<decimal> CashExpenOthers { get; set; }
		public Nullable<decimal> NetIncomePerCapita { get; set; }
		public Nullable<decimal> NetSalaryIncome { get; set; }
		public Nullable<decimal> NetIncomeHouseholdCultivation { get; set; }
		public Nullable<decimal> NetIncomeTransferAndCapital { get; set; }
		public Nullable<decimal> NetIncomeCapital { get; set; }
		public Nullable<decimal> NetIncomeTransfering { get; set; }
		public Nullable<decimal> NetIncomeOthers { get; set; }
		public Nullable<decimal> ProductiveNetIncome { get; set; }
		public Nullable<decimal> NetIncomePrimaryIndustry { get; set; }
		public Nullable<decimal> NetIncomeSecondIndustry { get; set; }
		public Nullable<decimal> NetIncomeTertiary { get; set; }
		public Nullable<decimal> NonProductiveNetIncome { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

