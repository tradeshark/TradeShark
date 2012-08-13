using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_InstiFinancialStatusMap : EntityTypeConfiguration<LC_InstiFinancialStatus>
	{
		public LC_InstiFinancialStatusMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.ChiName, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ChiName)
				.IsRequired()
				.HasMaxLength(80);
				
			this.Property(t => t.IfAdjusted)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.IfMerged)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(2);
				
			// Table & Column Mappings
			this.ToTable("LC_InstiFinancialStatus");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.NetAsset).HasColumnName("NetAsset");
			this.Property(t => t.MainIncome).HasColumnName("MainIncome");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

