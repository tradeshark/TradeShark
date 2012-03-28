using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_FundPerformanceMap : EntityTypeConfiguration<MF_FundPerformance>
	{
		public MF_FundPerformanceMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.StatisticRange, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.StatisticRange)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_FundPerformance");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.NetIncome).HasColumnName("NetIncome");
			this.Property(t => t.NetIncomePerShare).HasColumnName("NetIncomePerShare");
			this.Property(t => t.StatisticRange).HasColumnName("StatisticRange");
			this.Property(t => t.GrowthRateOfNetValue).HasColumnName("GrowthRateOfNetValue");
			this.Property(t => t.StandardDeviationOfGRONV).HasColumnName("StandardDeviationOfGRONV");
			this.Property(t => t.GrowthRateOfBenchmark).HasColumnName("GrowthRateOfBenchmark");
			this.Property(t => t.StandardDeviationOfGROB).HasColumnName("StandardDeviationOfGROB");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

