using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_LongTermInv
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string DataType { get; set; }
		public Nullable<decimal> LongTermEquityInv { get; set; }
		public Nullable<decimal> Stock { get; set; }
		public Nullable<decimal> SubsidiaryCompany { get; set; }
		public Nullable<decimal> JointVentureM { get; set; }
		public Nullable<decimal> JointVentureH { get; set; }
		public Nullable<decimal> OtherEquityInv { get; set; }
		public Nullable<decimal> ConsolidationDifference { get; set; }
		public Nullable<decimal> EquityInvDifference { get; set; }
		public Nullable<decimal> LongTermInvOnBonds { get; set; }
		public Nullable<decimal> OtherLongTermInv { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

