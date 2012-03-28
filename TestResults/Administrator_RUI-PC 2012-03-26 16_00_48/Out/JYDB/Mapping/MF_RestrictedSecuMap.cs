using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_RestrictedSecuMap : EntityTypeConfiguration<MF_RestrictedSecu>
	{
		public MF_RestrictedSecuMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.StockInnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.StockInnerCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.ObtainReason)
				.HasMaxLength(100);
				
			this.Property(t => t.SuspendReason)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("MF_RestrictedSecu");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SecuSpecies).HasColumnName("SecuSpecies");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.StockInnerCode).HasColumnName("StockInnerCode");
			this.Property(t => t.ObtainDate).HasColumnName("ObtainDate");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.RestrictedTerm).HasColumnName("RestrictedTerm");
			this.Property(t => t.ObtainPrice).HasColumnName("ObtainPrice");
			this.Property(t => t.SharesHolding).HasColumnName("SharesHolding");
			this.Property(t => t.ObtainCost).HasColumnName("ObtainCost");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.ReportDateValue).HasColumnName("ReportDateValue");
			this.Property(t => t.ObtainReason).HasColumnName("ObtainReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.SuspendDate).HasColumnName("SuspendDate");
			this.Property(t => t.SuspendReason).HasColumnName("SuspendReason");
			this.Property(t => t.ResumptionDate).HasColumnName("ResumptionDate");
			this.Property(t => t.ResumptionOpenPrice).HasColumnName("ResumptionOpenPrice");
			this.Property(t => t.RestrictedType).HasColumnName("RestrictedType");
			this.Property(t => t.RepurchaseExpireDate).HasColumnName("RepurchaseExpireDate");
		}
	}
}

