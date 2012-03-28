using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_TopTenHolderMap : EntityTypeConfiguration<View_JJ_TopTenHolder>
	{
		public View_JJ_TopTenHolderMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ });

			// Properties
			this.Property(t => t.HolderNature)
				.HasMaxLength(300);
				
			this.Property(t => t.HolderName)
				.HasMaxLength(100);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_TopTenHolder");
			this.Property(t => t.HolderNature).HasColumnName("HolderNature");
			this.Property(t => t.HolderName).HasColumnName("HolderName");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.HoldingVolume).HasColumnName("HoldingVolume");
			this.Property(t => t.HoldingRatio).HasColumnName("HoldingRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

