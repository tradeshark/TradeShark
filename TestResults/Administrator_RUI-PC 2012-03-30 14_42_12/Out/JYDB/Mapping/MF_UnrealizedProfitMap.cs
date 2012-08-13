using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_UnrealizedProfitMap : EntityTypeConfiguration<MF_UnrealizedProfit>
	{
		public MF_UnrealizedProfitMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_UnrealizedProfit");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.UnrealizedProfitAtBegin).HasColumnName("UnrealizedProfitAtBegin");
			this.Property(t => t.EstimatedIncrementAtBegin).HasColumnName("EstimatedIncrementAtBegin");
			this.Property(t => t.UnrealizedProfitBufferAtBegin).HasColumnName("UnrealizedProfitBufferAtBegin");
			this.Property(t => t.EstimatedIncrementChange).HasColumnName("EstimatedIncrementChange");
			this.Property(t => t.ApplyingMoney).HasColumnName("ApplyingMoney");
			this.Property(t => t.DividendReinvestment).HasColumnName("DividendReinvestment");
			this.Property(t => t.RedemptionMoney).HasColumnName("RedemptionMoney");
			this.Property(t => t.OtherBufferMoney).HasColumnName("OtherBufferMoney");
			this.Property(t => t.UnrealizedProfitAtEnd).HasColumnName("UnrealizedProfitAtEnd");
			this.Property(t => t.EstimatedIncrementAtEnd).HasColumnName("EstimatedIncrementAtEnd");
			this.Property(t => t.UnrealizedProfitBufferAtEnd).HasColumnName("UnrealizedProfitBufferAtEnd");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

