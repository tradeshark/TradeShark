using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FundManager
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int PostName { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public Nullable<System.DateTime> BirthDate { get; set; }
		public Nullable<System.DateTime> AccessionDate { get; set; }
		public Nullable<System.DateTime> DimissionDate { get; set; }
		public Nullable<decimal> Performance { get; set; }
		public Nullable<int> EducationLevel { get; set; }
		public Nullable<decimal> ExperienceTime { get; set; }
		public Nullable<System.DateTime> PracticeDate { get; set; }
		public string Background { get; set; }
		public Nullable<byte> Incumbent { get; set; }
		public string Notes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public byte[] PersonalData { get; set; }
		public Nullable<int> FileType { get; set; }
		public string BirthYMInfo { get; set; }
	}
}

