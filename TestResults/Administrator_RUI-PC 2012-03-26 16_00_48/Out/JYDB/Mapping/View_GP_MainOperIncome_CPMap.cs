using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_MainOperIncome_CPMap : EntityTypeConfiguration<View_GP_MainOperIncome_CP>
	{
		public View_GP_MainOperIncome_CPMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_Industry)
				.HasMaxLength(50);
				
			this.Property(t => t.N_RegionAndBusiness)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Classification)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfAdjusted)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.N_DateType)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Project)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("View_GP_MainOperIncome_CP");
			this.Property(t => t.N_Industry).HasColumnName("N_Industry");
			this.Property(t => t.N_RegionAndBusiness).HasColumnName("N_RegionAndBusiness");
			this.Property(t => t.N_Classification).HasColumnName("N_Classification");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_DateType).HasColumnName("N_DateType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.DateType).HasColumnName("DateType");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.Classification).HasColumnName("Classification");
			this.Property(t => t.SN).HasColumnName("SN");
			this.Property(t => t.Project).HasColumnName("Project");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.RegionAndBusiness).HasColumnName("RegionAndBusiness");
			this.Property(t => t.MainOperIncome).HasColumnName("MainOperIncome");
			this.Property(t => t.MainOperCost).HasColumnName("MainOperCost");
			this.Property(t => t.MainOperProfit).HasColumnName("MainOperProfit");
			this.Property(t => t.MainOperIncomeFormerYear).HasColumnName("MainOperIncomeFormerYear");
			this.Property(t => t.MainOperCostFormerYear).HasColumnName("MainOperCostFormerYear");
			this.Property(t => t.MainOperProfitFormerYear).HasColumnName("MainOperProfitFormerYear");
			this.Property(t => t.MainIncomeGrowRateYOY).HasColumnName("MainIncomeGrowRateYOY");
			this.Property(t => t.MainICostGrowRateYOY).HasColumnName("MainICostGrowRateYOY");
			this.Property(t => t.MainProfitGrowRateYOY).HasColumnName("MainProfitGrowRateYOY");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ZYML).HasColumnName("ZYML");
			this.Property(t => t.ZYMLL).HasColumnName("ZYMLL");
		}
	}
}

