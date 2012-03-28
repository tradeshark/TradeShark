using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FSpecialIndicatorsMap : EntityTypeConfiguration<LC_FSpecialIndicators>
	{
		public LC_FSpecialIndicatorsMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IndicatorName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_FSpecialIndicators");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.IndicatorType).HasColumnName("IndicatorType");
			this.Property(t => t.IndicatorName).HasColumnName("IndicatorName");
			this.Property(t => t.IndicatorCode).HasColumnName("IndicatorCode");
			this.Property(t => t.Amount).HasColumnName("Amount");
			this.Property(t => t.RatioEOP).HasColumnName("RatioEOP");
			this.Property(t => t.RatioAVG).HasColumnName("RatioAVG");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

