using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_NVChangeMap : EntityTypeConfiguration<MF_NVChange>
	{
		public MF_NVChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_NVChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.NVAtBegin).HasColumnName("NVAtBegin");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.UnrealizedProfitChange).HasColumnName("UnrealizedProfitChange");
			this.Property(t => t.NVChangeDueToOperating).HasColumnName("NVChangeDueToOperating");
			this.Property(t => t.ApplyingMoney).HasColumnName("ApplyingMoney");
			this.Property(t => t.RedemptionMoney).HasColumnName("RedemptionMoney");
			this.Property(t => t.NVChangeDueToUnitTrade).HasColumnName("NVChangeDueToUnitTrade");
			this.Property(t => t.DistributedProfit).HasColumnName("DistributedProfit");
			this.Property(t => t.NVAtEnd).HasColumnName("NVAtEnd");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.PriorYearProfitAdjust).HasColumnName("PriorYearProfitAdjust");
		}
	}
}

