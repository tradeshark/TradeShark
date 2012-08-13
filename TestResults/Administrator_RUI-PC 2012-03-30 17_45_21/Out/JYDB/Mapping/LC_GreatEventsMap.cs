using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_GreatEventsMap : EntityTypeConfiguration<LC_GreatEvents>
	{
		public LC_GreatEventsMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.InfoSource, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.XGRQ)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("LC_GreatEvents");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.InvolvedType).HasColumnName("InvolvedType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
		}
	}
}

