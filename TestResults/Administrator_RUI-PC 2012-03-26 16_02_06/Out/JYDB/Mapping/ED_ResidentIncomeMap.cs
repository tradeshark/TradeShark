using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ResidentIncomeMap : EntityTypeConfiguration<ED_ResidentIncome>
	{
		public ED_ResidentIncomeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ED_ResidentIncome");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.NumberOfHouseholdSurveyed).HasColumnName("NumberOfHouseholdSurveyed");
			this.Property(t => t.AvgFamilySize).HasColumnName("AvgFamilySize");
			this.Property(t => t.AvgFamilyLaborers).HasColumnName("AvgFamilyLaborers");
			this.Property(t => t.PersonsSupportedPerLaborer).HasColumnName("PersonsSupportedPerLaborer");
			this.Property(t => t.TotalIncomePerCapita).HasColumnName("TotalIncomePerCapita");
			this.Property(t => t.AvgDisposalIncomePerCapita).HasColumnName("AvgDisposalIncomePerCapita");
			this.Property(t => t.TotalSalaryIncome).HasColumnName("TotalSalaryIncome");
			this.Property(t => t.HouseholdCultivationIncome).HasColumnName("HouseholdCultivationIncome");
			this.Property(t => t.TransferAndCatitalIncome).HasColumnName("TransferAndCatitalIncome");
			this.Property(t => t.TransferingIncome).HasColumnName("TransferingIncome");
			this.Property(t => t.CatitalIncome).HasColumnName("CatitalIncome");
			this.Property(t => t.OtherIncome).HasColumnName("OtherIncome");
			this.Property(t => t.PerCapitaCashIncome).HasColumnName("PerCapitaCashIncome");
			this.Property(t => t.CashIncomeFromWages).HasColumnName("CashIncomeFromWages");
			this.Property(t => t.CashIcomeFromCultivation).HasColumnName("CashIcomeFromCultivation");
			this.Property(t => t.CashIncomeFromTranCapital).HasColumnName("CashIncomeFromTranCapital");
			this.Property(t => t.CapitalCashIncome).HasColumnName("CapitalCashIncome");
			this.Property(t => t.TransferingCashIncome).HasColumnName("TransferingCashIncome");
			this.Property(t => t.CashIncomeSavingsLoans).HasColumnName("CashIncomeSavingsLoans");
			this.Property(t => t.OtherCashIncome).HasColumnName("OtherCashIncome");
			this.Property(t => t.TotalExpenPerCapita).HasColumnName("TotalExpenPerCapita");
			this.Property(t => t.TotalExpenFamilyCultivation).HasColumnName("TotalExpenFamilyCultivation");
			this.Property(t => t.TotalExpenProductiveFAssets).HasColumnName("TotalExpenProductiveFAssets");
			this.Property(t => t.TotalExpenTaxAndFees).HasColumnName("TotalExpenTaxAndFees");
			this.Property(t => t.TotalExpenLivingConsumption).HasColumnName("TotalExpenLivingConsumption");
			this.Property(t => t.TotalExpenFood).HasColumnName("TotalExpenFood");
			this.Property(t => t.TotalExpenGrains).HasColumnName("TotalExpenGrains");
			this.Property(t => t.TotalExpenDress).HasColumnName("TotalExpenDress");
			this.Property(t => t.TotalExpenClothing).HasColumnName("TotalExpenClothing");
			this.Property(t => t.TotalExpenFamilyEquipService).HasColumnName("TotalExpenFamilyEquipService");
			this.Property(t => t.TotalExpenDurables).HasColumnName("TotalExpenDurables");
			this.Property(t => t.TotalExpenMedicare).HasColumnName("TotalExpenMedicare");
			this.Property(t => t.TotalExpenTrafficCommuni).HasColumnName("TotalExpenTrafficCommuni");
			this.Property(t => t.TotalExpenEntertainmentEdu).HasColumnName("TotalExpenEntertainmentEdu");
			this.Property(t => t.TotalExpenDurablesForAE).HasColumnName("TotalExpenDurablesForAE");
			this.Property(t => t.TotalExpenHabitation).HasColumnName("TotalExpenHabitation");
			this.Property(t => t.TotalExpenHousing).HasColumnName("TotalExpenHousing");
			this.Property(t => t.TotalExpenOtherGoodsServices).HasColumnName("TotalExpenOtherGoodsServices");
			this.Property(t => t.TotalExpenOtherConsumption).HasColumnName("TotalExpenOtherConsumption");
			this.Property(t => t.TotalExpenTransferAndCapital).HasColumnName("TotalExpenTransferAndCapital");
			this.Property(t => t.TotalExpenCapital).HasColumnName("TotalExpenCapital");
			this.Property(t => t.TotalExpenTransfering).HasColumnName("TotalExpenTransfering");
			this.Property(t => t.TotalExpenSavingsLoans).HasColumnName("TotalExpenSavingsLoans");
			this.Property(t => t.TotalExpenOther).HasColumnName("TotalExpenOther");
			this.Property(t => t.CashExpenPerCapita).HasColumnName("CashExpenPerCapita");
			this.Property(t => t.CashExpenProductionCost).HasColumnName("CashExpenProductionCost");
			this.Property(t => t.CashExpenHouseholdCultivation).HasColumnName("CashExpenHouseholdCultivation");
			this.Property(t => t.CashExpenProductiveFAssets).HasColumnName("CashExpenProductiveFAssets");
			this.Property(t => t.CashExpenTaxAndFee).HasColumnName("CashExpenTaxAndFee");
			this.Property(t => t.CashExpenLiving).HasColumnName("CashExpenLiving");
			this.Property(t => t.CashExpenFood).HasColumnName("CashExpenFood");
			this.Property(t => t.CashExpenGrains).HasColumnName("CashExpenGrains");
			this.Property(t => t.CashExpenDress).HasColumnName("CashExpenDress");
			this.Property(t => t.CashExpenClothing).HasColumnName("CashExpenClothing");
			this.Property(t => t.CashExpenFamilyEquipService).HasColumnName("CashExpenFamilyEquipService");
			this.Property(t => t.CashExpenDurables).HasColumnName("CashExpenDurables");
			this.Property(t => t.CashExpenMedicare).HasColumnName("CashExpenMedicare");
			this.Property(t => t.CashExpenTrafficCommuni).HasColumnName("CashExpenTrafficCommuni");
			this.Property(t => t.CashExpenEntertainmentEdu).HasColumnName("CashExpenEntertainmentEdu");
			this.Property(t => t.CashExpenDurablesForAE).HasColumnName("CashExpenDurablesForAE");
			this.Property(t => t.CashExpenHabitation).HasColumnName("CashExpenHabitation");
			this.Property(t => t.CashExpenHousing).HasColumnName("CashExpenHousing");
			this.Property(t => t.CashExpenOtherGoodsServices).HasColumnName("CashExpenOtherGoodsServices");
			this.Property(t => t.CashExpenOtherConsumption).HasColumnName("CashExpenOtherConsumption");
			this.Property(t => t.CashExpenTransferAndCapital).HasColumnName("CashExpenTransferAndCapital");
			this.Property(t => t.CashExpenCapital).HasColumnName("CashExpenCapital");
			this.Property(t => t.CashExpenTransfering).HasColumnName("CashExpenTransfering");
			this.Property(t => t.CashExpenSavingsLoans).HasColumnName("CashExpenSavingsLoans");
			this.Property(t => t.CashExpenOthers).HasColumnName("CashExpenOthers");
			this.Property(t => t.NetIncomePerCapita).HasColumnName("NetIncomePerCapita");
			this.Property(t => t.NetSalaryIncome).HasColumnName("NetSalaryIncome");
			this.Property(t => t.NetIncomeHouseholdCultivation).HasColumnName("NetIncomeHouseholdCultivation");
			this.Property(t => t.NetIncomeTransferAndCapital).HasColumnName("NetIncomeTransferAndCapital");
			this.Property(t => t.NetIncomeCapital).HasColumnName("NetIncomeCapital");
			this.Property(t => t.NetIncomeTransfering).HasColumnName("NetIncomeTransfering");
			this.Property(t => t.NetIncomeOthers).HasColumnName("NetIncomeOthers");
			this.Property(t => t.ProductiveNetIncome).HasColumnName("ProductiveNetIncome");
			this.Property(t => t.NetIncomePrimaryIndustry).HasColumnName("NetIncomePrimaryIndustry");
			this.Property(t => t.NetIncomeSecondIndustry).HasColumnName("NetIncomeSecondIndustry");
			this.Property(t => t.NetIncomeTertiary).HasColumnName("NetIncomeTertiary");
			this.Property(t => t.NonProductiveNetIncome).HasColumnName("NonProductiveNetIncome");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

