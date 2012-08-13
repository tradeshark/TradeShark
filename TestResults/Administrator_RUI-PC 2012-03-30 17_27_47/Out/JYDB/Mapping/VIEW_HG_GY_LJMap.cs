using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_GY_LJMap : EntityTypeConfiguration<VIEW_HG_GY_LJ>
	{
		public VIEW_HG_GY_LJMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.ReportPeriod, t.AdjustMark, t.XGRQ });

			// Properties
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_StatStandard)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AdjustMark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_GY_LJ");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_ReportPeriod).HasColumnName("N_ReportPeriod");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_StatStandard).HasColumnName("N_StatStandard");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.IndustrialValueAdded).HasColumnName("IndustrialValueAdded");
			this.Property(t => t.LIValueAdded).HasColumnName("LIValueAdded");
			this.Property(t => t.HIValueAdded).HasColumnName("HIValueAdded");
			this.Property(t => t.StateOwnedControlledCom).HasColumnName("StateOwnedControlledCom");
			this.Property(t => t.CollectiveCom).HasColumnName("CollectiveCom");
			this.Property(t => t.PrivateEnterprise).HasColumnName("PrivateEnterprise");
			this.Property(t => t.StockCooperativeCom).HasColumnName("StockCooperativeCom");
			this.Property(t => t.JointStockCom).HasColumnName("JointStockCom");
			this.Property(t => t.ForeignHKMacauTaiwanInv).HasColumnName("ForeignHKMacauTaiwanInv");
			this.Property(t => t.ForeignInv).HasColumnName("ForeignInv");
			this.Property(t => t.HKMacauTaiwanInv).HasColumnName("HKMacauTaiwanInv");
			this.Property(t => t.LargeCom).HasColumnName("LargeCom");
			this.Property(t => t.MediumCom).HasColumnName("MediumCom");
			this.Property(t => t.MinitypeCom).HasColumnName("MinitypeCom");
			this.Property(t => t.IndustrialOutputValueAP).HasColumnName("IndustrialOutputValueAP");
			this.Property(t => t.LIValueAP).HasColumnName("LIValueAP");
			this.Property(t => t.HIValueAP).HasColumnName("HIValueAP");
			this.Property(t => t.StateOwnedControlledComAP).HasColumnName("StateOwnedControlledComAP");
			this.Property(t => t.CollectiveComAP).HasColumnName("CollectiveComAP");
			this.Property(t => t.PrivateEnterpriseAP).HasColumnName("PrivateEnterpriseAP");
			this.Property(t => t.StockCooperativeComAP).HasColumnName("StockCooperativeComAP");
			this.Property(t => t.JointStockComAP).HasColumnName("JointStockComAP");
			this.Property(t => t.ForeignHKMacauTaiwanInvAP).HasColumnName("ForeignHKMacauTaiwanInvAP");
			this.Property(t => t.ForeignInvAP).HasColumnName("ForeignInvAP");
			this.Property(t => t.HKMacauTaiwanInvAP).HasColumnName("HKMacauTaiwanInvAP");
			this.Property(t => t.LargeComAP).HasColumnName("LargeComAP");
			this.Property(t => t.MediumComAP).HasColumnName("MediumComAP");
			this.Property(t => t.MinitypeComAP).HasColumnName("MinitypeComAP");
			this.Property(t => t.IndustrialOutputValueFP).HasColumnName("IndustrialOutputValueFP");
			this.Property(t => t.LIValueFP).HasColumnName("LIValueFP");
			this.Property(t => t.HIValueFP).HasColumnName("HIValueFP");
			this.Property(t => t.StateOwnedControlledComFP).HasColumnName("StateOwnedControlledComFP");
			this.Property(t => t.CollectiveComFP).HasColumnName("CollectiveComFP");
			this.Property(t => t.PrivateEnterpriseFP).HasColumnName("PrivateEnterpriseFP");
			this.Property(t => t.StockCooperativeComFP).HasColumnName("StockCooperativeComFP");
			this.Property(t => t.JointStockComFP).HasColumnName("JointStockComFP");
			this.Property(t => t.ForeignHKMacauTaiwanInvFP).HasColumnName("ForeignHKMacauTaiwanInvFP");
			this.Property(t => t.ForeignInvFP).HasColumnName("ForeignInvFP");
			this.Property(t => t.HKMacauTaiwanInvFP).HasColumnName("HKMacauTaiwanInvFP");
			this.Property(t => t.LargeComFP).HasColumnName("LargeComFP");
			this.Property(t => t.MediumComFP).HasColumnName("MediumComFP");
			this.Property(t => t.MinitypeComFP).HasColumnName("MinitypeComFP");
			this.Property(t => t.ProductionSalesRatio).HasColumnName("ProductionSalesRatio");
			this.Property(t => t.GrowthIValueAdded).HasColumnName("GrowthIValueAdded");
			this.Property(t => t.GrowthLIValueAdded).HasColumnName("GrowthLIValueAdded");
			this.Property(t => t.GrowthHIValueAdded).HasColumnName("GrowthHIValueAdded");
			this.Property(t => t.GrowthSOwnedControlledCom).HasColumnName("GrowthSOwnedControlledCom");
			this.Property(t => t.GrowthCollectiveCom).HasColumnName("GrowthCollectiveCom");
			this.Property(t => t.GrowthPrivateEnterprise).HasColumnName("GrowthPrivateEnterprise");
			this.Property(t => t.GrowthStockCooperativeCom).HasColumnName("GrowthStockCooperativeCom");
			this.Property(t => t.GrowthJointStockCom).HasColumnName("GrowthJointStockCom");
			this.Property(t => t.GrowthFHKMTInv).HasColumnName("GrowthFHKMTInv");
			this.Property(t => t.GrowthForeignInv).HasColumnName("GrowthForeignInv");
			this.Property(t => t.GrowthHKMacauTaiwanInv).HasColumnName("GrowthHKMacauTaiwanInv");
			this.Property(t => t.GrowthLargeCom).HasColumnName("GrowthLargeCom");
			this.Property(t => t.GrowthMediumCom).HasColumnName("GrowthMediumCom");
			this.Property(t => t.GrowthMinitypeCom).HasColumnName("GrowthMinitypeCom");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.EXPR1).HasColumnName("EXPR1");
			this.Property(t => t.EXPR2).HasColumnName("EXPR2");
			this.Property(t => t.EXPR3).HasColumnName("EXPR3");
			this.Property(t => t.EXPR4).HasColumnName("EXPR4");
			this.Property(t => t.EXPR5).HasColumnName("EXPR5");
			this.Property(t => t.EXPR6).HasColumnName("EXPR6");
			this.Property(t => t.EXPR7).HasColumnName("EXPR7");
			this.Property(t => t.EXPR8).HasColumnName("EXPR8");
			this.Property(t => t.EXPR9).HasColumnName("EXPR9");
			this.Property(t => t.EXPR10).HasColumnName("EXPR10");
			this.Property(t => t.EXPR11).HasColumnName("EXPR11");
			this.Property(t => t.EXPR12).HasColumnName("EXPR12");
			this.Property(t => t.EXPR13).HasColumnName("EXPR13");
			this.Property(t => t.EXPR14).HasColumnName("EXPR14");
			this.Property(t => t.EXPR15).HasColumnName("EXPR15");
			this.Property(t => t.EXPR16).HasColumnName("EXPR16");
			this.Property(t => t.EXPR17).HasColumnName("EXPR17");
			this.Property(t => t.EXPR18).HasColumnName("EXPR18");
			this.Property(t => t.EXPR19).HasColumnName("EXPR19");
			this.Property(t => t.EXPR20).HasColumnName("EXPR20");
			this.Property(t => t.EXPR21).HasColumnName("EXPR21");
			this.Property(t => t.EXPR22).HasColumnName("EXPR22");
			this.Property(t => t.EXPR23).HasColumnName("EXPR23");
		}
	}
}

