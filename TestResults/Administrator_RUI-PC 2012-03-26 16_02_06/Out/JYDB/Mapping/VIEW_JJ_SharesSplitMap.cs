using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_JJ_SharesSplitMap : EntityTypeConfiguration<VIEW_JJ_SharesSplit>
	{
		public VIEW_JJ_SharesSplitMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_InfoType)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("VIEW_JJ_SharesSplit");
			this.Property(t => t.N_InfoType).HasColumnName("N_InfoType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.InfoType).HasColumnName("InfoType");
			this.Property(t => t.SplitDay).HasColumnName("SplitDay");
			this.Property(t => t.SplitRatio).HasColumnName("SplitRatio");
			this.Property(t => t.OutcomeNoticeIssueDate).HasColumnName("OutcomeNoticeIssueDate");
			this.Property(t => t.ChangeRegDate).HasColumnName("ChangeRegDate");
			this.Property(t => t.NV).HasColumnName("NV");
			this.Property(t => t.SharesBefore).HasColumnName("SharesBefore");
			this.Property(t => t.SharesAfter).HasColumnName("SharesAfter");
			this.Property(t => t.UnitNVBefore).HasColumnName("UnitNVBefore");
			this.Property(t => t.UnitNVAfter).HasColumnName("UnitNVAfter");
			this.Property(t => t.AccumulatedUnitNVBefore).HasColumnName("AccumulatedUnitNVBefore");
			this.Property(t => t.AccumulatedUnitNVAfter).HasColumnName("AccumulatedUnitNVAfter");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

