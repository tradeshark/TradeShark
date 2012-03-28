using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_EquityChangesStatement
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public int InnerCode { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int Mark { get; set; }
		public Nullable<int> AccountingStandards { get; set; }
		public string ItemsName { get; set; }
		public int ItemsType { get; set; }
		public Nullable<decimal> OpeningNV { get; set; }
		public Nullable<decimal> NVChangeByoOperating { get; set; }
		public Nullable<decimal> NVChangeByUnitTransaction { get; set; }
		public Nullable<decimal> ApplyingSum { get; set; }
		public Nullable<decimal> DividendReinvestmentSum { get; set; }
		public Nullable<decimal> RedemptionSum { get; set; }
		public Nullable<decimal> NVChangeByDistribution { get; set; }
		public Nullable<decimal> NVChangeExceptionalItems { get; set; }
		public Nullable<decimal> NVChangeAdjustmentItems { get; set; }
		public Nullable<decimal> EndingNV { get; set; }
		public string SpecialFieldRemark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
	}
}

