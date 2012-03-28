using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_QCashFlowStatementMap : EntityTypeConfiguration<LC_QCashFlowStatement>
	{
		public LC_QCashFlowStatementMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_QCashFlowStatement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.GoodsSaleServiceRenderCash).HasColumnName("GoodsSaleServiceRenderCash");
			this.Property(t => t.RentalReceived).HasColumnName("RentalReceived");
			this.Property(t => t.VATReceivedAndRefunded).HasColumnName("VATReceivedAndRefunded");
			this.Property(t => t.OtherTaxLevyRefund).HasColumnName("OtherTaxLevyRefund");
			this.Property(t => t.TaxLevyRefund).HasColumnName("TaxLevyRefund");
			this.Property(t => t.OtherCashInRelatedOperate).HasColumnName("OtherCashInRelatedOperate");
			this.Property(t => t.SubtotalOperateCashInflow).HasColumnName("SubtotalOperateCashInflow");
			this.Property(t => t.GoodsServicesCashPaid).HasColumnName("GoodsServicesCashPaid");
			this.Property(t => t.OperateLeasesCashPaid).HasColumnName("OperateLeasesCashPaid");
			this.Property(t => t.StaffBehalfPaid).HasColumnName("StaffBehalfPaid");
			this.Property(t => t.VATPaid).HasColumnName("VATPaid");
			this.Property(t => t.IncomeTaxPaid).HasColumnName("IncomeTaxPaid");
			this.Property(t => t.OtherTaxPaid).HasColumnName("OtherTaxPaid");
			this.Property(t => t.AllTaxesPaid).HasColumnName("AllTaxesPaid");
			this.Property(t => t.OtherOperateCashPaid).HasColumnName("OtherOperateCashPaid");
			this.Property(t => t.SubtotalOperateCashOutflow).HasColumnName("SubtotalOperateCashOutflow");
			this.Property(t => t.NetOperateCashFlow).HasColumnName("NetOperateCashFlow");
			this.Property(t => t.InvestWithdrawalCash).HasColumnName("InvestWithdrawalCash");
			this.Property(t => t.DividendAndProfitReceived).HasColumnName("DividendAndProfitReceived");
			this.Property(t => t.BondInterestIncome).HasColumnName("BondInterestIncome");
			this.Property(t => t.FixIntanOtherAssetDispoCash).HasColumnName("FixIntanOtherAssetDispoCash");
			this.Property(t => t.OtherCashFromInvestAct).HasColumnName("OtherCashFromInvestAct");
			this.Property(t => t.SubtotalInvestCashInflow).HasColumnName("SubtotalInvestCashInflow");
			this.Property(t => t.FixIntanOtherAssetAcquiCash).HasColumnName("FixIntanOtherAssetAcquiCash");
			this.Property(t => t.EquityInvestCashPaid).HasColumnName("EquityInvestCashPaid");
			this.Property(t => t.DebtInvestCashPaid).HasColumnName("DebtInvestCashPaid");
			this.Property(t => t.OtherCashToInvestAct).HasColumnName("OtherCashToInvestAct");
			this.Property(t => t.SubtotalInvestCashOutflow).HasColumnName("SubtotalInvestCashOutflow");
			this.Property(t => t.NetInvestCashFlow).HasColumnName("NetInvestCashFlow");
			this.Property(t => t.IssueShareproceeds).HasColumnName("IssueShareproceeds");
			this.Property(t => t.MinorityInvestproceeds).HasColumnName("MinorityInvestproceeds");
			this.Property(t => t.IssueBondproceeds).HasColumnName("IssueBondproceeds");
			this.Property(t => t.Borrowingproceeds).HasColumnName("Borrowingproceeds");
			this.Property(t => t.OtherFinanceActproceeds).HasColumnName("OtherFinanceActproceeds");
			this.Property(t => t.SubtotalFinanceCashInflow).HasColumnName("SubtotalFinanceCashInflow");
			this.Property(t => t.BorrowingRepayment).HasColumnName("BorrowingRepayment");
			this.Property(t => t.FinanceActPayment).HasColumnName("FinanceActPayment");
			this.Property(t => t.DividendProfitDistribPayment).HasColumnName("DividendProfitDistribPayment");
			this.Property(t => t.SubCompanyPaidDiviToMino).HasColumnName("SubCompanyPaidDiviToMino");
			this.Property(t => t.InterestPayment).HasColumnName("InterestPayment");
			this.Property(t => t.FinanceLeasePayment).HasColumnName("FinanceLeasePayment");
			this.Property(t => t.RegCapitalReductionPayment).HasColumnName("RegCapitalReductionPayment");
			this.Property(t => t.SubCompanyCapiReduPaidMino).HasColumnName("SubCompanyCapiReduPaidMino");
			this.Property(t => t.OtherFinanceActPayment).HasColumnName("OtherFinanceActPayment");
			this.Property(t => t.SubtotalFinanceCashOutflow).HasColumnName("SubtotalFinanceCashOutflow");
			this.Property(t => t.NetFinanceCashFlow).HasColumnName("NetFinanceCashFlow");
			this.Property(t => t.ExchanRateChangeEffect).HasColumnName("ExchanRateChangeEffect");
			this.Property(t => t.CashEquivalentIncrease).HasColumnName("CashEquivalentIncrease");
			this.Property(t => t.FixedAssetTransRepayment).HasColumnName("FixedAssetTransRepayment");
			this.Property(t => t.InvestTransRepayment).HasColumnName("InvestTransRepayment");
			this.Property(t => t.FixedAssetFormInvest).HasColumnName("FixedAssetFormInvest");
			this.Property(t => t.InventoryTransRepayment).HasColumnName("InventoryTransRepayment");
			this.Property(t => t.FinanceLeaseFixedAssets).HasColumnName("FinanceLeaseFixedAssets");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.MergeAcquisitionProfit).HasColumnName("MergeAcquisitionProfit");
			this.Property(t => t.UnrecognisedInvestLoss).HasColumnName("UnrecognisedInvestLoss");
			this.Property(t => t.BadDebtWrittenOffProvision).HasColumnName("BadDebtWrittenOffProvision");
			this.Property(t => t.FixedAssetDepreciation).HasColumnName("FixedAssetDepreciation");
			this.Property(t => t.IntangibleAssetAmortization).HasColumnName("IntangibleAssetAmortization");
			this.Property(t => t.PreoperateEexpenseAmort).HasColumnName("PreoperateEexpenseAmort");
			this.Property(t => t.DeferredExpenseAmort).HasColumnName("DeferredExpenseAmort");
			this.Property(t => t.DeferredExpenseDecreased).HasColumnName("DeferredExpenseDecreased");
			this.Property(t => t.AccruedExpenseAdded).HasColumnName("AccruedExpenseAdded");
			this.Property(t => t.FixIntanOtherAssetDispoLoss).HasColumnName("FixIntanOtherAssetDispoLoss");
			this.Property(t => t.FixedAssetScrapLoss).HasColumnName("FixedAssetScrapLoss");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.InvestLoss).HasColumnName("InvestLoss");
			this.Property(t => t.NetDeferedTaxCredit).HasColumnName("NetDeferedTaxCredit");
			this.Property(t => t.InventoryDecrease).HasColumnName("InventoryDecrease");
			this.Property(t => t.InventoryDevalProvision).HasColumnName("InventoryDevalProvision");
			this.Property(t => t.OperateReceivableDecrease).HasColumnName("OperateReceivableDecrease");
			this.Property(t => t.OperatePayableDecrease).HasColumnName("OperatePayableDecrease");
			this.Property(t => t.VATNetIncrease).HasColumnName("VATNetIncrease");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.NetOperateCashFlowNotes).HasColumnName("NetOperateCashFlowNotes");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

