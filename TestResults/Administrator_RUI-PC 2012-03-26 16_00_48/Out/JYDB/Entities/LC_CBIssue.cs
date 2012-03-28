using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_CBIssue
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public string CBCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> AdvanceDate { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<System.DateTime> ValidStartDate { get; set; }
		public Nullable<System.DateTime> ValidEndDate { get; set; }
		public Nullable<decimal> LowerLimit { get; set; }
		public Nullable<decimal> UpperLimit { get; set; }
		public Nullable<System.DateTime> ProspectusIssueDate { get; set; }
		public Nullable<System.DateTime> ListAnnouncementDate { get; set; }
		public string IssueMethod { get; set; }
		public string IssueObject { get; set; }
		public Nullable<decimal> ActualIssueSize { get; set; }
		public Nullable<decimal> IssueVol { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<decimal> IssuePrice { get; set; }
		public Nullable<System.DateTime> IssueStartDate { get; set; }
		public Nullable<System.DateTime> IssueEndDate { get; set; }
		public string UnderwritingMethod { get; set; }
		public Nullable<System.DateTime> UnderwritingStartDate { get; set; }
		public Nullable<System.DateTime> UnderwritingEndDate { get; set; }
		public string PrefPlaCodeH { get; set; }
		public string PrefPlaNameH { get; set; }
		public Nullable<System.DateTime> PrefPlaRightRegDateH { get; set; }
		public Nullable<System.DateTime> PayStartDateH { get; set; }
		public Nullable<System.DateTime> PayEndDateH { get; set; }
		public Nullable<decimal> PrefPlaRatioH { get; set; }
		public Nullable<int> PrefPlaUnitH { get; set; }
		public Nullable<decimal> PrefPlaSizeH { get; set; }
		public Nullable<decimal> PlaSizeF { get; set; }
		public Nullable<System.DateTime> PlaPayStartDateF { get; set; }
		public Nullable<System.DateTime> PlaPayEndDateF { get; set; }
		public Nullable<decimal> PlaSizeLP { get; set; }
		public Nullable<System.DateTime> PlaPayStartDateLP { get; set; }
		public Nullable<System.DateTime> PlaPayEndDateLP { get; set; }
		public string ApplyCodeOnline { get; set; }
		public string ApplyNameOnline { get; set; }
		public Nullable<System.DateTime> IssueDateOnline { get; set; }
		public Nullable<decimal> IssueSumOnline { get; set; }
		public Nullable<int> ApplyUnitOnline { get; set; }
		public Nullable<int> ApplyMaxOnline { get; set; }
		public Nullable<int> ValidApplyVolOnline { get; set; }
		public Nullable<int> ValidApplyNumOnline { get; set; }
		public Nullable<decimal> OverSubsTimesOnline { get; set; }
		public Nullable<decimal> LotRateOnline { get; set; }
		public Nullable<int> ValidApplyVolOffline { get; set; }
		public Nullable<int> ValidApplyNumOffline { get; set; }
		public Nullable<decimal> OverSubsTimesOffline { get; set; }
		public Nullable<decimal> LotRateOffline { get; set; }
		public Nullable<int> PrefPlaValidApplyVolH { get; set; }
		public Nullable<int> PrefPlaValidApplyNumH { get; set; }
		public Nullable<decimal> PrefPlaOverSubsTimeH { get; set; }
		public Nullable<decimal> PrefPlaLotRateH { get; set; }
		public Nullable<System.DateTime> ListDate { get; set; }
		public Nullable<decimal> Proceeds { get; set; }
		public Nullable<decimal> IssueCost { get; set; }
		public Nullable<decimal> NetProceeds { get; set; }
		public Nullable<decimal> UnderwriterboughtVolume { get; set; }
		public Nullable<System.DateTime> ProfitForecastYear { get; set; }
		public Nullable<decimal> RevenueForecast { get; set; }
		public Nullable<decimal> NetProfitForecast { get; set; }
		public Nullable<decimal> EPSForecast { get; set; }
		public string SchemeChangeStatement { get; set; }
		public string SchemeChangeType { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

