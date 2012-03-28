using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_GP_ZYCWZBMap : EntityTypeConfiguration<VIEW_GP_ZYCWZB>
	{
		public VIEW_GP_ZYCWZBMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_GP_ZYCWZB");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.DeclareDate).HasColumnName("DeclareDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.EPSWeighted).HasColumnName("EPSWeighted");
			this.Property(t => t.EPSCut).HasColumnName("EPSCut");
			this.Property(t => t.EPSCutWeighted).HasColumnName("EPSCutWeighted");
			this.Property(t => t.NetAssetPS).HasColumnName("NetAssetPS");
			this.Property(t => t.NetAssetPSAdjusted).HasColumnName("NetAssetPSAdjusted");
			this.Property(t => t.OperCashFlowPS).HasColumnName("OperCashFlowPS");
			this.Property(t => t.AccumulationFundPS).HasColumnName("AccumulationFundPS");
			this.Property(t => t.UndividedProfit).HasColumnName("UndividedProfit");
			this.Property(t => t.CashFlowPS).HasColumnName("CashFlowPS");
			this.Property(t => t.B_ROE).HasColumnName("B_ROE");
			this.Property(t => t.B_ROEWeighted).HasColumnName("B_ROEWeighted");
			this.Property(t => t.B_ROECut).HasColumnName("B_ROECut");
			this.Property(t => t.B_ROECutWeighted).HasColumnName("B_ROECutWeighted");
			this.Property(t => t.B_NetProfitCut).HasColumnName("B_NetProfitCut");
		}
	}
}

