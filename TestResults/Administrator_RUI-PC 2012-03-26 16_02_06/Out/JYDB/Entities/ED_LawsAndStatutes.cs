using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_LawsAndStatutes
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public Nullable<System.DateTime> ActualizationDate { get; set; }
		public string IfInvalidation { get; set; }
		public string IssuanceOrg { get; set; }
		public string ContentType { get; set; }
		public string InfoTitle { get; set; }
		public string Content { get; set; }
		public string Notes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

