using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_IssueAndListAgent
	{
		public long ID { get; set; }
		public Nullable<int> IssueAndListType { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<int> AgentType { get; set; }
		public Nullable<int> AgentCode { get; set; }
		public string FullName { get; set; }
		public string AbbrName { get; set; }
		public string LegalPersonRepr { get; set; }
		public string Address { get; set; }
		public string Code { get; set; }
		public string Website { get; set; }
		public string Email { get; set; }
		public string Tel { get; set; }
		public string Fax { get; set; }
		public string Contactman { get; set; }
		public string PersonInCharge { get; set; }
		public Nullable<decimal> UnderwritingVol { get; set; }
		public Nullable<decimal> UnderwritingSum { get; set; }
		public Nullable<decimal> UnderwritingRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> AgentData { get; set; }
		public string Representative { get; set; }
		public Nullable<int> IfEffected { get; set; }
		public Nullable<System.DateTime> CancelDate { get; set; }
		public string Remark { get; set; }
	}
}

