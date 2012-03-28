using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_Function
	{
		public long ID { get; set; }
		public int FuncCode { get; set; }
		public string FuncName { get; set; }
		public int ParaCode { get; set; }
		public Nullable<decimal> XPara { get; set; }
		public Nullable<decimal> YPara { get; set; }
		public Nullable<decimal> FuncResult { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

