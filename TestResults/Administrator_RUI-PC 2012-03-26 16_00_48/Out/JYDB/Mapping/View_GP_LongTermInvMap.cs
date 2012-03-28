using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_LongTermInvMap : EntityTypeConfiguration<View_GP_LongTermInv>
	{
		public View_GP_LongTermInvMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.DataType, t.IfAdjusted, t.IfMerged, t.XGRQ });

			// Properties
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfAdjusted)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.DataType)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_GP_LongTermInv");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.LongTermEquityInv).HasColumnName("LongTermEquityInv");
			this.Property(t => t.Stock).HasColumnName("Stock");
			this.Property(t => t.SubsidiaryCompany).HasColumnName("SubsidiaryCompany");
			this.Property(t => t.JointVentureM).HasColumnName("JointVentureM");
			this.Property(t => t.JointVentureH).HasColumnName("JointVentureH");
			this.Property(t => t.OtherEquityInv).HasColumnName("OtherEquityInv");
			this.Property(t => t.ConsolidationDifference).HasColumnName("ConsolidationDifference");
			this.Property(t => t.EquityInvDifference).HasColumnName("EquityInvDifference");
			this.Property(t => t.LongTermInvOnBonds).HasColumnName("LongTermInvOnBonds");
			this.Property(t => t.OtherLongTermInv).HasColumnName("OtherLongTermInv");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.LongTermEquityInv_DJZB).HasColumnName("LongTermEquityInv_DJZB");
			this.Property(t => t.Stock_DJZB).HasColumnName("Stock_DJZB");
			this.Property(t => t.SubsidiaryCompany_DJZB).HasColumnName("SubsidiaryCompany_DJZB");
			this.Property(t => t.JointVentureM_DJZB).HasColumnName("JointVentureM_DJZB");
			this.Property(t => t.JointVentureH_DJZB).HasColumnName("JointVentureH_DJZB");
			this.Property(t => t.OtherEquityInv_DJZB).HasColumnName("OtherEquityInv_DJZB");
			this.Property(t => t.ConsolidationDifference_DJZB).HasColumnName("ConsolidationDifference_DJZB");
			this.Property(t => t.EquityInvDifference_DJZB).HasColumnName("EquityInvDifference_DJZB");
			this.Property(t => t.LongTermInvOnBonds_DJZB).HasColumnName("LongTermInvOnBonds_DJZB");
			this.Property(t => t.OtherLongTermInv_DJZB).HasColumnName("OtherLongTermInv_DJZB");
			this.Property(t => t.Total_DJZB).HasColumnName("Total_DJZB");
			this.Property(t => t.JTBL).HasColumnName("JTBL");
		}
	}
}

