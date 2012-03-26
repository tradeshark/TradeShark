using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_KZZ_FXSSMap : EntityTypeConfiguration<VIEW_KZZ_FXSS>
	{
		public VIEW_KZZ_FXSSMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ });

			// Properties
			this.Property(t => t.N_UnderwritingMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_SchemeChangeType)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(500);
				
			this.Property(t => t.GuarantMethod)
				.HasMaxLength(200);
				
			this.Property(t => t.CreditRating)
				.HasMaxLength(50);
				
			this.Property(t => t.UnderwritingMethod)
				.HasMaxLength(100);
				
			this.Property(t => t.PrefAltNameH)
				.HasMaxLength(20);
				
			this.Property(t => t.OnLinePubOffName)
				.HasMaxLength(20);
				
			this.Property(t => t.SchemeChangeStatement)
				.HasMaxLength(300);
				
			// Table & Column Mappings
			this.ToTable("VIEW_KZZ_FXSS");
			this.Property(t => t.N_UnderwritingMethod).HasColumnName("N_UnderwritingMethod");
			this.Property(t => t.N_SchemeChangeType).HasColumnName("N_SchemeChangeType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.ValidStartDate).HasColumnName("ValidStartDate");
			this.Property(t => t.ValidEndDate).HasColumnName("ValidEndDate");
			this.Property(t => t.IssueSizePlanned).HasColumnName("IssueSizePlanned");
			this.Property(t => t.LowerLimit).HasColumnName("LowerLimit");
			this.Property(t => t.UpperLimit).HasColumnName("UpperLimit");
			this.Property(t => t.ProspectusIssueDate).HasColumnName("ProspectusIssueDate");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.ActualIssueSize).HasColumnName("ActualIssueSize");
			this.Property(t => t.IssueVol).HasColumnName("IssueVol");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.GuarantMethod).HasColumnName("GuarantMethod");
			this.Property(t => t.CreditRating).HasColumnName("CreditRating");
			this.Property(t => t.UnderwritingMethod).HasColumnName("UnderwritingMethod");
			this.Property(t => t.ApplyingDate).HasColumnName("ApplyingDate");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.UnderwritingStartDate).HasColumnName("UnderwritingStartDate");
			this.Property(t => t.UnderwritingEndDate).HasColumnName("UnderwritingEndDate");
			this.Property(t => t.PrefAltCodeH).HasColumnName("PrefAltCodeH");
			this.Property(t => t.PrefAltNameH).HasColumnName("PrefAltNameH");
			this.Property(t => t.PrefAltRegDateH).HasColumnName("PrefAltRegDateH");
			this.Property(t => t.PrefAltPayStartDateH).HasColumnName("PrefAltPayStartDateH");
			this.Property(t => t.PrefAltPayEndDateH).HasColumnName("PrefAltPayEndDateH");
			this.Property(t => t.PrefAltProportionH).HasColumnName("PrefAltProportionH");
			this.Property(t => t.PrefAltUnitH).HasColumnName("PrefAltUnitH");
			this.Property(t => t.PrefAltSizeH).HasColumnName("PrefAltSizeH");
			this.Property(t => t.AltSizeF).HasColumnName("AltSizeF");
			this.Property(t => t.AltPayStartDateF).HasColumnName("AltPayStartDateF");
			this.Property(t => t.AltPayEndDateF).HasColumnName("AltPayEndDateF");
			this.Property(t => t.AltSizeI).HasColumnName("AltSizeI");
			this.Property(t => t.AltPayStartDateI).HasColumnName("AltPayStartDateI");
			this.Property(t => t.AltPayEndDateI).HasColumnName("AltPayEndDateI");
			this.Property(t => t.OnLinePubOffDate).HasColumnName("OnLinePubOffDate");
			this.Property(t => t.OnLinePubOffSize).HasColumnName("OnLinePubOffSize");
			this.Property(t => t.OnLinePubOffCode).HasColumnName("OnLinePubOffCode");
			this.Property(t => t.OnLinePubOffName).HasColumnName("OnLinePubOffName");
			this.Property(t => t.OnLinePubOffUnit).HasColumnName("OnLinePubOffUnit");
			this.Property(t => t.OnLinePubOffApplyCap).HasColumnName("OnLinePubOffApplyCap");
			this.Property(t => t.PrefAltValidApplyVolH).HasColumnName("PrefAltValidApplyVolH");
			this.Property(t => t.PrefAltValidApplyNumH).HasColumnName("PrefAltValidApplyNumH");
			this.Property(t => t.PrefAltOverSubsTimeH).HasColumnName("PrefAltOverSubsTimeH");
			this.Property(t => t.PrefAltRatioH).HasColumnName("PrefAltRatioH");
			this.Property(t => t.OnLinePubOffValidApplyVol).HasColumnName("OnLinePubOffValidApplyVol");
			this.Property(t => t.OnLinePubOffValidApplyNum).HasColumnName("OnLinePubOffValidApplyNum");
			this.Property(t => t.OnLinePubOffOverSubsTime).HasColumnName("OnLinePubOffOverSubsTime");
			this.Property(t => t.OnLinePubOffRatio).HasColumnName("OnLinePubOffRatio");
			this.Property(t => t.OffLinePubOffValidApplyVolI).HasColumnName("OffLinePubOffValidApplyVolI");
			this.Property(t => t.OffLinePubOffValidApplyNumI).HasColumnName("OffLinePubOffValidApplyNumI");
			this.Property(t => t.OffLinePubOffOverSubsTimeI).HasColumnName("OffLinePubOffOverSubsTimeI");
			this.Property(t => t.OffLinePubOffRatioI).HasColumnName("OffLinePubOffRatioI");
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
		}
	}
}

