using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class Fut_ContractMainMap : EntityTypeConfiguration<Fut_ContractMain>
	{
		public Fut_ContractMainMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.ContractInnerCode, t.ContractCode, t.ExchangeCode, t.OptionCode, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.ContractInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ContractCode)
				.IsRequired()
				.HasMaxLength(10);
				
			this.Property(t => t.ContractName)
				.HasMaxLength(100);
				
			this.Property(t => t.ExchangeCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.OptionCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ContractMultiplier)
				.HasMaxLength(50);
				
			this.Property(t => t.PriceUnit)
				.HasMaxLength(50);
				
			this.Property(t => t.LittlestChangeUnit)
				.HasMaxLength(50);
				
			this.Property(t => t.ChangePCTLimit)
				.HasMaxLength(200);
				
			this.Property(t => t.DeliveryYear)
				.HasMaxLength(4);
				
			this.Property(t => t.DeliveryMonth)
				.HasMaxLength(2);
				
			this.Property(t => t.TradingCommission)
				.HasMaxLength(100);
				
			this.Property(t => t.DeliveryCommission)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(200);
				
			this.Property(t => t.ContractMonth)
				.HasMaxLength(100);
				
			this.Property(t => t.ExchangeDate)
				.HasMaxLength(200);
				
			this.Property(t => t.LastTradingDateDesc)
				.HasMaxLength(100);
				
			this.Property(t => t.LastTradingTimeDesc)
				.HasMaxLength(100);
				
			this.Property(t => t.DeliveryDateDesc)
				.HasMaxLength(100);
				
			this.Property(t => t.LastDeliveryDateDesc)
				.HasMaxLength(100);
				
			this.Property(t => t.ContractAbbr)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("Fut_ContractMain");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.ContractInnerCode).HasColumnName("ContractInnerCode");
			this.Property(t => t.ContractCode).HasColumnName("ContractCode");
			this.Property(t => t.ContractName).HasColumnName("ContractName");
			this.Property(t => t.ExchangeCode).HasColumnName("ExchangeCode");
			this.Property(t => t.ContractType).HasColumnName("ContractType");
			this.Property(t => t.OptionCode).HasColumnName("OptionCode");
			this.Property(t => t.ContractMultiplier).HasColumnName("ContractMultiplier");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.LittlestChangeUnit).HasColumnName("LittlestChangeUnit");
			this.Property(t => t.ChangePCTLimit).HasColumnName("ChangePCTLimit");
			this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
			this.Property(t => t.DeliveryYear).HasColumnName("DeliveryYear");
			this.Property(t => t.DeliveryMonth).HasColumnName("DeliveryMonth");
			this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
			this.Property(t => t.LastTradingDate).HasColumnName("LastTradingDate");
			this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
			this.Property(t => t.LastDeliveryDate).HasColumnName("LastDeliveryDate");
			this.Property(t => t.DeliveryMethod).HasColumnName("DeliveryMethod");
			this.Property(t => t.DeliveryGrades).HasColumnName("DeliveryGrades");
			this.Property(t => t.MinMarginRatio).HasColumnName("MinMarginRatio");
			this.Property(t => t.TradingCommission).HasColumnName("TradingCommission");
			this.Property(t => t.DeliveryCommission).HasColumnName("DeliveryCommission");
			this.Property(t => t.SettPriceCode).HasColumnName("SettPriceCode");
			this.Property(t => t.SettPriceDesc).HasColumnName("SettPriceDesc");
			this.Property(t => t.DeliSettPriceCode).HasColumnName("DeliSettPriceCode");
			this.Property(t => t.DeliSettPriceDesc).HasColumnName("DeliSettPriceDesc");
			this.Property(t => t.ListBasisPrice).HasColumnName("ListBasisPrice");
			this.Property(t => t.ChangePCTListPrice).HasColumnName("ChangePCTListPrice");
			this.Property(t => t.ContractState).HasColumnName("ContractState");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.ContractMonth).HasColumnName("ContractMonth");
			this.Property(t => t.ExchangeDate).HasColumnName("ExchangeDate");
			this.Property(t => t.LastTradingDateDesc).HasColumnName("LastTradingDateDesc");
			this.Property(t => t.LastTradingTimeDesc).HasColumnName("LastTradingTimeDesc");
			this.Property(t => t.DeliveryDateDesc).HasColumnName("DeliveryDateDesc");
			this.Property(t => t.LastDeliveryDateDesc).HasColumnName("LastDeliveryDateDesc");
			this.Property(t => t.ContractIntroduction).HasColumnName("ContractIntroduction");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.CMValue).HasColumnName("CMValue");
			this.Property(t => t.ContractAbbr).HasColumnName("ContractAbbr");
		}
	}
}

