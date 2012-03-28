using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_AShareSeasonedNewIssueMap : EntityTypeConfiguration<LC_AShareSeasonedNewIssue>
	{
		public LC_AShareSeasonedNewIssueMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.PriceIntervalStatement)
				.HasMaxLength(255);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(255);
				
			this.Property(t => t.PrefPlaApplyCodeH)
				.HasMaxLength(10);
				
			this.Property(t => t.PrefPlaApplyAbbrNameH)
				.HasMaxLength(20);
				
			this.Property(t => t.ApplyCodeOnline)
				.HasMaxLength(10);
				
			this.Property(t => t.ApplyAbbrNameOnline)
				.HasMaxLength(20);
				
			this.Property(t => t.OddLotsTreatment)
				.HasMaxLength(255);
				
			this.Property(t => t.ChangeStatement)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_AShareSeasonedNewIssue");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.AdvanceValidStartDate).HasColumnName("AdvanceValidStartDate");
			this.Property(t => t.AdvanceValidEndDate).HasColumnName("AdvanceValidEndDate");
			this.Property(t => t.IntentLetterPublDate).HasColumnName("IntentLetterPublDate");
			this.Property(t => t.ProspectusPublDate).HasColumnName("ProspectusPublDate");
			this.Property(t => t.StockType).HasColumnName("StockType");
			this.Property(t => t.PriceIntervalStatement).HasColumnName("PriceIntervalStatement");
			this.Property(t => t.PricingModel).HasColumnName("PricingModel");
			this.Property(t => t.RationModel).HasColumnName("RationModel");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.IssuePriceCeiling).HasColumnName("IssuePriceCeiling");
			this.Property(t => t.IssuePriceFloor).HasColumnName("IssuePriceFloor");
			this.Property(t => t.ReferringPrice).HasColumnName("ReferringPrice");
			this.Property(t => t.IssueVolCeiling).HasColumnName("IssueVolCeiling");
			this.Property(t => t.IssueVolFloor).HasColumnName("IssueVolFloor");
			this.Property(t => t.OverAllotmentOption).HasColumnName("OverAllotmentOption");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.UnderwritingStartDate).HasColumnName("UnderwritingStartDate");
			this.Property(t => t.UnderwritingEndDate).HasColumnName("UnderwritingEndDate");
			this.Property(t => t.IfExRightAShare).HasColumnName("IfExRightAShare");
			this.Property(t => t.RightRegDate).HasColumnName("RightRegDate");
			this.Property(t => t.ExRightDate).HasColumnName("ExRightDate");
			this.Property(t => t.SuspendStartDate).HasColumnName("SuspendStartDate");
			this.Property(t => t.SuspendEndDate).HasColumnName("SuspendEndDate");
			this.Property(t => t.PrefPlaDateH).HasColumnName("PrefPlaDateH");
			this.Property(t => t.PrefPlaRatioH).HasColumnName("PrefPlaRatioH");
			this.Property(t => t.PrefPlaApplyCodeH).HasColumnName("PrefPlaApplyCodeH");
			this.Property(t => t.PrefPlaApplyAbbrNameH).HasColumnName("PrefPlaApplyAbbrNameH");
			this.Property(t => t.IssueDateOnline).HasColumnName("IssueDateOnline");
			this.Property(t => t.ApplyCodeOnline).HasColumnName("ApplyCodeOnline");
			this.Property(t => t.ApplyAbbrNameOnline).HasColumnName("ApplyAbbrNameOnline");
			this.Property(t => t.ApplyUnitOnline).HasColumnName("ApplyUnitOnline");
			this.Property(t => t.ApplyMaxOnline).HasColumnName("ApplyMaxOnline");
			this.Property(t => t.ApplyStartDateLPOffline).HasColumnName("ApplyStartDateLPOffline");
			this.Property(t => t.ApplyEndDateLPOffline).HasColumnName("ApplyEndDateLPOffline");
			this.Property(t => t.PayStartDateLPOffline).HasColumnName("PayStartDateLPOffline");
			this.Property(t => t.PlaPayEndDateLPOffline).HasColumnName("PlaPayEndDateLPOffline");
			this.Property(t => t.ApplyUnitLPOffline).HasColumnName("ApplyUnitLPOffline");
			this.Property(t => t.ApplyMinLPOffline).HasColumnName("ApplyMinLPOffline");
			this.Property(t => t.ApplyMaxLPOffline).HasColumnName("ApplyMaxLPOffline");
			this.Property(t => t.ValidApplyTimesLPOffline).HasColumnName("ValidApplyTimesLPOffline");
			this.Property(t => t.ApplyStartDateF).HasColumnName("ApplyStartDateF");
			this.Property(t => t.ApplyEndDateF).HasColumnName("ApplyEndDateF");
			this.Property(t => t.PayStartDateF).HasColumnName("PayStartDateF");
			this.Property(t => t.PayEndDateF).HasColumnName("PayEndDateF");
			this.Property(t => t.PrefAllotmentF).HasColumnName("PrefAllotmentF");
			this.Property(t => t.PrefAllotmentSingleF).HasColumnName("PrefAllotmentSingleF");
			this.Property(t => t.STAQNETPlaStartDate).HasColumnName("STAQNETPlaStartDate");
			this.Property(t => t.STAQNETPlaEndDate).HasColumnName("STAQNETPlaEndDate");
			this.Property(t => t.STAQNETPlaRatio).HasColumnName("STAQNETPlaRatio");
			this.Property(t => t.QuotationUnitOnline).HasColumnName("QuotationUnitOnline");
			this.Property(t => t.QuotationUnitOffline).HasColumnName("QuotationUnitOffline");
			this.Property(t => t.OddLotsTreatment).HasColumnName("OddLotsTreatment");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.StateSharesIssuePrice).HasColumnName("StateSharesIssuePrice");
			this.Property(t => t.WeightedPERatio).HasColumnName("WeightedPERatio");
			this.Property(t => t.DilutedPERatio).HasColumnName("DilutedPERatio");
			this.Property(t => t.IssueVol).HasColumnName("IssueVol");
			this.Property(t => t.StateSharesIssued).HasColumnName("StateSharesIssued");
			this.Property(t => t.TotalIssueMV).HasColumnName("TotalIssueMV");
			this.Property(t => t.IssueCost).HasColumnName("IssueCost");
			this.Property(t => t.UnderwritingFee).HasColumnName("UnderwritingFee");
			this.Property(t => t.CPAFee).HasColumnName("CPAFee");
			this.Property(t => t.AssetAppraisalFee).HasColumnName("AssetAppraisalFee");
			this.Property(t => t.LandEvaluationFee).HasColumnName("LandEvaluationFee");
			this.Property(t => t.AttorneyFee).HasColumnName("AttorneyFee");
			this.Property(t => t.TotalAgentFee).HasColumnName("TotalAgentFee");
			this.Property(t => t.OnlineIssueFee).HasColumnName("OnlineIssueFee");
			this.Property(t => t.ScripFee).HasColumnName("ScripFee");
			this.Property(t => t.SponsorFee).HasColumnName("SponsorFee");
			this.Property(t => t.OtherFee).HasColumnName("OtherFee");
			this.Property(t => t.IssueCostPerShare).HasColumnName("IssueCostPerShare");
			this.Property(t => t.FreezedMoney).HasColumnName("FreezedMoney");
			this.Property(t => t.SNIProceeds).HasColumnName("SNIProceeds");
			this.Property(t => t.SNINetProceeds).HasColumnName("SNINetProceeds");
			this.Property(t => t.StateSharesProceeds).HasColumnName("StateSharesProceeds");
			this.Property(t => t.StateSharesNetProceeds).HasColumnName("StateSharesNetProceeds");
			this.Property(t => t.MoneyToAccount).HasColumnName("MoneyToAccount");
			this.Property(t => t.DateToAccount).HasColumnName("DateToAccount");
			this.Property(t => t.NewShareListDate).HasColumnName("NewShareListDate");
			this.Property(t => t.OutstandingShares).HasColumnName("OutstandingShares");
			this.Property(t => t.PutBackVol).HasColumnName("PutBackVol");
			this.Property(t => t.PrefPlaVolH).HasColumnName("PrefPlaVolH");
			this.Property(t => t.PublicOfferVolOnline).HasColumnName("PublicOfferVolOnline");
			this.Property(t => t.ValidApplyVolOnline).HasColumnName("ValidApplyVolOnline");
			this.Property(t => t.ValidApplyNumOnline).HasColumnName("ValidApplyNumOnline");
			this.Property(t => t.OverSubsTimesOnline).HasColumnName("OverSubsTimesOnline");
			this.Property(t => t.LotRateOnline).HasColumnName("LotRateOnline");
			this.Property(t => t.PlaVolLPOffline).HasColumnName("PlaVolLPOffline");
			this.Property(t => t.ValidApplyVolLPOffline).HasColumnName("ValidApplyVolLPOffline");
			this.Property(t => t.ValidApplyNumLPOffline).HasColumnName("ValidApplyNumLPOffline");
			this.Property(t => t.OverSubsTimesLPOffline).HasColumnName("OverSubsTimesLPOffline");
			this.Property(t => t.LotRateLPOffline).HasColumnName("LotRateLPOffline");
			this.Property(t => t.PlaVolF).HasColumnName("PlaVolF");
			this.Property(t => t.PlaVolSTAQNET).HasColumnName("PlaVolSTAQNET");
			this.Property(t => t.TailoredPlaVolLP).HasColumnName("TailoredPlaVolLP");
			this.Property(t => t.EarningForecastYear).HasColumnName("EarningForecastYear");
			this.Property(t => t.MainIncomeForecast).HasColumnName("MainIncomeForecast");
			this.Property(t => t.NetProfitForecast).HasColumnName("NetProfitForecast");
			this.Property(t => t.DilutedEPSForecast).HasColumnName("DilutedEPSForecast");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.ChangeStatement).HasColumnName("ChangeStatement");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.PERatioBeforeIssue).HasColumnName("PERatioBeforeIssue");
			this.Property(t => t.PERatioAfterIssue).HasColumnName("PERatioAfterIssue");
			this.Property(t => t.PrefPlaVolHMax).HasColumnName("PrefPlaVolHMax");
			this.Property(t => t.PrefPlaVolHOnline).HasColumnName("PrefPlaVolHOnline");
			this.Property(t => t.PrefPlaVolHOffline).HasColumnName("PrefPlaVolHOffline");
			this.Property(t => t.ValidApplyHNum).HasColumnName("ValidApplyHNum");
			this.Property(t => t.ValidApplyNumHOnline).HasColumnName("ValidApplyNumHOnline");
			this.Property(t => t.ValidApplyNumHOffline).HasColumnName("ValidApplyNumHOffline");
			this.Property(t => t.APlaVolLPOffline).HasColumnName("APlaVolLPOffline");
			this.Property(t => t.AValidApplyVolLPOffline).HasColumnName("AValidApplyVolLPOffline");
			this.Property(t => t.AValidApplyNumLPOffline).HasColumnName("AValidApplyNumLPOffline");
			this.Property(t => t.ALotRateLPOffline).HasColumnName("ALotRateLPOffline");
			this.Property(t => t.BPlaVolLPOffline).HasColumnName("BPlaVolLPOffline");
			this.Property(t => t.BValidApplyVolLPOffline).HasColumnName("BValidApplyVolLPOffline");
			this.Property(t => t.BValidApplyNumLPOffline).HasColumnName("BValidApplyNumLPOffline");
			this.Property(t => t.BLotRateLPOffline).HasColumnName("BLotRateLPOffline");
			this.Property(t => t.PlaVolHOffline).HasColumnName("PlaVolHOffline");
			this.Property(t => t.ValidPlaVolHOffline).HasColumnName("ValidPlaVolHOffline");
			this.Property(t => t.ValidPlaNumHOffline).HasColumnName("ValidPlaNumHOffline");
			this.Property(t => t.LotRateHOffline).HasColumnName("LotRateHOffline");
		}
	}
}

