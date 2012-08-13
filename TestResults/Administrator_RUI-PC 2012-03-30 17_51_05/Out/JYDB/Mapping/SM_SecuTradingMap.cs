using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class SM_SecuTradingMap : EntityTypeConfiguration<SM_SecuTrading>
	{
		public SM_SecuTradingMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("SM_SecuTrading");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.TradingObjects).HasColumnName("TradingObjects");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.TradingDays).HasColumnName("TradingDays");
			this.Property(t => t.StockTurnover).HasColumnName("StockTurnover");
			this.Property(t => t.StockTurnover_Daily).HasColumnName("StockTurnover_Daily");
			this.Property(t => t.StockTradingVolume).HasColumnName("StockTradingVolume");
			this.Property(t => t.StockTradingVolume_Daily).HasColumnName("StockTradingVolume_Daily");
			this.Property(t => t.TransactionNum).HasColumnName("TransactionNum");
			this.Property(t => t.TransactionNum_Daily).HasColumnName("TransactionNum_Daily");
			this.Property(t => t.StampDuty).HasColumnName("StampDuty");
			this.Property(t => t.ASharePE).HasColumnName("ASharePE");
			this.Property(t => t.BSharePE).HasColumnName("BSharePE");
			this.Property(t => t.AShareTurnoverRate).HasColumnName("AShareTurnoverRate");
			this.Property(t => t.BShareTurnoverRate).HasColumnName("BShareTurnoverRate");
			this.Property(t => t.StockTurnoverChangePCT_YoY).HasColumnName("StockTurnoverChangePCT_YoY");
			this.Property(t => t.StockTurnoverDChangePCT_YoY).HasColumnName("StockTurnoverDChangePCT_YoY");
			this.Property(t => t.StockTradVolChangePCT_YoY).HasColumnName("StockTradVolChangePCT_YoY");
			this.Property(t => t.StockTradVolDChangePCT_YoY).HasColumnName("StockTradVolDChangePCT_YoY");
			this.Property(t => t.TransactNumChangePCT_YoY).HasColumnName("TransactNumChangePCT_YoY");
			this.Property(t => t.TransactNumDChangePCT_YoY).HasColumnName("TransactNumDChangePCT_YoY");
			this.Property(t => t.StampDutyChangePCT_YoY).HasColumnName("StampDutyChangePCT_YoY");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

