using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CBIssueMap : EntityTypeConfiguration<LC_CBIssue>
	{
		public LC_CBIssueMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.CBCode)
				.HasMaxLength(10);
				
			this.Property(t => t.IssueMethod)
				.HasMaxLength(50);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(255);
				
			this.Property(t => t.UnderwritingMethod)
				.HasMaxLength(10);
				
			this.Property(t => t.PrefPlaCodeH)
				.HasMaxLength(10);
				
			this.Property(t => t.PrefPlaNameH)
				.HasMaxLength(10);
				
			this.Property(t => t.ApplyCodeOnline)
				.HasMaxLength(10);
				
			this.Property(t => t.ApplyNameOnline)
				.HasMaxLength(10);
				
			this.Property(t => t.SchemeChangeStatement)
				.HasMaxLength(255);
				
			this.Property(t => t.SchemeChangeType)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("LC_CBIssue");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CBCode).HasColumnName("CBCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.ValidStartDate).HasColumnName("ValidStartDate");
			this.Property(t => t.ValidEndDate).HasColumnName("ValidEndDate");
			this.Property(t => t.LowerLimit).HasColumnName("LowerLimit");
			this.Property(t => t.UpperLimit).HasColumnName("UpperLimit");
			this.Property(t => t.ProspectusIssueDate).HasColumnName("ProspectusIssueDate");
			this.Property(t => t.ListAnnouncementDate).HasColumnName("ListAnnouncementDate");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.ActualIssueSize).HasColumnName("ActualIssueSize");
			this.Property(t => t.IssueVol).HasColumnName("IssueVol");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.UnderwritingMethod).HasColumnName("UnderwritingMethod");
			this.Property(t => t.UnderwritingStartDate).HasColumnName("UnderwritingStartDate");
			this.Property(t => t.UnderwritingEndDate).HasColumnName("UnderwritingEndDate");
			this.Property(t => t.PrefPlaCodeH).HasColumnName("PrefPlaCodeH");
			this.Property(t => t.PrefPlaNameH).HasColumnName("PrefPlaNameH");
			this.Property(t => t.PrefPlaRightRegDateH).HasColumnName("PrefPlaRightRegDateH");
			this.Property(t => t.PayStartDateH).HasColumnName("PayStartDateH");
			this.Property(t => t.PayEndDateH).HasColumnName("PayEndDateH");
			this.Property(t => t.PrefPlaRatioH).HasColumnName("PrefPlaRatioH");
			this.Property(t => t.PrefPlaUnitH).HasColumnName("PrefPlaUnitH");
			this.Property(t => t.PrefPlaSizeH).HasColumnName("PrefPlaSizeH");
			this.Property(t => t.PlaSizeF).HasColumnName("PlaSizeF");
			this.Property(t => t.PlaPayStartDateF).HasColumnName("PlaPayStartDateF");
			this.Property(t => t.PlaPayEndDateF).HasColumnName("PlaPayEndDateF");
			this.Property(t => t.PlaSizeLP).HasColumnName("PlaSizeLP");
			this.Property(t => t.PlaPayStartDateLP).HasColumnName("PlaPayStartDateLP");
			this.Property(t => t.PlaPayEndDateLP).HasColumnName("PlaPayEndDateLP");
			this.Property(t => t.ApplyCodeOnline).HasColumnName("ApplyCodeOnline");
			this.Property(t => t.ApplyNameOnline).HasColumnName("ApplyNameOnline");
			this.Property(t => t.IssueDateOnline).HasColumnName("IssueDateOnline");
			this.Property(t => t.IssueSumOnline).HasColumnName("IssueSumOnline");
			this.Property(t => t.ApplyUnitOnline).HasColumnName("ApplyUnitOnline");
			this.Property(t => t.ApplyMaxOnline).HasColumnName("ApplyMaxOnline");
			this.Property(t => t.ValidApplyVolOnline).HasColumnName("ValidApplyVolOnline");
			this.Property(t => t.ValidApplyNumOnline).HasColumnName("ValidApplyNumOnline");
			this.Property(t => t.OverSubsTimesOnline).HasColumnName("OverSubsTimesOnline");
			this.Property(t => t.LotRateOnline).HasColumnName("LotRateOnline");
			this.Property(t => t.ValidApplyVolOffline).HasColumnName("ValidApplyVolOffline");
			this.Property(t => t.ValidApplyNumOffline).HasColumnName("ValidApplyNumOffline");
			this.Property(t => t.OverSubsTimesOffline).HasColumnName("OverSubsTimesOffline");
			this.Property(t => t.LotRateOffline).HasColumnName("LotRateOffline");
			this.Property(t => t.PrefPlaValidApplyVolH).HasColumnName("PrefPlaValidApplyVolH");
			this.Property(t => t.PrefPlaValidApplyNumH).HasColumnName("PrefPlaValidApplyNumH");
			this.Property(t => t.PrefPlaOverSubsTimeH).HasColumnName("PrefPlaOverSubsTimeH");
			this.Property(t => t.PrefPlaLotRateH).HasColumnName("PrefPlaLotRateH");
			this.Property(t => t.ListDate).HasColumnName("ListDate");
			this.Property(t => t.Proceeds).HasColumnName("Proceeds");
			this.Property(t => t.IssueCost).HasColumnName("IssueCost");
			this.Property(t => t.NetProceeds).HasColumnName("NetProceeds");
			this.Property(t => t.UnderwriterboughtVolume).HasColumnName("UnderwriterboughtVolume");
			this.Property(t => t.ProfitForecastYear).HasColumnName("ProfitForecastYear");
			this.Property(t => t.RevenueForecast).HasColumnName("RevenueForecast");
			this.Property(t => t.NetProfitForecast).HasColumnName("NetProfitForecast");
			this.Property(t => t.EPSForecast).HasColumnName("EPSForecast");
			this.Property(t => t.SchemeChangeStatement).HasColumnName("SchemeChangeStatement");
			this.Property(t => t.SchemeChangeType).HasColumnName("SchemeChangeType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

