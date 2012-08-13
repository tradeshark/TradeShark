using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_InvestTargetCriterionMap : EntityTypeConfiguration<MF_InvestTargetCriterion>
	{
		public MF_InvestTargetCriterionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfExecuted)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.InvestTarget)
				.HasMaxLength(20);
				
			this.Property(t => t.InvestRatioBenchmark)
				.HasMaxLength(50);
				
			this.Property(t => t.InvestRatioDescription)
				.HasMaxLength(250);
				
			// Table & Column Mappings
			this.ToTable("MF_InvestTargetCriterion");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.IfExecuted).HasColumnName("IfExecuted");
			this.Property(t => t.CancelDate).HasColumnName("CancelDate");
			this.Property(t => t.InvestTarget).HasColumnName("InvestTarget");
			this.Property(t => t.TracedIndexCode).HasColumnName("TracedIndexCode");
			this.Property(t => t.TopInvestRatio).HasColumnName("TopInvestRatio");
			this.Property(t => t.MinimumInvestRatio).HasColumnName("MinimumInvestRatio");
			this.Property(t => t.InvestRatioBenchmark).HasColumnName("InvestRatioBenchmark");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.InvestRatioDescription).HasColumnName("InvestRatioDescription");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ExecuteDate).HasColumnName("ExecuteDate");
		}
	}
}

