using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SHNumberMap : EntityTypeConfiguration<LC_SHNumber>
	{
		public LC_SHNumberMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_SHNumber");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SHNum).HasColumnName("SHNum");
			this.Property(t => t.AverageHoldSum).HasColumnName("AverageHoldSum");
			this.Property(t => t.ASHNum).HasColumnName("ASHNum");
			this.Property(t => t.AAverageHoldSum).HasColumnName("AAverageHoldSum");
			this.Property(t => t.BSHNum).HasColumnName("BSHNum");
			this.Property(t => t.BAverageHoldSum).HasColumnName("BAverageHoldSum");
			this.Property(t => t.HSHNum).HasColumnName("HSHNum");
			this.Property(t => t.HAverageHoldSum).HasColumnName("HAverageHoldSum");
			this.Property(t => t.StaffSHNum).HasColumnName("StaffSHNum");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.HoldProportionPAccount).HasColumnName("HoldProportionPAccount");
			this.Property(t => t.ProportionChange).HasColumnName("ProportionChange");
			this.Property(t => t.AvgHoldSumGRQuarter).HasColumnName("AvgHoldSumGRQuarter");
			this.Property(t => t.ProportionGRQuarter).HasColumnName("ProportionGRQuarter");
			this.Property(t => t.AvgHoldSumGRHalfAYear).HasColumnName("AvgHoldSumGRHalfAYear");
			this.Property(t => t.ProportionGRHalfAYear).HasColumnName("ProportionGRHalfAYear");
			this.Property(t => t.AHoldProportionPAccount).HasColumnName("AHoldProportionPAccount");
			this.Property(t => t.AProportionChange).HasColumnName("AProportionChange");
			this.Property(t => t.AAvgHoldSumGRQuarter).HasColumnName("AAvgHoldSumGRQuarter");
			this.Property(t => t.AProportionGRQuarter).HasColumnName("AProportionGRQuarter");
			this.Property(t => t.AAvgHoldSumGRHalfAYear).HasColumnName("AAvgHoldSumGRHalfAYear");
			this.Property(t => t.AProportionGRHalfAYear).HasColumnName("AProportionGRHalfAYear");
			this.Property(t => t.AFAverageHoldSum).HasColumnName("AFAverageHoldSum");
			this.Property(t => t.AFHoldProportionPAccount).HasColumnName("AFHoldProportionPAccount");
			this.Property(t => t.AFProportionChange).HasColumnName("AFProportionChange");
			this.Property(t => t.AFAvgHoldSumGRQuarter).HasColumnName("AFAvgHoldSumGRQuarter");
			this.Property(t => t.AFProportionGRQuarter).HasColumnName("AFProportionGRQuarter");
			this.Property(t => t.AFAvgHoldSumGRHalfAYear).HasColumnName("AFAvgHoldSumGRHalfAYear");
			this.Property(t => t.AFProportionGRHalfAYear).HasColumnName("AFProportionGRHalfAYear");
			this.Property(t => t.BHoldProportionPAccount).HasColumnName("BHoldProportionPAccount");
			this.Property(t => t.BProportionChange).HasColumnName("BProportionChange");
			this.Property(t => t.BAvgHoldSumGRQuarter).HasColumnName("BAvgHoldSumGRQuarter");
			this.Property(t => t.BProportionGRQuarter).HasColumnName("BProportionGRQuarter");
			this.Property(t => t.BAvgHoldSumGRHalfAYear).HasColumnName("BAvgHoldSumGRHalfAYear");
			this.Property(t => t.BProportionGRHalfAYear).HasColumnName("BProportionGRHalfAYear");
			this.Property(t => t.HHoldProportionPAccount).HasColumnName("HHoldProportionPAccount");
			this.Property(t => t.HProportionChange).HasColumnName("HProportionChange");
			this.Property(t => t.HAvgHoldSumGRQuarter).HasColumnName("HAvgHoldSumGRQuarter");
			this.Property(t => t.HProportionGRQuarter).HasColumnName("HProportionGRQuarter");
			this.Property(t => t.HAvgHoldSumGRHalfAYear).HasColumnName("HAvgHoldSumGRHalfAYear");
			this.Property(t => t.HProportionGRHalfAYear).HasColumnName("HProportionGRHalfAYear");
		}
	}
}

