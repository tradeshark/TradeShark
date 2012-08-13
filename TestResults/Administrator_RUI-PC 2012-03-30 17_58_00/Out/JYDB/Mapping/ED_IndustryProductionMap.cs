using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_IndustryProductionMap : EntityTypeConfiguration<ED_IndustryProduction>
	{
		public ED_IndustryProductionMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_IndustryProduction");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.StatStandard).HasColumnName("StatStandard");
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
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

