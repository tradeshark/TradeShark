using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PriceRatioIndexMap : EntityTypeConfiguration<LC_PriceRatioIndex>
	{
		public LC_PriceRatioIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_PriceRatioIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.StockDividendRatio).HasColumnName("StockDividendRatio");
			this.Property(t => t.StockPERatio1).HasColumnName("StockPERatio1");
			this.Property(t => t.StockPERatio2).HasColumnName("StockPERatio2");
			this.Property(t => t.StockPERatio3).HasColumnName("StockPERatio3");
			this.Property(t => t.StockPBRatio).HasColumnName("StockPBRatio");
			this.Property(t => t.StockPBRatioAdjusted).HasColumnName("StockPBRatioAdjusted");
			this.Property(t => t.StockCFM1).HasColumnName("StockCFM1");
			this.Property(t => t.StockCFM2).HasColumnName("StockCFM2");
			this.Property(t => t.StockCFM3).HasColumnName("StockCFM3");
			this.Property(t => t.StockPSRatio1).HasColumnName("StockPSRatio1");
			this.Property(t => t.StockPSRatio2).HasColumnName("StockPSRatio2");
			this.Property(t => t.StockPSRatio3).HasColumnName("StockPSRatio3");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

