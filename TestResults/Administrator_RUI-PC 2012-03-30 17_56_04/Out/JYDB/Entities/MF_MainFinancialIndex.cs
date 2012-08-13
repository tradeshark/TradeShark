using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_MainFinancialIndex
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> AccountingStandards { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public Nullable<decimal> NetIncome { get; set; }
		public Nullable<decimal> TotalProfitPerShare { get; set; }
		public Nullable<decimal> DistributableProfits { get; set; }
		public Nullable<decimal> DistriProfitsPShare { get; set; }
		public Nullable<decimal> NetAssetsValue { get; set; }
		public Nullable<decimal> NVPerShare { get; set; }
		public Nullable<decimal> WANVProfitRate { get; set; }
		public Nullable<decimal> UnitNVGrowthRate { get; set; }
		public Nullable<decimal> UnitAccumulativeNVGR { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

