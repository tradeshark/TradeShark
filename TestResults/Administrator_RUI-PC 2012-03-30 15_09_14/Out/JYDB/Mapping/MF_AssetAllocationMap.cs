using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_AssetAllocationMap : EntityTypeConfiguration<MF_AssetAllocation>
	{
		public MF_AssetAllocationMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.AssetType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AssetType)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("MF_AssetAllocation");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.AssetType).HasColumnName("AssetType");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.RatioInTotalAsset).HasColumnName("RatioInTotalAsset");
			this.Property(t => t.RatioInNV).HasColumnName("RatioInNV");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.AssetTypeCode).HasColumnName("AssetTypeCode");
		}
	}
}

