using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_IncomeStatementMap : EntityTypeConfiguration<MF_IncomeStatement>
	{
		public MF_IncomeStatementMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_IncomeStatement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.StockSpreadIncome).HasColumnName("StockSpreadIncome");
			this.Property(t => t.BondSpreadIncome).HasColumnName("BondSpreadIncome");
			this.Property(t => t.BondInterestIncome).HasColumnName("BondInterestIncome");
			this.Property(t => t.DepositInterestIncome).HasColumnName("DepositInterestIncome");
			this.Property(t => t.DividendIncome).HasColumnName("DividendIncome");
			this.Property(t => t.BoughtSellbackSecuIncome).HasColumnName("BoughtSellbackSecuIncome");
			this.Property(t => t.OtherIncome).HasColumnName("OtherIncome");
			this.Property(t => t.TotalIncome).HasColumnName("TotalIncome");
			this.Property(t => t.MangementFee).HasColumnName("MangementFee");
			this.Property(t => t.TrustFee).HasColumnName("TrustFee");
			this.Property(t => t.SoldRepoSecuExpense).HasColumnName("SoldRepoSecuExpense");
			this.Property(t => t.OtherExpense).HasColumnName("OtherExpense");
			this.Property(t => t.InfoDisclosureFee).HasColumnName("InfoDisclosureFee");
			this.Property(t => t.AuditFee).HasColumnName("AuditFee");
			this.Property(t => t.TotalExpense).HasColumnName("TotalExpense");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.UnrealizedProfitChange).HasColumnName("UnrealizedProfitChange");
			this.Property(t => t.Performance).HasColumnName("Performance");
			this.Property(t => t.RetainedProfitAtBegin).HasColumnName("RetainedProfitAtBegin");
			this.Property(t => t.ApplyingBufferMoney).HasColumnName("ApplyingBufferMoney");
			this.Property(t => t.RedemptionBufferMoney).HasColumnName("RedemptionBufferMoney");
			this.Property(t => t.DistributableNetProfit).HasColumnName("DistributableNetProfit");
			this.Property(t => t.DistributedNetProfit).HasColumnName("DistributedNetProfit");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

