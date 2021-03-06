using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class tb_style_perfMap : EntityTypeConfiguration<tb_style_perf>
	{
		public tb_style_perfMap()
		{
			// Primary Key
			this.HasKey(t => t.id);

			// Properties
			// Table & Column Mappings
			this.ToTable("tb_style_perf");
			this.Property(t => t.id).HasColumnName("id");
			this.Property(t => t.tradingday).HasColumnName("tradingday");
			this.Property(t => t.cmvstyle).HasColumnName("cmvstyle");
			this.Property(t => t.grtstyle).HasColumnName("grtstyle");
			this.Property(t => t.yield).HasColumnName("yield");
			this.Property(t => t.yieldrank).HasColumnName("yieldrank");
			this.Property(t => t.risk).HasColumnName("risk");
			this.Property(t => t.riskrank).HasColumnName("riskrank");
			this.Property(t => t.yrvalue).HasColumnName("yrvalue");
			this.Property(t => t.yrrank).HasColumnName("yrrank");
		}
	}
}

