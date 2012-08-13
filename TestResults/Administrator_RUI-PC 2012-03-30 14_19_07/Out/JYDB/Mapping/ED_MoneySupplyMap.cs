using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_MoneySupplyMap : EntityTypeConfiguration<ED_MoneySupply>
	{
		public ED_MoneySupplyMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_MoneySupply");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.M2).HasColumnName("M2");
			this.Property(t => t.M1).HasColumnName("M1");
			this.Property(t => t.M0).HasColumnName("M0");
			this.Property(t => t.DemandDeposits).HasColumnName("DemandDeposits");
			this.Property(t => t.QuasiMoney).HasColumnName("QuasiMoney");
			this.Property(t => t.QMTimeDep).HasColumnName("QMTimeDep");
			this.Property(t => t.QMSavingDep).HasColumnName("QMSavingDep");
			this.Property(t => t.QMOtherDep).HasColumnName("QMOtherDep");
			this.Property(t => t.NetIssueMonthly).HasColumnName("NetIssueMonthly");
			this.Property(t => t.AvgOfferedRateMonthly).HasColumnName("AvgOfferedRateMonthly");
			this.Property(t => t.OfferedTurnoverMonthly).HasColumnName("OfferedTurnoverMonthly");
			this.Property(t => t.M2GrowthYoY).HasColumnName("M2GrowthYoY");
			this.Property(t => t.M1GrowthYoY).HasColumnName("M1GrowthYoY");
			this.Property(t => t.M0GrowthYoY).HasColumnName("M0GrowthYoY");
			this.Property(t => t.DemandDepositsGrowthYoY).HasColumnName("DemandDepositsGrowthYoY");
			this.Property(t => t.QuasiMoneyGrowthYoY).HasColumnName("QuasiMoneyGrowthYoY");
			this.Property(t => t.QMTimeDepGrowthYoY).HasColumnName("QMTimeDepGrowthYoY");
			this.Property(t => t.QMSavingDepGrowthYoY).HasColumnName("QMSavingDepGrowthYoY");
			this.Property(t => t.QMOtherDepGrowthYoY).HasColumnName("QMOtherDepGrowthYoY");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

