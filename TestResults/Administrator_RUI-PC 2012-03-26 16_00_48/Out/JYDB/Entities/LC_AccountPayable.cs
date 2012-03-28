using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_AccountPayable
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> Amount0_1 { get; set; }
		public Nullable<decimal> Ratio0_1 { get; set; }
		public Nullable<decimal> Amount1_2 { get; set; }
		public Nullable<decimal> Ratio1_2 { get; set; }
		public Nullable<decimal> Amount2_3 { get; set; }
		public Nullable<decimal> Ratio2_3 { get; set; }
		public Nullable<decimal> Amount3 { get; set; }
		public Nullable<decimal> Ratio3 { get; set; }
		public Nullable<decimal> Amount3_4 { get; set; }
		public Nullable<decimal> Ratio3_4 { get; set; }
		public Nullable<decimal> Amount4_5 { get; set; }
		public Nullable<decimal> Ratio4_5 { get; set; }
		public Nullable<decimal> Amount5 { get; set; }
		public Nullable<decimal> Ratio5 { get; set; }
		public Nullable<decimal> TotalAmount { get; set; }
		public Nullable<decimal> TotalRatio { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> Mark { get; set; }
		public Nullable<decimal> AmountToMainDebtor { get; set; }
		public Nullable<decimal> RatioToMainDebtor { get; set; }
		public Nullable<decimal> AmountOfMainHolders { get; set; }
		public Nullable<decimal> RatioOfMainHolders { get; set; }
		public Nullable<decimal> AmountForRelations { get; set; }
		public Nullable<decimal> RatioForRelations { get; set; }
	}
}

