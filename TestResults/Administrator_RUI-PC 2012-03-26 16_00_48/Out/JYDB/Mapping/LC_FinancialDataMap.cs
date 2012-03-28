using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FinancialDataMap : EntityTypeConfiguration<LC_FinancialData>
	{
		public LC_FinancialDataMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("LC_FinancialData");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SalesCost).HasColumnName("SalesCost");
			this.Property(t => t.GrossProfit).HasColumnName("GrossProfit");
			this.Property(t => t.SalesRevenue).HasColumnName("SalesRevenue");
			this.Property(t => t.OtherBizProfit).HasColumnName("OtherBizProfit");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.SubsidyIncome).HasColumnName("SubsidyIncome");
			this.Property(t => t.NetNonoperating).HasColumnName("NetNonoperating");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.ProfitatISA).HasColumnName("ProfitatISA");
			this.Property(t => t.MarginIntoOut).HasColumnName("MarginIntoOut");
			this.Property(t => t.MarginIntoOutStatement).HasColumnName("MarginIntoOutStatement");
			this.Property(t => t.NetProfitCut).HasColumnName("NetProfitCut");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.CashEquivalentIncrease).HasColumnName("CashEquivalentIncrease");
			this.Property(t => t.NetOperateCashFlow).HasColumnName("NetOperateCashFlow");
			this.Property(t => t.GoodsSaleServiceRenderCash).HasColumnName("GoodsSaleServiceRenderCash");
			this.Property(t => t.MarginOperCashtoProfit).HasColumnName("MarginOperCashtoProfit");
			this.Property(t => t.NetProfitCashCover).HasColumnName("NetProfitCashCover");
			this.Property(t => t.MainIncomeCashCover).HasColumnName("MainIncomeCashCover");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.CashEquivalents).HasColumnName("CashEquivalents");
			this.Property(t => t.Deposit).HasColumnName("Deposit");
			this.Property(t => t.WorkingCapital).HasColumnName("WorkingCapital");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.CapitalReserveFund).HasColumnName("CapitalReserveFund");
			this.Property(t => t.SurplusReserveFund).HasColumnName("SurplusReserveFund");
			this.Property(t => t.TotalShares).HasColumnName("TotalShares");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

