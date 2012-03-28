using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CapitalReserveMap : EntityTypeConfiguration<LC_CapitalReserve>
	{
		public LC_CapitalReserveMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.DataType, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.DataType)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_CapitalReserve");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.StockPremium).HasColumnName("StockPremium");
			this.Property(t => t.StockPremiumIC).HasColumnName("StockPremiumIC");
			this.Property(t => t.EquityInvReserves).HasColumnName("EquityInvReserves");
			this.Property(t => t.EquityInvReservesIC).HasColumnName("EquityInvReservesIC");
			this.Property(t => t.AssetValuationReserve).HasColumnName("AssetValuationReserve");
			this.Property(t => t.AssetValuationReserveIC).HasColumnName("AssetValuationReserveIC");
			this.Property(t => t.DonatedSurplus).HasColumnName("DonatedSurplus");
			this.Property(t => t.DonatedNonCashSurplus).HasColumnName("DonatedNonCashSurplus");
			this.Property(t => t.DonatedCashSurplus).HasColumnName("DonatedCashSurplus");
			this.Property(t => t.DonatedICSurplus).HasColumnName("DonatedICSurplus");
			this.Property(t => t.ForeignCurrencyCapital).HasColumnName("ForeignCurrencyCapital");
			this.Property(t => t.ForeignCurrencyCapitalIC).HasColumnName("ForeignCurrencyCapitalIC");
			this.Property(t => t.AllocateSumsChangeoverIn).HasColumnName("AllocateSumsChangeoverIn");
			this.Property(t => t.ConnectedTransactionSpread).HasColumnName("ConnectedTransactionSpread");
			this.Property(t => t.DebtRearrangementGain).HasColumnName("DebtRearrangementGain");
			this.Property(t => t.OtherCapitalReserve).HasColumnName("OtherCapitalReserve");
			this.Property(t => t.HouseTurnoverFunds).HasColumnName("HouseTurnoverFunds");
			this.Property(t => t.FreezedCapitalInterest).HasColumnName("FreezedCapitalInterest");
			this.Property(t => t.EquityInvDiff).HasColumnName("EquityInvDiff");
			this.Property(t => t.Subsidy).HasColumnName("Subsidy");
			this.Property(t => t.PayableUnableToPay).HasColumnName("PayableUnableToPay");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

