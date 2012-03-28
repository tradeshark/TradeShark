using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_CashFlowStatement_HB_NewMap : EntityTypeConfiguration<View_GP_CashFlowStatement_HB_New>
	{
		public View_GP_CashFlowStatement_HB_NewMap()
		{
			// Primary Key
			this.HasKey(t => new { t.XGRQ, t.ID, t.CompanyCode, t.EndDate, t.Mark, t.AccountingStandards, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.N_BulletinType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_AccountingStandards)
				.HasMaxLength(10);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Mark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AccountingStandards)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("View_GP_CashFlowStatement_HB_New");
			this.Property(t => t.N_BulletinType).HasColumnName("N_BulletinType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.N_AccountingStandards).HasColumnName("N_AccountingStandards");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.GoodsSaleServiceRenderCash).HasColumnName("GoodsSaleServiceRenderCash");
			this.Property(t => t.TaxLevyRefund).HasColumnName("TaxLevyRefund");
			this.Property(t => t.OtherCashInRelatedOperate).HasColumnName("OtherCashInRelatedOperate");
			this.Property(t => t.SpecialItemsOCIF).HasColumnName("SpecialItemsOCIF");
			this.Property(t => t.AdjustmentItemsOCIF).HasColumnName("AdjustmentItemsOCIF");
			this.Property(t => t.SubtotalOperateCashInflow).HasColumnName("SubtotalOperateCashInflow");
			this.Property(t => t.GoodsServicesCashPaid).HasColumnName("GoodsServicesCashPaid");
			this.Property(t => t.StaffBehalfPaid).HasColumnName("StaffBehalfPaid");
			this.Property(t => t.AllTaxesPaid).HasColumnName("AllTaxesPaid");
			this.Property(t => t.OtherOperateCashPaid).HasColumnName("OtherOperateCashPaid");
			this.Property(t => t.SpecialItemsOCOF).HasColumnName("SpecialItemsOCOF");
			this.Property(t => t.AdjustmentItemsOCOF).HasColumnName("AdjustmentItemsOCOF");
			this.Property(t => t.SubtotalOperateCashOutflow).HasColumnName("SubtotalOperateCashOutflow");
			this.Property(t => t.AdjustmentItemsNOCF).HasColumnName("AdjustmentItemsNOCF");
			this.Property(t => t.NetOperateCashFlow).HasColumnName("NetOperateCashFlow");
			this.Property(t => t.InvestWithdrawalCash).HasColumnName("InvestWithdrawalCash");
			this.Property(t => t.Investproceeds).HasColumnName("Investproceeds");
			this.Property(t => t.FixIntanOtherAssetDispoCash).HasColumnName("FixIntanOtherAssetDispoCash");
			this.Property(t => t.NetCashDealSubCompany).HasColumnName("NetCashDealSubCompany");
			this.Property(t => t.OtherCashFromInvestAct).HasColumnName("OtherCashFromInvestAct");
			this.Property(t => t.SpecialItemsICIF).HasColumnName("SpecialItemsICIF");
			this.Property(t => t.AdjustmentItemsICIF).HasColumnName("AdjustmentItemsICIF");
			this.Property(t => t.SubtotalInvestCashInflow).HasColumnName("SubtotalInvestCashInflow");
			this.Property(t => t.FixIntanOtherAssetAcquiCash).HasColumnName("FixIntanOtherAssetAcquiCash");
			this.Property(t => t.InvestCashPaid).HasColumnName("InvestCashPaid");
			this.Property(t => t.NetCashFromSubCompany).HasColumnName("NetCashFromSubCompany");
			this.Property(t => t.ImpawnedLoanNetIncrease).HasColumnName("ImpawnedLoanNetIncrease");
			this.Property(t => t.OtherCashToInvestAct).HasColumnName("OtherCashToInvestAct");
			this.Property(t => t.SpecialItemsICOF).HasColumnName("SpecialItemsICOF");
			this.Property(t => t.AdjustmentItemsICOF).HasColumnName("AdjustmentItemsICOF");
			this.Property(t => t.SubtotalInvestCashOutflow).HasColumnName("SubtotalInvestCashOutflow");
			this.Property(t => t.AdjustmentItemsNICF).HasColumnName("AdjustmentItemsNICF");
			this.Property(t => t.NetInvestCashFlow).HasColumnName("NetInvestCashFlow");
			this.Property(t => t.CashFromInvest).HasColumnName("CashFromInvest");
			this.Property(t => t.CashFromMinoSInvestSub).HasColumnName("CashFromMinoSInvestSub");
			this.Property(t => t.CashFromBondsIssue).HasColumnName("CashFromBondsIssue");
			this.Property(t => t.CashFromBorrowing).HasColumnName("CashFromBorrowing");
			this.Property(t => t.OtherFinanceActCash).HasColumnName("OtherFinanceActCash");
			this.Property(t => t.SpecialItemsFCIF).HasColumnName("SpecialItemsFCIF");
			this.Property(t => t.AdjustmentItemsFCIF).HasColumnName("AdjustmentItemsFCIF");
			this.Property(t => t.SubtotalFinanceCashInflow).HasColumnName("SubtotalFinanceCashInflow");
			this.Property(t => t.BorrowingRepayment).HasColumnName("BorrowingRepayment");
			this.Property(t => t.DividendInterestPayment).HasColumnName("DividendInterestPayment");
			this.Property(t => t.ProceedsFromSubToMinoS).HasColumnName("ProceedsFromSubToMinoS");
			this.Property(t => t.OtherFinanceActPayment).HasColumnName("OtherFinanceActPayment");
			this.Property(t => t.SpecialItemsFCOF).HasColumnName("SpecialItemsFCOF");
			this.Property(t => t.AdjustmentItemsFCOF).HasColumnName("AdjustmentItemsFCOF");
			this.Property(t => t.SubtotalFinanceCashOutflow).HasColumnName("SubtotalFinanceCashOutflow");
			this.Property(t => t.AdjustmentItemsNFCF).HasColumnName("AdjustmentItemsNFCF");
			this.Property(t => t.NetFinanceCashFlow).HasColumnName("NetFinanceCashFlow");
			this.Property(t => t.ExchanRateChangeEffect).HasColumnName("ExchanRateChangeEffect");
			this.Property(t => t.OtherItemsEffectingCE).HasColumnName("OtherItemsEffectingCE");
			this.Property(t => t.AdjustmentItemsCE).HasColumnName("AdjustmentItemsCE");
			this.Property(t => t.CashEquivalentIncrease).HasColumnName("CashEquivalentIncrease");
			this.Property(t => t.BeginPeriodCash).HasColumnName("BeginPeriodCash");
			this.Property(t => t.EndPeriodCashEquivalent).HasColumnName("EndPeriodCashEquivalent");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.AssetsDepreciationReserves).HasColumnName("AssetsDepreciationReserves");
			this.Property(t => t.FixedAssetDepreciation).HasColumnName("FixedAssetDepreciation");
			this.Property(t => t.IntangibleAssetAmortization).HasColumnName("IntangibleAssetAmortization");
			this.Property(t => t.DeferredExpenseAmort).HasColumnName("DeferredExpenseAmort");
			this.Property(t => t.DeferredExpenseDecreased).HasColumnName("DeferredExpenseDecreased");
			this.Property(t => t.AccruedExpenseAdded).HasColumnName("AccruedExpenseAdded");
			this.Property(t => t.FixIntanOtherAssetDispoLoss).HasColumnName("FixIntanOtherAssetDispoLoss");
			this.Property(t => t.FixedAssetScrapLoss).HasColumnName("FixedAssetScrapLoss");
			this.Property(t => t.LossFromFairValueChanges).HasColumnName("LossFromFairValueChanges");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.InvestLoss).HasColumnName("InvestLoss");
			this.Property(t => t.DeferedTaxAssetDecrease).HasColumnName("DeferedTaxAssetDecrease");
			this.Property(t => t.DeferedTaxLiabilityIncrease).HasColumnName("DeferedTaxLiabilityIncrease");
			this.Property(t => t.InventoryDecrease).HasColumnName("InventoryDecrease");
			this.Property(t => t.OperateReceivableDecrease).HasColumnName("OperateReceivableDecrease");
			this.Property(t => t.OperatePayableIncrease).HasColumnName("OperatePayableIncrease");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.SpecialItemsNOCF1).HasColumnName("SpecialItemsNOCF1");
			this.Property(t => t.AdjustmentItemsNOCF1).HasColumnName("AdjustmentItemsNOCF1");
			this.Property(t => t.NetOperateCashFlowNotes).HasColumnName("NetOperateCashFlowNotes");
			this.Property(t => t.ContrastAdjutmentNOCF).HasColumnName("ContrastAdjutmentNOCF");
			this.Property(t => t.DebtToCaptical).HasColumnName("DebtToCaptical");
			this.Property(t => t.CBsExpiringWithin1Y).HasColumnName("CBsExpiringWithin1Y");
			this.Property(t => t.FixedAssetsFinanceLeases).HasColumnName("FixedAssetsFinanceLeases");
			this.Property(t => t.CashAtEndOfYear).HasColumnName("CashAtEndOfYear");
			this.Property(t => t.CashAtBeginningOfYear).HasColumnName("CashAtBeginningOfYear");
			this.Property(t => t.CashEquivalentsAtEndOfYear).HasColumnName("CashEquivalentsAtEndOfYear");
			this.Property(t => t.CashEquivalentsAtBeginning).HasColumnName("CashEquivalentsAtBeginning");
			this.Property(t => t.SpecialItemsC).HasColumnName("SpecialItemsC");
			this.Property(t => t.AdjustmentItemsC).HasColumnName("AdjustmentItemsC");
			this.Property(t => t.NetIncrInCashAndEquivalents).HasColumnName("NetIncrInCashAndEquivalents");
			this.Property(t => t.ContrastAdjutmentNC).HasColumnName("ContrastAdjutmentNC");
			this.Property(t => t.Cash).HasColumnName("Cash");
			this.Property(t => t.CashHoldings).HasColumnName("CashHoldings");
			this.Property(t => t.CashInBankPayingAnytime).HasColumnName("CashInBankPayingAnytime");
			this.Property(t => t.OtherMAPayingAnytime).HasColumnName("OtherMAPayingAnytime");
			this.Property(t => t.CashEquivalents).HasColumnName("CashEquivalents");
			this.Property(t => t.BondsExpiringWithin3M).HasColumnName("BondsExpiringWithin3M");
			this.Property(t => t.CashAndEquivalentsAtEnd).HasColumnName("CashAndEquivalentsAtEnd");
			this.Property(t => t.CashRestrictedToAssociates).HasColumnName("CashRestrictedToAssociates");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

