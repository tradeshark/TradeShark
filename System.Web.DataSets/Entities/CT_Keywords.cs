using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class CT_Keywords
	{
		public long ID { get; set; }
		public Nullable<int> Type { get; set; }
		public string Content { get; set; }
		public string Keyword { get; set; }
		public Nullable<int> Code { get; set; }
		public string ChiSpelling { get; set; }
		public Nullable<byte> InfoLevel { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

