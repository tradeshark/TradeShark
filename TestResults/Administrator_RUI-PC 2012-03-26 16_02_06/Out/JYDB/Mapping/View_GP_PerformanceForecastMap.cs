using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_PerformanceForecastMap : EntityTypeConfiguration<View_GP_PerformanceForecast>
	{
		public View_GP_PerformanceForecastMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_ForcastType)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ResultStatement)
				.HasMaxLength(24);
				
			// Table & Column Mappings
			this.ToTable("View_GP_PerformanceForecast");
			this.Property(t => t.N_ForcastType).HasColumnName("N_ForcastType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ForcastType).HasColumnName("ForcastType");
			this.Property(t => t.ForcastReason).HasColumnName("ForcastReason");
			this.Property(t => t.ResultStatement).HasColumnName("ResultStatement");
			this.Property(t => t.ForcastContent).HasColumnName("ForcastContent");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

