using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class JYDB_Probation
	{
		public long ID { get; set; }
		public string TableName { get; set; }
		public string ColumnName { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

