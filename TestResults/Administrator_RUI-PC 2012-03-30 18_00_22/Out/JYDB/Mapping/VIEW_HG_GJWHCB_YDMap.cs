using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_GJWHCB_YDMap : EntityTypeConfiguration<VIEW_HG_GJWHCB_YD>
	{
		public VIEW_HG_GJWHCB_YDMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.ReportArea, t.EndDate, t.ReportPeriod, t.XGRQ });

			// Properties
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Country)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ReportArea)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_GJWHCB_YD");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_Country).HasColumnName("N_Country");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_ReportPeriod).HasColumnName("N_ReportPeriod");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ForeignReserves).HasColumnName("ForeignReserves");
			this.Property(t => t.GoldReserves).HasColumnName("GoldReserves");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

