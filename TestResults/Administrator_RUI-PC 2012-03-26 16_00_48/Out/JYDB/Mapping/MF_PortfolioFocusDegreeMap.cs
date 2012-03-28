using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_PortfolioFocusDegreeMap : EntityTypeConfiguration<MF_PortfolioFocusDegree>
	{
		public MF_PortfolioFocusDegreeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_PortfolioFocusDegree");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.TopThreeInduMV).HasColumnName("TopThreeInduMV");
			this.Property(t => t.TopThreeInduRatioInNV).HasColumnName("TopThreeInduRatioInNV");
			this.Property(t => t.TopThreeInduRatioInSMV).HasColumnName("TopThreeInduRatioInSMV");
			this.Property(t => t.TopFiveInduMV).HasColumnName("TopFiveInduMV");
			this.Property(t => t.TopFiveInduRatioInNV).HasColumnName("TopFiveInduRatioInNV");
			this.Property(t => t.TopFiveInduRatioInSMV).HasColumnName("TopFiveInduRatioInSMV");
			this.Property(t => t.TopEightInduMV).HasColumnName("TopEightInduMV");
			this.Property(t => t.TopEightInduRatioInNV).HasColumnName("TopEightInduRatioInNV");
			this.Property(t => t.TopEightInduRatioInSMV).HasColumnName("TopEightInduRatioInSMV");
			this.Property(t => t.TopThreeShareMV).HasColumnName("TopThreeShareMV");
			this.Property(t => t.TopThreeShareRatioInNV).HasColumnName("TopThreeShareRatioInNV");
			this.Property(t => t.TopThreeShareRatioInSMV).HasColumnName("TopThreeShareRatioInSMV");
			this.Property(t => t.TopFiveShareMV).HasColumnName("TopFiveShareMV");
			this.Property(t => t.TopFiveShareRatioInNV).HasColumnName("TopFiveShareRatioInNV");
			this.Property(t => t.TopFiveShareRatioInSMV).HasColumnName("TopFiveShareRatioInSMV");
			this.Property(t => t.TopTenShareMV).HasColumnName("TopTenShareMV");
			this.Property(t => t.TopTenShareRatioInNV).HasColumnName("TopTenShareRatioInNV");
			this.Property(t => t.TopTenShareRatioInSMV).HasColumnName("TopTenShareRatioInSMV");
			this.Property(t => t.TopPositiveThreeShareMV).HasColumnName("TopPositiveThreeShareMV");
			this.Property(t => t.TopThreeShareRatioInPSMV).HasColumnName("TopThreeShareRatioInPSMV");
			this.Property(t => t.TopPositiveFiveShareMV).HasColumnName("TopPositiveFiveShareMV");
			this.Property(t => t.TopfiveShareRatioInPSMV).HasColumnName("TopfiveShareRatioInPSMV");
			this.Property(t => t.TopExponentialThreeShareMV).HasColumnName("TopExponentialThreeShareMV");
			this.Property(t => t.TopThreeShareRatioInESMV).HasColumnName("TopThreeShareRatioInESMV");
			this.Property(t => t.TopExponentialFiveShareMV).HasColumnName("TopExponentialFiveShareMV");
			this.Property(t => t.TopFiveeShareRatioInESMV).HasColumnName("TopFiveeShareRatioInESMV");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

