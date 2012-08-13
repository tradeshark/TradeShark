using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ChinaForeignDebtsMap : EntityTypeConfiguration<ED_ChinaForeignDebts>
	{
		public ED_ChinaForeignDebtsMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.DebtorsCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.DebtorsCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_ChinaForeignDebts");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DebtorsCode).HasColumnName("DebtorsCode");
			this.Property(t => t.LoansForeignGov).HasColumnName("LoansForeignGov");
			this.Property(t => t.LoansIFO).HasColumnName("LoansIFO");
			this.Property(t => t.LoansFI).HasColumnName("LoansFI");
			this.Property(t => t.BuyerCredit).HasColumnName("BuyerCredit");
			this.Property(t => t.BorrowingsFromOthers).HasColumnName("BorrowingsFromOthers");
			this.Property(t => t.ForeignBankInChinaLoans).HasColumnName("ForeignBankInChinaLoans");
			this.Property(t => t.BondIssuedAbroad).HasColumnName("BondIssuedAbroad");
			this.Property(t => t.DeferredPayments).HasColumnName("DeferredPayments");
			this.Property(t => t.ForeignerSavings).HasColumnName("ForeignerSavings");
			this.Property(t => t.IntlFinancialLeasing).HasColumnName("IntlFinancialLeasing");
			this.Property(t => t.CashPayedforDebtsInCT).HasColumnName("CashPayedforDebtsInCT");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.TradeCredit).HasColumnName("TradeCredit");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

