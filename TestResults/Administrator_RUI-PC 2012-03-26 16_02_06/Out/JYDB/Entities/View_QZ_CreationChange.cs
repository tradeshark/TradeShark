using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_QZ_CreationChange
	{
		public string SecuCode { get; set; }
		public string SecuAbbr { get; set; }
		public string N_WarrantCategory { get; set; }
		public string N_ChangeType { get; set; }
		public string N_IssuerSN { get; set; }
		public long ID { get; set; }
		public int WarrantCategory { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public string Issuer { get; set; }
		public Nullable<int> IssuerSN { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EffectiveDate { get; set; }
		public Nullable<decimal> Circulation { get; set; }
		public Nullable<decimal> ChangeSize { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public string ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

