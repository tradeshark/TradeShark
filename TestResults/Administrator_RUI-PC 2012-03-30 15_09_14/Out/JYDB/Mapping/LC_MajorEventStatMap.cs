using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_MajorEventStatMap : EntityTypeConfiguration<LC_MajorEventStat>
	{
		public LC_MajorEventStatMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Note)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_MajorEventStat");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.Subitem).HasColumnName("Subitem");
			this.Property(t => t.Unit).HasColumnName("Unit");
			this.Property(t => t.Data).HasColumnName("Data");
			this.Property(t => t.Note).HasColumnName("Note");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

