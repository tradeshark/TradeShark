using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class vw_research_companyforecastMap : EntityTypeConfiguration<vw_research_companyforecast>
	{
		public vw_research_companyforecastMap()
		{
			// Primary Key
			this.HasKey(t => new { t.endDate, t.companytype });

			// Properties
			this.Property(t => t.years)
				.HasMaxLength(30);
				
			this.Property(t => t.secucode)
				.HasMaxLength(10);
				
			this.Property(t => t.companytype)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("vw_research_companyforecast");
			this.Property(t => t.years).HasColumnName("years");
			this.Property(t => t.endDate).HasColumnName("endDate");
			this.Property(t => t.secucode).HasColumnName("secucode");
			this.Property(t => t.companytype).HasColumnName("companytype");
			this.Property(t => t.SalesRevenue).HasColumnName("SalesRevenue");
			this.Property(t => t.MainIncomeGrowRate).HasColumnName("MainIncomeGrowRate");
			this.Property(t => t.GrossProfit).HasColumnName("GrossProfit");
			this.Property(t => t.GrossProfitGrowRate).HasColumnName("GrossProfitGrowRate");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.NetProfitGrowRate).HasColumnName("NetProfitGrowRate");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.NetAssetPS).HasColumnName("NetAssetPS");
			this.Property(t => t.ROE).HasColumnName("ROE");
		}
	}
}

