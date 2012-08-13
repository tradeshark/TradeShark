using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_ConIssueInstPriPlc
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> TotalPriPlcVolume { get; set; }
		public string Reason { get; set; }
		public int SerialNumber { get; set; }
		public string AcquirerName { get; set; }
		public string AcquirerNature { get; set; }
		public string InstitutionName { get; set; }
		public Nullable<int> AcquirerSecuCode { get; set; }
		public Nullable<int> Volume { get; set; }
		public Nullable<int> LockedInPeriod { get; set; }
		public string PriPlcNature { get; set; }
		public Nullable<System.DateTime> TradableDate { get; set; }
		public string Remark { get; set; }
		public string RelativeListedCom { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

