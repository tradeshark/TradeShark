using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_PopulationMap : EntityTypeConfiguration<ED_Population>
	{
		public ED_PopulationMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_Population");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.TotalPopulation).HasColumnName("TotalPopulation");
			this.Property(t => t.MalePopulation).HasColumnName("MalePopulation");
			this.Property(t => t.FemalePopulation).HasColumnName("FemalePopulation");
			this.Property(t => t.UrbanPopulation).HasColumnName("UrbanPopulation");
			this.Property(t => t.RuralPopulation).HasColumnName("RuralPopulation");
			this.Property(t => t.FarmingPopulation).HasColumnName("FarmingPopulation");
			this.Property(t => t.NonFarmingPopulation).HasColumnName("NonFarmingPopulation");
			this.Property(t => t.BirthRate).HasColumnName("BirthRate");
			this.Property(t => t.DeathRate).HasColumnName("DeathRate");
			this.Property(t => t.IncreaseRate).HasColumnName("IncreaseRate");
			this.Property(t => t.Ratio0to14).HasColumnName("Ratio0to14");
			this.Property(t => t.Ratio15to64).HasColumnName("Ratio15to64");
			this.Property(t => t.Ratio65Above).HasColumnName("Ratio65Above");
			this.Property(t => t.TotalBurdenCoefficiency).HasColumnName("TotalBurdenCoefficiency");
			this.Property(t => t.BurdenCoefficiencyOfKids).HasColumnName("BurdenCoefficiencyOfKids");
			this.Property(t => t.BurdenCoefficiencyOfOlder).HasColumnName("BurdenCoefficiencyOfOlder");
			this.Property(t => t.MarriageRegistration).HasColumnName("MarriageRegistration");
			this.Property(t => t.FirstMarriages).HasColumnName("FirstMarriages");
			this.Property(t => t.Remarriages).HasColumnName("Remarriages");
			this.Property(t => t.Divorcements).HasColumnName("Divorcements");
			this.Property(t => t.DivorcementRate).HasColumnName("DivorcementRate");
			this.Property(t => t.JuniorCollegeAndAbove).HasColumnName("JuniorCollegeAndAbove");
			this.Property(t => t.SeniorHSchoolAndTSchool).HasColumnName("SeniorHSchoolAndTSchool");
			this.Property(t => t.JuniorHighSchool).HasColumnName("JuniorHighSchool");
			this.Property(t => t.ElementarySchool).HasColumnName("ElementarySchool");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

