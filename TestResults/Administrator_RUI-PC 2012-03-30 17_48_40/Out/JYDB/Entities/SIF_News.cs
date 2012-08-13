using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class SIF_News
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string Media { get; set; }
		public string Writer { get; set; }
		public string Author { get; set; }
		public int ContentType { get; set; }
		public string InfoTitle { get; set; }
		public string Content { get; set; }
		public string InvolvedIndex { get; set; }
		public Nullable<int> ObjectCode { get; set; }
		public Nullable<int> AreaCode { get; set; }
		public Nullable<int> MarketCode { get; set; }
		public Nullable<int> InfoLevel { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

