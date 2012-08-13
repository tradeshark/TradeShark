using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_MoneyAuthorityBSMap : EntityTypeConfiguration<ED_MoneyAuthorityBS>
	{
		public ED_MoneyAuthorityBSMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_MoneyAuthorityBS");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.AbroadAssets).HasColumnName("AbroadAssets");
			this.Property(t => t.Forex).HasColumnName("Forex");
			this.Property(t => t.MoneyAndGold).HasColumnName("MoneyAndGold");
			this.Property(t => t.OtherForeignAssets).HasColumnName("OtherForeignAssets");
			this.Property(t => t.ClaimToGovernment).HasColumnName("ClaimToGovernment");
			this.Property(t => t.CentralGovernment).HasColumnName("CentralGovernment");
			this.Property(t => t.ClaimToSavingsBanks).HasColumnName("ClaimToSavingsBanks");
			this.Property(t => t.ClaimToSavingsInst).HasColumnName("ClaimToSavingsInst");
			this.Property(t => t.ClaimtoOtherFinNonFinInst).HasColumnName("ClaimtoOtherFinNonFinInst");
			this.Property(t => t.ClaimToNonFinancialInst).HasColumnName("ClaimToNonFinancialInst");
			this.Property(t => t.OtherAssets).HasColumnName("OtherAssets");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.MoneyReserves).HasColumnName("MoneyReserves");
			this.Property(t => t.MoneyIssuance).HasColumnName("MoneyIssuance");
			this.Property(t => t.LiabToSavingsBanks).HasColumnName("LiabToSavingsBanks");
			this.Property(t => t.LiabToSavingsInst).HasColumnName("LiabToSavingsInst");
			this.Property(t => t.LiabToSpecificSavingsInst).HasColumnName("LiabToSpecificSavingsInst");
			this.Property(t => t.LiabtoOtherFinancialInst).HasColumnName("LiabtoOtherFinancialInst");
			this.Property(t => t.ReserveDeposits).HasColumnName("ReserveDeposits");
			this.Property(t => t.NonFinancialOrgDeposits).HasColumnName("NonFinancialOrgDeposits");
			this.Property(t => t.DemandDeposits).HasColumnName("DemandDeposits");
			this.Property(t => t.SavingsDeposits).HasColumnName("SavingsDeposits");
			this.Property(t => t.BondIssuance).HasColumnName("BondIssuance");
			this.Property(t => t.AbroadLiability).HasColumnName("AbroadLiability");
			this.Property(t => t.GovernmentSavings).HasColumnName("GovernmentSavings");
			this.Property(t => t.CentralGovernmentSavings).HasColumnName("CentralGovernmentSavings");
			this.Property(t => t.SelfOwnedMoney).HasColumnName("SelfOwnedMoney");
			this.Property(t => t.OtherLiability).HasColumnName("OtherLiability");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

