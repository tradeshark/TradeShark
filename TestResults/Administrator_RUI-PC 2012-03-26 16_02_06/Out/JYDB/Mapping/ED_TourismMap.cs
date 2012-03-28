using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_TourismMap : EntityTypeConfiguration<ED_Tourism>
	{
		public ED_TourismMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_Tourism");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.AgencyNumber).HasColumnName("AgencyNumber");
			this.Property(t => t.IAgencyNumber).HasColumnName("IAgencyNumber");
			this.Property(t => t.DAgencyNumber).HasColumnName("DAgencyNumber");
			this.Property(t => t.AgencyWorkers).HasColumnName("AgencyWorkers");
			this.Property(t => t.IAgencyWorkers).HasColumnName("IAgencyWorkers");
			this.Property(t => t.DAgencyWorkers).HasColumnName("DAgencyWorkers");
			this.Property(t => t.ForeignRelatedRestaurants).HasColumnName("ForeignRelatedRestaurants");
			this.Property(t => t.TotalTravelersAbroad).HasColumnName("TotalTravelersAbroad");
			this.Property(t => t.PersonalTravelersAbroad).HasColumnName("PersonalTravelersAbroad");
			this.Property(t => t.TotalDPersonTimes).HasColumnName("TotalDPersonTimes");
			this.Property(t => t.URPersonTimes).HasColumnName("URPersonTimes");
			this.Property(t => t.RRPersonTimes).HasColumnName("RRPersonTimes");
			this.Property(t => t.TotalDExpenditure).HasColumnName("TotalDExpenditure");
			this.Property(t => t.URExpenditure).HasColumnName("URExpenditure");
			this.Property(t => t.RRExpenditure).HasColumnName("RRExpenditure");
			this.Property(t => t.AverageDExpenditure).HasColumnName("AverageDExpenditure");
			this.Property(t => t.AverageURExpenditure).HasColumnName("AverageURExpenditure");
			this.Property(t => t.AverageRRExpenditure).HasColumnName("AverageRRExpenditure");
			this.Property(t => t.EnterCountryNum).HasColumnName("EnterCountryNum");
			this.Property(t => t.EnterCountryNumOC).HasColumnName("EnterCountryNumOC");
			this.Property(t => t.EnterCountryNumF).HasColumnName("EnterCountryNumF");
			this.Property(t => t.EnterCountryNumHK).HasColumnName("EnterCountryNumHK");
			this.Property(t => t.EnterCountryNumMC).HasColumnName("EnterCountryNumMC");
			this.Property(t => t.EnterCountryNumTW).HasColumnName("EnterCountryNumTW");
			this.Property(t => t.EnterCountryNumGYoY).HasColumnName("EnterCountryNumGYoY");
			this.Property(t => t.EnterCountryNumOCGYoY).HasColumnName("EnterCountryNumOCGYoY");
			this.Property(t => t.EnterCountryNumFGYoY).HasColumnName("EnterCountryNumFGYoY");
			this.Property(t => t.EnterCountryNumHKGYoY).HasColumnName("EnterCountryNumHKGYoY");
			this.Property(t => t.EnterCountryNumMCGYoY).HasColumnName("EnterCountryNumMCGYoY");
			this.Property(t => t.EnterCountryNumTWGYoY).HasColumnName("EnterCountryNumTWGYoY");
			this.Property(t => t.ECStayoverNum).HasColumnName("ECStayoverNum");
			this.Property(t => t.ECStayoverNumOC).HasColumnName("ECStayoverNumOC");
			this.Property(t => t.ECStayoverNumF).HasColumnName("ECStayoverNumF");
			this.Property(t => t.ECStayoverNumHK).HasColumnName("ECStayoverNumHK");
			this.Property(t => t.ECStayoverNumMC).HasColumnName("ECStayoverNumMC");
			this.Property(t => t.ECStayoverNumTW).HasColumnName("ECStayoverNumTW");
			this.Property(t => t.ECStayoverNumGYoY).HasColumnName("ECStayoverNumGYoY");
			this.Property(t => t.ECStayoverNumOCGYoY).HasColumnName("ECStayoverNumOCGYoY");
			this.Property(t => t.ECStayoverNumFGYoY).HasColumnName("ECStayoverNumFGYoY");
			this.Property(t => t.ECStayoverNumHKGYoY).HasColumnName("ECStayoverNumHKGYoY");
			this.Property(t => t.ECStayoverNumMCGYoY).HasColumnName("ECStayoverNumMCGYoY");
			this.Property(t => t.ECStayoverNumTWGYoY).HasColumnName("ECStayoverNumTWGYoY");
			this.Property(t => t.IServedBy3BAgencies).HasColumnName("IServedBy3BAgencies");
			this.Property(t => t.ChinaIntlTravelAgency).HasColumnName("ChinaIntlTravelAgency");
			this.Property(t => t.ChinaTravelAgency).HasColumnName("ChinaTravelAgency");
			this.Property(t => t.ChinaYouthTravelAgency).HasColumnName("ChinaYouthTravelAgency");
			this.Property(t => t.TotalIFXIncome).HasColumnName("TotalIFXIncome");
			this.Property(t => t.IFXIncomeDIndex).HasColumnName("IFXIncomeDIndex");
			this.Property(t => t.IFXIncomeGYoY).HasColumnName("IFXIncomeGYoY");
			this.Property(t => t.LDistanceFXIncome).HasColumnName("LDistanceFXIncome");
			this.Property(t => t.AirlinesFXIncome).HasColumnName("AirlinesFXIncome");
			this.Property(t => t.RailwayFXIncome).HasColumnName("RailwayFXIncome");
			this.Property(t => t.AutomobileFXIncome).HasColumnName("AutomobileFXIncome");
			this.Property(t => t.ShipFXIncome).HasColumnName("ShipFXIncome");
			this.Property(t => t.SightseeingFXIncome).HasColumnName("SightseeingFXIncome");
			this.Property(t => t.AccommodationFXIncome).HasColumnName("AccommodationFXIncome");
			this.Property(t => t.FoodBeverageFXIncome).HasColumnName("FoodBeverageFXIncome");
			this.Property(t => t.GoodsSalesFXIncome).HasColumnName("GoodsSalesFXIncome");
			this.Property(t => t.EntertaimentFXIncome).HasColumnName("EntertaimentFXIncome");
			this.Property(t => t.PostTelecomFXIncome).HasColumnName("PostTelecomFXIncome");
			this.Property(t => t.CityTrafficFXIncome).HasColumnName("CityTrafficFXIncome");
			this.Property(t => t.OtherFXIncome).HasColumnName("OtherFXIncome");
			this.Property(t => t.OCFXIncome).HasColumnName("OCFXIncome");
			this.Property(t => t.FFXIncome).HasColumnName("FFXIncome");
			this.Property(t => t.HKFXIncome).HasColumnName("HKFXIncome");
			this.Property(t => t.MCFXIncome).HasColumnName("MCFXIncome");
			this.Property(t => t.TWFXIncome).HasColumnName("TWFXIncome");
			this.Property(t => t.OCFXIncomeGYoY).HasColumnName("OCFXIncomeGYoY");
			this.Property(t => t.FFXIncomeGYoY).HasColumnName("FFXIncomeGYoY");
			this.Property(t => t.HKFXIncomeGYoY).HasColumnName("HKFXIncomeGYoY");
			this.Property(t => t.MCFXIncomeGYoY).HasColumnName("MCFXIncomeGYoY");
			this.Property(t => t.TWFXIncomeGYoY).HasColumnName("TWFXIncomeGYoY");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

