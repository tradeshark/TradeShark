using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FinanceSpecialIndexMap : EntityTypeConfiguration<LC_FinanceSpecialIndex>
	{
		public LC_FinanceSpecialIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.DataType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.DataType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_FinanceSpecialIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.TotalDeposit).HasColumnName("TotalDeposit");
			this.Property(t => t.LDepositAndIBorrowing).HasColumnName("LDepositAndIBorrowing");
			this.Property(t => t.LongtermDeposit).HasColumnName("LongtermDeposit");
			this.Property(t => t.InterbankBorrowing).HasColumnName("InterbankBorrowing");
			this.Property(t => t.TotalLoan).HasColumnName("TotalLoan");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.ImOutportForeiCurrReserv).HasColumnName("ImOutportForeiCurrReserv");
			this.Property(t => t.Discount).HasColumnName("Discount");
			this.Property(t => t.MidLongtermLoan).HasColumnName("MidLongtermLoan");
			this.Property(t => t.OverrideLoan).HasColumnName("OverrideLoan");
			this.Property(t => t.NonAccrualLoan).HasColumnName("NonAccrualLoan");
			this.Property(t => t.BadLoan).HasColumnName("BadLoan");
			this.Property(t => t.DeadLoan).HasColumnName("DeadLoan");
			this.Property(t => t.CoreCapital).HasColumnName("CoreCapital");
			this.Property(t => t.SupplementaryCapital).HasColumnName("SupplementaryCapital");
			this.Property(t => t.CapitalAdequacyRatio).HasColumnName("CapitalAdequacyRatio");
			this.Property(t => t.CurrentRatioRMB).HasColumnName("CurrentRatioRMB");
			this.Property(t => t.CurrentRatioFC).HasColumnName("CurrentRatioFC");
			this.Property(t => t.DepositLoanRatioRMB).HasColumnName("DepositLoanRatioRMB");
			this.Property(t => t.DepositLoanRatioFC).HasColumnName("DepositLoanRatioFC");
			this.Property(t => t.MidLongtermLoanRatioRMB).HasColumnName("MidLongtermLoanRatioRMB");
			this.Property(t => t.MidLongtermLoanRatioFC).HasColumnName("MidLongtermLoanRatioFC");
			this.Property(t => t.BorrowingRatio).HasColumnName("BorrowingRatio");
			this.Property(t => t.LendOutRatio).HasColumnName("LendOutRatio");
			this.Property(t => t.IBusinessBorrowingRatio).HasColumnName("IBusinessBorrowingRatio");
			this.Property(t => t.NonPerformingRatio).HasColumnName("NonPerformingRatio");
			this.Property(t => t.IntrerestCollectionRatio).HasColumnName("IntrerestCollectionRatio");
			this.Property(t => t.Single1stLoanRatio).HasColumnName("Single1stLoanRatio");
			this.Property(t => t.SingleBig10LoanRatio).HasColumnName("SingleBig10LoanRatio");
			this.Property(t => t.NormalCredit).HasColumnName("NormalCredit");
			this.Property(t => t.NormalLoan).HasColumnName("NormalLoan");
			this.Property(t => t.NormalDiscount).HasColumnName("NormalDiscount");
			this.Property(t => t.AttentionCredit).HasColumnName("AttentionCredit");
			this.Property(t => t.SubstandardCredit).HasColumnName("SubstandardCredit");
			this.Property(t => t.DoubtfulCredit).HasColumnName("DoubtfulCredit");
			this.Property(t => t.LossCredit).HasColumnName("LossCredit");
			this.Property(t => t.CurrentAsset).HasColumnName("CurrentAsset");
			this.Property(t => t.ProxySecu).HasColumnName("ProxySecu");
			this.Property(t => t.TrustCapital).HasColumnName("TrustCapital");
			this.Property(t => t.CurrentLiability).HasColumnName("CurrentLiability");
			this.Property(t => t.NetCapital).HasColumnName("NetCapital");
			this.Property(t => t.OperatingIncome).HasColumnName("OperatingIncome");
			this.Property(t => t.CommissionIncome).HasColumnName("CommissionIncome");
			this.Property(t => t.SelfSecuSpreadIncome).HasColumnName("SelfSecuSpreadIncome");
			this.Property(t => t.SecuIssueSpreadIncome).HasColumnName("SecuIssueSpreadIncome");
			this.Property(t => t.OperatingExpense).HasColumnName("OperatingExpense");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.BadAccountReserve).HasColumnName("BadAccountReserve");
			this.Property(t => t.DefaultLoan).HasColumnName("DefaultLoan");
			this.Property(t => t.SingleBig10Loan).HasColumnName("SingleBig10Loan");
			this.Property(t => t.NormalCreditProportion).HasColumnName("NormalCreditProportion");
			this.Property(t => t.AttentionCreditProp).HasColumnName("AttentionCreditProp");
			this.Property(t => t.SubstandardCreditProp).HasColumnName("SubstandardCreditProp");
			this.Property(t => t.DoubtfulCreditProp).HasColumnName("DoubtfulCreditProp");
			this.Property(t => t.LossCreditProp).HasColumnName("LossCreditProp");
			this.Property(t => t.CoreCapitalAdequacyRatio).HasColumnName("CoreCapitalAdequacyRatio");
			this.Property(t => t.DepositLoanRatioRMBFC).HasColumnName("DepositLoanRatioRMBFC");
			this.Property(t => t.OperateBTBFundRatio).HasColumnName("OperateBTBFundRatio");
			this.Property(t => t.BadAssetRatio).HasColumnName("BadAssetRatio");
			this.Property(t => t.BLoanCoverRatio).HasColumnName("BLoanCoverRatio");
			this.Property(t => t.OverReserveRateRMB).HasColumnName("OverReserveRateRMB");
			this.Property(t => t.NetCapitalBank).HasColumnName("NetCapitalBank");
			this.Property(t => t.WeightedRiskNetAssets).HasColumnName("WeightedRiskNetAssets");
			this.Property(t => t.LiquidityGap90).HasColumnName("LiquidityGap90");
			this.Property(t => t.InvestmentTARatio).HasColumnName("InvestmentTARatio");
			this.Property(t => t.LoanTARatio).HasColumnName("LoanTARatio");
			this.Property(t => t.OperateAssetTARatio).HasColumnName("OperateAssetTARatio");
			this.Property(t => t.ProfitAssetTARatio).HasColumnName("ProfitAssetTARatio");
			this.Property(t => t.ROA).HasColumnName("ROA");
			this.Property(t => t.ROEBank).HasColumnName("ROEBank");
			this.Property(t => t.LoanInterestTERatio).HasColumnName("LoanInterestTERatio");
			this.Property(t => t.DepInterestTCRatio).HasColumnName("DepInterestTCRatio");
			this.Property(t => t.CostEarningRatio).HasColumnName("CostEarningRatio");
			this.Property(t => t.InterestEarningAssets).HasColumnName("InterestEarningAssets");
			this.Property(t => t.AvgInterestFromAS).HasColumnName("AvgInterestFromAS");
			this.Property(t => t.AvgInterestFromIL).HasColumnName("AvgInterestFromIL");
			this.Property(t => t.InterestAvAcAssetRatio).HasColumnName("InterestAvAcAssetRatio");
			this.Property(t => t.AvgAnnLoanInterest).HasColumnName("AvgAnnLoanInterest");
			this.Property(t => t.AvgAnnDepoInterest).HasColumnName("AvgAnnDepoInterest");
			this.Property(t => t.AvgDLInterestSpread).HasColumnName("AvgDLInterestSpread");
			this.Property(t => t.NetInterestSpreadReturn).HasColumnName("NetInterestSpreadReturn");
			this.Property(t => t.AvgBalanceShortTermLoan).HasColumnName("AvgBalanceShortTermLoan");
			this.Property(t => t.AvgIRateShortTermLoan).HasColumnName("AvgIRateShortTermLoan");
			this.Property(t => t.AvgBalanceLongTermLoan).HasColumnName("AvgBalanceLongTermLoan");
			this.Property(t => t.AvgIRateLongTermLoan).HasColumnName("AvgIRateLongTermLoan");
			this.Property(t => t.AvgBalanceEDemandDeposit).HasColumnName("AvgBalanceEDemandDeposit");
			this.Property(t => t.AvgIRateEDemandDeposit).HasColumnName("AvgIRateEDemandDeposit");
			this.Property(t => t.AvgBalanceEFixedDeposit).HasColumnName("AvgBalanceEFixedDeposit");
			this.Property(t => t.AvgIRateEFixedDeposit).HasColumnName("AvgIRateEFixedDeposit");
			this.Property(t => t.AvgBalaEnterpriseDeposit).HasColumnName("AvgBalaEnterpriseDeposit");
			this.Property(t => t.AvgIREnterpriseDeposit).HasColumnName("AvgIREnterpriseDeposit");
			this.Property(t => t.AvgBalanceCurrentDeposit).HasColumnName("AvgBalanceCurrentDeposit");
			this.Property(t => t.AvgIRateCurrentDeposit).HasColumnName("AvgIRateCurrentDeposit");
			this.Property(t => t.AvgBalanceTimeDeposit).HasColumnName("AvgBalanceTimeDeposit");
			this.Property(t => t.AvgIRateTimetDeposit).HasColumnName("AvgIRateTimetDeposit");
			this.Property(t => t.AvgBalanceSavingsDeposit).HasColumnName("AvgBalanceSavingsDeposit");
			this.Property(t => t.AvgIRateSavingsDeposit).HasColumnName("AvgIRateSavingsDeposit");
			this.Property(t => t.InterestBearingLiability).HasColumnName("InterestBearingLiability");
			this.Property(t => t.IBLsToTotalLiabilities).HasColumnName("IBLsToTotalLiabilities");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.OnOffAassetsWithin90D).HasColumnName("OnOffAassetsWithin90D");
		}
	}
}

