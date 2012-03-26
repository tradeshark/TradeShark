using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_RMBInterestRate
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string Sources { get; set; }
		public System.DateTime AdjustDate { get; set; }
		public Nullable<decimal> DemandDeposits { get; set; }
		public Nullable<decimal> TimeDeposit3M { get; set; }
		public Nullable<decimal> TimeDeposit6M { get; set; }
		public Nullable<decimal> TimeDeposit1Y { get; set; }
		public Nullable<decimal> TimeDeposit2Y { get; set; }
		public Nullable<decimal> TimeDeposit3Y { get; set; }
		public Nullable<decimal> TimeDeposit5Y { get; set; }
		public Nullable<decimal> OD1Y { get; set; }
		public Nullable<decimal> OD3Y { get; set; }
		public Nullable<decimal> OD5Y { get; set; }
		public string ODOptionalTimeOrDemand { get; set; }
		public Nullable<decimal> ODContractualDeposits { get; set; }
		public Nullable<decimal> NoticeDeposits1D { get; set; }
		public Nullable<decimal> NoticeDeposits7D { get; set; }
		public Nullable<decimal> STBelow6Months { get; set; }
		public Nullable<decimal> ST6to12Months { get; set; }
		public Nullable<decimal> MLT1to3years { get; set; }
		public Nullable<decimal> MLT3to5years { get; set; }
		public Nullable<decimal> MLT5Plusyears { get; set; }
		public string Discount { get; set; }
		public Nullable<decimal> IHAF5YBelow { get; set; }
		public Nullable<decimal> IHAF5YAbove { get; set; }
		public Nullable<decimal> CBankIHAF6Mbelow { get; set; }
		public Nullable<decimal> CBankIHAF6Mto1Y { get; set; }
		public Nullable<decimal> CBankIHAF1to3Y { get; set; }
		public Nullable<decimal> CBankIHAF3to5Y { get; set; }
		public Nullable<decimal> CBankIHAF5YAbove { get; set; }
		public Nullable<decimal> ReserveDeposit { get; set; }
		public Nullable<decimal> ExcessReserveDeposit { get; set; }
		public Nullable<decimal> Reloan20D { get; set; }
		public Nullable<decimal> Reloan3M { get; set; }
		public Nullable<decimal> Reloan6M { get; set; }
		public Nullable<decimal> Reloan1Y { get; set; }
		public Nullable<decimal> ReDiscount { get; set; }
		public Nullable<decimal> LoanToWelfareEnterprise { get; set; }
		public Nullable<decimal> LoanToDevelopingAreas { get; set; }
		public Nullable<decimal> LoanToPoorCounty { get; set; }
		public Nullable<decimal> LoanToNationTrade { get; set; }
		public Nullable<decimal> DiscountLoanToPA { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

