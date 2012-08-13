using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_CodeRelationship
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public int CompanyCode { get; set; }
		public int SecuMarket { get; set; }
		public int CodeDefine { get; set; }
		public int Market { get; set; }
		public int RelatedInnerCode { get; set; }
		public int RelatedCompanyCode { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

