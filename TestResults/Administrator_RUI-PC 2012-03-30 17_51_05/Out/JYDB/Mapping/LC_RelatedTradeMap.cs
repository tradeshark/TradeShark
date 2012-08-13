using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_RelatedTradeMap : EntityTypeConfiguration<LC_RelatedTrade>
	{
		public LC_RelatedTradeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Media)
				.HasMaxLength(80);
				
			this.Property(t => t.RelatedParty)
				.IsRequired()
				.HasMaxLength(120);
				
			this.Property(t => t.PaymentMeans)
				.HasMaxLength(100);
				
			this.Property(t => t.TradeContent)
				.HasMaxLength(255);
				
			this.Property(t => t.IndeFinaAdvisor)
				.HasMaxLength(255);
				
			this.Property(t => t.FinancialEffect)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_RelatedTrade");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.InfoSourceType).HasColumnName("InfoSourceType");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.RelatedParty).HasColumnName("RelatedParty");
			this.Property(t => t.Association).HasColumnName("Association");
			this.Property(t => t.TradeType).HasColumnName("TradeType");
			this.Property(t => t.TradeSum).HasColumnName("TradeSum");
			this.Property(t => t.RatioInProject).HasColumnName("RatioInProject");
			this.Property(t => t.PricingMethod).HasColumnName("PricingMethod");
			this.Property(t => t.PaymentMeans).HasColumnName("PaymentMeans");
			this.Property(t => t.ConfirmedDate).HasColumnName("ConfirmedDate");
			this.Property(t => t.TradeContent).HasColumnName("TradeContent");
			this.Property(t => t.IndeFinaAdvisor).HasColumnName("IndeFinaAdvisor");
			this.Property(t => t.FinancialEffect).HasColumnName("FinancialEffect");
			this.Property(t => t.TradeChangeInfo).HasColumnName("TradeChangeInfo");
			this.Property(t => t.TradeChangeDate).HasColumnName("TradeChangeDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

