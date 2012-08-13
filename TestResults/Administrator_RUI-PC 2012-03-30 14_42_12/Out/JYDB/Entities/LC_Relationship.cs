using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Relationship
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string Media { get; set; }
		public string RelatedPartyName { get; set; }
		public Nullable<int> Relationship { get; set; }
		public string RelatedShareholderName { get; set; }
		public string LegalPersonRepr { get; set; }
		public Nullable<decimal> RegCapital { get; set; }
		public Nullable<decimal> EquityRatio { get; set; }
		public Nullable<decimal> InvestSum { get; set; }
		public Nullable<decimal> ShareAmount { get; set; }
		public string ShareType { get; set; }
		public string MainBusiness { get; set; }
		public Nullable<int> Industry { get; set; }
		public Nullable<decimal> InvestTerm { get; set; }
		public Nullable<int> EnterpriseType { get; set; }
		public Nullable<int> InvolvedStock { get; set; }
		public string BackgroundIntro { get; set; }
		public string Notes { get; set; }
		public Nullable<int> IfExisted { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

