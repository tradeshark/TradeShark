using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class StockDistributionMap : EntityTypeConfiguration<StockDistribution>
	{
		public StockDistributionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.id, t.StockCode });

			// Properties
			this.Property(t => t.id)
				.IsRequired()
				.HasMaxLength(38);
				
			this.Property(t => t.StockCode)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(6);
				
			this.Property(t => t.DistributeType)
				.IsFixedLength()
				.HasMaxLength(10);
				
			this.Property(t => t.DistributeTarget)
				.HasMaxLength(250);
				
			this.Property(t => t.RightsIssueMeans)
				.HasMaxLength(40);
				
			this.Property(t => t.Underwriter)
				.HasMaxLength(200);
				
			this.Property(t => t.UnderrightMode)
				.HasMaxLength(40);
				
			this.Property(t => t.ResultType)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("StockDistribution");
			this.Property(t => t.id).HasColumnName("id");
			this.Property(t => t.StockCode).HasColumnName("StockCode");
			this.Property(t => t.DistributeType).HasColumnName("DistributeType");
			this.Property(t => t.Ratio).HasColumnName("Ratio");
			this.Property(t => t.Price).HasColumnName("Price");
			this.Property(t => t.DistributeTarget).HasColumnName("DistributeTarget");
			this.Property(t => t.NoticeDate).HasColumnName("NoticeDate");
			this.Property(t => t.DeclareDate).HasColumnName("DeclareDate");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.MeetDate).HasColumnName("MeetDate");
			this.Property(t => t.AllowDate).HasColumnName("AllowDate");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
			this.Property(t => t.EXDate).HasColumnName("EXDate");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.FirstTradingDate).HasColumnName("FirstTradingDate");
			this.Property(t => t.RightsIssueMeans).HasColumnName("RightsIssueMeans");
			this.Property(t => t.Underwriter).HasColumnName("Underwriter");
			this.Property(t => t.UnderrightMode).HasColumnName("UnderrightMode");
			this.Property(t => t.Seller).HasColumnName("Seller");
			this.Property(t => t.PlannedVolumeOfRights).HasColumnName("PlannedVolumeOfRights");
			this.Property(t => t.ActualVolumeOfRights).HasColumnName("ActualVolumeOfRights");
			this.Property(t => t.ExclusiveSale).HasColumnName("ExclusiveSale");
			this.Property(t => t.ActualValueOfRights).HasColumnName("ActualValueOfRights");
			this.Property(t => t.DistributeYear).HasColumnName("DistributeYear");
			this.Property(t => t.ResultType).HasColumnName("ResultType");
			this.Property(t => t.RePrice).HasColumnName("RePrice");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.ActFlowRights).HasColumnName("ActFlowRights");
			this.Property(t => t.BaseShares).HasColumnName("BaseShares");
			this.Property(t => t.DisFee).HasColumnName("DisFee");
		}
	}
}

