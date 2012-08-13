using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_LC_BShareIPOMap : EntityTypeConfiguration<View_GP_LC_BShareIPO>
	{
		public View_GP_LC_BShareIPOMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InitialInfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.SecuCode)
				.HasMaxLength(10);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.ChiName)
				.HasMaxLength(200);
				
			this.Property(t => t.EngName)
				.HasMaxLength(200);
				
			this.Property(t => t.N_State)
				.HasMaxLength(300);
				
			this.Property(t => t.JY_InduCSRC)
				.HasMaxLength(50);
				
			this.Property(t => t.证监会三级行业代码)
				.HasMaxLength(10);
				
			this.Property(t => t.N3_InduCSRC)
				.HasMaxLength(50);
				
			this.Property(t => t.证监会二级行业代码)
				.HasMaxLength(6);
				
			this.Property(t => t.N2_InduCSRC)
				.HasMaxLength(50);
				
			this.Property(t => t.N1_InduCSRC)
				.HasMaxLength(50);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.StockType)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(255);
				
			this.Property(t => t.DividendPolicy)
				.HasMaxLength(100);
				
			this.Property(t => t.EstimatedFirstDiviDate)
				.HasMaxLength(50);
				
			this.Property(t => t.SecuMarket)
				.HasMaxLength(300);
				
			// Table & Column Mappings
			this.ToTable("View_GP_LC_BShareIPO");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EngName).HasColumnName("EngName");
			this.Property(t => t.N_State).HasColumnName("N_State");
			this.Property(t => t.JY_InduCSRC).HasColumnName("JY_InduCSRC");
			this.Property(t => t.证监会三级行业代码).HasColumnName("证监会三级行业代码");
			this.Property(t => t.N3_InduCSRC).HasColumnName("N3_InduCSRC");
			this.Property(t => t.证监会二级行业代码).HasColumnName("证监会二级行业代码");
			this.Property(t => t.N2_InduCSRC).HasColumnName("N2_InduCSRC");
			this.Property(t => t.N1_InduCSRC).HasColumnName("N1_InduCSRC");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.IntentLetterPublDate).HasColumnName("IntentLetterPublDate");
			this.Property(t => t.ProspectusPublDate).HasColumnName("ProspectusPublDate");
			this.Property(t => t.ListAnnouncementDate).HasColumnName("ListAnnouncementDate");
			this.Property(t => t.RaisingMethod).HasColumnName("RaisingMethod");
			this.Property(t => t.StockType).HasColumnName("StockType");
			this.Property(t => t.ParValueRMB).HasColumnName("ParValueRMB");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.IssuePriceRMB).HasColumnName("IssuePriceRMB");
			this.Property(t => t.IssuePriceFC).HasColumnName("IssuePriceFC");
			this.Property(t => t.WeightedPERatio).HasColumnName("WeightedPERatio");
			this.Property(t => t.DilutedPERatio).HasColumnName("DilutedPERatio");
			this.Property(t => t.StraInvestorPlaPriceFC).HasColumnName("StraInvestorPlaPriceFC");
			this.Property(t => t.IssueVolPlanned).HasColumnName("IssueVolPlanned");
			this.Property(t => t.OverAllotmentOption).HasColumnName("OverAllotmentOption");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.PlaStartDate).HasColumnName("PlaStartDate");
			this.Property(t => t.PlaEndDate).HasColumnName("PlaEndDate");
			this.Property(t => t.PayStartDate).HasColumnName("PayStartDate");
			this.Property(t => t.PayEndDate).HasColumnName("PayEndDate");
			this.Property(t => t.UnderwritingStartDate).HasColumnName("UnderwritingStartDate");
			this.Property(t => t.UnderwritingEndDate).HasColumnName("UnderwritingEndDate");
			this.Property(t => t.PreparedListExchange).HasColumnName("PreparedListExchange");
			this.Property(t => t.DividendPolicy).HasColumnName("DividendPolicy");
			this.Property(t => t.EstimatedFirstDiviDate).HasColumnName("EstimatedFirstDiviDate");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.ActualIssueVol).HasColumnName("ActualIssueVol");
			this.Property(t => t.TotalIssueMVRMB).HasColumnName("TotalIssueMVRMB");
			this.Property(t => t.IssueCostRMB).HasColumnName("IssueCostRMB");
			this.Property(t => t.IPOProceedsRMB).HasColumnName("IPOProceedsRMB");
			this.Property(t => t.IPONetProceedsRMB).HasColumnName("IPONetProceedsRMB");
			this.Property(t => t.IssueCostPerShareRMB).HasColumnName("IssueCostPerShareRMB");
			this.Property(t => t.TotalIssueMVFC).HasColumnName("TotalIssueMVFC");
			this.Property(t => t.IssueCostFC).HasColumnName("IssueCostFC");
			this.Property(t => t.IPOProceedsFC).HasColumnName("IPOProceedsFC");
			this.Property(t => t.IPONetProceedsFC).HasColumnName("IPONetProceedsFC");
			this.Property(t => t.IssueCostPerShareFC).HasColumnName("IssueCostPerShareFC");
			this.Property(t => t.DateToAccount).HasColumnName("DateToAccount");
			this.Property(t => t.ListDate).HasColumnName("ListDate");
			this.Property(t => t.OutstandingShares).HasColumnName("OutstandingShares");
			this.Property(t => t.StraInvestorPlaVol).HasColumnName("StraInvestorPlaVol");
			this.Property(t => t.PlaNum).HasColumnName("PlaNum");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.FirstOpenPrice).HasColumnName("FirstOpenPrice");
			this.Property(t => t.FirstClosePrice).HasColumnName("FirstClosePrice");
			this.Property(t => t.FirstTurnover).HasColumnName("FirstTurnover");
			this.Property(t => t.EarningForecastYear).HasColumnName("EarningForecastYear");
			this.Property(t => t.MainIncomeForecast).HasColumnName("MainIncomeForecast");
			this.Property(t => t.NetProfitForecast).HasColumnName("NetProfitForecast");
			this.Property(t => t.DilutedEPSForecast).HasColumnName("DilutedEPSForecast");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
		}
	}
}

