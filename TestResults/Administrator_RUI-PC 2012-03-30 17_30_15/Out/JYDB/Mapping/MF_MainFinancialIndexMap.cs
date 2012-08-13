using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_MainFinancialIndexMap : EntityTypeConfiguration<MF_MainFinancialIndex>
	{
		public MF_MainFinancialIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("MF_MainFinancialIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.NetIncome).HasColumnName("NetIncome");
			this.Property(t => t.TotalProfitPerShare).HasColumnName("TotalProfitPerShare");
			this.Property(t => t.DistributableProfits).HasColumnName("DistributableProfits");
			this.Property(t => t.DistriProfitsPShare).HasColumnName("DistriProfitsPShare");
			this.Property(t => t.NetAssetsValue).HasColumnName("NetAssetsValue");
			this.Property(t => t.NVPerShare).HasColumnName("NVPerShare");
			this.Property(t => t.WANVProfitRate).HasColumnName("WANVProfitRate");
			this.Property(t => t.UnitNVGrowthRate).HasColumnName("UnitNVGrowthRate");
			this.Property(t => t.UnitAccumulativeNVGR).HasColumnName("UnitAccumulativeNVGR");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

