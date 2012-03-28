using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class JYDB_SysUpdate
	{
		public long ID { get; set; }
		public int PRDNO { get; set; }
		public int UPDTYPE { get; set; }
		public string FILEPATH { get; set; }
		public string FILENAME { get; set; }
		public System.DateTime FILETIME { get; set; }
		public int FILEVER { get; set; }
		public string USERIDLIST { get; set; }
		public Nullable<int> REVI { get; set; }
		public Nullable<System.DateTime> REVD { get; set; }
		public string REVC { get; set; }
		public byte[] REVB { get; set; }
		public byte[] FILEDATA { get; set; }
		public int GKBZ { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

