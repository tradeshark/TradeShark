using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_ChargeRateMap : EntityTypeConfiguration<MF_ChargeRate>
	{
		public MF_ChargeRateMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.TermMarkUnit)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.Notes)
				.HasMaxLength(1000);
				
			this.Property(t => t.ChargeRateDesciption)
				.HasMaxLength(1000);
				
			this.Property(t => t.IntervalDescription)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("MF_ChargeRate");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.IfExecuted).HasColumnName("IfExecuted");
			this.Property(t => t.ExcuteDate).HasColumnName("ExcuteDate");
			this.Property(t => t.CancelDate).HasColumnName("CancelDate");
			this.Property(t => t.ChargeRateType).HasColumnName("ChargeRateType");
			this.Property(t => t.ChargePattern).HasColumnName("ChargePattern");
			this.Property(t => t.TermMarkUnit).HasColumnName("TermMarkUnit");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.BeginOfApplySumInterval).HasColumnName("BeginOfApplySumInterval");
			this.Property(t => t.EndOfApplySumInterval).HasColumnName("EndOfApplySumInterval");
			this.Property(t => t.BeginOfHoldTermInterval).HasColumnName("BeginOfHoldTermInterval");
			this.Property(t => t.EndOfHoldTermInterval).HasColumnName("EndOfHoldTermInterval");
			this.Property(t => t.BeginOfTranTimesInterval).HasColumnName("BeginOfTranTimesInterval");
			this.Property(t => t.EndOfTranTimesInterval).HasColumnName("EndOfTranTimesInterval");
			this.Property(t => t.MinimumChargeRate).HasColumnName("MinimumChargeRate");
			this.Property(t => t.MaximumChargeRate).HasColumnName("MaximumChargeRate");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.ChargeRateDesciption).HasColumnName("ChargeRateDesciption");
			this.Property(t => t.IntervalDescription).HasColumnName("IntervalDescription");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.IfApplyBegin).HasColumnName("IfApplyBegin");
			this.Property(t => t.IfApplyEnd).HasColumnName("IfApplyEnd");
			this.Property(t => t.IfHoldBegin).HasColumnName("IfHoldBegin");
			this.Property(t => t.IfHoldEnd).HasColumnName("IfHoldEnd");
		}
	}
}

