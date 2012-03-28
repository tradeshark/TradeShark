using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_MMBenchmarkRateMap : EntityTypeConfiguration<ED_MMBenchmarkRate>
	{
		public ED_MMBenchmarkRateMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ED_MMBenchmarkRate");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.OriginalDataName).HasColumnName("OriginalDataName");
			this.Property(t => t.DataProcessingMethod).HasColumnName("DataProcessingMethod");
			this.Property(t => t.IndicatorName).HasColumnName("IndicatorName");
			this.Property(t => t.Indicator).HasColumnName("Indicator");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

