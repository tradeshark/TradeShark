using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_LC_AShareIPOMap : EntityTypeConfiguration<View_GP_LC_AShareIPO>
	{
		public View_GP_LC_AShareIPOMap()
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
				.HasMaxLength(255);
				
			this.Property(t => t.EstimatedFirstDiviDate)
				.HasMaxLength(100);
				
			this.Property(t => t.IssueNameAbbr_Online)
				.HasMaxLength(20);
				
			this.Property(t => t.SecuMarket)
				.HasMaxLength(300);
				
			// Table & Column Mappings
			this.ToTable("View_GP_LC_AShareIPO");
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
			this.Property(t => t.IntentLetterSignDate).HasColumnName("IntentLetterSignDate");
			this.Property(t => t.ProspectusPublDate).HasColumnName("ProspectusPublDate");
			this.Property(t => t.ProspectusSignDate).HasColumnName("ProspectusSignDate");
			this.Property(t => t.ListAnnouncementDate).HasColumnName("ListAnnouncementDate");
			this.Property(t => t.RaisingMethod).HasColumnName("RaisingMethod");
			this.Property(t => t.StockType).HasColumnName("StockType");
			this.Property(t => t.IssuePriceCeiling).HasColumnName("IssuePriceCeiling");
			this.Property(t => t.IssuePriceFloor).HasColumnName("IssuePriceFloor");
			this.Property(t => t.IssueVolCeiling).HasColumnName("IssueVolCeiling");
			this.Property(t => t.IssueVolFloor).HasColumnName("IssueVolFloor");
			this.Property(t => t.OverAllotmentOption).HasColumnName("OverAllotmentOption");
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
			this.Property(t => t.IPOProceeds).HasColumnName("IPOProceeds");
			this.Property(t => t.IPONetProceeds).HasColumnName("IPONetProceeds");
			this.Property(t => t.StateSharesProceeds).HasColumnName("StateSharesProceeds");
			this.Property(t => t.StateSharesNetProceeds).HasColumnName("StateSharesNetProceeds");
			this.Property(t => t.MoneyToAccount).HasColumnName("MoneyToAccount");
			this.Property(t => t.DateToAccount).HasColumnName("DateToAccount");
			this.Property(t => t.PricingModel).HasColumnName("PricingModel");
			this.Property(t => t.RationModel).HasColumnName("RationModel");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.OnlineStartDate).HasColumnName("OnlineStartDate");
			this.Property(t => t.OnlineEndDate).HasColumnName("OnlineEndDate");
			this.Property(t => t.BookingStartDateLP).HasColumnName("BookingStartDateLP");
			this.Property(t => t.BookingEndDateLP).HasColumnName("BookingEndDateLP");
			this.Property(t => t.PayStartDateLP).HasColumnName("PayStartDateLP");
			this.Property(t => t.PayEndDateLP).HasColumnName("PayEndDateLP");
			this.Property(t => t.ApplyStartDateF).HasColumnName("ApplyStartDateF");
			this.Property(t => t.ApplyEndDateF).HasColumnName("ApplyEndDateF");
			this.Property(t => t.PayStartDateF).HasColumnName("PayStartDateF");
			this.Property(t => t.PayEndDateF).HasColumnName("PayEndDateF");
			this.Property(t => t.SecMarketPlacingDate).HasColumnName("SecMarketPlacingDate");
			this.Property(t => t.PayStartDateSM).HasColumnName("PayStartDateSM");
			this.Property(t => t.PayEndDateSM).HasColumnName("PayEndDateSM");
			this.Property(t => t.UnderwritingSignDate).HasColumnName("UnderwritingSignDate");
			this.Property(t => t.UnderwritingStartDate).HasColumnName("UnderwritingStartDate");
			this.Property(t => t.UnderwritingEndDate).HasColumnName("UnderwritingEndDate");
			this.Property(t => t.PreparedListExchange).HasColumnName("PreparedListExchange");
			this.Property(t => t.ListDate).HasColumnName("ListDate");
			this.Property(t => t.StaffSharesListDate).HasColumnName("StaffSharesListDate");
			this.Property(t => t.StaffSharesListTerm).HasColumnName("StaffSharesListTerm");
			this.Property(t => t.OutstandingShares).HasColumnName("OutstandingShares");
			this.Property(t => t.NumOver1000Shares).HasColumnName("NumOver1000Shares");
			this.Property(t => t.FirstOpenPrice).HasColumnName("FirstOpenPrice");
			this.Property(t => t.FirstClosePrice).HasColumnName("FirstClosePrice");
			this.Property(t => t.FirstHighPrice).HasColumnName("FirstHighPrice");
			this.Property(t => t.FirstLowPrice).HasColumnName("FirstLowPrice");
			this.Property(t => t.FirstTurnover).HasColumnName("FirstTurnover");
			this.Property(t => t.ApplyCodeOnline).HasColumnName("ApplyCodeOnline");
			this.Property(t => t.SharesOnline).HasColumnName("SharesOnline");
			this.Property(t => t.ApplyUnitOnline).HasColumnName("ApplyUnitOnline");
			this.Property(t => t.ApplyMaxOnline).HasColumnName("ApplyMaxOnline");
			this.Property(t => t.ValidApplyVolOnline).HasColumnName("ValidApplyVolOnline");
			this.Property(t => t.ValidApplyNumOnline).HasColumnName("ValidApplyNumOnline");
			this.Property(t => t.OverSubsTimesOnline).HasColumnName("OverSubsTimesOnline");
			this.Property(t => t.NumAllotedOnline).HasColumnName("NumAllotedOnline");
			this.Property(t => t.FreezedMoneyOnline).HasColumnName("FreezedMoneyOnline");
			this.Property(t => t.LotRateOnline).HasColumnName("LotRateOnline");
			this.Property(t => t.ApplyCodeSM).HasColumnName("ApplyCodeSM");
			this.Property(t => t.ApplyMaxSM).HasColumnName("ApplyMaxSM");
			this.Property(t => t.PlacingSharesSM).HasColumnName("PlacingSharesSM");
			this.Property(t => t.ApplyUnitSM).HasColumnName("ApplyUnitSM");
			this.Property(t => t.ValidApplyVolSM).HasColumnName("ValidApplyVolSM");
			this.Property(t => t.ValidApplyNumSM).HasColumnName("ValidApplyNumSM");
			this.Property(t => t.OverSubsTimesSM).HasColumnName("OverSubsTimesSM");
			this.Property(t => t.NumAllotedSM).HasColumnName("NumAllotedSM");
			this.Property(t => t.LotRateSM).HasColumnName("LotRateSM");
			this.Property(t => t.PlacingSharesLP).HasColumnName("PlacingSharesLP");
			this.Property(t => t.ApplyUnitLP).HasColumnName("ApplyUnitLP");
			this.Property(t => t.ApplyMaxLP).HasColumnName("ApplyMaxLP");
			this.Property(t => t.ApplyMinLP).HasColumnName("ApplyMinLP");
			this.Property(t => t.ValidApplyVolLP).HasColumnName("ValidApplyVolLP");
			this.Property(t => t.ValidApplyNumLP).HasColumnName("ValidApplyNumLP");
			this.Property(t => t.OverSubsTimesLP).HasColumnName("OverSubsTimesLP");
			this.Property(t => t.ApplyMoneyLP).HasColumnName("ApplyMoneyLP");
			this.Property(t => t.LotRateLP).HasColumnName("LotRateLP");
			this.Property(t => t.FundPrefAllotment).HasColumnName("FundPrefAllotment");
			this.Property(t => t.SingleFundPrefAllotment).HasColumnName("SingleFundPrefAllotment");
			this.Property(t => t.FunPrefAllotmentShares).HasColumnName("FunPrefAllotmentShares");
			this.Property(t => t.FunPrefAllotmentHoldTerm).HasColumnName("FunPrefAllotmentHoldTerm");
			this.Property(t => t.STAQNETAllotment).HasColumnName("STAQNETAllotment");
			this.Property(t => t.STAQNETSubscription).HasColumnName("STAQNETSubscription");
			this.Property(t => t.StaffAllotment).HasColumnName("StaffAllotment");
			this.Property(t => t.EarningForecastYear).HasColumnName("EarningForecastYear");
			this.Property(t => t.MainIncomeForecast).HasColumnName("MainIncomeForecast");
			this.Property(t => t.NetProfitForecast).HasColumnName("NetProfitForecast");
			this.Property(t => t.DilutedEPSForecast).HasColumnName("DilutedEPSForecast");
			this.Property(t => t.DividendPolicy).HasColumnName("DividendPolicy");
			this.Property(t => t.EstimatedFirstDiviDate).HasColumnName("EstimatedFirstDiviDate");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.PERatioBeforeIssue).HasColumnName("PERatioBeforeIssue");
			this.Property(t => t.PERatioAfterIssue).HasColumnName("PERatioAfterIssue");
			this.Property(t => t.BidderNumberLP).HasColumnName("BidderNumberLP");
			this.Property(t => t.PlacingNumberLP).HasColumnName("PlacingNumberLP");
			this.Property(t => t.ApplyVolLP).HasColumnName("ApplyVolLP");
			this.Property(t => t.TailoredPlaVolLP).HasColumnName("TailoredPlaVolLP");
			this.Property(t => t.OnlineIssuePlan).HasColumnName("OnlineIssuePlan");
			this.Property(t => t.OfflineApplyPlan).HasColumnName("OfflineApplyPlan");
			this.Property(t => t.StrategyApplyPlan).HasColumnName("StrategyApplyPlan");
			this.Property(t => t.RefundmentDate_Offline).HasColumnName("RefundmentDate_Offline");
			this.Property(t => t.RefundmentDate_Online).HasColumnName("RefundmentDate_Online");
			this.Property(t => t.IssueNameAbbr_Online).HasColumnName("IssueNameAbbr_Online");
			this.Property(t => t.ApplyFloor_Online).HasColumnName("ApplyFloor_Online");
			this.Property(t => t.LOAccuApplyCeiling).HasColumnName("LOAccuApplyCeiling");
			this.Property(t => t.OffLineLockPeriod).HasColumnName("OffLineLockPeriod");
			this.Property(t => t.OverSubSum).HasColumnName("OverSubSum");
			this.Property(t => t.ExGSOptionPublDate).HasColumnName("ExGSOptionPublDate");
			this.Property(t => t.ExGSOptionEndDate).HasColumnName("ExGSOptionEndDate");
			this.Property(t => t.SLBuySum).HasColumnName("SLBuySum");
			this.Property(t => t.ExGsOptionOverSubSum).HasColumnName("ExGsOptionOverSubSum");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
		}
	}
}

