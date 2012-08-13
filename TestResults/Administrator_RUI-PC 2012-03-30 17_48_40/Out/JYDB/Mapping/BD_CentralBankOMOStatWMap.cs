using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_CentralBankOMOStatWMap : EntityTypeConfiguration<BD_CentralBankOMOStatW>
	{
		public BD_CentralBankOMOStatWMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.WeekStart, t.WeekEnd, t.XGRQ, t.JSID });

			// Properties
			// Table & Column Mappings
			this.ToTable("BD_CentralBankOMOStatW");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.WeekStart).HasColumnName("WeekStart");
			this.Property(t => t.WeekEnd).HasColumnName("WeekEnd");
			this.Property(t => t.IssueSizeTreasNotes).HasColumnName("IssueSizeTreasNotes");
			this.Property(t => t.RepurchaseBuySize).HasColumnName("RepurchaseBuySize");
			this.Property(t => t.RepurchaseSellSize).HasColumnName("RepurchaseSellSize");
			this.Property(t => t.SpotSellSize).HasColumnName("SpotSellSize");
			this.Property(t => t.SpotBuySize).HasColumnName("SpotBuySize");
			this.Property(t => t.RedemptionTreasNotes).HasColumnName("RedemptionTreasNotes");
			this.Property(t => t.RepurchaseBuyExpire).HasColumnName("RepurchaseBuyExpire");
			this.Property(t => t.RepurchaseSellExpire).HasColumnName("RepurchaseSellExpire");
			this.Property(t => t.NetCurrencyIssue).HasColumnName("NetCurrencyIssue");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

