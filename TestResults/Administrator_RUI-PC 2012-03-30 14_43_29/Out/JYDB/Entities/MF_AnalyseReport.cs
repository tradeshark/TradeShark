using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class MF_AnalyseReport
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string Media { get; set; }
		public string Writer { get; set; }
		public string Author { get; set; }
		public string InfoTitle { get; set; }
		public string Content { get; set; }
		public Nullable<int> InvolvedFund { get; set; }
		public Nullable<int> ObjectCode { get; set; }
		public Nullable<int> AreaCode { get; set; }
		public Nullable<int> MarketCode { get; set; }
		public Nullable<int> InvolvedInstitution { get; set; }
		public Nullable<int> InfoLevel { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

