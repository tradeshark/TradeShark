using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MT_OperationIndicatorsMap : EntityTypeConfiguration<MT_OperationIndicators>
	{
		public MT_OperationIndicatorsMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.PubOrgCode, t.ValidDate, t.IndicatorCode, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(200);
				
			this.Property(t => t.PubOrgCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IndicatorCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IndicatorName)
				.HasMaxLength(50);
				
			this.Property(t => t.CreditGrade)
				.HasMaxLength(50);
				
			this.Property(t => t.RemarkDesc)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("MT_OperationIndicators");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PubOrgCode).HasColumnName("PubOrgCode");
			this.Property(t => t.ValidDate).HasColumnName("ValidDate");
			this.Property(t => t.IndicatorCode).HasColumnName("IndicatorCode");
			this.Property(t => t.IndicatorName).HasColumnName("IndicatorName");
			this.Property(t => t.IndicatorUnit).HasColumnName("IndicatorUnit");
			this.Property(t => t.DataValue).HasColumnName("DataValue");
			this.Property(t => t.RatioValue).HasColumnName("RatioValue");
			this.Property(t => t.CreditGradeCode).HasColumnName("CreditGradeCode");
			this.Property(t => t.CreditGrade).HasColumnName("CreditGrade");
			this.Property(t => t.RemarkDesc).HasColumnName("RemarkDesc");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

