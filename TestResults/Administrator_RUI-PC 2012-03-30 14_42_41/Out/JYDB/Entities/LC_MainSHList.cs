using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_MainSHList
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> InfoType { get; set; }
		public Nullable<int> SHNo { get; set; }
		public string SHList { get; set; }
		public Nullable<int> SHKind { get; set; }
		public Nullable<int> SecuCoBelongedCode { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public Nullable<decimal> HoldSum { get; set; }
		public Nullable<decimal> PCTOfTotalShares { get; set; }
		public Nullable<int> ShareCharacter { get; set; }
		public Nullable<decimal> PledgeInvolvedSum { get; set; }
		public Nullable<decimal> FreezeInvolvedSum { get; set; }
		public string PFStatement { get; set; }
		public string ConnectionRelation { get; set; }
		public string ConnectionStatement { get; set; }
		public string ActInConcertStatement { get; set; }
		public string Notes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> SHType { get; set; }
		public Nullable<decimal> RestrainedTShare { get; set; }
		public Nullable<decimal> UnstintedTShare { get; set; }
		public Nullable<int> FloatSHNo { get; set; }
		public Nullable<int> FrontSHNo { get; set; }
	}
}

