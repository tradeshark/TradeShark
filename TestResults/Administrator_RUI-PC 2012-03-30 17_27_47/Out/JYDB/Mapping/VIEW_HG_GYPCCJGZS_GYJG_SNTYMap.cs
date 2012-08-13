using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_GYPCCJGZS_GYJG_SNTYMap : EntityTypeConfiguration<VIEW_HG_GYPCCJGZS_GYJG_SNTY>
	{
		public VIEW_HG_GYPCCJGZS_GYJG_SNTYMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_AdjustMark, t.ID, t.EndDate, t.AdjustMark, t.ReportPeriod, t.ReportArea, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_ReportPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndexType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndexCode)
				.HasMaxLength(50);
				
			this.Property(t => t.N_AdjustMark)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.AdjustMark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportArea)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IndexName)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_GYPCCJGZS_GYJG_SNTY");
			this.Property(t => t.N_ReportPeriod).HasColumnName("N_ReportPeriod");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_IndexType).HasColumnName("N_IndexType");
			this.Property(t => t.N_IndexCode).HasColumnName("N_IndexCode");
			this.Property(t => t.N_AdjustMark).HasColumnName("N_AdjustMark");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.IndexType).HasColumnName("IndexType");
			this.Property(t => t.IndexName).HasColumnName("IndexName");
			this.Property(t => t.IndexCode).HasColumnName("IndexCode");
			this.Property(t => t.IndexValue).HasColumnName("IndexValue");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

