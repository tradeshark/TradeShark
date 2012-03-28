using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_ConIndicatorDMap : EntityTypeConfiguration<BD_ConIndicatorD>
	{
		public BD_ConIndicatorDMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.TradingDay, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("BD_ConIndicatorD");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.ClosePriceCon).HasColumnName("ClosePriceCon");
			this.Property(t => t.ActualConvPrice).HasColumnName("ActualConvPrice");
			this.Property(t => t.ConvValue).HasColumnName("ConvValue");
			this.Property(t => t.ConvPremiumRate).HasColumnName("ConvPremiumRate");
			this.Property(t => t.ConvParity).HasColumnName("ConvParity");
			this.Property(t => t.DeltaStkPr).HasColumnName("DeltaStkPr");
			this.Property(t => t.CallTriggerPrice).HasColumnName("CallTriggerPrice");
			this.Property(t => t.PutTriggerPrice).HasColumnName("PutTriggerPrice");
			this.Property(t => t.TradeCodeStk).HasColumnName("TradeCodeStk");
			this.Property(t => t.InnerCodeStk).HasColumnName("InnerCodeStk");
			this.Property(t => t.ClosePriceStk).HasColumnName("ClosePriceStk");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

