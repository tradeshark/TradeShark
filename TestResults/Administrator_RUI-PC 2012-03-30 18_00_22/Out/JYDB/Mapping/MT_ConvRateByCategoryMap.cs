using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MT_ConvRateByCategoryMap : EntityTypeConfiguration<MT_ConvRateByCategory>
	{
		public MT_ConvRateByCategoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.PubOrgCode, t.SecondSecuCategory, t.ExecuteDate, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(200);
				
			this.Property(t => t.PubOrgCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SecondSecuCategory)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ConvensionRateDesc)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("MT_ConvRateByCategory");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PubOrgCode).HasColumnName("PubOrgCode");
			this.Property(t => t.FirstSecuCategory).HasColumnName("FirstSecuCategory");
			this.Property(t => t.SecondSecuCategory).HasColumnName("SecondSecuCategory");
			this.Property(t => t.ExecuteDate).HasColumnName("ExecuteDate");
			this.Property(t => t.CancelDate).HasColumnName("CancelDate");
			this.Property(t => t.MaxConvensionRate).HasColumnName("MaxConvensionRate");
			this.Property(t => t.MinConvensionRate).HasColumnName("MinConvensionRate");
			this.Property(t => t.ConvensionRateDesc).HasColumnName("ConvensionRateDesc");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

