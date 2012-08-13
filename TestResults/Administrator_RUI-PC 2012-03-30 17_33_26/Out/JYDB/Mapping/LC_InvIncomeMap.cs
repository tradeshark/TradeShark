using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_InvIncomeMap : EntityTypeConfiguration<LC_InvIncome>
	{
		public LC_InvIncomeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_InvIncome");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ShortTermInvIncome).HasColumnName("ShortTermInvIncome");
			this.Property(t => t.StockInvIncome).HasColumnName("StockInvIncome");
			this.Property(t => t.MutualFundInvIncome).HasColumnName("MutualFundInvIncome");
			this.Property(t => t.BondsInvIncome).HasColumnName("BondsInvIncome");
			this.Property(t => t.EntrustInvIncome).HasColumnName("EntrustInvIncome");
			this.Property(t => t.FuturesInvIncome).HasColumnName("FuturesInvIncome");
			this.Property(t => t.OtherShortTermInvIncome).HasColumnName("OtherShortTermInvIncome");
			this.Property(t => t.LongTermEquityInvIncome).HasColumnName("LongTermEquityInvIncome");
			this.Property(t => t.ProfitUnderCostMethod).HasColumnName("ProfitUnderCostMethod");
			this.Property(t => t.EquityChangeUnderEquityMethod).HasColumnName("EquityChangeUnderEquityMethod");
			this.Property(t => t.OtherEquityInvIncome).HasColumnName("OtherEquityInvIncome");
			this.Property(t => t.BondInvIncome).HasColumnName("BondInvIncome");
			this.Property(t => t.AssetDealIncome).HasColumnName("AssetDealIncome");
			this.Property(t => t.InvDevalueReserve).HasColumnName("InvDevalueReserve");
			this.Property(t => t.ShortTermInvDevalueReserve).HasColumnName("ShortTermInvDevalueReserve");
			this.Property(t => t.LongTermInvDevalueReserve).HasColumnName("LongTermInvDevalueReserve");
			this.Property(t => t.DiffAmort).HasColumnName("DiffAmort");
			this.Property(t => t.EquityInvDiffAmort).HasColumnName("EquityInvDiffAmort");
			this.Property(t => t.MergingPriceDiffAmort).HasColumnName("MergingPriceDiffAmort");
			this.Property(t => t.OtherInvIncome).HasColumnName("OtherInvIncome");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

