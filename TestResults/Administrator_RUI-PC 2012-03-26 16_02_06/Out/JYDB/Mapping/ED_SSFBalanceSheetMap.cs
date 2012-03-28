using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_SSFBalanceSheetMap : EntityTypeConfiguration<ED_SSFBalanceSheet>
	{
		public ED_SSFBalanceSheetMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.IfAdjusted, t.XGRQ, t.JSID });

			// Properties
			// Table & Column Mappings
			this.ToTable("ED_SSFBalanceSheet");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.BankSavings).HasColumnName("BankSavings");
			this.Property(t => t.InterestsReceivable).HasColumnName("InterestsReceivable");
			this.Property(t => t.DividensReceivables).HasColumnName("DividensReceivables");
			this.Property(t => t.OtherReceivables).HasColumnName("OtherReceivables");
			this.Property(t => t.ShortTermBondInv).HasColumnName("ShortTermBondInv");
			this.Property(t => t.EntrustedInv).HasColumnName("EntrustedInv");
			this.Property(t => t.StockAssetsReceived).HasColumnName("StockAssetsReceived");
			this.Property(t => t.EquityAssets).HasColumnName("EquityAssets");
			this.Property(t => t.ApplingForNewShares).HasColumnName("ApplingForNewShares");
			this.Property(t => t.LongTermBondInv).HasColumnName("LongTermBondInv");
			this.Property(t => t.LongTermBondInvMaturedIn1Year).HasColumnName("LongTermBondInvMaturedIn1Year");
			this.Property(t => t.OtherAssets).HasColumnName("OtherAssets");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.InterestsPayable).HasColumnName("InterestsPayable");
			this.Property(t => t.AccountsPayable).HasColumnName("AccountsPayable");
			this.Property(t => t.BankBorrowings).HasColumnName("BankBorrowings");
			this.Property(t => t.OtherLiabilities).HasColumnName("OtherLiabilities");
			this.Property(t => t.TotalLiabilities).HasColumnName("TotalLiabilities");
			this.Property(t => t.SocialSecurityFunds).HasColumnName("SocialSecurityFunds");
			this.Property(t => t.RiskReserves).HasColumnName("RiskReserves");
			this.Property(t => t.UnrealizedProfitSecuAsset).HasColumnName("UnrealizedProfitSecuAsset");
			this.Property(t => t.OtherFundsClaims).HasColumnName("OtherFundsClaims");
			this.Property(t => t.TotalEquities).HasColumnName("TotalEquities");
			this.Property(t => t.OtherLiabilitiesAndEquity).HasColumnName("OtherLiabilitiesAndEquity");
			this.Property(t => t.TotalLiabilitiesAndEquity).HasColumnName("TotalLiabilitiesAndEquity");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

