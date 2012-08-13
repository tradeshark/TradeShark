using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class JYDB_LocaSystem
	{
		public string BH { get; set; }
		public string MS { get; set; }
		public Nullable<int> IVALUE { get; set; }
		public Nullable<double> FVALUE { get; set; }
		public Nullable<System.DateTime> DVALUE { get; set; }
		public string CVALUE { get; set; }
		public Nullable<long> I64VALUE { get; set; }
	}
}

