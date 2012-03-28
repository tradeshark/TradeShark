using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_SSFCashFlowMap : EntityTypeConfiguration<ED_SSFCashFlow>
	{
		public ED_SSFCashFlowMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.IfAdjusted, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_SSFCashFlow");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.CashFromBondInv).HasColumnName("CashFromBondInv");
			this.Property(t => t.CashFromEntrustInv).HasColumnName("CashFromEntrustInv");
			this.Property(t => t.CashDividendReceived).HasColumnName("CashDividendReceived");
			this.Property(t => t.CashFromEntrustInvIncome).HasColumnName("CashFromEntrustInvIncome");
			this.Property(t => t.CouponFromBondInv).HasColumnName("CouponFromBondInv");
			this.Property(t => t.BankSavings).HasColumnName("BankSavings");
			this.Property(t => t.TaxReimbursement).HasColumnName("TaxReimbursement");
			this.Property(t => t.CashFromOtherOperRelated).HasColumnName("CashFromOtherOperRelated");
			this.Property(t => t.TotalCashInOper).HasColumnName("TotalCashInOper");
			this.Property(t => t.CashPaidBondInvestment).HasColumnName("CashPaidBondInvestment");
			this.Property(t => t.CashPaidEntrustInv).HasColumnName("CashPaidEntrustInv");
			this.Property(t => t.CashPaidApplyingNewShares).HasColumnName("CashPaidApplyingNewShares");
			this.Property(t => t.CashPaidOtherOperRelated).HasColumnName("CashPaidOtherOperRelated");
			this.Property(t => t.TotalCashOutOper).HasColumnName("TotalCashOutOper");
			this.Property(t => t.NetCashFlowOper).HasColumnName("NetCashFlowOper");
			this.Property(t => t.CashFromFinaAppropriation).HasColumnName("CashFromFinaAppropriation");
			this.Property(t => t.ReduStateStockholdings).HasColumnName("ReduStateStockholdings");
			this.Property(t => t.CashFromLottoryIssuance).HasColumnName("CashFromLottoryIssuance");
			this.Property(t => t.CashBankBorrowings).HasColumnName("CashBankBorrowings");
			this.Property(t => t.CashFromOtherFinaRelated).HasColumnName("CashFromOtherFinaRelated");
			this.Property(t => t.TotalCashInFina).HasColumnName("TotalCashInFina");
			this.Property(t => t.CashPaidBySSF).HasColumnName("CashPaidBySSF");
			this.Property(t => t.ReturnBankBorrowings).HasColumnName("ReturnBankBorrowings");
			this.Property(t => t.InterestsPaidtoBanks).HasColumnName("InterestsPaidtoBanks");
			this.Property(t => t.CashPaidOtherFinaRelated).HasColumnName("CashPaidOtherFinaRelated");
			this.Property(t => t.TotalCashOutFina).HasColumnName("TotalCashOutFina");
			this.Property(t => t.NetCashFlowFina).HasColumnName("NetCashFlowFina");
			this.Property(t => t.ImpactExchangeRateChange).HasColumnName("ImpactExchangeRateChange");
			this.Property(t => t.ImpactOtherFactors).HasColumnName("ImpactOtherFactors");
			this.Property(t => t.NetIncrCashAndEquivalent).HasColumnName("NetIncrCashAndEquivalent");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

