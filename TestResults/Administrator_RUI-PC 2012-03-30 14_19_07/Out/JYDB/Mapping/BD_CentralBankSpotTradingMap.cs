using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_CentralBankSpotTradingMap : EntityTypeConfiguration<BD_CentralBankSpotTrading>
	{
		public BD_CentralBankSpotTradingMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TradingDay, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("BD_CentralBankSpotTrading");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.SpotTradingType).HasColumnName("SpotTradingType");
			this.Property(t => t.SpotTradingMethod).HasColumnName("SpotTradingMethod");
			this.Property(t => t.TenderSize).HasColumnName("TenderSize");
			this.Property(t => t.TenderPrice).HasColumnName("TenderPrice");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

