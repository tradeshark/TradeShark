using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_DividendMap : EntityTypeConfiguration<LC_Dividend>
	{
		public LC_DividendMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ChangeStatement)
				.HasMaxLength(255);
				
			this.Property(t => t.Notes)
				.HasMaxLength(255);
				
			this.Property(t => t.UndistributeStatement)
				.HasMaxLength(255);
				
			this.Property(t => t.DistributeTimes)
				.HasMaxLength(10);
				
			this.Property(t => t.EventProcedureDesc)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_Dividend");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfDividend).HasColumnName("IfDividend");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.BonusShareRatio).HasColumnName("BonusShareRatio");
			this.Property(t => t.TranAddShareRaio).HasColumnName("TranAddShareRaio");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.CashDiviRMB).HasColumnName("CashDiviRMB");
			this.Property(t => t.ActualCashDiviRMB).HasColumnName("ActualCashDiviRMB");
			this.Property(t => t.CashDiviFC).HasColumnName("CashDiviFC");
			this.Property(t => t.ActualCashDiviFC).HasColumnName("ActualCashDiviFC");
			this.Property(t => t.RightRegDate).HasColumnName("RightRegDate");
			this.Property(t => t.ExDiviDate).HasColumnName("ExDiviDate");
			this.Property(t => t.BonusShareListDate).HasColumnName("BonusShareListDate");
			this.Property(t => t.ToAccountDate).HasColumnName("ToAccountDate");
			this.Property(t => t.FinalTradingDay).HasColumnName("FinalTradingDay");
			this.Property(t => t.DiviBase).HasColumnName("DiviBase");
			this.Property(t => t.SharesAfterDivi).HasColumnName("SharesAfterDivi");
			this.Property(t => t.DiviObject).HasColumnName("DiviObject");
			this.Property(t => t.TotalCashDiviComRMB).HasColumnName("TotalCashDiviComRMB");
			this.Property(t => t.TotalCashDiviComFC).HasColumnName("TotalCashDiviComFC");
			this.Property(t => t.CashDiviAShare).HasColumnName("CashDiviAShare");
			this.Property(t => t.CashDiviBShareRMB).HasColumnName("CashDiviBShareRMB");
			this.Property(t => t.CashDiviBShareFC).HasColumnName("CashDiviBShareFC");
			this.Property(t => t.DiviStartDate).HasColumnName("DiviStartDate");
			this.Property(t => t.IFSchemeChange).HasColumnName("IFSchemeChange");
			this.Property(t => t.ChangeStatement).HasColumnName("ChangeStatement");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.IfDiviBeforeChange).HasColumnName("IfDiviBeforeChange");
			this.Property(t => t.BonusShareRatioBeforeChange).HasColumnName("BonusShareRatioBeforeChange");
			this.Property(t => t.TranAddShareRatioBeforeChange).HasColumnName("TranAddShareRatioBeforeChange");
			this.Property(t => t.CashDiviBeforeChangeRMB).HasColumnName("CashDiviBeforeChangeRMB");
			this.Property(t => t.CashDiviBeforeChangeFC).HasColumnName("CashDiviBeforeChangeFC");
			this.Property(t => t.DiviBaseBeforeChange).HasColumnName("DiviBaseBeforeChange");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.UndistributeStatement).HasColumnName("UndistributeStatement");
			this.Property(t => t.DistributeTimes).HasColumnName("DistributeTimes");
			this.Property(t => t.CeilingNext).HasColumnName("CeilingNext");
			this.Property(t => t.FloorNext).HasColumnName("FloorNext");
			this.Property(t => t.Ceiling).HasColumnName("Ceiling");
			this.Property(t => t.Floor).HasColumnName("Floor");
			this.Property(t => t.MainForm).HasColumnName("MainForm");
			this.Property(t => t.CashDiviCeiling).HasColumnName("CashDiviCeiling");
			this.Property(t => t.CashDiviFloor).HasColumnName("CashDiviFloor");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.DiviEndDate).HasColumnName("DiviEndDate");
			this.Property(t => t.DividendImplementDate).HasColumnName("DividendImplementDate");
			this.Property(t => t.EventProcedure).HasColumnName("EventProcedure");
			this.Property(t => t.EventProcedureDesc).HasColumnName("EventProcedureDesc");
		}
	}
}

