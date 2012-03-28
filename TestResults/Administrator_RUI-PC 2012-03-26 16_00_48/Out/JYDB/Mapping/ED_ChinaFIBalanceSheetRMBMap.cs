using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ChinaFIBalanceSheetRMBMap : EntityTypeConfiguration<ED_ChinaFIBalanceSheetRMB>
	{
		public ED_ChinaFIBalanceSheetRMBMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.StatementTypeCode, t.DataTypeCode, t.CurrencyCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.StatementTypeCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.DataTypeCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.CurrencyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_ChinaFIBalanceSheetRMB");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.StatementTypeCode).HasColumnName("StatementTypeCode");
			this.Property(t => t.DataTypeCode).HasColumnName("DataTypeCode");
			this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
			this.Property(t => t.TotalAssetBySources).HasColumnName("TotalAssetBySources");
			this.Property(t => t.TotalSavings).HasColumnName("TotalSavings");
			this.Property(t => t.CorporateSavings).HasColumnName("CorporateSavings");
			this.Property(t => t.DemandDeposits).HasColumnName("DemandDeposits");
			this.Property(t => t.TimeDeposits).HasColumnName("TimeDeposits");
			this.Property(t => t.FinanceDeposits).HasColumnName("FinanceDeposits");
			this.Property(t => t.OrgDeposits).HasColumnName("OrgDeposits");
			this.Property(t => t.SavingsDeposits).HasColumnName("SavingsDeposits");
			this.Property(t => t.DemandSavings).HasColumnName("DemandSavings");
			this.Property(t => t.TimeSavings).HasColumnName("TimeSavings");
			this.Property(t => t.AgriculturalDeposits).HasColumnName("AgriculturalDeposits");
			this.Property(t => t.TrustedAndCreditDeposits).HasColumnName("TrustedAndCreditDeposits");
			this.Property(t => t.AcrossBorderDeposits).HasColumnName("AcrossBorderDeposits");
			this.Property(t => t.OtherSavings).HasColumnName("OtherSavings");
			this.Property(t => t.FinancialBonds).HasColumnName("FinancialBonds");
			this.Property(t => t.moneyInCirculation).HasColumnName("moneyInCirculation");
			this.Property(t => t.LiablityToIFO).HasColumnName("LiablityToIFO");
			this.Property(t => t.AbroadFundRaised).HasColumnName("AbroadFundRaised");
			this.Property(t => t.ForexTrading).HasColumnName("ForexTrading");
			this.Property(t => t.BorrowingsFromAbroadInterBank).HasColumnName("BorrowingsFromAbroadInterBank");
			this.Property(t => t.BorrowingsFromCentralBank).HasColumnName("BorrowingsFromCentralBank");
			this.Property(t => t.OtherSources).HasColumnName("OtherSources");
			this.Property(t => t.TotalCapitalUsed).HasColumnName("TotalCapitalUsed");
			this.Property(t => t.TotalLoans).HasColumnName("TotalLoans");
			this.Property(t => t.ShortTermLoans).HasColumnName("ShortTermLoans");
			this.Property(t => t.IndustrialLoans).HasColumnName("IndustrialLoans");
			this.Property(t => t.CommercialLoans).HasColumnName("CommercialLoans");
			this.Property(t => t.ConstructionLoans).HasColumnName("ConstructionLoans");
			this.Property(t => t.AgriculturalLoans).HasColumnName("AgriculturalLoans");
			this.Property(t => t.LoansToRuralEnterprises).HasColumnName("LoansToRuralEnterprises");
			this.Property(t => t.LoansToForeignInvestedCo).HasColumnName("LoansToForeignInvestedCo");
			this.Property(t => t.LoansToPrivateCo).HasColumnName("LoansToPrivateCo");
			this.Property(t => t.OtherShortTermLoans).HasColumnName("OtherShortTermLoans");
			this.Property(t => t.MediumLongTermLoans).HasColumnName("MediumLongTermLoans");
			this.Property(t => t.TrustedAndCreditLoans).HasColumnName("TrustedAndCreditLoans");
			this.Property(t => t.LoanFromFundRaisedAbroad).HasColumnName("LoanFromFundRaisedAbroad");
			this.Property(t => t.LoanByCommercialPaper).HasColumnName("LoanByCommercialPaper");
			this.Property(t => t.OtherLoans).HasColumnName("OtherLoans");
			this.Property(t => t.EquityAndOtherInvestment).HasColumnName("EquityAndOtherInvestment");
			this.Property(t => t.GoldSilver).HasColumnName("GoldSilver");
			this.Property(t => t.Forex).HasColumnName("Forex");
			this.Property(t => t.LoanToGov).HasColumnName("LoanToGov");
			this.Property(t => t.AssetsAtIFO).HasColumnName("AssetsAtIFO");
			this.Property(t => t.LoanToAbroadInterBank).HasColumnName("LoanToAbroadInterBank");
			this.Property(t => t.ReserveDeposits).HasColumnName("ReserveDeposits");
			this.Property(t => t.OtherUses).HasColumnName("OtherUses");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InterimLiquidityLoans).HasColumnName("InterimLiquidityLoans");
			this.Property(t => t.MediumLongClassLoans).HasColumnName("MediumLongClassLoans");
			this.Property(t => t.TotalSavingsGrowthYoY).HasColumnName("TotalSavingsGrowthYoY");
			this.Property(t => t.SavingDepGrowthYoY).HasColumnName("SavingDepGrowthYoY");
			this.Property(t => t.ShortTermLoansGrowthYoY).HasColumnName("ShortTermLoansGrowthYoY");
			this.Property(t => t.TotalLoansGrowthYoY).HasColumnName("TotalLoansGrowthYoY");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ResidentDeposits).HasColumnName("ResidentDeposits");
			this.Property(t => t.ResidentDemandDeposits).HasColumnName("ResidentDemandDeposits");
			this.Property(t => t.ResidentTimeDeposits).HasColumnName("ResidentTimeDeposits");
			this.Property(t => t.NonFinCorpDeposits).HasColumnName("NonFinCorpDeposits");
			this.Property(t => t.EnterprisesDeposits).HasColumnName("EnterprisesDeposits");
			this.Property(t => t.ResidentLoans).HasColumnName("ResidentLoans");
			this.Property(t => t.ConsumptionLoans).HasColumnName("ConsumptionLoans");
			this.Property(t => t.ShortConsumptionLoans).HasColumnName("ShortConsumptionLoans");
			this.Property(t => t.MedLongConsumptionLoans).HasColumnName("MedLongConsumptionLoans");
			this.Property(t => t.OperatingLoans).HasColumnName("OperatingLoans");
			this.Property(t => t.ShortOperatingLoans).HasColumnName("ShortOperatingLoans");
			this.Property(t => t.LoansToFarmHouseholds).HasColumnName("LoansToFarmHouseholds");
			this.Property(t => t.MediumLongOperatingLoans).HasColumnName("MediumLongOperatingLoans");
			this.Property(t => t.NonFinCorpAndOtherLoans).HasColumnName("NonFinCorpAndOtherLoans");
			this.Property(t => t.ShortLoansBillFinancing).HasColumnName("ShortLoansBillFinancing");
		}
	}
}

