using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class JYDB_DeleteRec
	{
		public string TABLENAME { get; set; }
		public decimal RECID { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long ID { get; set; }
		public long JSID { get; set; }
	}
}

