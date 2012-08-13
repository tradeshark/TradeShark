using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_EquityChangesStatementMap : EntityTypeConfiguration<LC_EquityChangesStatement>
	{
		public LC_EquityChangesStatementMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ItemsName)
				.HasMaxLength(100);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("LC_EquityChangesStatement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.ItemsSN).HasColumnName("ItemsSN");
			this.Property(t => t.ItemsName).HasColumnName("ItemsName");
			this.Property(t => t.ItemsType).HasColumnName("ItemsType");
			this.Property(t => t.PaidInCapital).HasColumnName("PaidInCapital");
			this.Property(t => t.CapitalReserveFund).HasColumnName("CapitalReserveFund");
			this.Property(t => t.SurplusReserveFund).HasColumnName("SurplusReserveFund");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.TreasuryStock).HasColumnName("TreasuryStock");
			this.Property(t => t.CommonRiskReserve).HasColumnName("CommonRiskReserve");
			this.Property(t => t.ConversionMarginInFCR).HasColumnName("ConversionMarginInFCR");
			this.Property(t => t.OtherShareholderEquity).HasColumnName("OtherShareholderEquity");
			this.Property(t => t.SpecialItem).HasColumnName("SpecialItem");
			this.Property(t => t.AdjustmentItem).HasColumnName("AdjustmentItem");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.TotalParentCompanySE).HasColumnName("TotalParentCompanySE");
			this.Property(t => t.MinoritySE).HasColumnName("MinoritySE");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

