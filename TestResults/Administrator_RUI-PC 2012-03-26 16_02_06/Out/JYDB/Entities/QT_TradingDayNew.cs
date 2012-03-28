using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_TradingDayNew
	{
		public long ID { get; set; }
		public System.DateTime TradingDate { get; set; }
		public Nullable<int> IfTradingDay { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public Nullable<int> IfWeekEnd { get; set; }
		public Nullable<int> IfMonthEnd { get; set; }
		public Nullable<int> IfQuarterEnd { get; set; }
		public Nullable<int> IfYearEnd { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

