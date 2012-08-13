using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_AssetBuyAndSaleMap : EntityTypeConfiguration<LC_AssetBuyAndSale>
	{
		public LC_AssetBuyAndSaleMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SubjectName)
				.HasMaxLength(200);
				
			this.Property(t => t.ObjectName)
				.HasMaxLength(200);
				
			this.Property(t => t.TargetAsset)
				.HasMaxLength(500);
				
			this.Property(t => t.CounterPartyAsset)
				.HasMaxLength(1000);
				
			this.Property(t => t.PricingRule)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_AssetBuyAndSale");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.SubjectName).HasColumnName("SubjectName");
			this.Property(t => t.SubjectCode).HasColumnName("SubjectCode");
			this.Property(t => t.SubjectAssociation).HasColumnName("SubjectAssociation");
			this.Property(t => t.ObjectName).HasColumnName("ObjectName");
			this.Property(t => t.ObjectCode).HasColumnName("ObjectCode");
			this.Property(t => t.ObjectAssociation).HasColumnName("ObjectAssociation");
			this.Property(t => t.TargetAsset).HasColumnName("TargetAsset");
			this.Property(t => t.CounterPartyAsset).HasColumnName("CounterPartyAsset");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.Price).HasColumnName("Price");
			this.Property(t => t.ProfitToReportPeriod).HasColumnName("ProfitToReportPeriod");
			this.Property(t => t.TradeProfitOrLoss).HasColumnName("TradeProfitOrLoss");
			this.Property(t => t.IfConnectedTransaction).HasColumnName("IfConnectedTransaction");
			this.Property(t => t.PricingRule).HasColumnName("PricingRule");
			this.Property(t => t.IfOwnershipTransfered).HasColumnName("IfOwnershipTransfered");
			this.Property(t => t.IfDebtTransfered).HasColumnName("IfDebtTransfered");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

