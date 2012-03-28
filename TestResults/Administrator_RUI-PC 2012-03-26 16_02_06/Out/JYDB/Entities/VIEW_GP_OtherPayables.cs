using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_GP_OtherPayables
	{
		public string N_IfMerged { get; set; }
		public string N_IfAdjusted { get; set; }
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> Amount0_1 { get; set; }
		public Nullable<decimal> Ratio0_1 { get; set; }
		public Nullable<decimal> Amount1_2 { get; set; }
		public Nullable<decimal> Ratio1_2 { get; set; }
		public Nullable<decimal> Amount2_3 { get; set; }
		public Nullable<decimal> Ratio2_3 { get; set; }
		public Nullable<decimal> Amount3 { get; set; }
		public Nullable<decimal> Ratio3 { get; set; }
		public Nullable<decimal> Amount3_4 { get; set; }
		public Nullable<decimal> Ratio3_4 { get; set; }
		public Nullable<decimal> Amount4_5 { get; set; }
		public Nullable<decimal> Ratio4_5 { get; set; }
		public Nullable<decimal> Amount5 { get; set; }
		public Nullable<decimal> Ratio5 { get; set; }
		public Nullable<decimal> OtherAmount { get; set; }
		public Nullable<decimal> OtherRatio { get; set; }
		public Nullable<decimal> TotalAmount { get; set; }
		public Nullable<decimal> TotalRatio { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

