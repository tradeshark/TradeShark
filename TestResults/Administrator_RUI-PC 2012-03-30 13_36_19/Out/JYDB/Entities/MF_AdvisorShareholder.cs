using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class MF_AdvisorShareholder
	{
		public long ID { get; set; }
		public int InvestAdvisorCode { get; set; }
		public Nullable<System.DateTime> ChangeDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string Name { get; set; }
		public Nullable<int> InstitutionCode { get; set; }
		public Nullable<int> CompanyCode { get; set; }
		public Nullable<decimal> HoldingShares { get; set; }
		public Nullable<decimal> HoldingRatio { get; set; }
		public Nullable<byte> IfExisted { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

