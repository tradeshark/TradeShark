using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_HouseProsperityIndexMap : EntityTypeConfiguration<ED_HouseProsperityIndex>
	{
		public ED_HouseProsperityIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_HouseProsperityIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.HouseProsperityIndex).HasColumnName("HouseProsperityIndex");
			this.Property(t => t.CapitalSourceIndex).HasColumnName("CapitalSourceIndex");
			this.Property(t => t.HouseBuildingAreaIndex).HasColumnName("HouseBuildingAreaIndex");
			this.Property(t => t.CommodityHouseSalesIndex).HasColumnName("CommodityHouseSalesIndex");
			this.Property(t => t.REDevelopmentInvIndex).HasColumnName("REDevelopmentInvIndex");
			this.Property(t => t.VacancyAreaIndexCH).HasColumnName("VacancyAreaIndexCH");
			this.Property(t => t.LandAreaDevelopedIndex).HasColumnName("LandAreaDevelopedIndex");
			this.Property(t => t.NewDevelopedLandAreaIndex).HasColumnName("NewDevelopedLandAreaIndex");
			this.Property(t => t.LandTransferIncomeIndex).HasColumnName("LandTransferIncomeIndex");
			this.Property(t => t.FinishedBuildingAreaIndex).HasColumnName("FinishedBuildingAreaIndex");
			this.Property(t => t.NationProsperityIndexGYoY).HasColumnName("NationProsperityIndexGYoY");
			this.Property(t => t.CapitalSourceIndexGYoY).HasColumnName("CapitalSourceIndexGYoY");
			this.Property(t => t.HouseBuildingAreaIndexGYoY).HasColumnName("HouseBuildingAreaIndexGYoY");
			this.Property(t => t.CommodityHouseSalesIndexGYoY).HasColumnName("CommodityHouseSalesIndexGYoY");
			this.Property(t => t.REDevelopmentInvIndexGYoY).HasColumnName("REDevelopmentInvIndexGYoY");
			this.Property(t => t.VacancyAreaIndexCHGYoY).HasColumnName("VacancyAreaIndexCHGYoY");
			this.Property(t => t.LandAreaDevelopedIndexGYoY).HasColumnName("LandAreaDevelopedIndexGYoY");
			this.Property(t => t.NewDevelopedLandAreaIndexGYoY).HasColumnName("NewDevelopedLandAreaIndexGYoY");
			this.Property(t => t.LandTransferIncomeIndexGYoY).HasColumnName("LandTransferIncomeIndexGYoY");
			this.Property(t => t.FinishedBuildingAreaIndexGYoY).HasColumnName("FinishedBuildingAreaIndexGYoY");
			this.Property(t => t.NationProsperityIndexGCP).HasColumnName("NationProsperityIndexGCP");
			this.Property(t => t.CapitalSourceIndexGCP).HasColumnName("CapitalSourceIndexGCP");
			this.Property(t => t.HouseBuildingAreaIndexGCP).HasColumnName("HouseBuildingAreaIndexGCP");
			this.Property(t => t.CommodityHouseSalesIndexGCP).HasColumnName("CommodityHouseSalesIndexGCP");
			this.Property(t => t.REDevelopmentInvIndexGCP).HasColumnName("REDevelopmentInvIndexGCP");
			this.Property(t => t.VacancyAreaIndexCHGCP).HasColumnName("VacancyAreaIndexCHGCP");
			this.Property(t => t.LandAreaDevelopedIndexGCP).HasColumnName("LandAreaDevelopedIndexGCP");
			this.Property(t => t.NewDevelopedLandAreaIndexGCP).HasColumnName("NewDevelopedLandAreaIndexGCP");
			this.Property(t => t.LandTransferIncomeIndexGCP).HasColumnName("LandTransferIncomeIndexGCP");
			this.Property(t => t.FinishedBuildingAreaIndexGCP).HasColumnName("FinishedBuildingAreaIndexGCP");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

