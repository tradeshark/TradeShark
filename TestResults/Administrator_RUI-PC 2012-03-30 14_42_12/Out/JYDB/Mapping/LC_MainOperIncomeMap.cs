using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_MainOperIncomeMap : EntityTypeConfiguration<LC_MainOperIncome>
	{
		public LC_MainOperIncomeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Project)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_MainOperIncome");
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
		}
	}
}

