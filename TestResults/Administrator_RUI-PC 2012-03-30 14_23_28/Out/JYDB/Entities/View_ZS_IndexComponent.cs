using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_ZS_IndexComponent
	{
		public string N_PubOrgCode { get; set; }
		public string IndexId { get; set; }
		public string IndexName { get; set; }
		public string SecuCode { get; set; }
		public string SecuAbbr { get; set; }
		public string N_SecuCategory { get; set; }
		public long ID { get; set; }
		public int IndexInnerCode { get; set; }
		public int SecuInnerCode { get; set; }
		public Nullable<System.DateTime> InDate { get; set; }
		public Nullable<System.DateTime> OutDate { get; set; }
		public int Flag { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

