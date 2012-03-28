using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ShortTermInvMap : EntityTypeConfiguration<LC_ShortTermInv>
	{
		public LC_ShortTermInvMap()
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
			this.ToTable("LC_ShortTermInv");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.ShortTermInvOnStock).HasColumnName("ShortTermInvOnStock");
			this.Property(t => t.QuotedStock).HasColumnName("QuotedStock");
			this.Property(t => t.UnquotedStockStock).HasColumnName("UnquotedStockStock");
			this.Property(t => t.ShortTermInvOnBond).HasColumnName("ShortTermInvOnBond");
			this.Property(t => t.TreasuryBond).HasColumnName("TreasuryBond");
			this.Property(t => t.FinancialBond).HasColumnName("FinancialBond");
			this.Property(t => t.CompanyBond).HasColumnName("CompanyBond");
			this.Property(t => t.ConvertibleBond).HasColumnName("ConvertibleBond");
			this.Property(t => t.BondsRepurchase).HasColumnName("BondsRepurchase");
			this.Property(t => t.InvOnMutualFunds).HasColumnName("InvOnMutualFunds");
			this.Property(t => t.EntrustedInv).HasColumnName("EntrustedInv");
			this.Property(t => t.FuturesInv).HasColumnName("FuturesInv");
			this.Property(t => t.OtherShortTermInv).HasColumnName("OtherShortTermInv");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

