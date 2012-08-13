using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Deregulation
	{
		public long ID { get; set; }
		public int Subject { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<int> InstitutionCode { get; set; }
		public string InstitutionName { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string EventContent { get; set; }
		public Nullable<int> AdminInst { get; set; }
		public Nullable<int> AdminObject { get; set; }
		public Nullable<int> AdminType { get; set; }
		public string Reason { get; set; }
		public Nullable<int> ReasonType { get; set; }
		public Nullable<int> ContentType { get; set; }
		public string RelatedParty { get; set; }
		public Nullable<int> Association { get; set; }
		public Nullable<decimal> ComPenalSum { get; set; }
		public Nullable<decimal> IndividualPenalSum { get; set; }
		public Nullable<decimal> InstitutionPenalSum { get; set; }
		public string InvolvedStatute { get; set; }
		public string Penalty { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

