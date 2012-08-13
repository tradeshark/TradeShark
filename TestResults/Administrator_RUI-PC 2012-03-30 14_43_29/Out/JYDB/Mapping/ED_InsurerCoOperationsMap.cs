using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_InsurerCoOperationsMap : EntityTypeConfiguration<ED_InsurerCoOperations>
	{
		public ED_InsurerCoOperationsMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_InsurerCoOperations");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.PremiumRevenue).HasColumnName("PremiumRevenue");
			this.Property(t => t.PropertyInsuranceIncome).HasColumnName("PropertyInsuranceIncome");
			this.Property(t => t.LifeInsuranceIncome).HasColumnName("LifeInsuranceIncome");
			this.Property(t => t.AccidentInsuranceIncome).HasColumnName("AccidentInsuranceIncome");
			this.Property(t => t.HealthInsuranceIncome).HasColumnName("HealthInsuranceIncome");
			this.Property(t => t.LongevityInsuranceIncome).HasColumnName("LongevityInsuranceIncome");
			this.Property(t => t.Indemnity).HasColumnName("Indemnity");
			this.Property(t => t.PropertyInsurancePayout).HasColumnName("PropertyInsurancePayout");
			this.Property(t => t.LifeInsurancePayout).HasColumnName("LifeInsurancePayout");
			this.Property(t => t.AccidentInsurancePayout).HasColumnName("AccidentInsurancePayout");
			this.Property(t => t.HealthInsurancePayout).HasColumnName("HealthInsurancePayout");
			this.Property(t => t.LongevityInsurancePayout).HasColumnName("LongevityInsurancePayout");
			this.Property(t => t.OperatingFees).HasColumnName("OperatingFees");
			this.Property(t => t.BankDeposits).HasColumnName("BankDeposits");
			this.Property(t => t.Investment).HasColumnName("Investment");
			this.Property(t => t.TreasuryBond).HasColumnName("TreasuryBond");
			this.Property(t => t.MutualFunds).HasColumnName("MutualFunds");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

