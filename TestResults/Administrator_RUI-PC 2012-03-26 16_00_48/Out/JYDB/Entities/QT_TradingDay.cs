using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_TradingDay
	{
		public long ID { get; set; }
		public System.DateTime Date { get; set; }
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

