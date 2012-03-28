using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_IndexBasicInfo
	{
		public long ID { get; set; }
		public int IndexCode { get; set; }
		public Nullable<int> IndexType { get; set; }
		public Nullable<int> ComponentType { get; set; }
		public Nullable<int> IndustryStandard { get; set; }
		public Nullable<int> IndustryType { get; set; }
		public Nullable<int> PubOrgCode { get; set; }
		public string PubOrgName { get; set; }
		public Nullable<int> CreatIndexOrgCode { get; set; }
		public string CreatIndexOrgName { get; set; }
		public Nullable<System.DateTime> PubDate { get; set; }
		public Nullable<System.DateTime> BaseDate { get; set; }
		public Nullable<int> BasePoint { get; set; }
		public Nullable<int> WAMethod { get; set; }
		public Nullable<int> ComponentSum { get; set; }
		public Nullable<int> ComponentAdPeriod { get; set; }
		public string IndexRemark { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

