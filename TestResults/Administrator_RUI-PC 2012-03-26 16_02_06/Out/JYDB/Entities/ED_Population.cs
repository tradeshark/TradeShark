using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_Population
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Country { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> TotalPopulation { get; set; }
		public Nullable<decimal> MalePopulation { get; set; }
		public Nullable<decimal> FemalePopulation { get; set; }
		public Nullable<decimal> UrbanPopulation { get; set; }
		public Nullable<decimal> RuralPopulation { get; set; }
		public Nullable<decimal> FarmingPopulation { get; set; }
		public Nullable<decimal> NonFarmingPopulation { get; set; }
		public Nullable<decimal> BirthRate { get; set; }
		public Nullable<decimal> DeathRate { get; set; }
		public Nullable<decimal> IncreaseRate { get; set; }
		public Nullable<decimal> Ratio0to14 { get; set; }
		public Nullable<decimal> Ratio15to64 { get; set; }
		public Nullable<decimal> Ratio65Above { get; set; }
		public Nullable<decimal> TotalBurdenCoefficiency { get; set; }
		public Nullable<decimal> BurdenCoefficiencyOfKids { get; set; }
		public Nullable<decimal> BurdenCoefficiencyOfOlder { get; set; }
		public Nullable<decimal> MarriageRegistration { get; set; }
		public Nullable<decimal> FirstMarriages { get; set; }
		public Nullable<decimal> Remarriages { get; set; }
		public Nullable<decimal> Divorcements { get; set; }
		public Nullable<decimal> DivorcementRate { get; set; }
		public Nullable<decimal> JuniorCollegeAndAbove { get; set; }
		public Nullable<decimal> SeniorHSchoolAndTSchool { get; set; }
		public Nullable<decimal> JuniorHighSchool { get; set; }
		public Nullable<decimal> ElementarySchool { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

