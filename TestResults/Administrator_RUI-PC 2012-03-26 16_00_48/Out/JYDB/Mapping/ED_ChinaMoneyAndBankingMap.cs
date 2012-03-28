using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ChinaMoneyAndBankingMap : EntityTypeConfiguration<ED_ChinaMoneyAndBanking>
	{
		public ED_ChinaMoneyAndBankingMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.AccountCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.AccountCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_ChinaMoneyAndBanking");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AccountCode).HasColumnName("AccountCode");
			this.Property(t => t.NetAbroadAssets).HasColumnName("NetAbroadAssets");
			this.Property(t => t.DomesticLoans).HasColumnName("DomesticLoans");
			this.Property(t => t.ClaimsToGov).HasColumnName("ClaimsToGov");
			this.Property(t => t.ClaimsToNonfinancialInst).HasColumnName("ClaimsToNonfinancialInst");
			this.Property(t => t.ClaimsToSpecificSavingOrg).HasColumnName("ClaimsToSpecificSavingOrg");
			this.Property(t => t.ClaimsToOtherInst).HasColumnName("ClaimsToOtherInst");
			this.Property(t => t.moneyAndQuasimoney).HasColumnName("moneyAndQuasimoney");
			this.Property(t => t.money1).HasColumnName("money1");
			this.Property(t => t.moneyInCirculation).HasColumnName("moneyInCirculation");
			this.Property(t => t.DemandDeposits).HasColumnName("DemandDeposits");
			this.Property(t => t.Quasimoney).HasColumnName("Quasimoney");
			this.Property(t => t.TimeDeposits).HasColumnName("TimeDeposits");
			this.Property(t => t.SavingsDposits).HasColumnName("SavingsDposits");
			this.Property(t => t.OtherSavings).HasColumnName("OtherSavings");
			this.Property(t => t.FCDeposits).HasColumnName("FCDeposits");
			this.Property(t => t.Bonds).HasColumnName("Bonds");
			this.Property(t => t.CentralBankBonds).HasColumnName("CentralBankBonds");
			this.Property(t => t.CapitalReceived).HasColumnName("CapitalReceived");
			this.Property(t => t.NetOthers).HasColumnName("NetOthers");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

