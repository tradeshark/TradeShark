using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_StateShareDistribution
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string ShareType { get; set; }
		public Nullable<System.DateTime> AdvanceDate { get; set; }
		public Nullable<System.DateTime> PublDate { get; set; }
		public string DistributeFrom { get; set; }
		public string DistributeTo { get; set; }
		public string PublicAbbr { get; set; }
		public Nullable<int> PublicCode { get; set; }
		public string PricingMode { get; set; }
		public Nullable<decimal> FaceValue { get; set; }
		public Nullable<decimal> DistributionPrice { get; set; }
		public Nullable<decimal> PERatio { get; set; }
		public Nullable<decimal> DisrtibuteSum { get; set; }
		public Nullable<decimal> Proportion { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
		public Nullable<System.DateTime> EXDate { get; set; }
		public Nullable<System.DateTime> PayStartDate { get; set; }
		public Nullable<System.DateTime> PayEndDate { get; set; }
		public Nullable<System.DateTime> FundPayDate { get; set; }
		public Nullable<System.DateTime> ChangeDate { get; set; }
		public Nullable<System.DateTime> PDTradingDate { get; set; }
		public Nullable<System.DateTime> FDTradingDate { get; set; }
		public Nullable<decimal> ActualSum { get; set; }
		public Nullable<decimal> PActualSum { get; set; }
		public Nullable<decimal> ManagementSum { get; set; }
		public Nullable<decimal> ActualTranDistributeSum { get; set; }
		public Nullable<decimal> FActualSum { get; set; }
		public Nullable<decimal> UnderwritedSum { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

