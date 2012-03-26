using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class BD_IssueAndOutstandingStatY
	{
		public long ID { get; set; }
		public int Year { get; set; }
		public Nullable<decimal> IssueSizeGov { get; set; }
		public Nullable<decimal> IssueSizeGovReg { get; set; }
		public Nullable<decimal> IssueSizeGovCertif { get; set; }
		public Nullable<decimal> IssueSizeGovPhysic { get; set; }
		public Nullable<decimal> IssueSizeGovOther { get; set; }
		public Nullable<decimal> IssueSizeGovRegFixed { get; set; }
		public Nullable<decimal> IssueSizeGovRegFloat { get; set; }
		public Nullable<decimal> IssueSizeGovRegDis { get; set; }
		public Nullable<decimal> IssueSizeGovRegCoupon { get; set; }
		public Nullable<decimal> IssueSizeGovRegAcc { get; set; }
		public Nullable<decimal> IssueSizeGovRegZeroCoupon { get; set; }
		public Nullable<decimal> RedemptionAndIntPayGov { get; set; }
		public Nullable<decimal> IssueSizeTreasNotes { get; set; }
		public Nullable<decimal> RedemptionTreasNotes { get; set; }
		public Nullable<decimal> IssueSizeFin { get; set; }
		public Nullable<decimal> IssueSizeFinRegFixed { get; set; }
		public Nullable<decimal> IssueSizeFinRegFloat { get; set; }
		public Nullable<decimal> IssueSizeFinRegDis { get; set; }
		public Nullable<decimal> IssueSizeFinRegCoupon { get; set; }
		public Nullable<decimal> IssueSizeFinRegAcc { get; set; }
		public Nullable<decimal> IssueSizeFinRegZeroCoupon { get; set; }
		public Nullable<decimal> IssueSizeCor { get; set; }
		public Nullable<decimal> IssueSizeCorRegFixed { get; set; }
		public Nullable<decimal> IssueSizeCorRegFloat { get; set; }
		public Nullable<decimal> IssueSizeConvertibleBond { get; set; }
		public Nullable<int> NumberConvertibleBond { get; set; }
		public Nullable<decimal> OutstandingGov { get; set; }
		public Nullable<decimal> OutstandingFin { get; set; }
		public Nullable<decimal> OutstandingTreasNotes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

