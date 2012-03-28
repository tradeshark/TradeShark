using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_SystemConst
	{
		public long ID { get; set; }
		public int LB { get; set; }
		public string LBMC { get; set; }
		public string MS { get; set; }
		public int DM { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<double> FVALUE { get; set; }
		public Nullable<int> IVALUE { get; set; }
		public Nullable<System.DateTime> DVALUE { get; set; }
		public string CVALUE { get; set; }
	}
}

