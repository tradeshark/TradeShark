using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_EquityChangesStatementMap : EntityTypeConfiguration<MF_EquityChangesStatement>
	{
		public MF_EquityChangesStatementMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ItemsName)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("MF_EquityChangesStatement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.ItemsName).HasColumnName("ItemsName");
			this.Property(t => t.ItemsType).HasColumnName("ItemsType");
			this.Property(t => t.OpeningNV).HasColumnName("OpeningNV");
			this.Property(t => t.NVChangeByoOperating).HasColumnName("NVChangeByoOperating");
			this.Property(t => t.NVChangeByUnitTransaction).HasColumnName("NVChangeByUnitTransaction");
			this.Property(t => t.ApplyingSum).HasColumnName("ApplyingSum");
			this.Property(t => t.DividendReinvestmentSum).HasColumnName("DividendReinvestmentSum");
			this.Property(t => t.RedemptionSum).HasColumnName("RedemptionSum");
			this.Property(t => t.NVChangeByDistribution).HasColumnName("NVChangeByDistribution");
			this.Property(t => t.NVChangeExceptionalItems).HasColumnName("NVChangeExceptionalItems");
			this.Property(t => t.NVChangeAdjustmentItems).HasColumnName("NVChangeAdjustmentItems");
			this.Property(t => t.EndingNV).HasColumnName("EndingNV");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
		}
	}
}

