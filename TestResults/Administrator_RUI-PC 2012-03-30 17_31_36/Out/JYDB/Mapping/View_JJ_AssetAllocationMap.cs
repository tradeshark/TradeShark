using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_AssetAllocationMap : EntityTypeConfiguration<View_JJ_AssetAllocation>
	{
		public View_JJ_AssetAllocationMap()
		{
			// Primary Key
			this.HasKey(t => t.ReportDate);

			// Properties
			// Table & Column Mappings
			this.ToTable("View_JJ_AssetAllocation");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.Innercode).HasColumnName("Innercode");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.RatioInNV).HasColumnName("RatioInNV");
			this.Property(t => t.MarketValue_Bond).HasColumnName("MarketValue_Bond");
			this.Property(t => t.RatioInNV_Bond).HasColumnName("RatioInNV_Bond");
			this.Property(t => t.MarketValue_Cash).HasColumnName("MarketValue_Cash");
			this.Property(t => t.RatioInNV_Cash).HasColumnName("RatioInNV_Cash");
			this.Property(t => t.MarketValue_MRFSZQ).HasColumnName("MarketValue_MRFSZQ");
			this.Property(t => t.RatioInNV_MRFSZQ).HasColumnName("RatioInNV_MRFSZQ");
			this.Property(t => t.MarketValue_MCHGZQ).HasColumnName("MarketValue_MCHGZQ");
			this.Property(t => t.RatioInNV_MCHGZQ).HasColumnName("RatioInNV_MCHGZQ");
			this.Property(t => t.MarketValue_QTZC).HasColumnName("MarketValue_QTZC");
			this.Property(t => t.RatioInNV_QTZC).HasColumnName("RatioInNV_QTZC");
			this.Property(t => t.NV).HasColumnName("NV");
			this.Property(t => t.MarketValue_ZCZJ).HasColumnName("MarketValue_ZCZJ");
		}
	}
}

