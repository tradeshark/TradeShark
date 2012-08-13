using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_AdjustingFactor
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> ExDiviDate { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public Nullable<double> AdjustingFactor { get; set; }
		public Nullable<double> AdjustingConst { get; set; }
		public Nullable<double> RatioAdjustingFactor { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

