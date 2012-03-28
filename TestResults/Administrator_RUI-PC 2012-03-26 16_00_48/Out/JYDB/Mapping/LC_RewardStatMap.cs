using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_RewardStatMap : EntityTypeConfiguration<LC_RewardStat>
	{
		public LC_RewardStatMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Statement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_RewardStat");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.TotalYearPay).HasColumnName("TotalYearPay");
			this.Property(t => t.NumPayManagers).HasColumnName("NumPayManagers");
			this.Property(t => t.High3Directors).HasColumnName("High3Directors");
			this.Property(t => t.High3Managers).HasColumnName("High3Managers");
			this.Property(t => t.TotalIndeSupeYearPay).HasColumnName("TotalIndeSupeYearPay");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.TotalIndeSubsidy).HasColumnName("TotalIndeSubsidy");
		}
	}
}

