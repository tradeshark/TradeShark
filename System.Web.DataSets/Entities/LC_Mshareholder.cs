using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_Mshareholder
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string MSHName { get; set; }
		public Nullable<decimal> MSHPercentage { get; set; }
		public Nullable<int> MSHNumber { get; set; }
		public Nullable<int> GetMethod { get; set; }
		public string LegalRepr { get; set; }
		public Nullable<decimal> RegCapital { get; set; }
		public string MainBusiness { get; set; }
		public Nullable<int> EconomicNature { get; set; }
		public string BackgroundIntr { get; set; }
		public Nullable<int> IfExisted { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public string NationalityDesc { get; set; }
		public string PermanentResidency { get; set; }
		public byte[] StructureChart { get; set; }
		public Nullable<int> FileType { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
	}
}

