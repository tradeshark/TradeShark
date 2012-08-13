using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MT_DailyMarginMap : EntityTypeConfiguration<MT_DailyMargin>
	{
		public MT_DailyMarginMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.PubOrgCode, t.EndDate, t.InnerCode, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(200);
				
			this.Property(t => t.PubOrgCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.CreditGrade)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("MT_DailyMargin");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PubOrgCode).HasColumnName("PubOrgCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TargetCategory).HasColumnName("TargetCategory");
			this.Property(t => t.DepositRatio).HasColumnName("DepositRatio");
			this.Property(t => t.CreditGradeCode).HasColumnName("CreditGradeCode");
			this.Property(t => t.CreditGrade).HasColumnName("CreditGrade");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

