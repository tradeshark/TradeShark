using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_Bulletin
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

