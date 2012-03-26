using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_SMTVoting
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public Nullable<int> TitleSN { get; set; }
		public string Title { get; set; }
		public Nullable<int> SubtitleSN { get; set; }
		public string Subtitle { get; set; }
		public Nullable<int> SHNumber { get; set; }
		public string SHName { get; set; }
		public Nullable<int> SHKind { get; set; }
		public Nullable<int> SHCorporationSN { get; set; }
		public Nullable<int> ShareCharacter { get; set; }
		public Nullable<decimal> HoldSum { get; set; }
		public Nullable<decimal> PCTOfTotalShares { get; set; }
		public Nullable<int> Opinion { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

