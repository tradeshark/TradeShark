using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_GP_MainOperIncome_CP
	{
		public string N_Industry { get; set; }
		public string N_RegionAndBusiness { get; set; }
		public string N_Classification { get; set; }
		public string N_IfAdjusted { get; set; }
		public string N_IfMerged { get; set; }
		public string N_DateType { get; set; }
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> DateType { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> IfMerged { get; set; }
		public Nullable<int> IfAdjusted { get; set; }
		public Nullable<int> Classification { get; set; }
		public Nullable<int> SN { get; set; }
		public string Project { get; set; }
		public Nullable<int> Industry { get; set; }
		public Nullable<int> RegionAndBusiness { get; set; }
		public Nullable<decimal> MainOperIncome { get; set; }
		public Nullable<decimal> MainOperCost { get; set; }
		public Nullable<decimal> MainOperProfit { get; set; }
		public Nullable<decimal> MainOperIncomeFormerYear { get; set; }
		public Nullable<decimal> MainOperCostFormerYear { get; set; }
		public Nullable<decimal> MainOperProfitFormerYear { get; set; }
		public Nullable<decimal> MainIncomeGrowRateYOY { get; set; }
		public Nullable<decimal> MainICostGrowRateYOY { get; set; }
		public Nullable<decimal> MainProfitGrowRateYOY { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> ZYML { get; set; }
		public Nullable<decimal> ZYMLL { get; set; }
	}
}

