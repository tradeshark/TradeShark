using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_TradingDayMap : EntityTypeConfiguration<QT_TradingDay>
	{
		public QT_TradingDayMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("QT_TradingDay");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.Date).HasColumnName("Date");
			this.Property(t => t.IfTradingDay).HasColumnName("IfTradingDay");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.IfWeekEnd).HasColumnName("IfWeekEnd");
			this.Property(t => t.IfMonthEnd).HasColumnName("IfMonthEnd");
			this.Property(t => t.IfQuarterEnd).HasColumnName("IfQuarterEnd");
			this.Property(t => t.IfYearEnd).HasColumnName("IfYearEnd");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

