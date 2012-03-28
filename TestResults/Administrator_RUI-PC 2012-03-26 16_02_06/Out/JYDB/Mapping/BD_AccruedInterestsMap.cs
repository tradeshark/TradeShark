using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_AccruedInterestsMap : EntityTypeConfiguration<BD_AccruedInterests>
	{
		public BD_AccruedInterestsMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("BD_AccruedInterests");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ValueDatePer).HasColumnName("ValueDatePer");
			this.Property(t => t.DatePer).HasColumnName("DatePer");
			this.Property(t => t.AccruedInterest).HasColumnName("AccruedInterest");
			this.Property(t => t.AccruedDays).HasColumnName("AccruedDays");
			this.Property(t => t.CouponRate).HasColumnName("CouponRate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

