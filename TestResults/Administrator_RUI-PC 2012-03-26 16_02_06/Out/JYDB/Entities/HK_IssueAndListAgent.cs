using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_IssueAndListAgent
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<int> IssueType { get; set; }
		public string AgentTypeName { get; set; }
		public Nullable<int> AgentType { get; set; }
		public string AgentName { get; set; }
		public Nullable<int> AgentCode { get; set; }
		public Nullable<int> IfEffected { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

