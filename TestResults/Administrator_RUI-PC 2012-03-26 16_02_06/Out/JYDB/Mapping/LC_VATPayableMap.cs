using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_VATPayableMap : EntityTypeConfiguration<LC_VATPayable>
	{
		public LC_VATPayableMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(8);
				
			// Table & Column Mappings
			this.ToTable("LC_VATPayable");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.UndeductedAtBegin).HasColumnName("UndeductedAtBegin");
			this.Property(t => t.VATOnSales).HasColumnName("VATOnSales");
			this.Property(t => t.ExportRefundVAT).HasColumnName("ExportRefundVAT");
			this.Property(t => t.PurchaseTransOutVAT).HasColumnName("PurchaseTransOutVAT");
			this.Property(t => t.TransOutOverpaidVAT).HasColumnName("TransOutOverpaidVAT");
			this.Property(t => t.VATOnPurchase).HasColumnName("VATOnPurchase");
			this.Property(t => t.VATPaid).HasColumnName("VATPaid");
			this.Property(t => t.TaxReducedExempted).HasColumnName("TaxReducedExempted");
			this.Property(t => t.ExportOffsetVATPayable).HasColumnName("ExportOffsetVATPayable");
			this.Property(t => t.TransOutUpaidVAT).HasColumnName("TransOutUpaidVAT");
			this.Property(t => t.UndeductedAtEnd).HasColumnName("UndeductedAtEnd");
			this.Property(t => t.UnpaidAtBegin).HasColumnName("UnpaidAtBegin");
			this.Property(t => t.AmountTransIn).HasColumnName("AmountTransIn");
			this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
			this.Property(t => t.UnpaidAtEnd).HasColumnName("UnpaidAtEnd");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

