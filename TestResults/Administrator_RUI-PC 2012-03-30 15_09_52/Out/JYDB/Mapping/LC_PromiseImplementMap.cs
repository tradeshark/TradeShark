using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PromiseImplementMap : EntityTypeConfiguration<LC_PromiseImplement>
	{
		public LC_PromiseImplementMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SHName)
				.HasMaxLength(200);
				
			this.Property(t => t.PromiseStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.ImplementStatement)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("LC_PromiseImplement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PromiseSubject).HasColumnName("PromiseSubject");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.InfoType).HasColumnName("InfoType");
			this.Property(t => t.SHSN).HasColumnName("SHSN");
			this.Property(t => t.SHName).HasColumnName("SHName");
			this.Property(t => t.CompanyNumber).HasColumnName("CompanyNumber");
			this.Property(t => t.PromiseType).HasColumnName("PromiseType");
			this.Property(t => t.ImplementStartDate).HasColumnName("ImplementStartDate");
			this.Property(t => t.ImplementEndDate).HasColumnName("ImplementEndDate");
			this.Property(t => t.TriggerPrice).HasColumnName("TriggerPrice");
			this.Property(t => t.ImplementPrice).HasColumnName("ImplementPrice");
			this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.PromiseStatement).HasColumnName("PromiseStatement");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfImplemented).HasColumnName("IfImplemented");
			this.Property(t => t.Reason).HasColumnName("Reason");
			this.Property(t => t.ImplementStatement).HasColumnName("ImplementStatement");
			this.Property(t => t.ImplementShares).HasColumnName("ImplementShares");
			this.Property(t => t.ImplementMoney).HasColumnName("ImplementMoney");
			this.Property(t => t.ImplementSharesTotal).HasColumnName("ImplementSharesTotal");
			this.Property(t => t.ImplementMoneyTotal).HasColumnName("ImplementMoneyTotal");
			this.Property(t => t.ImplementPriceBottom).HasColumnName("ImplementPriceBottom");
			this.Property(t => t.ImplementPriceCeiling).HasColumnName("ImplementPriceCeiling");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

