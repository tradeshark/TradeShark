using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_SSFIncomeMap : EntityTypeConfiguration<ED_SSFIncome>
	{
		public ED_SSFIncomeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.IfAdjusted, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_SSFIncome");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.OperRevenues).HasColumnName("OperRevenues");
			this.Property(t => t.EntrustInvReturns).HasColumnName("EntrustInvReturns");
			this.Property(t => t.BondInterests).HasColumnName("BondInterests");
			this.Property(t => t.TBondInterests).HasColumnName("TBondInterests");
			this.Property(t => t.OtherBondInterests).HasColumnName("OtherBondInterests");
			this.Property(t => t.SavingsInterests).HasColumnName("SavingsInterests");
			this.Property(t => t.StockDividend).HasColumnName("StockDividend");
			this.Property(t => t.TaxReimbursement).HasColumnName("TaxReimbursement");
			this.Property(t => t.OtherIncome).HasColumnName("OtherIncome");
			this.Property(t => t.OperExpenses).HasColumnName("OperExpenses");
			this.Property(t => t.InterestExpenses).HasColumnName("InterestExpenses");
			this.Property(t => t.EntrustedSecuAssetsLoss).HasColumnName("EntrustedSecuAssetsLoss");
			this.Property(t => t.CurrencyExchangeLoss).HasColumnName("CurrencyExchangeLoss");
			this.Property(t => t.OtherExpenses).HasColumnName("OtherExpenses");
			this.Property(t => t.OperIncome).HasColumnName("OperIncome");
			this.Property(t => t.ProvisionRiskReserves).HasColumnName("ProvisionRiskReserves");
			this.Property(t => t.OperIncomeReserved).HasColumnName("OperIncomeReserved");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

