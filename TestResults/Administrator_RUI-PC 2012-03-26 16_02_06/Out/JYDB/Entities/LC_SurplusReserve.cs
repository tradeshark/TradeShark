using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SurplusReserve
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string DataType { get; set; }
		public Nullable<decimal> StatutorySurplusReserve { get; set; }
		public Nullable<decimal> CommonwealFund { get; set; }
		public Nullable<decimal> DiscretionarySurplusFund { get; set; }
		public Nullable<decimal> OtherSurplusFund { get; set; }
		public Nullable<decimal> DevelopmentProvision { get; set; }
		public Nullable<decimal> TaxReductionAndExemption { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

