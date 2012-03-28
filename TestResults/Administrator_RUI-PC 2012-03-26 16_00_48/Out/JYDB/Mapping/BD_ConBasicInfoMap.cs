using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_ConBasicInfoMap : EntityTypeConfiguration<BD_ConBasicInfo>
	{
		public BD_ConBasicInfoMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.TradeCodeStk)
				.HasMaxLength(10);
				
			this.Property(t => t.GuarantMethod)
				.HasMaxLength(200);
				
			this.Property(t => t.CreditRating)
				.HasMaxLength(50);
				
			this.Property(t => t.IntPaymentDescription)
				.HasMaxLength(300);
				
			this.Property(t => t.TradingMethod)
				.HasMaxLength(20);
				
			this.Property(t => t.TradingUnit)
				.HasMaxLength(200);
				
			this.Property(t => t.ConvStkAbbrName)
				.HasMaxLength(50);
				
			this.Property(t => t.ConvCode)
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("BD_ConBasicInfo");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradeCodeStk).HasColumnName("TradeCodeStk");
			this.Property(t => t.InnerCodeStk).HasColumnName("InnerCodeStk");
			this.Property(t => t.InnerCodeWarrant).HasColumnName("InnerCodeWarrant");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.BondForm).HasColumnName("BondForm");
			this.Property(t => t.BondNature).HasColumnName("BondNature");
			this.Property(t => t.GuarantMethod).HasColumnName("GuarantMethod");
			this.Property(t => t.CreditRating).HasColumnName("CreditRating");
			this.Property(t => t.Maturity).HasColumnName("Maturity");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ActualIssueSize).HasColumnName("ActualIssueSize");
			this.Property(t => t.IssueVolume).HasColumnName("IssueVolume");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.CompoundMethod).HasColumnName("CompoundMethod");
			this.Property(t => t.IntPaymentMethod).HasColumnName("IntPaymentMethod");
			this.Property(t => t.CouponFreq).HasColumnName("CouponFreq");
			this.Property(t => t.CouponRate).HasColumnName("CouponRate");
			this.Property(t => t.FRNMargin).HasColumnName("FRNMargin");
			this.Property(t => t.IncrsCouponMargin).HasColumnName("IncrsCouponMargin");
			this.Property(t => t.ValueDate).HasColumnName("ValueDate");
			this.Property(t => t.IntPaymentDescription).HasColumnName("IntPaymentDescription");
			this.Property(t => t.CallProtection).HasColumnName("CallProtection");
			this.Property(t => t.CallTermStartDate).HasColumnName("CallTermStartDate");
			this.Property(t => t.CallTermEndDate).HasColumnName("CallTermEndDate");
			this.Property(t => t.RedemptionPrice).HasColumnName("RedemptionPrice");
			this.Property(t => t.RedemptionPriceAfterTax).HasColumnName("RedemptionPriceAfterTax");
			this.Property(t => t.RedemptionPayDate).HasColumnName("RedemptionPayDate");
			this.Property(t => t.RedemptionVolume).HasColumnName("RedemptionVolume");
			this.Property(t => t.PutTermStartDate).HasColumnName("PutTermStartDate");
			this.Property(t => t.PutTermEndDate).HasColumnName("PutTermEndDate");
			this.Property(t => t.PutablePrice).HasColumnName("PutablePrice");
			this.Property(t => t.VolumeAfterPut).HasColumnName("VolumeAfterPut");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.ListedEndDate).HasColumnName("ListedEndDate");
			this.Property(t => t.TradingMethod).HasColumnName("TradingMethod");
			this.Property(t => t.TradingUnit).HasColumnName("TradingUnit");
			this.Property(t => t.TradingUnitParValue).HasColumnName("TradingUnitParValue");
			this.Property(t => t.StopTradingDate).HasColumnName("StopTradingDate");
			this.Property(t => t.LastTradingDate).HasColumnName("LastTradingDate");
			this.Property(t => t.DelistDate).HasColumnName("DelistDate");
			this.Property(t => t.InitialConvPrice).HasColumnName("InitialConvPrice");
			this.Property(t => t.InitialConvRatio).HasColumnName("InitialConvRatio");
			this.Property(t => t.ActualConvPrice).HasColumnName("ActualConvPrice");
			this.Property(t => t.ActualConvRatio).HasColumnName("ActualConvRatio");
			this.Property(t => t.ConvTermStartDate).HasColumnName("ConvTermStartDate");
			this.Property(t => t.ConvTermEndDate).HasColumnName("ConvTermEndDate");
			this.Property(t => t.ConvStkAbbrName).HasColumnName("ConvStkAbbrName");
			this.Property(t => t.ConvCode).HasColumnName("ConvCode");
			this.Property(t => t.StopConvDate).HasColumnName("StopConvDate");
			this.Property(t => t.ForcedConvDate).HasColumnName("ForcedConvDate");
			this.Property(t => t.ForcedConvPrice).HasColumnName("ForcedConvPrice");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

