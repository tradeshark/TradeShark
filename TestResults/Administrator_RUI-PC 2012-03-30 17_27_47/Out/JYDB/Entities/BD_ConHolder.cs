using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_ConHolder
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> OutstandingVolume { get; set; }
		public Nullable<int> HolderNumber { get; set; }
		public int HolderSN { get; set; }
		public string HolderName { get; set; }
		public Nullable<int> HolderNature { get; set; }
		public Nullable<int> InnerCodeFund { get; set; }
		public Nullable<int> SecuCoBelongedCode { get; set; }
		public string InstitutionName { get; set; }
		public Nullable<decimal> HoldVolume { get; set; }
		public Nullable<decimal> HoldRatio { get; set; }
		public string HolderRelationship { get; set; }
		public string Remark { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

