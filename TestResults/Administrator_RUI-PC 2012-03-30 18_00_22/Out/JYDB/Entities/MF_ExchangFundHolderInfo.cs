using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_ExchangFundHolderInfo
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> HolderAccountNumber { get; set; }
		public Nullable<decimal> AverageVolumePerAccount { get; set; }
		public Nullable<decimal> InstitutionHoldVolume { get; set; }
		public Nullable<decimal> InstitutionHoldRatio { get; set; }
		public Nullable<decimal> IndividualHoldVolume { get; set; }
		public Nullable<decimal> IndividualHoldRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

