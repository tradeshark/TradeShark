using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_NotTextAnnouncement
	{
		public long ID { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public Nullable<int> CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string Media { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> Category { get; set; }
		public string InfoTitle { get; set; }
		public byte[] Content { get; set; }
		public Nullable<int> LanguageType { get; set; }
		public Nullable<int> FileType { get; set; }
		public string FileName { get; set; }
		public Nullable<int> InfoType { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string SubTitle { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

