using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PayBebtSummaryMap : EntityTypeConfiguration<LC_PayBebtSummary>
	{
		public LC_PayBebtSummaryMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_PayBebtSummary");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.PeriodBeginOccupySum).HasColumnName("PeriodBeginOccupySum");
			this.Property(t => t.PeriodEndOccupySum).HasColumnName("PeriodEndOccupySum");
			this.Property(t => t.ThisPeriodPayBebtSum).HasColumnName("ThisPeriodPayBebtSum");
			this.Property(t => t.PayBebtStatement).HasColumnName("PayBebtStatement");
			this.Property(t => t.AnnouncementType).HasColumnName("AnnouncementType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

