using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_AdjustingFactorMap : EntityTypeConfiguration<QT_AdjustingFactor>
	{
		public QT_AdjustingFactorMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("QT_AdjustingFactor");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.ExDiviDate).HasColumnName("ExDiviDate");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.AdjustingFactor).HasColumnName("AdjustingFactor");
			this.Property(t => t.AdjustingConst).HasColumnName("AdjustingConst");
			this.Property(t => t.RatioAdjustingFactor).HasColumnName("RatioAdjustingFactor");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

