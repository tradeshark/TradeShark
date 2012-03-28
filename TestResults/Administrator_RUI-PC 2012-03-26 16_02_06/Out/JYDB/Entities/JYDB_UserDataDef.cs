using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class JYDB_UserDataDef
	{
		public long ID { get; set; }
		public int USERID { get; set; }
		public string TYPE { get; set; }
		public string SUBTYPE { get; set; }
		public string DESCRIPT { get; set; }
		public byte[] CONTENT { get; set; }
		public System.DateTime XGSJ { get; set; }
		public System.DateTime FBSJ { get; set; }
		public long JSID { get; set; }
	}
}

