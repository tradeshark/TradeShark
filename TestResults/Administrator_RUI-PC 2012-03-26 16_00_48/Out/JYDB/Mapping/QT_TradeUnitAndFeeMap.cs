using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_TradeUnitAndFeeMap : EntityTypeConfiguration<QT_TradeUnitAndFee>
	{
		public QT_TradeUnitAndFeeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EffectiveDate, t.InnerCode, t.TradeMarket, t.XGRQ });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.FullName)
				.HasMaxLength(200);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(50);
				
			this.Property(t => t.TradeMarket)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.RepoObject)
				.HasMaxLength(100);
				
			this.Property(t => t.OrderUnit)
				.HasMaxLength(200);
				
			this.Property(t => t.Currency)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("QT_TradeUnitAndFee");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradeCode).HasColumnName("TradeCode");
			this.Property(t => t.FullName).HasColumnName("FullName");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.TradeMarket).HasColumnName("TradeMarket");
			this.Property(t => t.RepoObject).HasColumnName("RepoObject");
			this.Property(t => t.Days).HasColumnName("Days");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.DelistDate).HasColumnName("DelistDate");
			this.Property(t => t.OrderUnit).HasColumnName("OrderUnit");
			this.Property(t => t.MinOrderUnit).HasColumnName("MinOrderUnit");
			this.Property(t => t.MaxOrderUnit).HasColumnName("MaxOrderUnit");
			this.Property(t => t.ParValuePerOrderUnit).HasColumnName("ParValuePerOrderUnit");
			this.Property(t => t.QuotationSpread).HasColumnName("QuotationSpread");
			this.Property(t => t.StampDuty).HasColumnName("StampDuty");
			this.Property(t => t.Commission).HasColumnName("Commission");
			this.Property(t => t.MinCommission).HasColumnName("MinCommission");
			this.Property(t => t.TransferFee).HasColumnName("TransferFee");
			this.Property(t => t.MinTransferFee).HasColumnName("MinTransferFee");
			this.Property(t => t.ClearingFee).HasColumnName("ClearingFee");
			this.Property(t => t.Currency).HasColumnName("Currency");
			this.Property(t => t.RegulationFee).HasColumnName("RegulationFee");
			this.Property(t => t.HandlingCharge).HasColumnName("HandlingCharge");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

