using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class IN_IndustryOutputStatMap : EntityTypeConfiguration<IN_IndustryOutputStat>
	{
		public IN_IndustryOutputStatMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ProductName)
				.HasMaxLength(500);
				
			this.Property(t => t.StateName)
				.HasMaxLength(100);
				
			this.Property(t => t.UnitName)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("IN_IndustryOutputStat");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPubDate).HasColumnName("InfoPubDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Period).HasColumnName("Period");
			this.Property(t => t.ProductCode).HasColumnName("ProductCode");
			this.Property(t => t.ProductName).HasColumnName("ProductName");
			this.Property(t => t.Unit).HasColumnName("Unit");
			this.Property(t => t.OutputQuantity).HasColumnName("OutputQuantity");
			this.Property(t => t.IncreaseOrDecreaseYOY).HasColumnName("IncreaseOrDecreaseYOY");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoSourceCode).HasColumnName("InfoSourceCode");
			this.Property(t => t.StateCode).HasColumnName("StateCode");
			this.Property(t => t.StateName).HasColumnName("StateName");
			this.Property(t => t.UnitName).HasColumnName("UnitName");
		}
	}
}

