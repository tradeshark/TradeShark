using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_TrusteePersonnel
	{
		public long ID { get; set; }
		public int TrusteeCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string Media { get; set; }
		public string PostName { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public Nullable<System.DateTime> BirthDate { get; set; }
		public string EducationLevel { get; set; }
		public Nullable<System.DateTime> AccessionDate { get; set; }
		public Nullable<System.DateTime> DimissionDate { get; set; }
		public string ConcurrentPost { get; set; }
		public string Background { get; set; }
		public string Incumbent { get; set; }
		public string Notes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

