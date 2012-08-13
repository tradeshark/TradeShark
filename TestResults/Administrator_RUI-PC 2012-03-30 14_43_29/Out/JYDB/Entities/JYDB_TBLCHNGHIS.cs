using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class JYDB_TBLCHNGHIS
	{
		public long ID { get; set; }
		public string TABLENAME { get; set; }
		public int RECCOUNT { get; set; }
		public System.DateTime XGSJ { get; set; }
		public long JSID { get; set; }
	}
}

